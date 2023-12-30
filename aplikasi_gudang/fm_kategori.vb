Imports System.Data.OleDb
Imports System.Linq.Expressions

Public Class fm_kategori
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Private Sub fm_kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateAutonumber()
    End Sub
    Private Sub GenerateAutonumber()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT MAX(id_kategori) FROM tbl_kategori"
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

                    TextBox1.Text = "KTG" & nextId.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim insertQuery As String = "INSERT INTO tbl_kategori (id_kategori, kategori) " &
                            "VALUES (@id_kategori, @kategori)"

                Using cmd As New OleDbCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@ID_kategori", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@kategori", TextBox2.Text)


                    cmd.ExecuteNonQuery()
                    MessageBox.Show("KATEGORI BERHASIL DI TAMBAHKAN")
                End Using
                GenerateAutonumber()
            End Using
            TextBox2.Clear()


        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
        End Try
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class