<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_stok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Button6 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        Button7 = New Button()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-2, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1130, 70)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(51, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 32)
        Label1.TabIndex = 0
        Label1.Text = "APLIKASI MANAGEMEN GUDANG"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        Panel1.Location = New Point(-2, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 467)
        Panel1.TabIndex = 2
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.ImeMode = ImeMode.NoControl
        Button6.Location = New Point(0, 366)
        Button6.Name = "Button6"
        Button6.Size = New Size(232, 88)
        Button6.TabIndex = 7
        Button6.Text = "USER"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(0, 278)
        Button4.Name = "Button4"
        Button4.Size = New Size(232, 88)
        Button4.TabIndex = 3
        Button4.Text = "DAFTAR BARANG"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 102)
        Button2.Name = "Button2"
        Button2.Size = New Size(232, 88)
        Button2.TabIndex = 1
        Button2.Text = "BARANG MASUK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 88)
        Button1.TabIndex = 0
        Button1.Text = "HOME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 190)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 88)
        Button3.TabIndex = 2
        Button3.Text = "BARANG KELUAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(265, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 32)
        Label2.TabIndex = 1
        Label2.Text = "DAFTAR BARANG"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(265, 133)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(850, 287)
        DataGridView1.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LimeGreen
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(265, 440)
        Button5.Name = "Button5"
        Button5.Size = New Size(222, 51)
        Button5.TabIndex = 7
        Button5.Text = "LAPORAN MASUK"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.LimeGreen
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(504, 440)
        Button7.Name = "Button7"
        Button7.Size = New Size(222, 51)
        Button7.TabIndex = 8
        Button7.Text = "LAPORAN KELUAR"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' fm_stok
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 511)
        Controls.Add(Button7)
        Controls.Add(Label2)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_stok"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fm_stok"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
End Class
