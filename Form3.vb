Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    'Public Property cName As String
    ' Public Property Cnumber As Long

    Private Sub Btnorder_Click(sender As Object, e As EventArgs) Handles Btnorder.Click
        Dim a, b, sam, allu, bed, chai, total As Integer
        a = 10
        b = 15
        sam = Textsamosha.Text
        allu = Textallu.Text
        bed = Textbed.Text
        chai = Textchai.Text
        total = 0
        If Checksamosha.Checked = True Then total = sam * a
        If CheckAllutikiya.Checked = True Then total = total + (allu * a)
        If Checkbedpokada.Checked = True Then total = total + (bed * a)
        If Checkchai.Checked = True Then total = total + (chai * b)
        Textbill.Text &= " ---------Bill---------" & vbCrLf & vbCrLf
        'Textbill.Text &= "Customer Name:" & cName & vbCrLf
        'Textbill.Text &= "Customer Number:" & Cnumber & vbCrLf
        Textbill.Text &= " Items           Qty  Amount " & vbCrLf
        If Checksamosha.Checked = True Then Textbill.Text &= " Samosha       " & sam & "     " & (sam * a) & vbCrLf
        If CheckAllutikiya.Checked = True Then Textbill.Text &= " Allu Tikiya     " & allu & "    " & (allu * a) & vbCrLf
        If Checkbedpokada.Checked = True Then Textbill.Text &= " Bed Pakoda   " & bed & "    " & (bed * a) & vbCrLf
        If Checkchai.Checked = True Then Textbill.Text &= " Chai               " & chai & "    " & (chai * b) & vbCrLf & vbCrLf
        Textbill.Text &= "================" & vbCrLf
        Textbill.Text &= " Total Amount :" & total & vbCrLf
        Textbill.Text &= "-------Thank you !!!------"


    End Sub

    Private Sub btnneworder_Click(sender As Object, e As EventArgs) Handles btnneworder.Click
        Textsamosha.Clear()
        Textallu.Clear()
        Textbed.Clear()
        Textchai.Clear()
        Textbill.Clear()
        Me.Hide()
        User_Details.Show()

    End Sub

End Class