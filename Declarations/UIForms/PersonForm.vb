Imports Declarations.Common

Public Class PersonForm
    Dim _dbService As DbService
    Dim _person As Person
    Dim errMsg As String = "Следующие поля должны быть заполнены:" + vbNewLine
    Dim state As Integer = 0

    Public Sub New(ByRef dbService As DbService, ByRef slcPerson As Person)
        ' This call is required by the designer.
        InitializeComponent()
        btnAddPerson.Text = "Добавить"

        _dbService = dbService
        _person = slcPerson
        If (slcPerson IsNot Nothing) Then
            state = 1
            btnAddPerson.Text = "Сохранить изменения"
            ShowPersonData()
        Else
            state = 0
        End If
    End Sub

    Private Sub btnAddPerson_Click(sender As Object, e As EventArgs) Handles btnAddPerson.Click
        Dim result As Boolean = False

        If state = 0 Then
            _person = New Person()
            _person.ID = 0
        End If

        _person.INN = Trim(tbInn.Text)
        _person.FirstName = Trim(tbName.Text)
        _person.SurName = Trim(tbSurname.Text)
        _person.Patronymic = Trim(tbPatronimyc.Text)
        _person.Phone = Trim(tbPhone.Text)
        If Not String.IsNullOrEmpty(mtbBornDate.Text) Then
            _person.BornDate = Date.Parse(mtbBornDate.Text)
        End If

        _person.Region = Trim(tbRegion.Text)
        _person.City = Trim(tbCity.Text)
        _person.Street = Trim(tbStreet.Text)

        _person.TypeDoc = Trim(tbTypeDoc.Text)
        _person.SeriaNumber = Trim(tbSeriaNum.Text)
        _person.IssuedBy = Trim(tbIssued.Text)
        _person.SeriaNumber = Trim(tbSeriaNum.Text)
        If Not String.IsNullOrEmpty(mtbDocIssued.Text) Then
            _person.IssueDate = Date.Parse(mtbDocIssued.Text)
        End If

        Dim valid As Boolean = ValidateFields()
        If valid = True Then
            If state = 0 Then
                result = _dbService.AddNewPerson(_person)
            Else
                result = _dbService.UpdatePerson(_person)
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

    Sub ShowPersonData()
        tbInn.Text = _person.INN
        tbName.Text = _person.FirstName
        tbSurname.Text = _person.SurName
        tbPatronimyc.Text = _person.Patronymic
        mtbBornDate.Text = _person.BornDate.ToString("dd.MM.yyyy")
        tbPhone.Text = _person.Phone
        If _person.Photo IsNot Nothing Then

        End If

        tbRegion.Text = _person.Region
        tbCity.Text = _person.City
        tbStreet.Text = _person.Street

        tbTypeDoc.Text = _person.TypeDoc
        mtbDocIssued.Text = _person.IssueDate.ToString("dd.MM.yyyy")
        tbIssued.Text = _person.IssuedBy
        tbSeriaNum.Text = _person.SeriaNumber

    End Sub

    Function ValidateFields() As Boolean
        Dim result As Boolean = True


        Return result
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class