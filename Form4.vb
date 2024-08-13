Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        name = "Shashikant"
        Dim pass As Integer
        pass = 2002
        If name = txtname.Text Then
            If pass = txtpass.Text Then
                MessageBox.Show("Login successfully !!", "SICS")
                User_Details.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Password!!", "SICS")
            End If
        Else
            MessageBox.Show("Wrong User Name!!", "SICS")
        End If
    End Sub
End Class