Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class AusleihenListe

    Private mlstAusleihen As List(Of Ausleihe)
    'Konstruktor parameterlos
    Public Sub New()
        mlstAusleihen = New List(Of Ausleihe)
    End Sub
    'Konstruktor mit Parametern
    Public Sub New(plstAusleihe As List(Of Ausleihe))
        mlstAusleihen = New List(Of Ausleihe)
    End Sub

    Public Property Ausleihen As List(Of Ausleihe)
        Get
            Return mlstAusleihen
        End Get
        Set(value As List(Of Ausleihe))
            mlstAusleihen = value
        End Set
    End Property

    Public Sub LadenAlleAusleihen()

    End Sub

    Public Sub hinzufuegen(pAus As Ausleihe)
        mlstAusleihen.Add(pAus)
    End Sub

    Public Sub leeren()
        mlstAusleihen.Clear()
    End Sub

End Class
