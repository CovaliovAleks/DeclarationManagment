Imports Declarations.Common

Public Class PersonsForm
    Dim _dbService As DbService
    Dim _person As Person = Nothing
    Dim lstPersons As List(Of Person)
    Dim _personForm As PersonForm

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        '_person = New Person()

        dgvPerson.AllowDrop = False
        dgvPerson.AllowUserToAddRows = False
        dgvPerson.AutoGenerateColumns = False
    End Sub
    Private Sub PersonsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResfreshDataGrid()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub dgvPerson_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPerson.MouseClick

    End Sub

    Private Sub dgvPerson_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPerson.MouseDoubleClick
        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String
        Dim obj = dgvPerson.SelectedRows(0).DataBoundItem

        _personForm = New PersonForm(_dbService, obj)
        Dim dlgResult As DialogResult = _personForm.ShowDialog()

        ResfreshDataGrid()
    End Sub
    Public Sub ResfreshDataGrid()
        lstPersons = _dbService.GetPersons()
        dgvPerson.DataSource = lstPersons
    End Sub
    Private Sub dgvPerson_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPerson.SelectionChanged
        Dim currentRow = dgvPerson.CurrentRow
        Dim indx = currentRow.Index
        Dim obj = dgvPerson.Rows(indx).DataBoundItem
        Dim prs As Person

        prs = DirectCast(obj, Person)

        If prs IsNot Nothing Then
            tbINN.Text = prs.INN
            tbPhone.Text = prs.Phone
            tbDocument.Text = prs.TypeDoc
            tbAddress.Text = prs.Region + ", " + prs.City + ", " + prs.Street
        End If

    End Sub

    Private Sub dgvPerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentClick

        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String

    End Sub

    Private Sub dgvPerson_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentDoubleClick
        Dim slcRow = dgvPerson.SelectedRows(0)
        Dim ss As String
    End Sub

    Private Sub btnFiltrRun_Click(sender As Object, e As EventArgs) Handles btnFiltrRun.Click
        Dim fltr As String = Trim(tbFilter.Text)

        If Not String.IsNullOrEmpty(fltr) Then
            Dim queryResults = From prs In lstPersons
                               Where prs.FirstName.Contains(fltr)
            dgvPerson.DataSource = queryResults.ToList
        Else
            dgvPerson.DataSource = lstPersons
        End If



    End Sub
End Class