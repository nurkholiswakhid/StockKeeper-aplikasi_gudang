Imports System.Data.OleDb

Public Class fm_stok
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"

    Private Sub fm_stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToDataGridView()
    End Sub

    Private Sub LoadDataToDataGridView()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT * FROM tbl_barang"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim adapter As New OleDbDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Mengisi DataGridView dengan data
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fm_dashboard As New fm_dashboard()
        fm_dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fm_masuk As New fm_masuk()
        fm_masuk.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_keluar As New fm_keluar()
        fm_keluar.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fm_user As New fm_user()
        fm_user.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fm_laporanmasuk As New fm_laporanmasuk()
        fm_laporanmasuk.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fm_laporankeluar As New fm_laporankeluar()
        fm_laporankeluar.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
