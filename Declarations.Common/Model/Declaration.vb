Public Class Declaration
    Private _id As Integer
    Private _NrDeclaration As String
    Private _DateCreatedAt As DateTime

    Private Person As Person

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property NrDeclaration() As String
        Get
            Return _NrDeclaration
        End Get
        Set(value As String)
            _NrDeclaration = value
        End Set
    End Property
    Public Property DateCreatedAt() As DateTime
        Get
            Return _DateCreatedAt
        End Get
        Set(value As DateTime)
            _DateCreatedAt = value
        End Set
    End Property




End Class
