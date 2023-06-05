Public Class Form1

    Dim declarationsForm As DeclarationsForm
    Dim personsForm As PersonsForm
    Dim personForm As PersonForm
    Dim declarationForm As DeclarationForm

    Dim form As Form

    Dim activForm As ActiveFormEnum = ActiveFormEnum.NotSelected

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        personsForm = New PersonsForm()
        declarationsForm = New DeclarationsForm()
        personForm = New PersonForm()
        declarationForm = New DeclarationForm()

    End Sub
    Private Sub pnlForms_Paint(sender As Object, e As PaintEventArgs) Handles pnlDesktop.Paint



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If activForm = ActiveFormEnum.NotSelected Then
            If declarationsForm Is Nothing Then
                declarationsForm = New DeclarationsForm()
            End If
            form = declarationsForm
            activForm = ActiveFormEnum.Declarations
        End If

        LoadForm(form)

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
                personsForm = New PersonsForm()
            End If
            LoadForm(personsForm)
        End If
    End Sub

    Private Sub tlsmDeclarations_Click(sender As Object, e As EventArgs) Handles tlsmDeclarations.Click
        If activForm <> ActiveFormEnum.Declarations Then
            activForm = ActiveFormEnum.Declarations
            If declarationsForm Is Nothing Then
                declarationsForm = New DeclarationsForm()
            End If
            LoadForm(declarationsForm)
        End If
    End Sub

    Private Sub tlsCreatePerson_Click(sender As Object, e As EventArgs) Handles tlsCreatePerson.Click
        If activForm <> ActiveFormEnum.AddPerson Then
            activForm = ActiveFormEnum.AddPerson
            If personForm Is Nothing Then
                personForm = New PersonForm()
            End If
            LoadForm(personForm)
        End If
    End Sub

    Private Sub tlsCreateDeclaration_Click(sender As Object, e As EventArgs) Handles tlsCreateDeclaration.Click
        If activForm <> ActiveFormEnum.AddDeclaration Then
            activForm = ActiveFormEnum.AddDeclaration
            If declarationForm Is Nothing Then
                declarationForm = New DeclarationForm()
            End If
            LoadForm(declarationForm)
        End If
    End Sub

End Class
