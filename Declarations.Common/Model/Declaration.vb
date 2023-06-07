Public Class Declaration
    Private _id As Integer
    Private _NrDeclaration As String
    Private _DateCreatedAt As DateTime
    Private _taxNumber As String
    Private _taxDistrict As String
    Private _Comment As String

    Private _personId As Integer
    Private _personFio As String

    Private _sumaAll As Double
    Private _sumaTax As Double
    Private _sumaPens As Double
    Private _exempt As Double
    Private _sumaFinal As Double
    Private _exmeptType As String

    Private _companyName As String
    Private _companyInn As String
    Private _companyAddress As String
    Private _companyPhone As String
    Private _companyChief As String

    Private _person As Person

    Public Property Person() As Person
        Get
            Return _person
        End Get
        Set(value As Person)
            _person = value
        End Set
    End Property

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
    Public Property TaxNumber() As String
        Get
            Return _taxNumber
        End Get
        Set(value As String)
            _taxNumber = value
        End Set
    End Property
    Public Property TaxDistrict() As String
        Get
            Return _taxDistrict
        End Get
        Set(value As String)
            _taxDistrict = value
        End Set
    End Property
    Public Property Comment() As String
        Get
            Return _Comment
        End Get
        Set(value As String)
            _Comment = value
        End Set
    End Property
    Public Property PersonFio() As String
        Get
            Return _personFio
        End Get
        Set(value As String)
            _personFio = value
        End Set
    End Property
    Public Property PersonId() As Integer
        Get
            Return _personId
        End Get
        Set(value As Integer)
            _personId = value
        End Set
    End Property
    Public Property SummaAll() As Double
        Get
            Return _sumaAll
        End Get
        Set(value As Double)
            _sumaAll = value
        End Set
    End Property
    Public Property SummaTax() As Double
        Get
            Return _sumaTax
        End Get
        Set(value As Double)
            _sumaTax = value
        End Set
    End Property
    Public Property SummaPens() As Double
        Get
            Return _sumaPens
        End Get
        Set(value As Double)
            _sumaPens = value
        End Set
    End Property
    Public Property SummaExempt() As Double
        Get
            Return _exempt
        End Get
        Set(value As Double)
            _exempt = value
        End Set
    End Property
    Public Property SummaFinal() As Double
        Get
            Return _sumaFinal
        End Get
        Set(value As Double)
            _sumaFinal = value
        End Set
    End Property
    Public Property ExemptType() As String
        Get
            Return _exmeptType
        End Get
        Set(value As String)
            _exmeptType = value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return _companyName
        End Get
        Set(value As String)
            _companyName = value
        End Set
    End Property
    Public Property CompanyInn() As String
        Get
            Return _companyInn
        End Get
        Set(value As String)
            _companyInn = value
        End Set
    End Property
    Public Property CompanyAddress() As String
        Get
            Return _companyAddress
        End Get
        Set(value As String)
            _companyAddress = value
        End Set
    End Property
    Public Property CompanyPhone() As String
        Get
            Return _companyPhone
        End Get
        Set(value As String)
            _companyPhone = value
        End Set
    End Property
    Public Property CompanyChief() As String
        Get
            Return _companyChief
        End Get
        Set(value As String)
            _companyChief = value
        End Set
    End Property


End Class
