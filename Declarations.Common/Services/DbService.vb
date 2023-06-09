﻿Imports System.Data.OleDb
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

    Public Function GetPersonTable() As DataTable
        Dim prTable As DataTable = New DataTable("Persons")
        Dim query As String

        query = "SELECT * FROM person;"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = query
                Dim reader = cmd.ExecuteReader()

                Dim numCols = Reader.FieldCount
                Dim hasRows = Reader.HasRows

                prTable.Load(reader)
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return prTable
    End Function

    Function GetDeclarations() As IEnumerable(Of Declaration)
        Dim lstDeclarations As New List(Of Declaration)
        Dim query As String

        'query = "SELECT * FROM Declaration"
        query = "SELECT Declaration.*, person.* FROM Declaration 
                    LEFT JOIN person ON person.ID = Declaration.PersonId;"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = query
                Dim reader = cmd.ExecuteReader()

                Dim numCols = reader.FieldCount
                Dim hasRows = reader.HasRows
                While reader.Read() = True
                    Dim item As New Declaration
                    item.ID = reader.GetValue(0)
                    item.NrDeclaration = reader.GetValue(1)
                    item.DateCreatedAt = reader.GetValue(2)
                    item.TaxNumber = reader.GetValue(3)
                    item.TaxDistrict = reader.GetValue(4)
                    item.Comment = reader.GetValue(5)
                    item.PersonId = reader.GetValue(6)
                    item.PersonFio = reader.GetValue(7)

                    item.SummaAll = reader.GetValue(8)
                    item.SummaTax = reader.GetValue(9)
                    item.SummaPens = reader.GetValue(10)
                    item.ExemptType = reader.GetValue(11)
                    item.SummaExempt = reader.GetValue(12)
                    item.SummaFinal = reader.GetValue(13)

                    item.CompanyName = reader.GetValue(14)
                    item.CompanyInn = reader.GetValue(15)
                    item.CompanyAddress = reader.GetValue(16)
                    item.CompanyChief = reader.GetValue(17)
                    item.CompanyPhone = reader.GetValue(18)


                    If Not reader.IsDBNull(19) Then
                        item.PersonId = reader.GetValue(19)
                    End If

                    If Not reader.IsDBNull(21) Then
                        item.PersonFio = reader.GetValue(21)
                    End If

                    If Not reader.IsDBNull(22) Then
                        item.PersonFio += " " + reader.GetValue(22)
                    End If

                    lstDeclarations.Add(item)

                End While

            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try


        Return lstDeclarations
    End Function

    Function GetPersons() As IEnumerable(Of Person)
        Dim lstPerons As New List(Of Person)

        Dim query As String

        query = "SELECT * FROM person;"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandText = query
                Dim reader = cmd.ExecuteReader()

                Dim numCols = reader.FieldCount
                Dim hasRows = reader.HasRows
                While reader.Read() = True
                    Dim item As New Person
                    item.ID = reader.GetValue(0)
                    item.INN = reader.GetValue(1)
                    item.FirstName = reader.GetValue(2)
                    item.SurName = reader.GetValue(3)
                    item.Patronymic = reader.GetValue(4)
                    If Not reader.IsDBNull(5) Then
                        item.BornDate = reader.GetValue(5)
                    End If
                    item.Phone = reader.GetValue(7)

                    item.Region = reader.GetValue(8)
                    item.City = reader.GetValue(9)
                    item.Street = reader.GetValue(10)

                    item.TypeDoc = reader.GetValue(11)
                    item.SeriaNumber = reader.GetValue(12)
                    item.IssuedBy = reader.GetValue(13)
                    If Not reader.IsDBNull(14) Then
                        item.IssueDate = reader.GetValue(14)
                    End If

                    lstPerons.Add(item)

                End While

            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return lstPerons
    End Function
    Function UpdateDeclaration(ByRef dcl As Declaration) As Boolean
        Dim qrResult As Boolean = False
        Dim query As String
        query = "UPDATE Declaration SET NumberTax='" + dcl.NrDeclaration + "',TaxNumber='" + dcl.TaxNumber + "'" +
            ",DistrictTax='" + dcl.TaxDistrict + "',Comment='" + dcl.Comment + "',CompanyName='" + dcl.CompanyName + "'" +
            ",CompanyInn='" + dcl.CompanyInn + "', DateTax='" + dcl.DateCreatedAt + "'" +
            ",SumAll=" + dcl.SummaAll.ToString() + ", SumTax=" + dcl.SummaPens.ToString() +
            ",ExemptType='" + dcl.ExemptType + "', Exempt=" + dcl.SummaExempt.ToString() +
            ",SumFinal=" + dcl.SummaFinal.ToString() + ", SumPension=" + dcl.SummaPens.ToString() +
            ",CompanyAddress='" + dcl.CompanyAddress + "',CompanyChief='" + dcl.CompanyChief +
            "',CompanyPhone='" + dcl.CompanyPhone + "', PersonId=" + dcl.PersonId.ToString() +
            ", PersonFio = '" + dcl.PersonFio + "' " +
            " WHERE ID = " + dcl.ID.ToString() + "; "

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = query
                Try
                    cmd.ExecuteNonQuery()
                    Console.WriteLine("Inserted.")
                    qrResult = True
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return qrResult
    End Function

    Function AddNewDeclaration(ByRef declaration As Declaration) As Boolean
        Dim qrResult As Boolean = False
        Dim query As String
        query = "INSERT INTO Declaration(NumberTax,DateTax,TaxNumber, DistrictTax,Comment, 
                        PersonId, PersonFIO, SumAll, SumTax, SumPension, ExemptType, Exempt, SumFinal,
                        CompanyName, CompanyInn, CompanyAddress, CompanyChief, CompanyPhone)
                VALUES(@declnum, @taxdate, @taxnumber, @taxdist, @comment,
                        @persid, @persfio, @sumaall, @sumatax,@sumapens, @exempttype, @exempt, @sumfinal,
                        @cmpname, @cmpinn, @cmpaddress, @cmpchief, @cmpphone);"

        'query = "INSERT INTO Persons(NumberTax) VALUES(@declnum);"

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = query
                Try
                    cmd.Parameters.AddWithValue("@declnum", declaration.NrDeclaration)
                    cmd.Parameters.AddWithValue("@taxdate", declaration.DateCreatedAt)
                    cmd.Parameters.AddWithValue("@taxnumber", declaration.TaxNumber)
                    cmd.Parameters.AddWithValue("@taxdist", declaration.TaxDistrict)
                    cmd.Parameters.AddWithValue("@comment", declaration.Comment)
                    cmd.Parameters.AddWithValue("@persid", declaration.PersonId)
                    cmd.Parameters.AddWithValue("@persfio", declaration.PersonFio)
                    cmd.Parameters.AddWithValue("@sumaall", declaration.SummaAll)
                    cmd.Parameters.AddWithValue("@sumatax", declaration.SummaTax)
                    cmd.Parameters.AddWithValue("@sumapens", declaration.SummaPens)
                    cmd.Parameters.AddWithValue("@exempttype", declaration.ExemptType)
                    cmd.Parameters.AddWithValue("@exempt", declaration.SummaExempt)
                    cmd.Parameters.AddWithValue("@sumfinal", declaration.SummaFinal)

                    cmd.Parameters.AddWithValue("@cmpname", declaration.CompanyName)
                    cmd.Parameters.AddWithValue("@cmpinn", declaration.CompanyInn)
                    cmd.Parameters.AddWithValue("@cmpaddress", declaration.CompanyAddress)
                    cmd.Parameters.AddWithValue("@cmpchief", declaration.CompanyChief)
                    cmd.Parameters.AddWithValue("@cmpphone", declaration.CompanyPhone)

                    cmd.ExecuteNonQuery()
                    Console.WriteLine("Inserted.")
                    qrResult = True
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return qrResult
    End Function

    Function AddNewPerson(ByRef person As Person) As Boolean
        Dim qrResult As Boolean = False
        Dim query As String

        query = "INSERT INTO person(INN,FirstName,LastName, Patronymic,Phone, Region, City, Street,  
				 TypeDocument, SeriaNumber, IssuedBy, born,DocIssueDate)
                VALUES(@inn, @first, @last, @patronymic, @phone, @region, @city, @street, @typDoc,
                        @ser, @issby, @born, @issdate);"

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
                    cmd.Parameters.AddWithValue("@born", person.BornDate)
                    cmd.Parameters.AddWithValue("@issdate", person.IssueDate)

                    cmd.ExecuteNonQuery()
                    Console.WriteLine("Inserted.")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try



        Return qrResult
    End Function

    Function UpdatePerson(ByRef prs As Person) As Boolean
        Dim qrResult As Boolean = False
        Dim query As String
        query = "UPDATE Person SET INN='" + prs.INN + "',FirstName='" + prs.FirstName + "'" +
            ",LastName='" + prs.SurName + "',Patronymic='" + prs.Patronymic + "',Phone='" + prs.Phone + "'" +
            ",Region='" + prs.Region + "', City='" + prs.City + "'" +
            ",Street='" + prs.Street + "', TypeDocument='" + prs.TypeDoc + "'" +
            ",SeriaNumber='" + prs.SeriaNumber + "', IssuedBy='" + prs.IssuedBy + "'" +
            ", born='" + prs.BornDate + "', DocIssueDate = '" + prs.IssueDate + "'" +
            " WHERE ID = " + prs.ID.ToString() + "; "

        'Dim ms As New IO.MemoryStream()

        Try
            dbConn = New OleDb.OleDbConnection(dbConnString)
            dbConn.Open()

            Using cmd As New OleDbCommand()
                cmd.Connection = dbConn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = query
                Try
                    cmd.ExecuteNonQuery()
                    'Console.WriteLine("Updated.")
                    qrResult = True
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            Dim msg As String = ex.Message
        Finally
            dbConn.Close()
        End Try

        Return qrResult
    End Function

    Public Sub DropTable()
        Dim result As Boolean = False
        'Dim strCreate As String = "DROP TABLE Person;"
        'Dim strCreate As String = "DROP TABLE Declaration;"
        'Persons
        Dim strCreate As String = "DROP TABLE Persons;"

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

    Public Sub CreateAllTables()
        Dim qr As String = "CREATE TABLE Person(ID COUNTER, INN Varchar(13), FirstName Varchar(50), LastName Varchar(50), Patronymic Varchar(50),born DATETIME, 
				Photo IMAGE, Phone Varchar(100), 
				Region Varchar(200), City Varchar(100), Street Varchar(200),
				TypeDocument Varchar(50), SeriaNumber Varchar(50), IssuedBy Varchar(100), DocIssueDate DATETIME,
				CONSTRAINT [PrimaryKey] PRIMARY KEY ([ID]));
                "

        'Create table Person
        'CreateTable(qr)


        qr = "CREATE TABLE Declaration(ID COUNTER, NumberTax Varchar(20), DateTax DATETIME, TaxNumber Varchar(4), DistrictTax Varchar(20), 
        		Comment Memo, PersonId INTEGER, PersonFIO Varchar(255),
        		SumAll Currency,SumTax	Currency,SumPension Currency,ExemptType Varchar(150), Exempt Currency,SumFinal Currency,
        CompanyName Varchar(200), CompanyInn Varchar(20), CompanyAddress Varchar(200), CompanyChief Varchar(150), 
        CompanyPhone Varchar(50), CONSTRAINT [PrimaryKey] PRIMARY KEY ([ID]));"

        'qr = "CREATE TABLE Persons(ID COUNTER, NumberTax Varchar(20));"


        'Create table Declaration
        CreateTable(qr)

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


End Class
