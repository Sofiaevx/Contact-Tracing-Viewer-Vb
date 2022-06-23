Public Class CTVForm
    Dim fileReader As System.IO.StreamReader
    Private Sub SNBtn_Click(sender As Object, e As EventArgs) Handles SNBtn.Click

        myfilereader("Fullname: ")
        SearchTextbox.Text = ""
    End Sub
    Sub myfilereader(data)
        fileReader = My.Computer.FileSystem.OpenTextFileReader("Information.txt")
        Dim stringReader As String

        While Not fileReader.EndOfStream
            stringReader = fileReader.ReadLine()

            If stringReader.Contains(data & SearchTextbox.Text) Then
                For index = 1 To 17
                    stringReader &= vbCrLf & fileReader.ReadLine()
                Next

                DisplayRichTbox.Text = stringReader

            Else
                DisplayRichTbox.Text = "No Record"
            End If
        End While
        fileReader.Close()
    End Sub
    Private Sub SABtn_Click(sender As Object, e As EventArgs) Handles SABtn.Click
        SearchTextbox.Text = ""
        fileReader = My.Computer.FileSystem.OpenTextFileReader("Information.txt")
        DisplayRichTbox.Text = fileReader.ReadToEnd()
    End Sub

    Private Sub SDBtn_Click(sender As Object, e As EventArgs) Handles SDBtn.Click

        myfilereader("Date: ")
        SearchTextbox.Text = ""
    End Sub
End Class
