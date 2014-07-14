Imports MySql.Data.MySqlClient
Public Class login
    Dim serv As String = "Server=localhost" & ";"
    Dim dbase As String = "Database=restoran" & ";"
    Dim uid As String = "uid=root" & ";"
    Dim pwd As String = "pwd=gombellama13" & ";"
    Dim Source = serv & dbase & uid & pwd & "default command timeout=3600; Allow User Variables=true"
    Dim Kueri As String
    Public Koneksi As New MySqlConnection(Source)
    Public mycommand As MySqlCommand
    Public Adapter As MySqlDataAdapter
    Public DS As DataSet
    Public DR As MySqlDataReader
    Sub login()
        db.Open()
        mycommand = New MySqlCommand("select status from user WHERE nama_user ='" & T_nama_user.Text & "' AND password = '" & T_password.Text & "' ", db)
        Dim reader As MySqlDataReader = mycommand.ExecuteReader()
        While reader.Read()
            T_Status.Text = (reader("status"))
        End While
        db.Close()
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T_password.PasswordChar = "*"
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        login()
        If T_Status.Text = "Admin" Then
            MenuAdmin.Show()
            Me.Hide()
        ElseIf T_Status.Text = "Kasir" Then
            transaksi.Show()
            Me.Hide()
        End If
    End Sub
End Class