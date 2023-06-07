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
        Dim obj = dgvDeclarations.SelectedRows(0).DataBoundItem
        _declarationForm = New DeclarationForm(_dbService, obj)
        Dim dlgResult As DialogResult = _declarationForm.ShowDialog()

        '_declarationForm.Dispose()

        ResfreshDataGrid()
    End Sub

    Private Sub dgvDeclarations_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDeclarations.SelectionChanged


    End Sub

    Private Sub btnSetFilter_Click(sender As Object, e As EventArgs) Handles btnSetFilter.Click
        Dim fltr As String = Trim(tbAddDataFiltr.Text)

        If Not String.IsNullOrEmpty(fltr) Then
            Dim queryResults = From dcl In lstDeclarations
                               Where dcl.PersonFio.Contains(fltr) Or
                                     dcl.CompanyInn.Contains(fltr) Or
                                     dcl.NrDeclaration.Contains(fltr) Or
                                     dcl.TaxNumber.Contains(fltr) Or
                                     dcl.TaxDistrict.Contains(fltr)
            dgvDeclarations.DataSource = queryResults.ToList
        Else
            dgvDeclarations.DataSource = lstDeclarations
        End If

    End Sub
End Class