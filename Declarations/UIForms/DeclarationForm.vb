Imports Declarations.Common

Public Class DeclarationForm
    Private declaration As Declaration
    Dim personId As Integer = 0
    Dim personFio As String = ""
    Dim _person As Person = Nothing

    Private listPersons As ListPersonsForm
    Dim _dbService As DbService
    Dim errMsg As String = "Следующие поля должны быть заполнены:" + vbNewLine
    Dim state As Integer = 0


    Public Sub New(ByRef dbService As DbService, ByRef slcDeclaration As Declaration)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        btnAddDeclaration.Text = "Добавить декларацию"
        declaration = slcDeclaration

        If (slcDeclaration IsNot Nothing) Then
            state = 1
            btnAddDeclaration.Text = "Сохранить изменения"
            ShowDeclarationData()
        Else
            state = 0
        End If

    End Sub

    Private Sub DeclarationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowDeclarationData()
        If declaration.Person IsNot Nothing Then
            _person = declaration.Person
            personId = _person.ID
            personFio = _person.FIO
        End If

        tbNrDeclaration.Text = declaration.NrDeclaration
        mtbDateDeclaration.Text = declaration.DateCreatedAt.ToString("dd.MM.yyyy")
        tbTaxNumber.Text = declaration.TaxNumber
        tbTaxDistrict.Text = declaration.TaxDistrict
        tbComments.Text = declaration.Comment
        tbPersonFio.Text = declaration.PersonFio

        tbSumAll.Text = declaration.SummaAll
        tbSumPens.Text = declaration.SummaPens
        tbSumTax.Text = declaration.SummaTax
        tbSumExempt.Text = declaration.SummaExempt
        tbExemptType.Text = declaration.ExemptType
        tbSumFinal.Text = declaration.SummaFinal

        tbCompanyName.Text = declaration.CompanyName
        tbCompanyPhone.Text = declaration.CompanyPhone
        tbCompanyInn.Text = declaration.CompanyInn
        tbCompanyAddress.Text = declaration.CompanyAddress
        tbCompanyChief.Text = declaration.CompanyChief

    End Sub

    Private Sub btnSelectPerson_Click(sender As Object, e As EventArgs) Handles btnSelectPerson.Click
        If (listPersons Is Nothing) Then
            listPersons = New ListPersonsForm(_dbService)
        End If

        Dim dlgresult As DialogResult = listPersons.ShowDialog()

        If dlgresult = DialogResult.OK Then
            _person = listPersons.GetPerson
        ElseIf dlgresult = DialogResult.Cancel Then

        End If

        If _person IsNot Nothing Then
            personId = _person.ID
            personFio = _person.FIO
            tbPersonFio.Text = _person.FIO
        End If

        'listPersons.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAddDeclaration_Click(sender As Object, e As EventArgs) Handles btnAddDeclaration.Click
        Dim result As Boolean = False

        If state = 0 Then
            declaration = New Declaration()
            declaration.ID = 0
        End If
        Dim createdAt As Date = Date.MinValue
        If Date.TryParse(mtbDateDeclaration.Text, createdAt) = True Then

        End If

        declaration.NrDeclaration = Strings.Trim(tbNrDeclaration.Text)
        declaration.DateCreatedAt = createdAt
        declaration.TaxNumber = Trim(tbTaxNumber.Text)
        declaration.TaxDistrict = Trim(tbTaxDistrict.Text)
        declaration.Comment = Trim(tbComments.Text)
        'Need to get from obj person
        declaration.PersonFio = Trim(tbPersonFio.Text)
        declaration.PersonId = declaration.PersonId

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
            If state = 0 Then
                result = _dbService.AddNewDeclaration(declaration)
            Else
                result = _dbService.UpdateDeclaration(declaration)
            End If

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
            errMsg += "Номер Декларации" + vbNewLine
        End If

        If String.IsNullOrEmpty(declaration.TaxNumber) Then
            result = False
            errMsg += "Номер налоговой инспекции" + vbNewLine
        End If

        If String.IsNullOrEmpty(declaration.TaxDistrict) Then
            result = False
            errMsg += "Инспекция, где стоит на учете" + vbNewLine
        End If

        If String.IsNullOrEmpty(declaration.CompanyName) Then
            result = False
            errMsg += "Компания" + vbNewLine
        End If

        If String.IsNullOrEmpty(declaration.CompanyInn) Then
            result = False
            errMsg += "ИНН Компании" + vbNewLine
        End If


        Return result
    End Function

    Private Sub btnClearPerson_Click(sender As Object, e As EventArgs) Handles btnClearPerson.Click
        If _person IsNot Nothing Then
            _person = Nothing
        End If
        declaration.PersonId = 0
        declaration.PersonFio = ""
        tbPersonFio.Text = ""
    End Sub
End Class