Public Class frmKeyLot
    Dim m_KeytextBox As TextBox
    Public strLot As String
    Public intPickup As Integer
    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If tbLot.Text.Length <> 10 Then
            MsgBox("LotNo ไม่ถูกต้องกรุณาตรวจสอบ")
            Exit Sub
        ElseIf IsNumeric(tbPickup.Text) = False OrElse CInt(tbPickup.Text) > 30000 Then
            MsgBox("Pickup Miss ไม่ถูกต้องกรุณาตรวจสอบ")
            Exit Sub
        End If
        strLot = tbLot.Text
        intPickup = CInt(tbPickup.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        If m_KeytextBox Is Nothing Then
            Exit Sub
        End If
        Dim bt As Button = CType(sender, Button)
        m_KeytextBox.Focus()
        SendKeys.Send("{" & bt.Text & "}")
    End Sub

    Private Sub tbLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLot.Click, tbPickup.Click
        Dim tb As TextBox = CType(sender, TextBox)
        m_KeytextBox = tb
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Me.Close()
    End Sub

    Private Sub frmKeyLot_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tbLot.Clear()
        tbPickup.Clear()
        strLot = ""
        intPickup = 0
    End Sub
End Class