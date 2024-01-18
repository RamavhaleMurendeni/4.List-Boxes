<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ListBox1 = New ListBox()
        Button3 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(50, 44)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(179, 304)
        ListBox1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button3.Location = New Point(294, 44)
        Button3.Name = "Button3"
        Button3.Size = New Size(127, 59)
        Button3.TabIndex = 1
        Button3.Text = "Add"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button4.Location = New Point(294, 131)
        Button4.Name = "Button4"
        Button4.Size = New Size(127, 59)
        Button4.TabIndex = 1
        Button4.Text = "Remove"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button1.Location = New Point(294, 209)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 59)
        Button1.TabIndex = 1
        Button1.Text = "Delete Selected"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button2.Location = New Point(294, 289)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 59)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "ListBoxes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
