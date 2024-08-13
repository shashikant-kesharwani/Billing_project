<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Checksamosha = New CheckBox()
        Lblrestmenu = New Label()
        Checkbedpokada = New CheckBox()
        CheckAllutikiya = New CheckBox()
        Checkchai = New CheckBox()
        Btnorder = New Button()
        Textsamosha = New TextBox()
        Textbed = New TextBox()
        Textallu = New TextBox()
        Textchai = New TextBox()
        Lblitemlist = New Label()
        Lblquantity = New Label()
        Lblrate = New Label()
        Lblsamosha10 = New Label()
        Lblbed10 = New Label()
        Lblallu10 = New Label()
        Labblchai15 = New Label()
        Textbill = New TextBox()
        Lblbillreciept = New Label()
        btnneworder = New Button()
        SuspendLayout()
        ' 
        ' Checksamosha
        ' 
        Checksamosha.AutoSize = True
        Checksamosha.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Checksamosha.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Checksamosha.Location = New Point(79, 169)
        Checksamosha.Name = "Checksamosha"
        Checksamosha.Size = New Size(105, 29)
        Checksamosha.TabIndex = 0
        Checksamosha.Text = "Samosha"
        Checksamosha.UseVisualStyleBackColor = False
        ' 
        ' Lblrestmenu
        ' 
        Lblrestmenu.AutoSize = True
        Lblrestmenu.BackColor = Color.Lime
        Lblrestmenu.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblrestmenu.Location = New Point(189, 22)
        Lblrestmenu.Name = "Lblrestmenu"
        Lblrestmenu.Size = New Size(228, 41)
        Lblrestmenu.TabIndex = 1
        Lblrestmenu.Text = "Resturant Menu"
        ' 
        ' Checkbedpokada
        ' 
        Checkbedpokada.AutoSize = True
        Checkbedpokada.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Checkbedpokada.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Checkbedpokada.Location = New Point(57, 239)
        Checkbedpokada.Name = "Checkbedpokada"
        Checkbedpokada.Size = New Size(127, 29)
        Checkbedpokada.TabIndex = 2
        Checkbedpokada.Text = "Bed Pakoda"
        Checkbedpokada.UseVisualStyleBackColor = False
        ' 
        ' CheckAllutikiya
        ' 
        CheckAllutikiya.AutoSize = True
        CheckAllutikiya.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        CheckAllutikiya.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckAllutikiya.Location = New Point(67, 306)
        CheckAllutikiya.Name = "CheckAllutikiya"
        CheckAllutikiya.Size = New Size(117, 29)
        CheckAllutikiya.TabIndex = 3
        CheckAllutikiya.Text = "Allu Tikiya"
        CheckAllutikiya.UseVisualStyleBackColor = False
        ' 
        ' Checkchai
        ' 
        Checkchai.AutoSize = True
        Checkchai.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Checkchai.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Checkchai.Location = New Point(113, 368)
        Checkchai.Name = "Checkchai"
        Checkchai.Size = New Size(71, 29)
        Checkchai.TabIndex = 4
        Checkchai.Text = "Chai"
        Checkchai.UseVisualStyleBackColor = False
        ' 
        ' Btnorder
        ' 
        Btnorder.BackColor = Color.Fuchsia
        Btnorder.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnorder.Location = New Point(148, 438)
        Btnorder.Name = "Btnorder"
        Btnorder.Size = New Size(94, 41)
        Btnorder.TabIndex = 5
        Btnorder.Text = "Order"
        Btnorder.UseVisualStyleBackColor = False
        ' 
        ' Textsamosha
        ' 
        Textsamosha.BorderStyle = BorderStyle.None
        Textsamosha.Location = New Point(235, 169)
        Textsamosha.Name = "Textsamosha"
        Textsamosha.Size = New Size(125, 20)
        Textsamosha.TabIndex = 6
        Textsamosha.Text = "0"
        ' 
        ' Textbed
        ' 
        Textbed.Location = New Point(235, 239)
        Textbed.Name = "Textbed"
        Textbed.Size = New Size(125, 27)
        Textbed.TabIndex = 7
        Textbed.Text = "0"
        ' 
        ' Textallu
        ' 
        Textallu.Location = New Point(235, 303)
        Textallu.Name = "Textallu"
        Textallu.Size = New Size(125, 27)
        Textallu.TabIndex = 8
        Textallu.Text = "0"
        ' 
        ' Textchai
        ' 
        Textchai.Location = New Point(235, 368)
        Textchai.Name = "Textchai"
        Textchai.Size = New Size(125, 27)
        Textchai.TabIndex = 9
        Textchai.Text = "0"
        ' 
        ' Lblitemlist
        ' 
        Lblitemlist.AutoSize = True
        Lblitemlist.BackColor = Color.Aqua
        Lblitemlist.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblitemlist.Location = New Point(95, 97)
        Lblitemlist.Name = "Lblitemlist"
        Lblitemlist.Size = New Size(71, 31)
        Lblitemlist.TabIndex = 10
        Lblitemlist.Text = "Items"
        ' 
        ' Lblquantity
        ' 
        Lblquantity.AutoSize = True
        Lblquantity.BackColor = Color.Aqua
        Lblquantity.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblquantity.Location = New Point(235, 97)
        Lblquantity.Name = "Lblquantity"
        Lblquantity.Size = New Size(105, 31)
        Lblquantity.TabIndex = 11
        Lblquantity.Text = "Quantity"
        ' 
        ' Lblrate
        ' 
        Lblrate.AutoSize = True
        Lblrate.BackColor = Color.Aqua
        Lblrate.Font = New Font("Bell MT", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblrate.Location = New Point(424, 96)
        Lblrate.Name = "Lblrate"
        Lblrate.Size = New Size(65, 33)
        Lblrate.TabIndex = 12
        Lblrate.Text = "Rate"
        ' 
        ' Lblsamosha10
        ' 
        Lblsamosha10.AutoSize = True
        Lblsamosha10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Lblsamosha10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblsamosha10.Location = New Point(411, 173)
        Lblsamosha10.Name = "Lblsamosha10"
        Lblsamosha10.Size = New Size(100, 25)
        Lblsamosha10.TabIndex = 13
        Lblsamosha10.Text = "10 Rupees "
        ' 
        ' Lblbed10
        ' 
        Lblbed10.AutoSize = True
        Lblbed10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Lblbed10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblbed10.Location = New Point(411, 243)
        Lblbed10.Name = "Lblbed10"
        Lblbed10.Size = New Size(95, 25)
        Lblbed10.TabIndex = 14
        Lblbed10.Text = "10 Rupees"
        ' 
        ' Lblallu10
        ' 
        Lblallu10.AutoSize = True
        Lblallu10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Lblallu10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblallu10.Location = New Point(411, 307)
        Lblallu10.Name = "Lblallu10"
        Lblallu10.Size = New Size(95, 25)
        Lblallu10.TabIndex = 15
        Lblallu10.Text = "10 Rupees"
        ' 
        ' Labblchai15
        ' 
        Labblchai15.AutoSize = True
        Labblchai15.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Labblchai15.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labblchai15.Location = New Point(411, 370)
        Labblchai15.Name = "Labblchai15"
        Labblchai15.Size = New Size(95, 25)
        Labblchai15.TabIndex = 16
        Labblchai15.Text = "15 Rupees"
        ' 
        ' Textbill
        ' 
        Textbill.Location = New Point(627, 96)
        Textbill.Multiline = True
        Textbill.Name = "Textbill"
        Textbill.ReadOnly = True
        Textbill.Size = New Size(273, 253)
        Textbill.TabIndex = 17
        ' 
        ' Lblbillreciept
        ' 
        Lblbillreciept.AutoSize = True
        Lblbillreciept.BackColor = Color.Lime
        Lblbillreciept.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblbillreciept.Location = New Point(674, 22)
        Lblbillreciept.Name = "Lblbillreciept"
        Lblbillreciept.Size = New Size(168, 41)
        Lblbillreciept.TabIndex = 18
        Lblbillreciept.Text = "Bill Reciept"
        ' 
        ' btnneworder
        ' 
        btnneworder.BackColor = Color.Red
        btnneworder.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnneworder.Location = New Point(304, 438)
        btnneworder.Name = "btnneworder"
        btnneworder.Size = New Size(165, 41)
        btnneworder.TabIndex = 19
        btnneworder.Text = "New Order"
        btnneworder.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1010, 491)
        Controls.Add(btnneworder)
        Controls.Add(Lblbillreciept)
        Controls.Add(Textbill)
        Controls.Add(Labblchai15)
        Controls.Add(Lblallu10)
        Controls.Add(Lblbed10)
        Controls.Add(Lblsamosha10)
        Controls.Add(Lblrate)
        Controls.Add(Lblquantity)
        Controls.Add(Lblitemlist)
        Controls.Add(Textchai)
        Controls.Add(Textallu)
        Controls.Add(Textbed)
        Controls.Add(Textsamosha)
        Controls.Add(Btnorder)
        Controls.Add(Checkchai)
        Controls.Add(CheckAllutikiya)
        Controls.Add(Checkbedpokada)
        Controls.Add(Lblrestmenu)
        Controls.Add(Checksamosha)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Checksamosha As CheckBox
    Friend WithEvents Lblrestmenu As Label
    Friend WithEvents Checkbedpokada As CheckBox
    Friend WithEvents CheckAllutikiya As CheckBox
    Friend WithEvents Checkchai As CheckBox
    Friend WithEvents Btnorder As Button
    Friend WithEvents Textsamosha As TextBox
    Friend WithEvents Textbed As TextBox
    Friend WithEvents Textallu As TextBox
    Friend WithEvents Textchai As TextBox
    Friend WithEvents Lblitemlist As Label
    Friend WithEvents Lblquantity As Label
    Friend WithEvents Lblrate As Label
    Friend WithEvents Lblsamosha10 As Label
    Friend WithEvents Lblbed10 As Label
    Friend WithEvents Lblallu10 As Label
    Friend WithEvents Labblchai15 As Label
    Friend WithEvents Textbill As TextBox
    Friend WithEvents Lblbillreciept As Label
    Friend WithEvents btnneworder As Button
End Class
