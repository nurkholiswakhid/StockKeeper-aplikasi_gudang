Imports System.Data.OleDb

Public Class fm_keluar
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
    Dim dt As New DataTable

    Private Sub fm_keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemIDsIntoComboBox()
        GenerateAutonumber()
        CalculateTotal()
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

    Private Sub TampilkanData()
        Try
            If ComboBox1.SelectedItem IsNot Nothing Then
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()

                    Dim selectQuery As String = "SELECT nama_barang, harga FROM tbl_barang WHERE id_barang = @id_barang"

                    Using cmd As New OleDbCommand(selectQuery, connection)
                        cmd.Parameters.AddWithValue("@id_barang", ComboBox1.SelectedItem.ToString())
                        Dim reader As OleDbDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()
                            TextBox2.Text = reader("nama_barang").ToString()
                            TextBox1.Text = reader("harga").ToString()
                        Else
                            ' Clear TextBox values if no matching data found
                            TextBox2.Clear()
                            TextBox1.Clear()
                            MessageBox.Show("Barang tidak ditemukan.")
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TampilkanData()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fm_dashboard As New fm_dashboard()
        fm_dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fm_masuk As New fm_masuk()
        fm_masuk.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fm_stok As New fm_stok()
        fm_stok.Show()
        Me.Hide()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        CalculateAndDisplay()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CalculateAndDisplay()
    End Sub

    Private Sub CalculateAndDisplay()
        Dim numericValue As Decimal = NumericUpDown2.Value
        Dim textBoxValue As Decimal

        If Decimal.TryParse(TextBox1.Text, textBoxValue) Then
            Dim result As Decimal = numericValue * textBoxValue
            TextBox7.Text = result.ToString()
        End If
    End Sub

    Private Sub GenerateAutonumber()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim selectQuery As String = "SELECT MAX(id_keluar) FROM tbl_keluar"
                Using cmd As New OleDbCommand(selectQuery, connection)
                    Dim maxId As Object = cmd.ExecuteScalar()

                    Dim nextId As Integer

                    If maxId IsNot DBNull.Value Then
                        Dim maxIdStr As String = maxId.ToString()
                        Dim numericPart As String = maxIdStr.Substring(4) ' Remove "FKTR" from the string
                        nextId = Integer.Parse(numericPart) + 1
                    Else
                        nextId = 1
                    End If

                    TextBox5.Text = "FKTR" & nextId.ToString("D4")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Errorauto: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim kode_faktur As String = row.Cells("kode_faktur").Value.ToString()
                        Dim id_barang As String = row.Cells("id_barang").Value.ToString()
                        Dim nama_barang As String = row.Cells("nama_barang").Value.ToString()
                        Dim qty As String = row.Cells("qyt").Value.ToString()
                        Dim TOTAL_HARGA As String = (row.Cells("TOTAL_HARGA").Value.ToString())

                        Using cmd As New OleDbCommand("INSERT INTO tbl_detailkeluar ( id_keluar, id_barang, nama_barang, qty, total) VALUES ( @id_keluar, @id_barang, @nama_barang, @qty, @total)", connection)
                            ' Menggunakan GUID untuk ID
                            cmd.Parameters.AddWithValue("@id_keluar", kode_faktur)
                            cmd.Parameters.AddWithValue("@id_barang", id_barang)
                            cmd.Parameters.AddWithValue("@nama_barang", nama_barang)
                            cmd.Parameters.AddWithValue("@qty", qty)
                            cmd.Parameters.AddWithValue("@total", TOTAL_HARGA)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Data berhasil disimpan ke tabel tbl_detailkeluar.")
            End Using
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using cmd As New OleDbCommand("INSERT INTO tbl_keluar (id_keluar, tanggal, total) VALUES (@id_keluar, @tanggal,  @total)", connection)
                    cmd.Parameters.AddWithValue("@id_keluar", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@tanggal", DateTimePicker2.Value)
                    cmd.Parameters.AddWithValue("@total", TextBox4.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim idBarang As String = row.Cells("ID_BARANG").Value.ToString()
                        Dim qty As Integer = CInt(row.Cells("QYT").Value)

                        Using cmd As New OleDbCommand("UPDATE tbl_barang SET stok = stok - @qty WHERE id_barang = @id_barang", connection)
                            cmd.Parameters.AddWithValue("@qty", qty)
                            cmd.Parameters.AddWithValue("@id_barang", idBarang)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Stok barang berhasil diperbarui.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan : " & ex.Message)
        End Try

        GenerateAutonumber()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fm_user As New fm_user()
        fm_user.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBox1.SelectedIndex <> -1 Then
            Dim kodeFaktur As String = TextBox5.Text
            Dim idBarang As String = ComboBox1.SelectedItem.ToString()
            Dim namaBarang As String = TextBox2.Text
            Dim qty As Integer = CInt(NumericUpDown2.Value)
            Dim harga As String = TextBox1.Text
            Dim TOTAL_HARGA As String = TextBox7.Text

            DataGridView1.Rows.Add(kodeFaktur, idBarang, namaBarang, qty, harga, TOTAL_HARGA)

            ' Bersihkan TextBox dan NumericUpDown   
            ComboBox1.SelectedIndex = -1 ' Clear the selected item in ComboBox
            TextBox2.Clear()
            NumericUpDown2.Value = 0
            TextBox1.Clear()
            TextBox7.Clear()

            CalculateTotal()
        Else
            MessageBox.Show("Silakan pilih item dari ComboBox.")
        End If
    End Sub


    Private Sub CalculateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim totalHarga As Decimal
                If Decimal.TryParse(row.Cells("TOTAL_HARGA").Value.ToString(), totalHarga) Then
                    total += totalHarga
                End If
            End If
        Next

        TextBox4.Text = total.ToString()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
