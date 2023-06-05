'Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing

Public Class Person
    Private _id As Integer
    Private _inn As String
    Private _firstname As String
    Private _surname As String
    Private _patronimyc As String
    Private _bornDate As Date
    Private _photo As Image
    Private _phone As String

    Private _region As String
    Private _city As String
    Private _street As String

    Private _typeDoc As String
    Private _seriaNumber As String
    Private _issuedBy As String
    Private _issueDate As Date


    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property INN() As String
        Get
            Return _inn
        End Get
        Set(value As String)
            _inn = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Public Property SurName() As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Patronymic() As String
        Get
            Return _patronimyc
        End Get
        Set(value As String)
            _patronimyc = value
        End Set
    End Property

    Public Property BornDate() As Date
        Get
            Return _bornDate
        End Get
        Set(value As Date)
            _bornDate = value
        End Set
    End Property

    Public Property Photo() As Image
        Get
            Return _photo
        End Get
        Set(value As Image)
            _photo = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    'Address
    Public Property Region() As String
        Get
            Return _region
        End Get
        Set(value As String)
            _region = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property Street() As String
        Get
            Return _street
        End Get
        Set(value As String)
            _street = value
        End Set
    End Property

    'Document
    Public Property TypeDoc() As String
        Get
            Return _typeDoc
        End Get
        Set(value As String)
            _typeDoc = value
        End Set
    End Property

    Public Property SeriaNumber() As String
        Get
            Return _seriaNumber
        End Get
        Set(value As String)
            _seriaNumber = value
        End Set
    End Property

    Public Property IssuedBy() As String
        Get
            Return _issuedBy
        End Get
        Set(value As String)
            _issuedBy = value
        End Set
    End Property

    Public Property IssueDate() As Date
        Get
            Return _issueDate
        End Get
        Set(value As Date)
            _issueDate = value
        End Set
    End Property

End Class
