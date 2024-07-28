Public Class Form1
    Private Sub Btncalculate_Click(sender As Object, e As EventArgs) Handles Btncalculate.Click
        Dim price, dis, total, per, total_pay As Double
        Dim nob As Integer
        nob = Textnob.Text
        price = Textprice.Text
        dis = Textdiscount.Text
        total = nob * price
        per = (total * dis) / 100
        total_pay = total - per
        Texttotalpayment.Text = total_pay

        Textbill.Text &= "Book Name  :" & Textbookname.Text & vbCrLf
        Textbill.Text &= "No. of Books :" & Textnob.Text & vbCrLf
        Textbill.Text &= "Price :" & Textprice.Text & vbCrLf
        Textbill.Text &= "Discount :" & Textdiscount.Text & "%" & vbCrLf
        Textbill.Text &= "Total amount :" & total & vbCrLf
        Textbill.Text &= "============================" & vbCrLf
        Textbill.Text &= "Total pay amount :" & total_pay & vbCrLf & vbCrLf
        Textbill.Text &= "------------ Thanku!!! --------------"
    End Sub
End Class
