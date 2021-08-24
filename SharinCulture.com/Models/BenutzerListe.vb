Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class BenutzerListe
    Private mlstBenutzer As List(Of Benutzer)

    'Konstruktor parameterlos
    Public Sub New()
        mlstBenutzer = New List(Of Benutzer)
    End Sub
    'Konstruktor mit Parametern
    Public Sub New(plstBenutzer As List(Of Benutzer))
        mlstBenutzer = plstBenutzer
    End Sub

    Public Property Benutzer As List(Of Benutzer)
        Get
            Return mlstBenutzer
        End Get
        Set(value As List(Of Benutzer))
            mlstBenutzer = value
        End Set
    End Property

    Public Sub hinzufuegen(pBen As Benutzer)
        mlstBenutzer.Add(pBen)
    End Sub

    Public Sub leeren()
        mlstBenutzer.Clear()
    End Sub


End Class
