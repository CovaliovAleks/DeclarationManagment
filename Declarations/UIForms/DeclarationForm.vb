Imports Declarations.Common

Public Class DeclarationForm
    Private declaration As Declaration

    Private listPersons As ListPersonsForm
    Dim _dbService As DbService
    Dim errMsg As String = "Следующие поля должны быть заполнены:" + vbNewLine

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
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAddDeclaration_Click(sender As Object, e As EventArgs) Handles btnAddDeclaration.Click
        Dim result As Boolean = False

        declaration.ID = 0
        declaration.NrDeclaration = Strings.Trim(tbNrDeclaration.Text)
        declaration.DateCreatedAt = Date.Today 'Date.Parse(mtbDateDeclaration.Text)
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

        declaration.CompanyName = Trim(tbCompanyName.Text)
        declaration.CompanyAddress = Trim(tbCompanyAddress.Text)
        declaration.CompanyInn = Trim(tbCompanyInn.Text)
        declaration.CompanyPhone = Trim(tbCompanyPhone.Text)
        declaration.CompanyChief = Trim(tbCompanyChief.Text)

        Dim valid As Boolean = ValidateDeclarationBeforeSave(declaration)

        If valid = True Then
            result = _dbService.AddNewDeclaration(declaration)
            If (result = True) Then
                Me.DialogResult = DialogResult.OK
            Else
                Me.DialogResult = DialogResult.No
            End If
            Me.Close()
        Else
            MessageBox.Show(errMsg)
        End If
    End Sub

    Private Function ValidateDeclarationBeforeSave(ByRef declaration As Declaration) As Boolean
        Dim result As Boolean = True

        If String.IsNullOrEmpty(declaration.NrDeclaration) Then
            result = False
            errMsg += "Декларации" + vbNewLine
        End If

        If String.IsNullOrEmpty(declaration.TaxDistrict) Then
            result = False
            errMsg += "Номер налоговой инспекции" + vbNewLine
        End If


        Return result
    End Function


End Class