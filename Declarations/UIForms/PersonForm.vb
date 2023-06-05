Imports Declarations.Common

Public Class PersonForm
    Dim _dbService As DbService
    Dim _person As Person

    Public Sub New(ByRef dbService As DbService)
        ' This call is required by the designer.
        InitializeComponent()

        _dbService = dbService
        _person = New Person()

    End Sub

    Private Sub btnAddPerson_Click(sender As Object, e As EventArgs) Handles btnAddPerson.Click

        _person.ID = 0
        _person.INN = Trim(tbInn.Text)
        _person.FirstName = Trim(tbName.Text)
        _person.SurName = Trim(tbSurname.Text)
        _person.Patronymic = Trim(tbPatronimyc.Text)
        _person.Phone = Trim(tbPhone.Text)
        If Not String.IsNullOrEmpty(mtbBornDate.Text) Then
            _person.BornDate = Date.Parse(mtbBornDate.Text)
        End If
        If pbPhoto.Image IsNot Nothing Then
            _person.Photo = pbPhoto.Image
        End If

        _person.Region = Trim(tbRegion.Text)
        _person.City = Trim(tbCity.Text)
        _person.Street = Trim(tbStreet.Text)

        _person.TypeDoc = Trim(tbTypeDoc.Text)
        _person.SeriaNumber = Trim(tbSeriaNum.Text)
        _person.IssuedBy = Trim(tbIssued.Text)

        _dbService.AddNewPerson(_person)

    End Sub

    Sub ValidateFields()



    End Sub

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbPhoto.Image = Image.FromFile(dialog.FileName)
        End If
    End Sub
End Class