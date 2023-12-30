Imports System.Data.OleDb

Public Class fm_laporanmasuk
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_stok As New fm_stok()
        fm_stok.Show()
        Me.Hide()
    End Sub

    Private Sub fm_laporanmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("id_masuk")
        ComboBox1.Items.Add("id_barang")
        ComboBox1.Items.Add("nama_barang")
        ComboBox1.Items.Add("tanggal_masuk")
        ComboBox1.Items.Add("jumlahmasuk")

        ComboBox1.SelectedIndex = 0

        LoadDataToDataGridView()
    End Sub

    Private Sub LoadDataToDataGridView()
        Try
            connection.Open()

            Dim query As String = "SELECT tbl_masuk.id_masuk, tbl_masuk.id_barang, tbl_barang.nama_barang, tbl_masuk.tanggal_masuk, tbl_masuk.jumlahmasuk " &
                                  "FROM tbl_barang INNER JOIN tbl_masuk ON tbl_barang.id_barang = tbl_masuk.id_barang;"

            Dim dataAdapter As New OleDbDataAdapter(query, connection)

            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            dataTable.Columns("nama_barang").SetOrdinal(2)

            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub SearchData()
        Try
            connection.Open()

            Dim selectedColumn As String = ComboBox1.SelectedItem.ToString()
            Dim searchTerm As String = TextBox1.Text.ToLower()

            Dim query As String = $"SELECT tbl_masuk.id_masuk, tbl_masuk.id_barang, tbl_barang.nama_barang, tbl_masuk.tanggal_masuk, tbl_masuk.jumlahmasuk " &
                              "FROM tbl_barang AS tbl_barang INNER JOIN tbl_masuk AS tbl_masuk ON tbl_barang.id_barang = tbl_masuk.id_barang " &
                              $"WHERE LCASE(tbl_masuk.{selectedColumn}) LIKE @SearchTerm;"

            Dim dataAdapter As New OleDbDataAdapter(query, connection)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            dataTable.Columns("nama_barang").SetOrdinal(2)

            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error searching data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        SearchData()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SearchData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        SearchData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
