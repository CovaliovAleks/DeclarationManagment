Imports Declarations.Common

Public Class PersonsForm
    Dim _dbService As DbService
    Dim _person As Person
    Dim lstPersons As List(Of Person)

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        _person = New Person()

        dgvPerson.AllowDrop = False
        dgvPerson.AllowUserToAddRows = False
    End Sub
    Private Sub PersonsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPersons = _dbService.GetPersons()
        dgvPerson.DataSource = lstPersons
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvPerson_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPerson.MouseClick

    End Sub

    Private Sub dgvPerson_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPerson.MouseDoubleClick
        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String
    End Sub

    Private Sub dgvPerson_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPerson.SelectionChanged

    End Sub

    Private Sub dgvPerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentClick
        '
        'e.RowIndex

        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String

    End Sub

    Private Sub dgvPerson_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentDoubleClick
        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String
    End Sub
End Class