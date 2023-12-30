Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class fm_user
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"

    Private Sub fm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateAutonumber()
    End Sub
    Private Sub GenerateAutonumber()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT MAX(id_user) FROM tbl_user"
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

                    TextBox1.Text = "USR" & nextId.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim insertQuery As String = "INSERT INTO tbl_user (id_user, username, userpassword, usertype, value) " &
                            "VALUES (@id_user, @username, @userpassword, @usertype, @value)"

                Using cmd As New OleDbCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@id_user", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@username", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@userpassword", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@usertype", ComboBox1.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@value", "1")



                    cmd.ExecuteNonQuery()
                End Using
            End Using

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()


            MessageBox.Show("berhasil menambah user")
            GenerateAutonumber()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi ke database
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fm_dashboard As New fm_dashboard()
        fm_dashboard.Show()
        Me.Hide()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class