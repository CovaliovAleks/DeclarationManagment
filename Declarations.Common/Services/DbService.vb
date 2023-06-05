Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Text

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
        Dim strCreate As String = "DROP TABLE Person;"

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
        Dim qr As String = "CREATE TABLE Person(ID COUNTER, INN Varchar(13), FirstName Varchar(50), LastName Varchar(50), Patronymic Varchar(50),born DATETIME, 
				Photo IMAGE, Phone Varchar(100), 
				Region Varchar(200), City Varchar(100), Street Varchar(200),
				TypeDocument Varchar(50), SeriaNumber Varchar(50), IssuedBy Varchar(100), DocIssueDate DATETIME,
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
        Dim query As String

        'Dim sb = New StringBuilder("INSERT INTO person(INN,FirstName,LastName, Patronymic")
        'If person.BornDate IsNot Nothing Then
        'End If
        '    query = "INSERT INTO person(INN,FirstName,LastName, Patronymic,born, Photo, Phone, 
        'Region, City, Street, TypeDocument, SeriaNumber, IssuedBy, DocIssueDate)
        '            VALUES(@inn, @first, @last, patronymic, @born,@photo, @phone);"
        '   query = "INSERT INTO person(INN,FirstName,LastName, Patronymic,Phone, Region, City, Street,  
        'TypeDocument, SeriaNumber, IssuedBy, born, Photo,DocIssueDate)
        '           VALUES(@inn, @first, @last, patronymic, @born,@photo, @phone);"


        query = "INSERT INTO person(INN,FirstName,LastName, Patronymic,Phone, Region, City, Street,  
				 TypeDocument, SeriaNumber, IssuedBy)
                VALUES(@inn, @first, @last, @patronymic, @phone, @region, @city, @street, @typDoc,
                        @ser, @issby);"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = query
                Try
                    cmd.Parameters.AddWithValue("@inn", person.INN)
                    cmd.Parameters.AddWithValue("@first", person.FirstName)
                    cmd.Parameters.AddWithValue("@last", person.SurName)
                    cmd.Parameters.AddWithValue("@patronymic", person.Patronymic)
                    cmd.Parameters.AddWithValue("@phone", person.Phone)
                    cmd.Parameters.AddWithValue("@region", person.Region)
                    cmd.Parameters.AddWithValue("@city", person.City)
                    cmd.Parameters.AddWithValue("@street", person.Street)
                    cmd.Parameters.AddWithValue("@typDoc", person.TypeDoc)
                    cmd.Parameters.AddWithValue("@ser", person.SeriaNumber)
                    cmd.Parameters.AddWithValue("@issby", person.IssuedBy)

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



        Return person
    End Function



End Class
