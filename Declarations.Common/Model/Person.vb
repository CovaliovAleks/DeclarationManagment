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

End Class
