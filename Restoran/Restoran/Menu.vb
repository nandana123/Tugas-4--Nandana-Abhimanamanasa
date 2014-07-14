Imports MySql.Data.MySqlClient
Public Class form_menu
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader

    Sub clear()
        T_Id_menu.Text = ""
        T_Nama_menu.Text = ""
        C_Kategori.Text = ""
        T_harga.Text = ""
        CheckBox1.Checked = False
        ButtonDelete.Enabled = False
        ButtonUpdate.Enabled = False
    End Sub
    Private Sub form_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = getTableMenuMK()
        DataGridView2.DataSource = getTableMenuMN()
        ButtonDelete.Enabled = False
        ButtonUpdate.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ButtonDelete.Enabled = True
            ButtonUpdate.Enabled = True
            ButtonSimpan.Enabled = False
        Else
            ButtonDelete.Enabled = False
            ButtonUpdate.Enabled = False
            ButtonSimpan.Enabled = True
        End If
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click

        If T_Id_menu.Text <> "" And T_Nama_menu.Text <> "" And C_Kategori.Text <> "" And T_harga.Text <> "" Then
            tambah_menu(T_Id_menu.Text, T_Nama_menu.Text, C_Kategori.Text, Integer.Parse(T_harga.Text))
            DataGridView1.DataSource = getTableMenuMK()
            DataGridView2.DataSource = getTableMenuMN()

            clear()
        Else
            MsgBox("Masukkan Data Secara Lengkap")
        End If


    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim konfirmasi
        konfirmasi = MsgBox("Data Akan di Hapus ?", vbOKCancel, "Hapus Data")
        If konfirmasi = vbOK Then
            Try
                hapus_menu(T_Id_menu.Text)
                DataGridView1.DataSource = getTableMenuMK()
                DataGridView2.DataSource = getTableMenuMN()
                clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf konfirmasi = vbCancel Then
            MsgBox("Data ga jadi di hapus", vbInformation, "Batal")
        End If
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If T_Id_menu.Text <> "" And T_Nama_menu.Text <> "" And C_Kategori.Text <> "" And T_harga.Text <> "" Then
            ubah_menu(T_Id_menu.Text, T_Nama_menu.Text, C_Kategori.Text, Integer.Parse(T_harga.Text))
            DataGridView1.DataSource = getTableMenuMK()
            DataGridView2.DataSource = getTableMenuMN()

            clear()
        Else
            MsgBox("Masukkan Data Secara Lengkap")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim idM As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim namaM As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim kategoriM As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim hargaM As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        T_Id_menu.Text = CType(idM, String)
        T_Nama_menu.Text = CType(namaM, String)
        C_Kategori.Text = CType(kategoriM, String)
        T_harga.Text = CType(hargaM, String)
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim idM As Object = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Dim namaM As Object = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Dim kategoriM As Object = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        Dim hargaM As Object = DataGridView2.Rows(e.RowIndex).Cells(3).Value

        T_Id_menu.Text = CType(idM, String)
        T_Nama_menu.Text = CType(namaM, String)
        C_Kategori.Text = CType(kategoriM, String)
        T_harga.Text = CType(hargaM, String)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MenuAdmin.Show()
        Me.Dispose()
    End Sub
End Class
