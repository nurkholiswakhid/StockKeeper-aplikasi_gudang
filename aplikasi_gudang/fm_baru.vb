Imports System.Data.OleDb

Public Class fm_baru
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Private Sub fm_baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateAutonumber()
        LoadComboBoxData()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_dashboard As New fm_dashboard()
        fm_dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub GenerateAutonumber()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT MAX(id_barang) FROM tbl_barang"
                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim maxId As Object = cmd.ExecuteScalar()

                    Dim nextId As Integer

                    If maxId IsNot DBNull.Value Then
                        Dim maxIdStr As String = maxId.ToString()

                        ' Ensure the string length is sufficient to avoid "startIndex" errors
                        If maxIdStr.Length >= 3 Then
                            Dim numericPart As String = maxIdStr.Substring(3) ' Remove "BRG" from the string
                            nextId = Integer.Parse(numericPart) + 1
                        Else
                            nextId = 1
                        End If
                    Else
                        nextId = 1
                    End If

                    TextBox6.Text = "BRG" & nextId.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            GenerateAutonumber()
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim insertQuery As String = "INSERT INTO tbl_barang (id_barang, nama_barang, merek, kategori, stok, supplier, rak, harga) " &
                            "VALUES (@id_barang, @nama_barang, @merek, @kategori, @stok, @supplier, @rak, @harga)"

                Using cmd As New OleDbCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@id_barang", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@nama_barang", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@merek", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@kategori", ComboBox1.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@stok", 0)
                    cmd.Parameters.AddWithValue("@supplier", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@rak", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@harga", TextBox7.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' If the insertion was successful
            MessageBox.Show("PRODUK TERSIMPAN")


            ' Clear textboxes

            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.SelectedIndex = -1
            TextBox3.Clear()
            TextBox5.Clear()
            TextBox7.Clear()

            GenerateAutonumber()
            ' Restart your application - you may need to implement this logic based on your application's structure
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi ke database
        End Try
    End Sub




    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fm_kategori As New fm_kategori()
        fm_kategori.Show()
    End Sub

    Private Sub LoadComboBoxData()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT ID_kategori, kategori FROM tbl_kategori"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    ComboBox1.Items.Clear()

                    While reader.Read()
                        Dim ID_kategori As String = reader("ID_kategori").ToString()
                        Dim kategori As String = reader("kategori").ToString()
                        Dim combinedValue As String = $"{ID_kategori}-{kategori}"
                        ComboBox1.Items.Add(combinedValue)
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class