Imports Declarations.Common

Public Class DeclarationForm
    Private declaration As Declaration

    Private listPersons As ListPersonsForm
    Dim _dbService As DbService

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
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
        declaration.DateCreatedAt = Date.Parse(mtbDateDeclaration.Text)
        declaration.TaxNumber = Trim(tbTaxNumber.Text)
        declaration.TaxDistrict = Trim(tbTaxDistrict.Text)
        declaration.Comment = Trim(tbComments.Text)
        'Need to get from obj person
        declaration.PersonFio = ""
        declaration.PersonId = 0

        Dim sumAll As Double = 0
        Dim sumTax As Double = 0
        Dim sumPens As Double = 0
        Dim sumExempt As Double = 0
        Dim sumFinal As Double = 0
        If Double.TryParse(tbSumAll.Text, sumAll) = True Then
            declaration.SummaAll = sumAll
        End If
        If Double.TryParse(tbSumTax.Text, sumTax) = True Then
            declaration.SummaTax = sumTax
        End If
        If Double.TryParse(tbSumPens.Text, sumPens) = True Then
            declaration.SummaPens = sumPens
        End If
        If Double.TryParse(tbSumExempt.Text, sumExempt) = True Then
            declaration.SummaExempt = sumExempt
        End If
        If Double.TryParse(tbSumFinal.Text, sumFinal) = True Then
            declaration.SummaFinal = sumFinal
        End If
        declaration.ExemptType = Trim(tbExemptType.Text)



        _dbService.AddNewDeclaration(declaration)


    End Sub

    Private Function ValidateDeclarationBeforeSave() As Boolean
        Dim result As Boolean = False



        Return result
    End Function


End Class