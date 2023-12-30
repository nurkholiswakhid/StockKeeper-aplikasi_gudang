<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_masuk
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(fm_masuk))
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Button6 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Dt_masuk = New DateTimePicker()
        num_masuk = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txt_idmasuk = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(num_masuk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Label1)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.White
        Label1.Name = "Label1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        resources.ApplyResources(Button6, "Button6")
        Button6.ForeColor = Color.White
        Button6.Name = "Button6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        resources.ApplyResources(Button4, "Button4")
        Button4.ForeColor = Color.White
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        resources.ApplyResources(Button2, "Button2")
        Button2.ForeColor = Color.White
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = Color.White
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        resources.ApplyResources(Button3, "Button3")
        Button3.ForeColor = Color.White
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LimeGreen
        Button5.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Button5, "Button5")
        Button5.ForeColor = Color.White
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Dt_masuk
        ' 
        resources.ApplyResources(Dt_masuk, "Dt_masuk")
        Dt_masuk.Name = "Dt_masuk"
        ' 
        ' num_masuk
        ' 
        num_masuk.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(num_masuk, "num_masuk")
        num_masuk.Name = "num_masuk"
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.Name = "Label7"
        ' 
        ' Label8
        ' 
        resources.ApplyResources(Label8, "Label8")
        Label8.Name = "Label8"
        ' 
        ' Label9
        ' 
        resources.ApplyResources(Label9, "Label9")
        Label9.Name = "Label9"
        ' 
        ' Label10
        ' 
        resources.ApplyResources(Label10, "Label10")
        Label10.Name = "Label10"
        ' 
        ' txt_idmasuk
        ' 
        txt_idmasuk.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_idmasuk, "txt_idmasuk")
        txt_idmasuk.Name = "txt_idmasuk"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        resources.ApplyResources(ComboBox1, "ComboBox1")
        ComboBox1.Name = "ComboBox1"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' fm_masuk
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Dt_masuk)
        Controls.Add(num_masuk)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(txt_idmasuk)
        Controls.Add(Button5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "fm_masuk"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(num_masuk, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Dt_masuk As DateTimePicker
    Friend WithEvents num_masuk As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_idmasuk As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
