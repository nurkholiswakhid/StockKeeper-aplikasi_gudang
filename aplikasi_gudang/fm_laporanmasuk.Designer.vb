<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_laporanmasuk
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
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        ButtonSearch = New Button()
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
        Panel2.TabIndex = 23
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(659, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 36)
        Button3.TabIndex = 27
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
        Label8.Size = New Size(189, 28)
        Label8.TabIndex = 18
        Label8.Text = "LAPAORAN MASUK"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 129)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(732, 283)
        DataGridView1.TabIndex = 24
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(393, 78)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(254, 33)
        ComboBox1.TabIndex = 25
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(33, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(354, 31)
        TextBox1.TabIndex = 26
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.BackColor = Color.LimeGreen
        ButtonSearch.FlatAppearance.BorderSize = 0
        ButtonSearch.FlatStyle = FlatStyle.Flat
        ButtonSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonSearch.ForeColor = Color.White
        ButtonSearch.Location = New Point(657, 79)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(108, 34)
        ButtonSearch.TabIndex = 27
        ButtonSearch.Text = "Search"
        ButtonSearch.UseVisualStyleBackColor = False
        ' 
        ' fm_laporanmasuk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSearch)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_laporanmasuk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fm_laporanmasuk"
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonSearch As Button
End Class
