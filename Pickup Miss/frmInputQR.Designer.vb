<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tbRevQR = New System.Windows.Forms.TextBox
        Me.lbCaption = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbPickup = New System.Windows.Forms.GroupBox
        Me.tbPickup = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btBS = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.btOK = New System.Windows.Forms.Button
        Me.gbNumber = New System.Windows.Forms.GroupBox
        Me.btKeylot = New System.Windows.Forms.Button
        Me.gbPickup.SuspendLayout()
        Me.gbNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRevQR
        '
        Me.tbRevQR.ForeColor = System.Drawing.Color.White
        Me.tbRevQR.Location = New System.Drawing.Point(612, 21)
        Me.tbRevQR.Name = "tbRevQR"
        Me.tbRevQR.Size = New System.Drawing.Size(10, 20)
        Me.tbRevQR.TabIndex = 0
        '
        'lbCaption
        '
        Me.lbCaption.AutoSize = True
        Me.lbCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbCaption.Location = New System.Drawing.Point(44, 9)
        Me.lbCaption.Name = "lbCaption"
        Me.lbCaption.Size = New System.Drawing.Size(108, 31)
        Me.lbCaption.TabIndex = 1
        Me.lbCaption.Text = "Caption"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 71)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(442, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gbPickup
        '
        Me.gbPickup.Controls.Add(Me.tbPickup)
        Me.gbPickup.Location = New System.Drawing.Point(12, 49)
        Me.gbPickup.Name = "gbPickup"
        Me.gbPickup.Size = New System.Drawing.Size(385, 66)
        Me.gbPickup.TabIndex = 3
        Me.gbPickup.TabStop = False
        Me.gbPickup.Visible = False
        '
        'tbPickup
        '
        Me.tbPickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbPickup.Location = New System.Drawing.Point(54, 23)
        Me.tbPickup.Name = "tbPickup"
        Me.tbPickup.Size = New System.Drawing.Size(283, 30)
        Me.tbPickup.TabIndex = 0
        Me.tbPickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(41, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(131, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 54)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(221, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 54)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.Location = New System.Drawing.Point(41, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 54)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button5.Location = New System.Drawing.Point(131, 78)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 54)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button6.Location = New System.Drawing.Point(221, 78)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 54)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button7.Location = New System.Drawing.Point(41, 138)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 54)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button8.Location = New System.Drawing.Point(131, 138)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 54)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button9.Location = New System.Drawing.Point(221, 138)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(84, 54)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btBS
        '
        Me.btBS.BackColor = System.Drawing.Color.Red
        Me.btBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btBS.Location = New System.Drawing.Point(41, 198)
        Me.btBS.Name = "btBS"
        Me.btBS.Size = New System.Drawing.Size(84, 54)
        Me.btBS.TabIndex = 4
        Me.btBS.Text = "BS"
        Me.btBS.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button11.Location = New System.Drawing.Point(131, 198)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(84, 54)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "0"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.Lime
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btOK.Location = New System.Drawing.Point(221, 198)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(84, 54)
        Me.btOK.TabIndex = 4
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'gbNumber
        '
        Me.gbNumber.Controls.Add(Me.btOK)
        Me.gbNumber.Controls.Add(Me.Button9)
        Me.gbNumber.Controls.Add(Me.Button6)
        Me.gbNumber.Controls.Add(Me.Button11)
        Me.gbNumber.Controls.Add(Me.Button3)
        Me.gbNumber.Controls.Add(Me.btBS)
        Me.gbNumber.Controls.Add(Me.Button8)
        Me.gbNumber.Controls.Add(Me.Button7)
        Me.gbNumber.Controls.Add(Me.Button5)
        Me.gbNumber.Controls.Add(Me.Button4)
        Me.gbNumber.Controls.Add(Me.Button2)
        Me.gbNumber.Controls.Add(Me.Button1)
        Me.gbNumber.Location = New System.Drawing.Point(12, 132)
        Me.gbNumber.Name = "gbNumber"
        Me.gbNumber.Size = New System.Drawing.Size(343, 276)
        Me.gbNumber.TabIndex = 5
        Me.gbNumber.TabStop = False
        '
        'btKeylot
        '
        Me.btKeylot.BackColor = System.Drawing.Color.Tomato
        Me.btKeylot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btKeylot.Location = New System.Drawing.Point(308, 12)
        Me.btKeylot.Name = "btKeylot"
        Me.btKeylot.Size = New System.Drawing.Size(89, 25)
        Me.btKeylot.TabIndex = 99
        Me.btKeylot.TabStop = False
        Me.btKeylot.Text = "Key Data"
        Me.btKeylot.UseVisualStyleBackColor = False
        Me.btKeylot.Visible = False
        '
        'frmInputQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 125)
        Me.Controls.Add(Me.btKeylot)
        Me.Controls.Add(Me.gbNumber)
        Me.Controls.Add(Me.gbPickup)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbCaption)
        Me.Controls.Add(Me.tbRevQR)
        Me.Name = "frmInputQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInputQR"
        Me.gbPickup.ResumeLayout(False)
        Me.gbPickup.PerformLayout()
        Me.gbNumber.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRevQR As System.Windows.Forms.TextBox
    Friend WithEvents lbCaption As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gbPickup As System.Windows.Forms.GroupBox
    Friend WithEvents tbPickup As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btBS As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents gbNumber As System.Windows.Forms.GroupBox
    Friend WithEvents btKeylot As System.Windows.Forms.Button
End Class
