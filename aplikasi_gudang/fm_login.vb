Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class fm_login
    Private Sub fm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = ""
        txt_password.Text = ""
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("silakan isi  username dan password!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select *from TBL_USER where username='" & txt_username.Text & "'and userpassword='" & txt_password.Text & "'", conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                fm_dashboard.Show()
            Else
                MsgBox("username atau pasword salah!")
            End If
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_username.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_password.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btn_login.PerformClick()
        End If
    End Sub

End Class