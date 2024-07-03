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
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(382, 76)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 50)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(81, 123)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(66, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(69, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(241, 154)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(147, 84)
        Panel1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 293)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel

End Class
