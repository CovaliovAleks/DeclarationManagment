Imports Declarations.Common

Public Class DeclarationForm
    Private declaration As Declaration

    Private listPersons As ListPersonsForm


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        declaration = New Declaration()

    End Sub

    Private Sub DeclarationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbDateDeclaration.Text = DateTime.Today.ToString("dd.MM.yyyy")
    End Sub
    Private Sub btnSelectPerson_Click(sender As Object, e As EventArgs) Handles btnSelectPerson.Click
        If (listPersons Is Nothing) Then
            listPersons = New ListPersonsForm()
        End If

        Dim dlgresult As DialogResult = listPersons.ShowDialog()

        If dlgresult = DialogResult.Yes Then


        ElseIf dlgresult = DialogResult.Cancel Then


        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnAddDeclaration_Click(sender As Object, e As EventArgs) Handles btnAddDeclaration.Click

        declaration.ID = 0
        declaration.NrDeclaration = Strings.Trim(tbNrDeclaration.Text)
        'declaration.DateCreatedAt = 


    End Sub

    Private Function ValidateDeclarationBeforeSave() As Boolean
        Dim result As Boolean = False



        Return result
    End Function


End Class