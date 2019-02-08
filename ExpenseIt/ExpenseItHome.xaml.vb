Class ExpenseItHome
    ' view expense report
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        NavigationService.Navigate(New ExpenseReportPage(peopleListBox.SelectedItem))
    End Sub
End Class
