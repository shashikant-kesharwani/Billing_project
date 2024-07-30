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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblbookdetail = New Label()
        lblbn = New Label()
        lblnob = New Label()
        lblprice = New Label()
        lbldiscount = New Label()
        lbltotalpayment = New Label()
        Btncalculate = New Button()
        Textbookname = New TextBox()
        Textnob = New TextBox()
        Textprice = New TextBox()
        Textdiscount = New TextBox()
        Texttotalpayment = New TextBox()
        Textbill = New TextBox()
        Btnprint = New Button()
        Lblbillpage = New Label()
        SuspendLayout()
        ' 
        ' lblbookdetail
        ' 
        lblbookdetail.AutoSize = True
        lblbookdetail.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        lblbookdetail.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblbookdetail.Location = New Point(243, 23)
        lblbookdetail.Margin = New Padding(4, 0, 4, 0)
        lblbookdetail.Name = "lblbookdetail"
        lblbookdetail.Size = New Size(185, 38)
        lblbookdetail.TabIndex = 0
        lblbookdetail.Text = "Book Details"
        ' 
        ' lblbn
        ' 
        lblbn.AutoSize = True
        lblbn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lblbn.Location = New Point(50, 85)
        lblbn.Margin = New Padding(4, 0, 4, 0)
        lblbn.Name = "lblbn"
        lblbn.Size = New Size(122, 28)
        lblbn.TabIndex = 1
        lblbn.Text = "Book Name"
        ' 
        ' lblnob
        ' 
        lblnob.AutoSize = True
        lblnob.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lblnob.Location = New Point(38, 144)
        lblnob.Margin = New Padding(4, 0, 4, 0)
        lblnob.Name = "lblnob"
        lblnob.Size = New Size(134, 28)
        lblnob.TabIndex = 2
        lblnob.Text = "No. of Books"
        ' 
        ' lblprice
        ' 
        lblprice.AutoSize = True
        lblprice.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lblprice.Location = New Point(113, 209)
        lblprice.Margin = New Padding(4, 0, 4, 0)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(59, 28)
        lblprice.TabIndex = 3
        lblprice.Text = "Price"
        ' 
        ' lbldiscount
        ' 
        lbldiscount.AutoSize = True
        lbldiscount.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lbldiscount.Location = New Point(76, 268)
        lbldiscount.Margin = New Padding(4, 0, 4, 0)
        lbldiscount.Name = "lbldiscount"
        lbldiscount.Size = New Size(96, 28)
        lbldiscount.TabIndex = 4
        lbldiscount.Text = "Discount"
        ' 
        ' lbltotalpayment
        ' 
        lbltotalpayment.AutoSize = True
        lbltotalpayment.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lbltotalpayment.Location = New Point(24, 331)
        lbltotalpayment.Margin = New Padding(4, 0, 4, 0)
        lbltotalpayment.Name = "lbltotalpayment"
        lbltotalpayment.Size = New Size(148, 28)
        lbltotalpayment.TabIndex = 5
        lbltotalpayment.Text = "Total payment"
        ' 
        ' Btncalculate
        ' 
        Btncalculate.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Btncalculate.Location = New Point(287, 402)
        Btncalculate.Margin = New Padding(4)
        Btncalculate.Name = "Btncalculate"
        Btncalculate.Size = New Size(141, 41)
        Btncalculate.TabIndex = 6
        Btncalculate.Text = "Calculate"
        Btncalculate.UseVisualStyleBackColor = False
        ' 
        ' Textbookname
        ' 
        Textbookname.Location = New Point(213, 85)
        Textbookname.Margin = New Padding(4)
        Textbookname.Name = "Textbookname"
        Textbookname.Size = New Size(316, 34)
        Textbookname.TabIndex = 7
        ' 
        ' Textnob
        ' 
        Textnob.Location = New Point(213, 144)
        Textnob.Margin = New Padding(4)
        Textnob.Name = "Textnob"
        Textnob.Size = New Size(316, 34)
        Textnob.TabIndex = 8
        ' 
        ' Textprice
        ' 
        Textprice.Location = New Point(213, 203)
        Textprice.Margin = New Padding(4)
        Textprice.Name = "Textprice"
        Textprice.Size = New Size(316, 34)
        Textprice.TabIndex = 9
        ' 
        ' Textdiscount
        ' 
        Textdiscount.Location = New Point(213, 262)
        Textdiscount.Margin = New Padding(4)
        Textdiscount.Name = "Textdiscount"
        Textdiscount.Size = New Size(316, 34)
        Textdiscount.TabIndex = 10
        ' 
        ' Texttotalpayment
        ' 
        Texttotalpayment.Location = New Point(213, 331)
        Texttotalpayment.Margin = New Padding(4)
        Texttotalpayment.Name = "Texttotalpayment"
        Texttotalpayment.Size = New Size(316, 34)
        Texttotalpayment.TabIndex = 11
        ' 
        ' Textbill
        ' 
        Textbill.ImeMode = ImeMode.NoControl
        Textbill.Location = New Point(590, 80)
        Textbill.Multiline = True
        Textbill.Name = "Textbill"
        Textbill.ReadOnly = True
        Textbill.Size = New Size(448, 285)
        Textbill.TabIndex = 12
        ' 
        ' Btnprint
        ' 
        Btnprint.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Btnprint.Location = New Point(728, 402)
        Btnprint.Name = "Btnprint"
        Btnprint.Size = New Size(172, 43)
        Btnprint.TabIndex = 13
        Btnprint.Text = "Print"
        Btnprint.UseVisualStyleBackColor = False
        ' 
        ' Lblbillpage
        ' 
        Lblbillpage.AutoSize = True
        Lblbillpage.BackColor = Color.Red
        Lblbillpage.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblbillpage.Location = New Point(728, 23)
        Lblbillpage.Name = "Lblbillpage"
        Lblbillpage.Size = New Size(136, 38)
        Lblbillpage.TabIndex = 14
        Lblbillpage.Text = "Bill page"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1050, 546)
        Controls.Add(Lblbillpage)
        Controls.Add(Btnprint)
        Controls.Add(Textbill)
        Controls.Add(Texttotalpayment)
        Controls.Add(Textdiscount)
        Controls.Add(Textprice)
        Controls.Add(Textnob)
        Controls.Add(Textbookname)
        Controls.Add(Btncalculate)
        Controls.Add(lbltotalpayment)
        Controls.Add(lbldiscount)
        Controls.Add(lblprice)
        Controls.Add(lblnob)
        Controls.Add(lblbn)
        Controls.Add(lblbookdetail)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblbookdetail As Label
    Friend WithEvents lblbn As Label
    Friend WithEvents lblnob As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents lbldiscount As Label
    Friend WithEvents lbltotalpayment As Label
    Friend WithEvents Btncalculate As Button
    Friend WithEvents Textbookname As TextBox
    Friend WithEvents Textnob As TextBox
    Friend WithEvents Textprice As TextBox
    Friend WithEvents Textdiscount As TextBox
    Friend WithEvents Texttotalpayment As TextBox
    Friend WithEvents Textbill As TextBox
    Friend WithEvents Btnprint As Button
    Friend WithEvents Lblbillpage As Label

End Class
