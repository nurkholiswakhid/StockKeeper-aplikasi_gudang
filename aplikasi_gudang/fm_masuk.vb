Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class fm_masuk
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Private Sub fm_masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemIDsIntoComboBox()
        GenerateAutonumber()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TampilkanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_keluar As New fm_keluar()
        fm_keluar.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fm_dashboard As New fm_dashboard()
        fm_dashboard.Show()
        Me.Hide()
    End Sub


    Private Sub LoadItemIDsIntoComboBox()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT id_barang FROM tbl_barang"
                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        ComboBox1.Items.Add(reader("id_barang").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading item IDs: " & ex.Message)
        End Try
    End Sub


    Private Sub GenerateAutonumber()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT MAX(id_masuk) FROM tbl_masuk"
                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim maxId As Object = cmd.ExecuteScalar()

                    Dim nextId As Integer

                    If maxId IsNot DBNull.Value Then
                        Dim maxIdStr As String = maxId.ToString()
                        Dim numericPart As String = maxIdStr.Substring(3) ' Remove "MSK" from the string
                        nextId = Integer.Parse(numericPart) + 1
                    Else
                        nextId = 1
                    End If

                    txt_idmasuk.Text = "MSK" & nextId.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim insertQuery As String = "INSERT INTO tbl_masuk (id_masuk, id_barang, tanggal_masuk, jumlahmasuk) " &
                                                "VALUES (@id_masuk, @id_barang, @tanggal_masuk, @jumlahmasuk)"

                Using cmd As New OleDbCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@id_masuk", txt_idmasuk.Text)
                    cmd.Parameters.AddWithValue("@id_barang", ComboBox1.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@tanggal_masuk", Dt_masuk.Value)
                    cmd.Parameters.AddWithValue("@jumlahmasuk", num_masuk.Value)

                    cmd.ExecuteNonQuery()
                End Using

                Dim updateQuery As String = "UPDATE tbl_barang SET stok = stok + @stok WHERE id_barang = @id_barang"
                Using cmd As New OleDbCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@stok", CInt(num_masuk.Value))
                    cmd.Parameters.AddWithValue("@id_barang", ComboBox1.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using


                MessageBox.Show("Data telah disimpan ke dalam database.")
                GenerateAutonumber() ' Generate autonumber baru setelah berhasil menyimpan data
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fm_stok As New fm_stok()
        fm_stok.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fm_user As New fm_user()
        fm_user.Show()
        Me.Hide()
    End Sub
    Private Sub TampilkanData()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT nama_barang FROM tbl_barang WHERE id_barang = @id_barang"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    cmd.Parameters.AddWithValue("@id_barang", ComboBox1.SelectedItem.ToString())
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        TextBox1.Text = reader("nama_barang").ToString()
                    Else
                        MessageBox.Show("Barang tidak ditemukan.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_idmasuk_TextChanged(sender As Object, e As EventArgs) Handles txt_idmasuk.TextChanged

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub num_masuk_ValueChanged(sender As Object, e As EventArgs) Handles num_masuk.ValueChanged

    End Sub
End Class