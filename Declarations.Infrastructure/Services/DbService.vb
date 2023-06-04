Public Class DbService

    Sub New()

    End Sub

    Sub Connect()
        Dim strDBFileName As String = "D:\WorkDocs\FreelancePrj\_WorkProjects\kwork\K.ZAV.1\Db\Database2.accdb"

        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        'Dim strQuery As String = "SELECT Код_физического_лица, Фамилия, Имя, Отчество FROM Физические_лица ORDER BY Фамилия, Имя, Отчество"
        Dim strQuery As String = ""
        Dim intCount As Integer = 0
        Dim intIDRow As Integer = 0
        Dim dtDataTable As New DataTable

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()

            Dim schema = objConnection.GetSchema()

            Dim temp As String = ""


            'Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            'Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)
            'With dtDataTable.Columns
            '    .Add("ID")
            '    .Add("№ пп")
            '    .Add("Фамилия")
            '    .Add("Имя")
            '    .Add("Отчество")
            'End With

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
