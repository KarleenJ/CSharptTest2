Public Class Q1
    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click


        MessageBox.Show($"Name: {txtFName.Text} {txtLName.Text} /n Phone Number:{txtPhone.Text}")


    End Sub

    Private Sub btnReset_Click(sender As Object, e As RoutedEventArgs) Handles btnReset.Click
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()


    End Sub
End Class
