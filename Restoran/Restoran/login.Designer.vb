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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_nama_user = New System.Windows.Forms.TextBox()
        Me.T_password = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.T_Status = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'T_nama_user
        '
        Me.T_nama_user.Location = New System.Drawing.Point(104, 220)
        Me.T_nama_user.Name = "T_nama_user"
        Me.T_nama_user.Size = New System.Drawing.Size(100, 20)
        Me.T_nama_user.TabIndex = 2
        '
        'T_password
        '
        Me.T_password.Location = New System.Drawing.Point(104, 258)
        Me.T_password.Name = "T_password"
        Me.T_password.Size = New System.Drawing.Size(100, 20)
        Me.T_password.TabIndex = 3
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(12, 318)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'T_Status
        '
        Me.T_Status.Location = New System.Drawing.Point(210, 220)
        Me.T_Status.Name = "T_Status"
        Me.T_Status.Size = New System.Drawing.Size(31, 20)
        Me.T_Status.TabIndex = 5
        Me.T_Status.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(463, 353)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.T_Status)
        Me.Controls.Add(Me.T_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T_nama_user)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T_nama_user As System.Windows.Forms.TextBox
    Friend WithEvents T_password As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents T_Status As System.Windows.Forms.TextBox
End Class
