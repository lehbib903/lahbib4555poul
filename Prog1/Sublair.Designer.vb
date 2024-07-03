<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sublair
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
        CheckedListBox1 = New CheckedListBox()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(142, 90)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(166, 40)
        CheckedListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(143, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(85, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 32)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Sublair
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 302)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(CheckedListBox1)
        Name = "Sublair"
        Text = "Sublair"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
