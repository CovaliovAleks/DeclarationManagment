Imports Declarations.Common

Public Class DeclarationsForm
    Private declaration As Declaration
    Dim _dbService As DbService
    Dim _declarationForm As DeclarationForm

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

    Private Sub dgvDeclarations_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDeclarations.MouseDoubleClick
        Dim crRow = dgvDeclarations.CurrentRow
        Dim rwIndex = dgvDeclarations.CurrentRow.Index
        Dim row = dgvDeclarations.Rows(rwIndex)
        Dim obj = dgvDeclarations.SelectedRows(0).DataBoundItem

        _declarationForm = New DeclarationForm(_dbService, obj)
        Dim dlgResult As DialogResult = _declarationForm.ShowDialog()

        _declarationForm.Dispose()

        ResfreshDataGrid()


    End Sub

    Private Sub dgvDeclarations_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDeclarations.SelectionChanged
        'Dim rowIndex As Integer = 
        'dgvDeclarations.

        'Dim rows = dgvDeclarations.SelectedRows
        'Dim dgvRow = rows.Item(0)




    End Sub
End Class