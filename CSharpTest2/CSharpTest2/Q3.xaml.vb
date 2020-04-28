Public Class Window1
    Private Sub Chkbox_Checked(sender As Object, e As RoutedEventArgs) Handles chkbox.Checked
        Tab2.Visibility = Visibility.Visible
    End Sub

    Private Sub Chkbox_unChecked(sender As Object, e As RoutedEventArgs) Handles chkbox.Unchecked
        Tab2.Visibility = Visibility.Hidden
    End Sub
End Class
