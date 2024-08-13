<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Details
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        cmbnumber = New ComboBox()
        btnsubmit = New Button()
        Txtnumber = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(246, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(395, 83)
        Label1.TabIndex = 0
        Label1.Text = "User Details"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(182, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 38)
        Label2.TabIndex = 1
        Label2.Text = "Customer Name :"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(162, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(203, 38)
        Label3.TabIndex = 2
        Label3.Text = "Customer Number :"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(399, 190)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.PlaceholderText = " Customer Name"
        txtName.Size = New Size(320, 33)
        txtName.TabIndex = 25
        ' 
        ' cmbnumber
        ' 
        cmbnumber.FormattingEnabled = True
        cmbnumber.Items.AddRange(New Object() {"+91", "+68", "+41", "+52"})
        cmbnumber.Location = New Point(398, 259)
        cmbnumber.Name = "cmbnumber"
        cmbnumber.Size = New Size(68, 33)
        cmbnumber.TabIndex = 4
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnsubmit.Font = New Font("SimSun-ExtB", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnsubmit.Location = New Point(337, 339)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(143, 50)
        btnsubmit.TabIndex = 5
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' Txtnumber
        ' 
        Txtnumber.Location = New Point(479, 258)
        Txtnumber.Multiline = True
        Txtnumber.Name = "Txtnumber"
        Txtnumber.PlaceholderText = "Mobile Number"
        Txtnumber.Size = New Size(240, 38)
        Txtnumber.TabIndex = 6
        ' 
        ' User_Details
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.user_Details
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(934, 553)
        Controls.Add(Txtnumber)
        Controls.Add(btnsubmit)
        Controls.Add(cmbnumber)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "User_Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Resturant  Application User_Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbnumber As ComboBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Txtnumber As TextBox
End Class
