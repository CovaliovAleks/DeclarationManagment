Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

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

    Public Sub DropTable()
        Dim result As Boolean = False
        Dim strCreate As String = "DROP TABLE testone;"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = strCreate
                Try
                    cmd.ExecuteNonQuery()
                    Console.WriteLine("Table created.")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub ReadingTable()
        Dim result As Boolean = False
        Dim strCreate As String = "SELECT * FROM testone;"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = strCreate
                Dim Reader = cmd.ExecuteReader()

                Dim numCols = Reader.FieldCount
                Dim hasRows = Reader.HasRows

                While Reader.Read() = True
                    Dim obj1 = Reader.GetValue(0)
                    Dim obj2 = Reader.GetValue(1)
                    Dim obj3 = Reader.GetValue(2)
                    Dim obj4 = Reader.GetValue(3)
                    Dim sss As String = ""
                End While




            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

    End Sub



    Public Sub AddRowInTable()
        Dim result As Boolean = False
        Dim strCreate As String = "INSERT INTO testone(FirstName,LastName) VALUES('frst name','sec name');"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = strCreate
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

    End Sub

    Function CreateTable(ByRef query As String) As Boolean
        Dim result As Boolean = False
        'Dim strCreate As String = "CREATE TABLE testone(ID COUNTER, FirstName CHAR, LastName Varchar(100),dt DATETIME, CONSTRAINT [PrimaryKey] PRIMARY KEY ([ID]));"
        Dim strCreate As String = query

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = strCreate
                Try
                    cmd.ExecuteNonQuery()
                    Console.WriteLine("Table created.")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return result

    End Function

    Public Sub CreateAllTables()
        Dim qr As String = "CREATE TABLE Person(ID COUNTER, FirstName Varchar(100), LastName Varchar(100), Patronymic Varchar(100),born DATETIME, 
				Phone Varchar(100), TypeDocument Varchar(50), SeriaNumber Varchar(50), DocIssueDate DATETIME,
				WasIssued Varchar(100), Region Varchar(200), City Varchar(100), Street Varchar(200),
				CONSTRAINT [PrimaryKey] PRIMARY KEY ([ID]));"

        'Create table Person
        CreateTable(qr)


    End Sub

    Function CheckDbTables() As Boolean
        Dim result As Boolean = False

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()


            Dim dtSchema = dbConn.GetSchema()

            Dim rows = dtSchema.Rows



            For Each row In dtSchema.Rows
                Dim strDetail As String


                Dim dtRow As DataRow = row
                Dim tblName As String = dtRow.Table.TableName
                Dim items = dtRow.ItemArray
                Dim item = items(0)

                'Dim nameItem = items[0]
                Dim temp As String = ""

                'strDetail = row[]
                'Console.WriteLine("Processing Detail {0}", strDetail)
            Next row




        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return result
    End Function

    Function AddNewPerson(ByRef person As Person) As Person



        Return person
    End Function



End Class
