Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Ausleihe
    Inherits Gegenstand
    Public Property intID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property datAusleiheStart As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property datAusleiheEnde As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class

Public Class CopyOfAusleihe
End Class
