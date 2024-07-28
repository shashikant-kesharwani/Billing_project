Imports System.Runtime.ConstrainedExecution

Public Class Form2
    Private Sub Btncalculate_Click(sender As Object, e As EventArgs) Handles Btncalculate.Click
        Dim total, hm, em, mm, pm, cm As Integer
        Dim per As Double

        hm = Texthindi.Text
        em = Textenglish.Text
        mm = Textmath.Text
        pm = Textphysics.Text
        cm = Textchemistry.Text
        total = (hm + em + mm + pm + cm)
        per = (total * 100) / 500
        Texttotalmarks.Text = total
        Textpercentage.Text = per
        If per >= 50 Then Textcatagory.Text = "Pass" Else Textcatagory.Text = "Fail"

        Textbill.Text &= " ******  Student Details *****   " & vbCrLf
        Textbill.Text &= " =============================" & vbCrLf
        Textbill.Text &= "Student Name :" & Textname.Text & vbCrLf
        Textbill.Text &= "Roll Number :" & Textrollno.Text & vbCrLf

        Textbill.Text &= " ****** Marks Details *********    " & vbCrLf
        Textbill.Text &= " ==============================   " & vbCrLf
        Textbill.Text &= "Hindi Marks :" & Texthindi.Text & vbCrLf
        Textbill.Text &= "English Marks :" & Textenglish.Text & vbCrLf
        Textbill.Text &= "Math Marks :" & Textmath.Text & vbCrLf
        Textbill.Text &= "Physics Marks :" & Textphysics.Text & vbCrLf
        Textbill.Text &= "Chemistry Marks :" & Textchemistry.Text & vbCrLf
        Textbill.Text &= "Total Marks :" & Texttotalmarks.Text & vbCrLf
        Textbill.Text &= "Percentage :" & Textpercentage.Text & vbCrLf

        Textbill.Text &= " ******* Fail / Pass Detail*****    " & vbCrLf
        Textbill.Text &= " ================================   " & vbCrLf

        If per > 50 Then Textbill.Text &= "     you are pass   Congratulation !!!" Else Textbill.Text &= "You are Fail !!!"


    End Sub


End Class