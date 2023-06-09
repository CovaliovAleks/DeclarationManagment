﻿Imports Declarations.Common

Public Class Form1

    Dim declarationsForm As DeclarationsForm
    Dim personsForm As PersonsForm
    Dim personForm As PersonForm
    Dim declarationForm As DeclarationForm

    Dim form As Form

    Dim connStr As String
    Dim strDBFileName As String
    Dim _dbService As DbService
    Dim activForm As ActiveFormEnum = ActiveFormEnum.NotSelected
    Dim isAlreadyClosing As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = "ИС налоговые декларации v0.9"

        strDBFileName = "Db\Database2.accdb"
        'strDBFileName = "C:\Db\Database2.accdb"
        connStr = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        _dbService = New DbService(connStr)
        '_dbService.DropTable()
        '_dbService.CreateAllTables()

        personsForm = New PersonsForm(_dbService)
        declarationsForm = New DeclarationsForm(_dbService)
        personForm = New PersonForm(_dbService, Nothing)
        declarationForm = New DeclarationForm(_dbService, Nothing)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If activForm = ActiveFormEnum.NotSelected Then
            If declarationsForm Is Nothing Then
                declarationsForm = New DeclarationsForm(_dbService)
            End If
            form = declarationsForm
            activForm = ActiveFormEnum.Declarations
        End If

        LoadForm(form)

        '_dbService = New DbService(connStr)
        '_dbService.CreateAllTables()

    End Sub

    Private Sub LoadForm(ByRef setForm As Form)
        setForm.TopLevel = False
        setForm.Dock = DockStyle.Fill
        setForm.FormBorderStyle = FormBorderStyle.None
        setForm.Tag = "mainpanel"

        If Me.pnlDesktop.Controls.Count > 0 Then
            Me.pnlDesktop.Controls.Clear()
        End If

        Me.pnlDesktop.Controls.Add(setForm)
        setForm.Show()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

    End Sub

    Private Sub tlsPersons_Click(sender As Object, e As EventArgs) Handles tlsPersons.Click
        If activForm <> ActiveFormEnum.Persons Then
            activForm = ActiveFormEnum.Persons
            If personsForm Is Nothing Then
                personsForm = New PersonsForm(_dbService)
            End If
            LoadForm(personsForm)
        End If
    End Sub

    Private Sub tlsmDeclarations_Click(sender As Object, e As EventArgs) Handles tlsmDeclarations.Click
        If activForm <> ActiveFormEnum.Declarations Then
            activForm = ActiveFormEnum.Declarations
            If declarationsForm Is Nothing Then
                declarationsForm = New DeclarationsForm(_dbService)
            End If
            LoadForm(declarationsForm)
        End If
    End Sub

    Private Sub tlsCreatePerson_Click(sender As Object, e As EventArgs) Handles tlsCreatePerson.Click
        If activForm <> ActiveFormEnum.AddPerson Then
            activForm = ActiveFormEnum.AddPerson
            If personForm Is Nothing Then
                personForm = New PersonForm(_dbService, Nothing)
            End If
            LoadForm(personForm)
        End If
    End Sub

    Private Sub tlsCreateDeclaration_Click(sender As Object, e As EventArgs) Handles tlsCreateDeclaration.Click
        If declarationForm Is Nothing Then
            declarationForm = New DeclarationForm(_dbService, Nothing)
        End If

        Dim dlgResult As DialogResult = declarationForm.ShowDialog()
        If dlgResult = DialogResult.OK Then
            declarationsForm.ResfreshDataGrid()
        End If
    End Sub

    Private Sub tlsAppExit_Click(sender As Object, e As EventArgs) Handles tlsAppExit.Click
        Dim dlgResult As DialogResult = MessageBox.Show("Желаете закрыть приложение?", "Окончание работы", MessageBoxButtons.YesNo)
        If dlgResult = DialogResult.Yes Then
            isAlreadyClosing = True
            Close()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isAlreadyClosing = False Then
            Dim dlgResult As DialogResult = MessageBox.Show("Желаете закрыть приложение?", "Окончание работы", MessageBoxButtons.YesNo)
            If dlgResult = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If declarationForm Is Nothing Then
            declarationForm = New DeclarationForm(_dbService, Nothing)
        End If

        Dim dlgResult As DialogResult = declarationForm.ShowDialog()
        If dlgResult = DialogResult.OK Then
            declarationsForm.ResfreshDataGrid()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If personForm Is Nothing Then
            personForm = New PersonForm(_dbService, Nothing)
        End If

        Dim dlgResult As DialogResult = personForm.ShowDialog()
        If dlgResult = DialogResult.OK Then
            'declarationsForm.ResfreshDataGrid()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If activForm <> ActiveFormEnum.Declarations Then
            activForm = ActiveFormEnum.Declarations
            If declarationsForm Is Nothing Then
                declarationsForm = New DeclarationsForm(_dbService)
            End If
            LoadForm(declarationsForm)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If activForm <> ActiveFormEnum.Persons Then
            activForm = ActiveFormEnum.Persons
            If personsForm Is Nothing Then
                personsForm = New PersonsForm(_dbService)
            End If
            LoadForm(personsForm)
        End If
    End Sub
End Class
