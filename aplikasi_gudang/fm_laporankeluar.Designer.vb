<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_laporankeluar
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
        Button3 = New Button()
        Label5 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Button1 = New Button()
        txtSearch = New TextBox()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(-2, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(804, 70)
        Panel2.TabIndex = 22
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(663, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 36)
        Button3.TabIndex = 28
        Button3.Text = "KELUAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(897, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(187, 38)
        Label5.TabIndex = 7
        Label5.Text = "dd/mm/yyyy"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(22, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(400, 32)
        Label9.TabIndex = 0
        Label9.Text = "APLIKASI MANAGEMEN GUDANG"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(22, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(192, 28)
        Label8.TabIndex = 18
        Label8.Text = "LAPAORAN KELUAR"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 142)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(749, 284)
        DataGridView1.TabIndex = 23
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(298, 92)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(163, 31)
        DateTimePicker1.TabIndex = 24
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(486, 92)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(163, 31)
        DateTimePicker2.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(464, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 25)
        Label1.TabIndex = 26
        Label1.Text = "-"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(661, 89)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 36)
        Button1.TabIndex = 29
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(20, 92)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 31)
        txtSearch.TabIndex = 31
        ' 
        ' fm_laporankeluar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtSearch)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_laporankeluar"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "fm_laporankeluar"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
End Class
