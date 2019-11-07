Public Class frmInputQR
    Public QRCode As String
    Public QROpNo As String
    Public QRGLNo As String
    Public InputQtyOSFT As Integer
    Public inputTPQr As Integer
    Public Caption As String
    Public InputPickUp As Integer
    'Public DeviecDLot As String




    Private Sub tbRevQR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbRevQR.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Return) Then
            If tbRevQR.Text.Length = 252 AndAlso lbCaption.Text = "QR Code Pickup" Then
                QRCode = ""
                QRCode = tbRevQR.Text
                ProgressBar1.Value = 0
                tbRevQR.Clear()
                btKeylot.Visible = False
                gbPickup.Visible = True
                gbPickup.Enabled = True
                gbNumber.Enabled = True
                Me.Width = 397
                Me.Height = 463
                Me.StartPosition = FormStartPosition.CenterScreen

            Else
                ProgressBar1.Value = 0
                tbRevQR.Clear()
                MsgBox("QRCode ไม่ถูกต้องกรุณาสแกนใหม่")
            End If
        End If

    End Sub

    Private Sub frmInputQR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        tbRevQR.Focus()

    End Sub


    Private Sub frmInputQR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbCaption.Text = Caption
        Timer1.Start()
        btKeylot.Visible = False
        gbPickup.Visible = False
        gbPickup.Enabled = False
        gbNumber.Enabled = False
        tbRevQR.Clear()
        If lbCaption.Text = "QR Code Pickup" Then
            btKeylot.Visible = True
        End If
        Me.Width = 474
        Me.Height = 163
        tbRevQR.Focus()
        tbPickup.Clear()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If lbCaption.Text = "SCAN QR CODE" Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 252) * 100
            ElseIf lbCaption.Text = "SCAN OP No." Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 6) * 100
            ElseIf lbCaption.Text = "SCAN GL No." Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 6) * 100
            ElseIf lbCaption.Text = "QR Code Pickup" Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 252) * 100
            ElseIf lbCaption.Text = "SCAN OP No.." Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 6) * 100
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseDown, Button9.MouseDown, Button8.MouseDown, Button7.MouseDown, Button6.MouseDown, Button5.MouseDown, Button4.MouseDown, Button3.MouseDown, Button2.MouseDown, Button11.MouseDown
        Dim bt As Button
        tbPickup.Focus()
        bt = CType(sender, Button)
        SendKeys.Send(bt.Text)
    End Sub

    Private Sub btBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBS.MouseDown
        Dim bt As Button
        tbPickup.Focus()
        bt = CType(sender, Button)
        SendKeys.Send("{BS}")
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.MouseDown
        If tbPickup.Text = "" Then
            MsgBox("กรุณากรอกค่า Pickup")
            Exit Sub
        End If

        InputPickUp = CInt(tbPickup.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbRevQR.Focus()
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Me.Location)
    End Sub

    Private Sub btKeylot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKeylot.Click
        tbRevQR.Focus()
        If frmKeyLot.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
End Class