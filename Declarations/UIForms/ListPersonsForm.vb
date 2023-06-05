Imports System.Security.Cryptography
Imports Declarations.Common

Public Class ListPersonsForm
    Private _slcPerson As Person

    Public Property SlcPerson() As Person
        Get
            Return _slcPerson
        End Get
        Set(value As Person)
            _slcPerson = value
        End Set
    End Property

    Private personForm As PersonForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        _slcPerson = Nothing

    End Sub



    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If _slcPerson Is Nothing Then
            MessageBox.Show("Выберите персону.")
        End If
    End Sub

    Private Sub ListPersonsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If personForm Is Nothing Then
            personForm = New PersonForm()
        End If
        Dim dlgresult As DialogResult = personForm.ShowDialog()



    End Sub

    Private Sub dgvPersons_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPersons.MouseDoubleClick
        If _slcPerson Is Nothing Then
            'Me.DialogResult = DialogResult.No
        Else
            'Me.DialogResult = DialogResult.Yes
        End If

    End Sub
End Class