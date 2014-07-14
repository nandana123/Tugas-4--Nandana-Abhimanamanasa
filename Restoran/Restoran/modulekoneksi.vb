Imports MySql.Data.MySqlClient
Module modulekoneksi
    Dim serv As String = "Server=localhost" & ";"
    Dim dbase As String = "Database=restoran" & ";"
    Dim uid As String = "uid=root" & ";"
    Dim pwd As String = "pwd=" & ";"
    Dim ConString = serv & dbase & uid & pwd & "default command timeout=3600; Allow User Variables=true"
    Public db As New MySqlConnection(ConString)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
        Catch ex As MySqlException
            'MsgBox(ex.Message)
            MessageBox.Show("Koneksi tidak berhasil dilakukan: " & ex.Message, "Jendela Pesan", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub
    
    Public Function getTableMenuMK() As DataTable
        Dim myDataTable As DataTable
        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT id_menu, nama, kategori, harga FROM tbl_menu WHERE kategori = 'food' Order By id_menu ASC", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet()
            myAdapter.Fill(myDataset, "Menu")
            myDataTable = myDataset.Tables("Menu")
            Return (myDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDB()
        End Try

    End Function
    Public Function getTableMenuMN() As DataTable
        Dim myDataTable As DataTable
        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT id_menu, nama, kategori, harga FROM tbl_menu WHERE kategori = 'drink' Order By id_menu ASC", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet()
            myAdapter.Fill(myDataset, "Menu")
            myDataTable = myDataset.Tables("Menu")
            Return (myDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDB()
        End Try

    End Function
    Public Sub tambah_menu(ByVal id_menu As String, ByVal nama As String, ByVal kategori As String, ByVal harga As Integer)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "insert into tbl_menu (id_menu, nama, kategori, harga) values (@idmenu,@nama,@kategori,@harga)"
        myCommand.Parameters.AddWithValue("@idmenu", id_menu)
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@kategori", kategori)
        myCommand.Parameters.AddWithValue("@harga", harga)
        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Telah Tersimpan", "Jendela Pesan", MessageBoxButtons.OK)
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDB()
        End Try
    End Sub


    Public Sub ubah_menu(ByVal id_menu As String, ByVal nama As String, ByVal kategori As String, ByVal harga As Integer)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE tbl_menu SET nama=@nama, kategori=@kategori, harga=@harga WHERE id_menu = @idmenu"
        myCommand.Parameters.AddWithValue("@idmenu", id_menu)
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@kategori", kategori)
        myCommand.Parameters.AddWithValue("@harga", harga)
        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Telah Terupdate", "Jendela Pesan", MessageBoxButtons.OK)
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal update data")
        Finally
            tutupDB()
        End Try
    End Sub

    Public Sub hapus_menu(ByVal id_menu As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "Delete from tbl_menu WHERE id_menu =@idmenu"
        myCommand.Parameters.AddWithValue("@idmenu", id_menu)
        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Telah Terhapus", "Jendela Pesan", MessageBoxButtons.OK)
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal hapus data")
        Finally
            tutupDB()
        End Try
    End Sub
    
    Public Sub inputtransaksi(ByVal id_transaksi As String, ByVal id_menu As String, ByVal jumlah_beli As Integer, ByVal jumlah_pesan As Integer, ByVal total_bayar As Integer)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "insert into transaksi (id_transaksi, id_menu,jumlah_beli, jumlah_pesan, total_bayar) values (@idtrans, @idmenu,@jumlahbeli,@jumlahpesan,@totalbayar)"
        myCommand.Parameters.AddWithValue("@idtrans", id_transaksi)
        myCommand.Parameters.AddWithValue("@idmenu", id_menu)
        myCommand.Parameters.AddWithValue("@jumlahbeli", jumlah_beli)
        myCommand.Parameters.AddWithValue("@jumlahpesan", jumlah_pesan)
        myCommand.Parameters.AddWithValue("@totalbayar", total_bayar)
        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Telah Tersimpan", "Jendela Pesan", MessageBoxButtons.OK)
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDB()
        End Try
    End Sub

End Module
