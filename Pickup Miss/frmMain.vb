Public Class frmMain
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Button1.Click, AddressOf Button2_Click
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable Then
            If Not My.Computer.Network.Ping(_ipServer) Then
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        frmInputQR.Caption = "QR Code Pickup"
        If frmInputQR.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim LotNo As String = Trim(frmInputQR.QRCode.Substring(30, 10)).ToUpper
            Dim intpickup As Integer = frmInputQR.InputPickUp
            Pickup(LotNo, intpickup)
        ElseIf frmInputQR.DialogResult = Windows.Forms.DialogResult.Yes Then
            Pickup(frmKeyLot.strLot, frmKeyLot.intPickup)
        End If
    End Sub
    Private Sub Pickup(ByVal LotNo As String, ByVal InputPickUp As Integer)
        Dim filldata As Integer
        Dim intpickup As Integer = InputPickUp
        Dim removeList As List(Of DataRow) = New List(Of DataRow)

        MAPTPDataTableAdapter.ClearBeforeFill = False

        filldata = MAPTPDataTableAdapter.FillBy(DBxDataSet.MAPTPData, LotNo)
        If filldata = 0 Then
            MsgBox("ไม่มีข้อมูล")
            Exit Sub
        End If

        For Each row As DBxDataSet.MAPTPDataRow In DBxDataSet.MAPTPData.Rows
            If row.LotNo = LotNo AndAlso Not row.IsLotJudgementNull() Then
                Format(row.LotStartTime, "yyyy/MM/dd HH:mm:ss")
                frmInputPickup.ltSelectTime.Items.Add(Format(row.LotStartTime, "yyyy/MM/dd HH:mm:ss"))
                removeList.Add(row)
            End If
        Next

        frmInputPickup.LotNo = LotNo
        frmInputPickup.intpickup = InputPickUp
        If frmInputPickup.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each row As DBxDataSet.MAPTPDataRow In DBxDataSet.MAPTPData.Rows
                If row.LotNo = LotNo AndAlso Not row.IsLotJudgementNull() AndAlso row.LotStartTime = frmInputPickup.lt.Text Then
                    Dim Pickup As frmInputPickup = frmInputPickup
                    row.ICMissing = Pickup.ICMIssingAfter
                    row.TotalNG = Pickup.TotalNG
                    row.NGRate = Pickup.NGRate
                    row.PickupMiss = intpickup
                    MAPTPDataTableAdapter.Update(row)
                End If

            Next

        End If

        For Each row As DataRow In removeList
            DBxDataSet.MAPTPData.Rows.Remove(row)
        Next
        frmInputPickup.ltSelectTime.Items.Clear()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MAPTPDataTableAdapter.FillPickup(DBxDataSet.MAPTPData)
        lbcount.Text = DBxDataSet.MAPTPData.Rows.Count
    End Sub
End Class
