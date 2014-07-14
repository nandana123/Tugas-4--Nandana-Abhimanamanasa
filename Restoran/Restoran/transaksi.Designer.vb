<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi))
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Buttonhit = New System.Windows.Forms.Button()
        Me.Buttoninput = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.T_jumlahpesan = New System.Windows.Forms.TextBox()
        Me.T_id_menu = New System.Windows.Forms.TextBox()
        Me.T_Total = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_Kembali = New System.Windows.Forms.TextBox()
        Me.T_Bayar = New System.Windows.Forms.TextBox()
        Me.T_Jumlah_Porsi = New System.Windows.Forms.TextBox()
        Me.T_Harga = New System.Windows.Forms.TextBox()
        Me.C_Nama_Menu = New System.Windows.Forms.ComboBox()
        Me.T_Id_Trans = New System.Windows.Forms.TextBox()
        Me.Button_BackToMain = New System.Windows.Forms.Button()
        Me.Button_Keluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Reset
        '
        Me.Button_Reset.Font = New System.Drawing.Font("Pristina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(988, 356)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reset.TabIndex = 21
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Buttonhit
        '
        Me.Buttonhit.Font = New System.Drawing.Font("Pristina", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonhit.Location = New System.Drawing.Point(329, 356)
        Me.Buttonhit.Name = "Buttonhit"
        Me.Buttonhit.Size = New System.Drawing.Size(100, 23)
        Me.Buttonhit.TabIndex = 18
        Me.Buttonhit.Text = "Hitung"
        Me.Buttonhit.UseVisualStyleBackColor = True
        '
        'Buttoninput
        '
        Me.Buttoninput.Font = New System.Drawing.Font("Pristina", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoninput.Location = New System.Drawing.Point(962, 31)
        Me.Buttoninput.Name = "Buttoninput"
        Me.Buttoninput.Size = New System.Drawing.Size(101, 23)
        Me.Buttoninput.TabIndex = 17
        Me.Buttoninput.Text = "INPUT"
        Me.Buttoninput.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(435, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(678, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Id Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.T_jumlahpesan)
        Me.GroupBox1.Controls.Add(Me.T_id_menu)
        Me.GroupBox1.Controls.Add(Me.Buttoninput)
        Me.GroupBox1.Controls.Add(Me.T_Total)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.T_Kembali)
        Me.GroupBox1.Controls.Add(Me.T_Bayar)
        Me.GroupBox1.Controls.Add(Me.T_Jumlah_Porsi)
        Me.GroupBox1.Controls.Add(Me.T_Harga)
        Me.GroupBox1.Controls.Add(Me.C_Nama_Menu)
        Me.GroupBox1.Controls.Add(Me.T_Id_Trans)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button_Reset)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Buttonhit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 389)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'T_jumlahpesan
        '
        Me.T_jumlahpesan.Enabled = False
        Me.T_jumlahpesan.Location = New System.Drawing.Point(615, 355)
        Me.T_jumlahpesan.Name = "T_jumlahpesan"
        Me.T_jumlahpesan.Size = New System.Drawing.Size(28, 24)
        Me.T_jumlahpesan.TabIndex = 34
        Me.T_jumlahpesan.Visible = False
        '
        'T_id_menu
        '
        Me.T_id_menu.Enabled = False
        Me.T_id_menu.Location = New System.Drawing.Point(402, 30)
        Me.T_id_menu.Name = "T_id_menu"
        Me.T_id_menu.Size = New System.Drawing.Size(100, 24)
        Me.T_id_menu.TabIndex = 33
        '
        'T_Total
        '
        Me.T_Total.Enabled = False
        Me.T_Total.Location = New System.Drawing.Point(58, 355)
        Me.T_Total.Name = "T_Total"
        Me.T_Total.Size = New System.Drawing.Size(100, 24)
        Me.T_Total.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idme, Me.Nama, Me.Hrg, Me.jml, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 242)
        Me.DataGridView1.TabIndex = 33
        '
        'idme
        '
        Me.idme.HeaderText = "id"
        Me.idme.Name = "idme"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 250
        '
        'Hrg
        '
        Me.Hrg.HeaderText = "Harga"
        Me.Hrg.Name = "Hrg"
        Me.Hrg.Width = 300
        '
        'jml
        '
        Me.jml.HeaderText = "Jumlah"
        Me.jml.Name = "jml"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 250
        '
        'T_Kembali
        '
        Me.T_Kembali.Location = New System.Drawing.Point(509, 355)
        Me.T_Kembali.Name = "T_Kembali"
        Me.T_Kembali.Size = New System.Drawing.Size(100, 24)
        Me.T_Kembali.TabIndex = 31
        '
        'T_Bayar
        '
        Me.T_Bayar.Location = New System.Drawing.Point(223, 355)
        Me.T_Bayar.Name = "T_Bayar"
        Me.T_Bayar.Size = New System.Drawing.Size(100, 24)
        Me.T_Bayar.TabIndex = 30
        '
        'T_Jumlah_Porsi
        '
        Me.T_Jumlah_Porsi.Location = New System.Drawing.Point(746, 30)
        Me.T_Jumlah_Porsi.Name = "T_Jumlah_Porsi"
        Me.T_Jumlah_Porsi.Size = New System.Drawing.Size(100, 24)
        Me.T_Jumlah_Porsi.TabIndex = 28
        '
        'T_Harga
        '
        Me.T_Harga.Enabled = False
        Me.T_Harga.Location = New System.Drawing.Point(572, 30)
        Me.T_Harga.Name = "T_Harga"
        Me.T_Harga.Size = New System.Drawing.Size(100, 24)
        Me.T_Harga.TabIndex = 27
        '
        'C_Nama_Menu
        '
        Me.C_Nama_Menu.FormattingEnabled = True
        Me.C_Nama_Menu.Location = New System.Drawing.Point(275, 30)
        Me.C_Nama_Menu.Name = "C_Nama_Menu"
        Me.C_Nama_Menu.Size = New System.Drawing.Size(121, 26)
        Me.C_Nama_Menu.TabIndex = 26
        '
        'T_Id_Trans
        '
        Me.T_Id_Trans.Location = New System.Drawing.Point(169, 31)
        Me.T_Id_Trans.Name = "T_Id_Trans"
        Me.T_Id_Trans.Size = New System.Drawing.Size(100, 24)
        Me.T_Id_Trans.TabIndex = 24
        '
        'Button_BackToMain
        '
        Me.Button_BackToMain.Font = New System.Drawing.Font("Pristina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_BackToMain.Location = New System.Drawing.Point(822, 449)
        Me.Button_BackToMain.Name = "Button_BackToMain"
        Me.Button_BackToMain.Size = New System.Drawing.Size(146, 23)
        Me.Button_BackToMain.TabIndex = 32
        Me.Button_BackToMain.Text = "Log Out"
        Me.Button_BackToMain.UseVisualStyleBackColor = True
        '
        'Button_Keluar
        '
        Me.Button_Keluar.Font = New System.Drawing.Font("Pristina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Keluar.Location = New System.Drawing.Point(1012, 449)
        Me.Button_Keluar.Name = "Button_Keluar"
        Me.Button_Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Keluar.TabIndex = 32
        Me.Button_Keluar.Text = "Keluar"
        Me.Button_Keluar.UseVisualStyleBackColor = True
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1120, 484)
        Me.Controls.Add(Me.Button_Keluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_BackToMain)
        Me.Name = "transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
    Friend WithEvents Buttonhit As System.Windows.Forms.Button
    Friend WithEvents Buttoninput As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T_Harga As System.Windows.Forms.TextBox
    Friend WithEvents C_Nama_Menu As System.Windows.Forms.ComboBox
    Friend WithEvents T_Id_Trans As System.Windows.Forms.TextBox
    Friend WithEvents T_Kembali As System.Windows.Forms.TextBox
    Friend WithEvents T_Bayar As System.Windows.Forms.TextBox
    Friend WithEvents T_Total As System.Windows.Forms.TextBox
    Friend WithEvents T_Jumlah_Porsi As System.Windows.Forms.TextBox
    Friend WithEvents Button_BackToMain As System.Windows.Forms.Button
    Friend WithEvents Button_Keluar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents T_id_menu As System.Windows.Forms.TextBox
    Friend WithEvents T_jumlahpesan As System.Windows.Forms.TextBox
    Friend WithEvents idme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
