Imports System.Data.OleDb

Public Class fm_dashboard
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fm_masuk As New fm_masuk()
        fm_masuk.Show()
        Me.Hide()
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub fm_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Date.Now.ToShortDateString()
        CalculateAndDisplayTotalStok()
        CalculateAndDisplayTotaljual()
        CalculateAndDisplayTotaluser()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fm_keluar As New fm_keluar()
        fm_keluar.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fm_baru As New fm_baru()
        fm_baru.Show()
        Me.Hide()
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


    Private Sub CalculateAndDisplayTotalStok()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT SUM(stok) FROM tbl_barang"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim totalStok As Object = cmd.ExecuteScalar()

                    If totalStok IsNot DBNull.Value Then
                        Label5.Text = " " & totalStok.ToString()
                    Else
                        Label5.Text = "0"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateAndDisplayTotaljual()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT SUM(qty) FROM tbl_detailkeluar"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim totalStok As Object = cmd.ExecuteScalar()

                    If totalStok IsNot DBNull.Value Then
                        Label7.Text = " " & totalStok.ToString()
                    Else
                        Label7.Text = "0"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateAndDisplayTotaluser()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT SUM(value) FROM tbl_user"

                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim totalStok As Object = cmd.ExecuteScalar()

                    If totalStok IsNot DBNull.Value Then
                        Label8.Text = " " & totalStok.ToString()
                    Else
                        Label8.Text = "0"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class