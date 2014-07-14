<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.T_nama_user = New System.Windows.Forms.TextBox
        Me.T_password = New System.Windows.Forms.TextBox
        Me.ButtonLogin = New System.Windows.Forms.Button
        Me.T_Status = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'T_nama_user
        '
        Me.T_nama_user.Location = New System.Drawing.Point(94, 19)
        Me.T_nama_user.Name = "T_nama_user"
        Me.T_nama_user.Size = New System.Drawing.Size(100, 20)
        Me.T_nama_user.TabIndex = 2
        '
        'T_password
        '
        Me.T_password.Location = New System.Drawing.Point(94, 53)
        Me.T_password.Name = "T_password"
        Me.T_password.Size = New System.Drawing.Size(100, 20)
        Me.T_password.TabIndex = 3
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(94, 90)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'T_Status
        '
        Me.T_Status.Location = New System.Drawing.Point(200, 19)
        Me.T_Status.Name = "T_Status"
        Me.T_Status.Size = New System.Drawing.Size(31, 20)
        Me.T_Status.TabIndex = 5
        Me.T_Status.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.T_nama_user)
        Me.GroupBox1.Controls.Add(Me.T_Status)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.T_password)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 153)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masuk"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "login"
        Me.Text = "login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T_nama_user As System.Windows.Forms.TextBox
    Friend WithEvents T_password As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents T_Status As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
