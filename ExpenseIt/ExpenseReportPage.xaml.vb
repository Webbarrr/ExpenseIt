Class ExpenseReportPage
    Inherits Page

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal data As Object)
        Me.New()
        DataContext = data
    End Sub
End Class
