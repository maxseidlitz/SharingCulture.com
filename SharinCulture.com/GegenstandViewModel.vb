Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class GegenstandViewModel
    Private mGegenstand As Integer
    Private mKategorie As Integer

    Public Property Gegenstand As Gegenstand
        Get
            Return Nothing
        End Get
        Set(value As Gegenstand)
        End Set
    End Property

    Public Property Kategorie As Kategorie
        Get
            Return Nothing
        End Get
        Set(value As Kategorie)
        End Set
    End Property
End Class
