Public Class User_Details
    Public name As String
    Public number As Long
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click

        name = txtName.Text
        number = Txtnumber.Text
        If name = Trim(name) Then
            If Txtnumber.Text.Length = 10 Then
                If cmbnumber.Text <> "" Then
                    MessageBox.Show("Succeeful Submit", "SICS")
                    Form3.Show()
                    Dim obj As New Form3
                    ' obj.cName = txtName.Text
                    ' obj.Cnumber = Txtnumber.Text

                    Me.Hide()
                    txtName.Clear()
                    Txtnumber.Clear()
                    cmbnumber.Text = ""
                Else
                    MessageBox.Show("Plz Select The Country Code!!", "SICS")
                End If
            Else
                MessageBox.Show("Something Went wrong !!" & vbCrLf & "Plz check the number again!!", "SICS")
            End If
        Else
            MessageBox.Show("Something Went wrong !!" & vbCrLf & "Plz Enter Name following Trim Rules!!", "SICS")
        End If
    End Sub
End Class