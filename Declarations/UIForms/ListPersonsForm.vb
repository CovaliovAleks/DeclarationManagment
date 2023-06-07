Imports System.Security.Cryptography
Imports Declarations.Common

Public Class ListPersonsForm
    Private _slcPerson As Person
    Dim _dbService As DbService
    Dim lstPersons As List(Of Person)
    Public ReadOnly Property GetPerson() As Person
        Get
            Return _slcPerson
        End Get
    End Property


    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _slcPerson = Nothing
        _dbService = dbService

        dgvPersons.AllowDrop = False
        dgvPersons.AllowUserToAddRows = False

    End Sub

    Public Property SlcPerson() As Person
        Get
            Return _slcPerson
        End Get
        Set(value As Person)
            _slcPerson = value
        End Set
    End Property

    Private personForm As PersonForm




    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If _slcPerson Is Nothing Then
            MessageBox.Show("Выберите персону.")
        End If
    End Sub

    Private Sub ListPersonsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGrid()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Dim personForm As PersonForm = Nothing

        If personForm Is Nothing Then
            personForm = New PersonForm(_dbService)
        End If

        Dim dlgresult As DialogResult = personForm.ShowDialog()
        personForm.Dispose()

    End Sub

    Private Sub dgvPersons_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPersons.MouseDoubleClick
        _slcPerson = dgvPersons.SelectedRows(0).DataBoundItem
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub RefreshDataGrid()
        lstPersons = _dbService.GetPersons()
        dgvPersons.DataSource = lstPersons
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgvPersons_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPersons.SelectionChanged
        Dim index = dgvPersons.CurrentRow.Index

        Dim str As String = ""
        '_slcPerson = dgvPersons.Rows(index).Data
        '_slcPerson = dgvPersons.SelectedRows(0).DataBoundItem
        'Me.DialogResult = DialogResult.OK
        'Me.Close()
    End Sub

End Class