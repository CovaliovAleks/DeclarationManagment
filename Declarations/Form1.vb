Public Class Form1

    Dim declarationForm As DeclarationsForm

    Public Sub Main()

    End Sub
    Private Sub pnlForms_Paint(sender As Object, e As PaintEventArgs) Handles pnlDesktop.Paint



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        declarationForm = New DeclarationsForm()
        declarationForm.TopLevel = False
        declarationForm.Dock = DockStyle.Fill
        declarationForm.FormBorderStyle = FormBorderStyle.None
        declarationForm.Tag = "mainpanel"

        Me.pnlDesktop.Controls.Add(declarationForm)
        declarationForm.Show()

    End Sub

End Class
