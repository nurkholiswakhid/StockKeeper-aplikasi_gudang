Imports System.Data.OleDb

Public Class fm_laporankeluar
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_stok As New fm_stok()
        fm_stok.Show()
        Me.Hide()
    End Sub

    Private Sub fm_laporankeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open the connection
            connection.Open()

            ' Perform the SELECT query
            Dim query As String = "SELECT tbl_keluar.id_keluar, tbl_keluar.tanggal, tbl_detailkeluar.id_barang, tbl_detailkeluar.nama_barang, tbl_detailkeluar.qty, tbl_detailkeluar.total " &
                                  "FROM tbl_detailkeluar INNER JOIN tbl_keluar ON tbl_detailkeluar.id_keluar = tbl_keluar.id_keluar;"

            ' Create a data adapter
            Dim dataAdapter As New OleDbDataAdapter(query, connection)

            ' Create a DataTable to store the results
            Dim dataTable As New DataTable()

            ' Fill the DataTable with the results of the query
            dataAdapter.Fill(dataTable)

            ' Set the DataTable as the DataSource for the DataGridView
            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell content click events if needed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PerformSearch()
    End Sub

    Private Sub PerformSearch()
        Try
            connection.Open()

            Dim searchQuery As String = "SELECT tbl_keluar.id_keluar, tbl_keluar.tanggal, tbl_detailkeluar.id_barang, tbl_detailkeluar.nama_barang, tbl_detailkeluar.qty, tbl_detailkeluar.total " &
                                        "FROM tbl_detailkeluar INNER JOIN tbl_keluar ON tbl_detailkeluar.id_keluar = tbl_keluar.id_keluar " &
                                        "WHERE 1=1"

            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                searchQuery &= " AND (tbl_detailkeluar.nama_barang LIKE @SearchParam OR tbl_detailkeluar.id_barang LIKE @SearchParam)"
            End If

            If DateTimePicker1.Value <> DateTimePicker1.MinDate Then
                searchQuery &= " AND tbl_keluar.tanggal >= @StartDate"
            End If

            If DateTimePicker2.Value <> DateTimePicker2.MinDate Then
                searchQuery &= " AND tbl_keluar.tanggal < @EndDate"
            End If

            Dim dataAdapter As New OleDbDataAdapter(searchQuery, connection)

            ' Add parameters based on user input
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchParam", "%" & txtSearch.Text & "%")
            End If

            If DateTimePicker1.Value <> DateTimePicker1.MinDate Then
                dataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", DateTimePicker1.Value)
            End If

            If DateTimePicker2.Value <> DateTimePicker2.MinDate Then
                dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", DateTimePicker2.Value.AddDays(1))
            End If

            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


End Class
