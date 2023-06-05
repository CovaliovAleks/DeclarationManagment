Imports Declarations.Common

Public Class PersonForm
    Dim _dbService As DbService
    Dim _person As Person

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        _person = New Person()

    End Sub

    Private Sub btnAddPerson_Click(sender As Object, e As EventArgs) Handles btnAddPerson.Click



    End Sub
End Class