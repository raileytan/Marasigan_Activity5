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
        txtFirstnum = New TextBox()
        Label1 = New Label()
        txtSecondnum = New TextBox()
        Label2 = New Label()
        btnDivide = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(97, 17)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 1
        Label1.Text = "First Number:"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(114, 54)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 1
        Label2.Text = "Second Number:"
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(75, 95)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 23)
        btnDivide.TabIndex = 2
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(85, 133)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(54, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "Quotient"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 429)
        Controls.Add(lblResult)
        Controls.Add(btnDivide)
        Controls.Add(Label2)
        Controls.Add(txtSecondnum)
        Controls.Add(Label1)
        Controls.Add(txtFirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblResult As Label
End Class
