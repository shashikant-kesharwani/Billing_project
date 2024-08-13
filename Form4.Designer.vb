<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txtname = New TextBox()
        txtpass = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtname.Location = New Point(387, 195)
        txtname.Multiline = True
        txtname.Name = "txtname"
        txtname.PlaceholderText = "Enter The User Name"
        txtname.Size = New Size(283, 49)
        txtname.TabIndex = 12
        txtname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtpass.Location = New Point(387, 274)
        txtpass.Multiline = True
        txtpass.Name = "txtpass"
        txtpass.PlaceholderText = "Enter The Password"
        txtpass.Size = New Size(283, 47)
        txtpass.TabIndex = 21
        txtpass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button1.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(455, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 64)
        Button1.TabIndex = 2
        Button1.Text = "Login "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Font = New Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(336, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(382, 96)
        Label1.TabIndex = 22
        Label1.Text = "Staff Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Login
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1100, 630)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtpass)
        Controls.Add(txtname)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Red
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(4)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Resturant Application Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
