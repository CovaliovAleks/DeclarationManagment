Public Class DbService

    Dim dbConnString As String
    Dim dbConn As OleDb.OleDbConnection

    Public Sub New(ByVal connStr As String)
        dbConnString = connStr

    End Sub

    Function OpenConnection() As Boolean
        Dim result As Boolean = False

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

        Catch ex As Exception

        End Try

        Return result
    End Function

    Function CheckDbTables() As Boolean
        Dim result As Boolean = False

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Dim dtSchema = dbConn.GetSchema()

            Dim rows = dtSchema.Rows



            For Each row In dtSchema.Rows
                Dim strDetail As String

                'Dim dtRow As DataRow = row

                'strDetail = row[]
                'Console.WriteLine("Processing Detail {0}", strDetail)
            Next row


            dbConn.Close()

        Catch ex As Exception

        End Try

        Return result
    End Function

    Function AddNewPerson(ByRef person As Person) As Person



        Return person
    End Function



End Class
