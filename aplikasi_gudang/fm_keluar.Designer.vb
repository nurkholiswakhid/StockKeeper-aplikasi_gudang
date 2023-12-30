<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_keluar
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
        Label9 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Panel1 = New Panel()
        Button6 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        ButtonTambah = New Button()
        Button5 = New Button()
        TextBox2 = New TextBox()
        NumericUpDown2 = New NumericUpDown()
        Label7 = New Label()
        Label10 = New Label()
        TextBox5 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        KODE_FAKTUR = New DataGridViewTextBoxColumn()
        ID_BARANG = New DataGridViewTextBoxColumn()
        NAMA_BARANG = New DataGridViewTextBoxColumn()
        QYT = New DataGridViewTextBoxColumn()
        HARGA = New DataGridViewTextBoxColumn()
        TOTAL_HARGA = New DataGridViewTextBoxColumn()
        TextBox7 = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1170, 70)
        Panel2.TabIndex = 5
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.ImeMode = ImeMode.NoControl
        Label9.Location = New Point(745, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 25)
        Label9.TabIndex = 29
        Label9.Text = "TANGGAL"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(845, 22)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(286, 31)
        DateTimePicker2.TabIndex = 33
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        Panel1.Location = New Point(-1, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 467)
        Panel1.TabIndex = 4
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.ImeMode = ImeMode.NoControl
        Button6.Location = New Point(0, 365)
        Button6.Name = "Button6"
        Button6.Size = New Size(232, 88)
        Button6.TabIndex = 6
        Button6.Text = "USER"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(0, 277)
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
        Button2.Location = New Point(0, 101)
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
        Button1.Location = New Point(0, 13)
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
        Button3.Location = New Point(0, 189)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 88)
        Button3.TabIndex = 2
        Button3.Text = "BARANG KELUAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.BackColor = Color.Red
        ButtonTambah.FlatAppearance.BorderSize = 0
        ButtonTambah.FlatStyle = FlatStyle.Flat
        ButtonTambah.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonTambah.ForeColor = Color.White
        ButtonTambah.ImeMode = ImeMode.NoControl
        ButtonTambah.Location = New Point(237, 422)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(288, 34)
        ButtonTambah.TabIndex = 23
        ButtonTambah.Text = "TAMBAH"
        ButtonTambah.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LimeGreen
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.ImeMode = ImeMode.NoControl
        Button5.Location = New Point(237, 465)
        Button5.Name = "Button5"
        Button5.Size = New Size(288, 34)
        Button5.TabIndex = 16
        Button5.Text = "SAVE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(563, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(275, 31)
        TextBox2.TabIndex = 34
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.BorderStyle = BorderStyle.FixedSingle
        NumericUpDown2.Location = New Point(842, 111)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(60, 31)
        NumericUpDown2.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(845, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 25)
        Label7.TabIndex = 31
        Label7.Text = "QYT"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ImeMode = ImeMode.NoControl
        Label10.Location = New Point(237, 83)
        Label10.Name = "Label10"
        Label10.Size = New Size(128, 25)
        Label10.TabIndex = 28
        Label10.Text = "KODE FAKTUR"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(237, 111)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(133, 31)
        TextBox5.TabIndex = 26
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(906, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(108, 31)
        TextBox1.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(1025, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 25)
        Label2.TabIndex = 38
        Label2.Text = "TOTAL"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {KODE_FAKTUR, ID_BARANG, NAMA_BARANG, QYT, HARGA, TOTAL_HARGA})
        DataGridView1.Location = New Point(237, 155)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(914, 239)
        DataGridView1.TabIndex = 39
        ' 
        ' KODE_FAKTUR
        ' 
        KODE_FAKTUR.HeaderText = "KODE FAKTUR"
        KODE_FAKTUR.MinimumWidth = 8
        KODE_FAKTUR.Name = "KODE_FAKTUR"
        KODE_FAKTUR.Width = 150
        ' 
        ' ID_BARANG
        ' 
        ID_BARANG.HeaderText = "ID BARANG"
        ID_BARANG.MinimumWidth = 8
        ID_BARANG.Name = "ID_BARANG"
        ID_BARANG.Width = 150
        ' 
        ' NAMA_BARANG
        ' 
        NAMA_BARANG.HeaderText = "NAMA BARANG"
        NAMA_BARANG.MinimumWidth = 8
        NAMA_BARANG.Name = "NAMA_BARANG"
        NAMA_BARANG.Width = 150
        ' 
        ' QYT
        ' 
        QYT.HeaderText = "QYT"
        QYT.MinimumWidth = 8
        QYT.Name = "QYT"
        QYT.Width = 150
        ' 
        ' HARGA
        ' 
        HARGA.HeaderText = "HARGA"
        HARGA.MinimumWidth = 8
        HARGA.Name = "HARGA"
        HARGA.Width = 150
        ' 
        ' TOTAL_HARGA
        ' 
        TOTAL_HARGA.HeaderText = "TOTAL HARGA"
        TOTAL_HARGA.MinimumWidth = 8
        TOTAL_HARGA.Name = "TOTAL_HARGA"
        TOTAL_HARGA.Width = 150
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Location = New Point(1018, 111)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(108, 31)
        TextBox7.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(911, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 25)
        Label3.TabIndex = 42
        Label3.Text = "HARGA"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(376, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 25)
        Label8.TabIndex = 30
        Label8.Text = "ID BARANG"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(563, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 25)
        Label4.TabIndex = 43
        Label4.Text = "NAMA BARANG"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(547, 422)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(175, 31)
        TextBox4.TabIndex = 45
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(547, 397)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 25)
        Label5.TabIndex = 44
        Label5.Text = "TOTAL"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(375, 109)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 46
        ' 
        ' fm_keluar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 511)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox7)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label10)
        Controls.Add(TextBox5)
        Controls.Add(ButtonTambah)
        Controls.Add(Button5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_keluar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents KODE_FAKTUR As DataGridViewTextBoxColumn
    Friend WithEvents ID_BARANG As DataGridViewTextBoxColumn
    Friend WithEvents NAMA_BARANG As DataGridViewTextBoxColumn
    Friend WithEvents QYT As DataGridViewTextBoxColumn
    Friend WithEvents HARGA As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_HARGA As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
