Imports Declarations.Common

Public Class DeclarationsForm
    Private declaration As Declaration
    Dim _dbService As DbService

    Dim lstDeclarations As List(Of Declaration)

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        dgvDeclarations.AutoGenerateColumns = False

    End Sub

    Private Sub DeclarationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstDeclarations = _dbService.GetDeclarations()
        dgvDeclarations.DataSource = lstDeclarations

    End Sub

    Public Sub ResfreshDataGrid()
        lstDeclarations = _dbService.GetDeclarations()
        dgvDeclarations.DataSource = lstDeclarations
    End Sub

End Class