<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        btn_exit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_username
        ' 
        txt_username.BorderStyle = BorderStyle.FixedSingle
        txt_username.Cursor = Cursors.IBeam
        txt_username.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(58, 252)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(298, 37)
        txt_username.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.BorderStyle = BorderStyle.FixedSingle
        txt_password.Cursor = Cursors.IBeam
        txt_password.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.Location = New Point(58, 327)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(298, 37)
        txt_password.TabIndex = 1
        txt_password.UseSystemPasswordChar = True
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = SystemColors.MenuHighlight
        btn_login.FlatAppearance.BorderSize = 0
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(58, 396)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(297, 41)
        btn_login.TabIndex = 2
        btn_login.Text = "Login"
        btn_login.TextAlign = ContentAlignment.TopCenter
        btn_login.TextImageRelation = TextImageRelation.TextAboveImage
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_exit.FlatAppearance.BorderSize = 0
        btn_exit.FlatStyle = FlatStyle.Flat
        btn_exit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_exit.ForeColor = Color.White
        btn_exit.Location = New Point(58, 443)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(297, 41)
        btn_exit.TabIndex = 3
        btn_exit.Text = "Exit"
        btn_exit.TextAlign = ContentAlignment.TopCenter
        btn_exit.TextImageRelation = TextImageRelation.TextAboveImage
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(58, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 32)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(58, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 32)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(136, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 32)
        Label3.TabIndex = 6
        Label3.Text = "Login here!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(142, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' fm_login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 508)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_exit)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
