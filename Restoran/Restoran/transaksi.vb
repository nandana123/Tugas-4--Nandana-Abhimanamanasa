Imports MySql.Data.MySqlClient
Public Class transaksi
    Dim serv As String = "Server=localhost" & ";"
    Dim dbase As String = "Database=restoran" & ";"
    Dim uid As String = "uid=root" & ";"
    Dim pwd As String = "pwd=" & ";"
    Dim Source = serv & dbase & uid & pwd & "default command timeout=3600; Allow User Variables=true"
    Dim Kueri As String
    Public Koneksi As New MySqlConnection(Source)
    Public mycommand As MySqlCommand
    Public Adapter As MySqlDataAdapter
    Public DS As DataSet
    Public DR As MySqlDataReader
    Sub No_Trans()
        Koneksi.Open()
        mycommand = New MySqlCommand("Select id_transaksi From transaksi order by id_transaksi Asc", Koneksi)
        DR = mycommand.ExecuteReader
        Try
            Dim X, Y As Integer
            X = 0
            While DR.Read
                T_Id_Trans.Text = DR.Item(0)
                Y = ((T_Id_Trans.Text.Substring(3, 1)) + 1)
                X = X + 1
            End While

            Select Case X
                Case Is = 0
                    T_Id_Trans.Text = " T-1"
                Case Is > 0
                    T_Id_Trans.Text = " T-" & Y & ""
            End Select
            DR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Koneksi.Close()
    End Sub
    Sub clear1()
        T_Harga.Text = ""
        C_Nama_Menu.Text = ""
        T_Jumlah_Porsi.Text = ""
        T_id_menu.Text = ""
    End Sub
    Sub ambildataidmenu()
        db.Open()
        myCommand = New MySqlCommand("select DISTINCT nama from tbl_menu order by nama ASC", db)
        Dim reader As MySqlDataReader = myCommand.ExecuteReader()
        While reader.Read()
            C_Nama_Menu.Items.Add(reader("nama"))
        End While
        db.Close()
    End Sub
    Sub harga()
        db.Open()
        myCommand = New MySqlCommand("select harga, nama from tbl_menu WHERE nama like'" & C_Nama_Menu.Text & "%'", db)
        Dim reader As MySqlDataReader = myCommand.ExecuteReader()
        While reader.Read()
            T_Harga.Text = (reader("harga"))
        End While
        db.Close()
    End Sub
    Sub idmenu()
        db.Open()
        myCommand = New MySqlCommand("select id_menu from tbl_menu WHERE nama like'" & C_Nama_Menu.Text & "%'", db)
        Dim reader As MySqlDataReader = myCommand.ExecuteReader()
        While reader.Read()
            T_id_menu.Text = (reader("id_menu"))
        End While
        db.Close()
    End Sub
    Private Sub transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T_Harga.Enabled = False
        T_Total.Enabled = False
        T_Kembali.Enabled = False
        ambildataidmenu()
        No_Trans()
    End Sub
    Private Sub Button_Cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhit.Click
        T_Kembali.Text = T_Bayar.Text - T_Total.Text
        Koneksi.Open()
        For i = 0 To DataGridView1.RowCount - 2
            With mycommand
                .CommandText = "insert into transaksi (id_transaksi, id_menu,jumlah_beli, jumlah_pesan, total_bayar) values (@idtrans, @idmenu,@jumlahbeli,@jumlahpesan,@totalbayar)"
                .Parameters.AddWithValue("@idtrans", Me.T_Id_Trans.Text)
                .Parameters.AddWithValue("@idmenu", Me.DataGridView1.Rows(i).Cells(4).Value)
                .Parameters.AddWithValue("@jumlahbeli", Me.DataGridView1.Rows(i).Cells(2).Value)
                .Parameters.AddWithValue("@jumlahpesan", T_jumlahpesan.Text)
                .Parameters.AddWithValue("@totalbayar", T_Total.Text)
                .Connection = Koneksi
                .ExecuteNonQuery()
            End With
            mycommand.Parameters.Clear()

        Next
        Koneksi.Close()
        Buttonhit.Enabled = False
    End Sub
    Private Sub Button_Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoninput.Click
        Dim a As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(a).Cells(0).Value = C_Nama_Menu.Text
        DataGridView1.Rows.Item(a).Cells(1).Value = T_Harga.Text
        DataGridView1.Rows.Item(a).Cells(2).Value = T_Jumlah_Porsi.Text
        DataGridView1.Rows.Item(a).Cells(4).Value = T_id_menu.Text
        Dim b, c, d, f As Integer
        b = T_Harga.Text
        c = T_Jumlah_Porsi.Text
        DataGridView1.Rows.Item(a).Cells(3).Value = b * c

        For i = 0 To DataGridView1.RowCount - 2
            d = d + DataGridView1.Rows(i).Cells(3).Value
            T_Total.Text = d
            f = f + DataGridView1.Rows(i).Cells(2).Value
            T_jumlahpesan.Text = f
            T_Id_Trans.Enabled = False
        Next

        clear1()
    End Sub

    Private Sub Button_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Keluar.Click
        Me.Dispose()

    End Sub
    Private Sub C_Nama_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Nama_Menu.SelectedIndexChanged
        harga()
        idmenu()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        T_Id_Trans.Text = ""
        Buttonhit.Enabled = True
        T_Id_Trans.Enabled = True

        clear1()
        DataGridView1.DataMember = Nothing
        T_Total.Text = ""
        T_Bayar.Text = ""
        T_Kembali.Text = ""
        No_Trans()
    End Sub

    Private Sub Button_BackToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_BackToMain.Click
        login.Show()
        Me.Dispose()
    End Sub
End Class