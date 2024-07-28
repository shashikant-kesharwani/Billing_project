<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Lblheading = New Label()
        Lblname = New Label()
        Lblrollnumber = New Label()
        Lblhindimark = New Label()
        Lblenglishmark = New Label()
        Lblmathmark = New Label()
        Lblphysicsmark = New Label()
        Lblchemistrymark = New Label()
        Lbltotalmarks = New Label()
        Lblpercentage = New Label()
        Lblbill = New Label()
        Btncalculate = New Button()
        Btnprint = New Button()
        Textname = New TextBox()
        Textrollno = New TextBox()
        Texthindi = New TextBox()
        Textenglish = New TextBox()
        Textmath = New TextBox()
        Textphysics = New TextBox()
        Textchemistry = New TextBox()
        Texttotalmarks = New TextBox()
        Textpercentage = New TextBox()
        Textbill = New TextBox()
        Lblcatagory = New Label()
        Textcatagory = New TextBox()
        SuspendLayout()
        ' 
        ' Lblheading
        ' 
        Lblheading.AutoSize = True
        Lblheading.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Lblheading.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblheading.Location = New Point(25, 12)
        Lblheading.Name = "Lblheading"
        Lblheading.Size = New Size(421, 46)
        Lblheading.TabIndex = 0
        Lblheading.Text = "Student marksheet detail"
        ' 
        ' Lblname
        ' 
        Lblname.AutoSize = True
        Lblname.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblname.Location = New Point(25, 94)
        Lblname.Name = "Lblname"
        Lblname.Size = New Size(126, 23)
        Lblname.TabIndex = 1
        Lblname.Text = "Student Name"
        ' 
        ' Lblrollnumber
        ' 
        Lblrollnumber.AutoSize = True
        Lblrollnumber.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblrollnumber.Location = New Point(39, 144)
        Lblrollnumber.Name = "Lblrollnumber"
        Lblrollnumber.Size = New Size(112, 23)
        Lblrollnumber.TabIndex = 2
        Lblrollnumber.Text = "Roll Number"
        ' 
        ' Lblhindimark
        ' 
        Lblhindimark.AutoSize = True
        Lblhindimark.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblhindimark.Location = New Point(43, 198)
        Lblhindimark.Name = "Lblhindimark"
        Lblhindimark.Size = New Size(108, 23)
        Lblhindimark.TabIndex = 3
        Lblhindimark.Text = "Hindi marks"
        ' 
        ' Lblenglishmark
        ' 
        Lblenglishmark.AutoSize = True
        Lblenglishmark.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblenglishmark.Location = New Point(30, 250)
        Lblenglishmark.Name = "Lblenglishmark"
        Lblenglishmark.Size = New Size(121, 23)
        Lblenglishmark.TabIndex = 4
        Lblenglishmark.Text = "English marks"
        ' 
        ' Lblmathmark
        ' 
        Lblmathmark.AutoSize = True
        Lblmathmark.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblmathmark.Location = New Point(45, 307)
        Lblmathmark.Name = "Lblmathmark"
        Lblmathmark.Size = New Size(106, 23)
        Lblmathmark.TabIndex = 5
        Lblmathmark.Text = "Math marks"
        ' 
        ' Lblphysicsmark
        ' 
        Lblphysicsmark.AutoSize = True
        Lblphysicsmark.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblphysicsmark.Location = New Point(31, 359)
        Lblphysicsmark.Name = "Lblphysicsmark"
        Lblphysicsmark.Size = New Size(120, 23)
        Lblphysicsmark.TabIndex = 6
        Lblphysicsmark.Text = "Physics marks"
        ' 
        ' Lblchemistrymark
        ' 
        Lblchemistrymark.AutoSize = True
        Lblchemistrymark.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblchemistrymark.Location = New Point(5, 411)
        Lblchemistrymark.Name = "Lblchemistrymark"
        Lblchemistrymark.Size = New Size(146, 23)
        Lblchemistrymark.TabIndex = 7
        Lblchemistrymark.Text = "Chemistry marks"
        ' 
        ' Lbltotalmarks
        ' 
        Lbltotalmarks.AutoSize = True
        Lbltotalmarks.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lbltotalmarks.Location = New Point(48, 475)
        Lbltotalmarks.Name = "Lbltotalmarks"
        Lbltotalmarks.Size = New Size(103, 23)
        Lbltotalmarks.TabIndex = 8
        Lbltotalmarks.Text = "Total marks"
        ' 
        ' Lblpercentage
        ' 
        Lblpercentage.AutoSize = True
        Lblpercentage.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblpercentage.Location = New Point(53, 531)
        Lblpercentage.Name = "Lblpercentage"
        Lblpercentage.Size = New Size(98, 23)
        Lblpercentage.TabIndex = 9
        Lblpercentage.Text = "Percentage"
        ' 
        ' Lblbill
        ' 
        Lblbill.AutoSize = True
        Lblbill.BackColor = Color.Yellow
        Lblbill.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lblbill.Location = New Point(610, 12)
        Lblbill.Name = "Lblbill"
        Lblbill.Size = New Size(275, 46)
        Lblbill.TabIndex = 10
        Lblbill.Text = "Marksheet Print"
        ' 
        ' Btncalculate
        ' 
        Btncalculate.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Btncalculate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btncalculate.Location = New Point(210, 662)
        Btncalculate.Name = "Btncalculate"
        Btncalculate.Size = New Size(191, 63)
        Btncalculate.TabIndex = 11
        Btncalculate.Text = "Calculate"
        Btncalculate.UseVisualStyleBackColor = False
        ' 
        ' Btnprint
        ' 
        Btnprint.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Btnprint.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btnprint.Location = New Point(627, 655)
        Btnprint.Name = "Btnprint"
        Btnprint.Size = New Size(206, 70)
        Btnprint.TabIndex = 12
        Btnprint.Text = "Print"
        Btnprint.UseVisualStyleBackColor = False
        ' 
        ' Textname
        ' 
        Textname.Location = New Point(177, 94)
        Textname.Name = "Textname"
        Textname.Size = New Size(269, 30)
        Textname.TabIndex = 13
        ' 
        ' Textrollno
        ' 
        Textrollno.Location = New Point(177, 141)
        Textrollno.Name = "Textrollno"
        Textrollno.Size = New Size(269, 30)
        Textrollno.TabIndex = 14
        ' 
        ' Texthindi
        ' 
        Texthindi.Location = New Point(177, 191)
        Texthindi.Name = "Texthindi"
        Texthindi.Size = New Size(269, 30)
        Texthindi.TabIndex = 15
        ' 
        ' Textenglish
        ' 
        Textenglish.Location = New Point(177, 243)
        Textenglish.Name = "Textenglish"
        Textenglish.Size = New Size(269, 30)
        Textenglish.TabIndex = 16
        ' 
        ' Textmath
        ' 
        Textmath.Location = New Point(177, 300)
        Textmath.Name = "Textmath"
        Textmath.Size = New Size(269, 30)
        Textmath.TabIndex = 17
        ' 
        ' Textphysics
        ' 
        Textphysics.Location = New Point(177, 352)
        Textphysics.Name = "Textphysics"
        Textphysics.Size = New Size(269, 30)
        Textphysics.TabIndex = 18
        ' 
        ' Textchemistry
        ' 
        Textchemistry.Location = New Point(177, 404)
        Textchemistry.Name = "Textchemistry"
        Textchemistry.Size = New Size(269, 30)
        Textchemistry.TabIndex = 19
        ' 
        ' Texttotalmarks
        ' 
        Texttotalmarks.Location = New Point(177, 468)
        Texttotalmarks.Name = "Texttotalmarks"
        Texttotalmarks.Size = New Size(269, 30)
        Texttotalmarks.TabIndex = 20
        ' 
        ' Textpercentage
        ' 
        Textpercentage.Location = New Point(177, 524)
        Textpercentage.Name = "Textpercentage"
        Textpercentage.Size = New Size(269, 30)
        Textpercentage.TabIndex = 21
        ' 
        ' Textbill
        ' 
        Textbill.BackColor = Color.White
        Textbill.Location = New Point(542, 91)
        Textbill.Multiline = True
        Textbill.Name = "Textbill"
        Textbill.Size = New Size(422, 558)
        Textbill.TabIndex = 22
        ' 
        ' Lblcatagory
        ' 
        Lblcatagory.AutoSize = True
        Lblcatagory.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Lblcatagory.Location = New Point(67, 590)
        Lblcatagory.Name = "Lblcatagory"
        Lblcatagory.Size = New Size(84, 23)
        Lblcatagory.TabIndex = 23
        Lblcatagory.Text = "Catagory"
        ' 
        ' Textcatagory
        ' 
        Textcatagory.Location = New Point(177, 583)
        Textcatagory.Name = "Textcatagory"
        Textcatagory.Size = New Size(269, 30)
        Textcatagory.TabIndex = 24
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1081, 807)
        Controls.Add(Textcatagory)
        Controls.Add(Lblcatagory)
        Controls.Add(Textbill)
        Controls.Add(Textpercentage)
        Controls.Add(Texttotalmarks)
        Controls.Add(Textchemistry)
        Controls.Add(Textphysics)
        Controls.Add(Textmath)
        Controls.Add(Textenglish)
        Controls.Add(Texthindi)
        Controls.Add(Textrollno)
        Controls.Add(Textname)
        Controls.Add(Btnprint)
        Controls.Add(Btncalculate)
        Controls.Add(Lblbill)
        Controls.Add(Lblpercentage)
        Controls.Add(Lbltotalmarks)
        Controls.Add(Lblchemistrymark)
        Controls.Add(Lblphysicsmark)
        Controls.Add(Lblmathmark)
        Controls.Add(Lblenglishmark)
        Controls.Add(Lblhindimark)
        Controls.Add(Lblrollnumber)
        Controls.Add(Lblname)
        Controls.Add(Lblheading)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lblheading As Label
    Friend WithEvents Lblname As Label
    Friend WithEvents Lblrollnumber As Label
    Friend WithEvents Lblhindimark As Label
    Friend WithEvents Lblenglishmark As Label
    Friend WithEvents Lblmathmark As Label
    Friend WithEvents Lblphysicsmark As Label
    Friend WithEvents Lblchemistrymark As Label
    Friend WithEvents Lbltotalmarks As Label
    Friend WithEvents Lblpercentage As Label
    Friend WithEvents Lblbill As Label
    Friend WithEvents Btncalculate As Button
    Friend WithEvents Btnprint As Button
    Friend WithEvents Textname As TextBox
    Friend WithEvents Textrollno As TextBox
    Friend WithEvents Texthindi As TextBox
    Friend WithEvents Textenglish As TextBox
    Friend WithEvents Textmath As TextBox
    Friend WithEvents Textphysics As TextBox
    Friend WithEvents Textchemistry As TextBox
    Friend WithEvents Texttotalmarks As TextBox
    Friend WithEvents Textpercentage As TextBox
    Friend WithEvents Textbill As TextBox
    Friend WithEvents Lblcatagory As Label
    Friend WithEvents Textcatagory As TextBox
End Class
