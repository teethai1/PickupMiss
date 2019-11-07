Imports System.Math
Public Class frmInputPickup

    Public LotNo As String
    Public TotalNG As Integer
    Public InPutQty As Integer
    Public TPQty As Integer
    Public NG1 As Integer
    Public NG2 As Integer
    Public NG3 As Integer
    Public NG4 As Integer
    Dim ICDrp As Integer
    Public NGRate As Double
    Public StartTime As Date
    Public EndTime As Date
    Public ICMIssingAfter As Integer
    Public intpickup As Integer
    Public lt As ListBox

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If StartTime <> #12:00:00 AM# Then
            If CInt(lbICMissBefore.Text) >= CInt(lbPickMiss.Text) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If MessageBox.Show("Pickup Miss มีจำนวนมากกว่า IC Missing คุณต้องการบันทึกใช่ไหม", "", MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.No Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            MsgBox("กรุณาเลือก เวลา Start Time")
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ltSelectTime_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltSelectTime.SelectedValueChanged

        lt = CType(sender, ListBox)

        For Each row As DBxDataSet.MAPTPDataRow In frmMain.DBxDataSet.MAPTPData.Rows

            If row.LotNo = LotNo AndAlso Not row.IsLotJudgementNull() AndAlso row.LotStartTime = lt.Text Then

                Dim intpickup As Integer = m_InputPickup
                StartTime = row.LotStartTime
                EndTime = row.LotEndTime
                InPutQty = row.InputQty
                TPQty = row.TotalGood
                lbICMissBefore.Text = row.ICMissing
                NG1 = row.NGBin1
                NG2 = row.NGBin2
                NG3 = row.NGBin3
                NG4 = row.NGBin4
                If row.IsICDropNull = False Then
                    ICDrp = row.ICDrop
                End If
                TotalNG = NG1 + NG2 + NG3 + NG4 + +ICDrp + intpickup
                ICMIssingAfter = Abs((TotalNG + TPQty) - InPutQty)
                NGRate = FormatNumber((TotalNG / InPutQty) * 100, 1)


                lblotNo.Text = LotNo
                lbStat.Text = Format(StartTime, "yyyy/MM/dd HH:mm:ss")
                lbEnd.Text = Format(EndTime, "yyyy/MM/dd HH:mm:ss")
                lbTP.Text = TPQty
                lbInput.Text = InPutQty
                lbBin1.Text = NG1
                lbBin2.Text = NG2
                lbBin3.Text = NG3
                lbBin4.Text = NG4
                lbICDrop.Text = ICDrp
                lbICmissAfter.Text = ICMIssingAfter
                lbPickMiss.Text = m_InputPickup
                lbTatal.Text = TotalNG
                lbNgrate.Text = NGRate

                If lbICmissAfter.Text <> 0 Then
                    blinkers.Enabled = True
                Else
                    blinkers.Enabled = False
                    gbblinkers.BackColor = Color.Transparent
                End If

            End If

        Next

    End Sub

    Private Sub frmInputPickup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        blinkers.Enabled = False
        gbblinkers.BackColor = Color.Transparent
    End Sub

    Private Sub frmInputPickup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        StartTime = #12:00:00 AM#
        m_InputPickup = intpickup
    End Sub

    Private Sub blinkers_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blinkers.Tick
        If gbblinkers.BackColor = Color.Orange Then
            gbblinkers.BackColor = Color.Violet
        Else
            gbblinkers.BackColor = Color.Orange
        End If

    End Sub
End Class
