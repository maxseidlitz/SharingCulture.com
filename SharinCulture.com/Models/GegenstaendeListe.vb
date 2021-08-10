Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class GegenstaendeListe
    Private mlstGegenstaende As List(Of Gegenstand)

    'Konstruktor parameterlos
    Public Sub New()
        mlstGegenstaende = New List(Of Gegenstand)
    End Sub
    'Konstruktor mit Parametern
    Public Sub New(plstGegenstaende As List(Of Gegenstand))
        mlstGegenstaende = plstGegenstaende
    End Sub

    Public Property Gegenstaende As List(Of Gegenstand)
        Get
            Return mlstGegenstaende
        End Get
        Set(value As List(Of Gegenstand))
            mlstGegenstaende = value
        End Set
    End Property

    Public Sub LadenAlleGegenstawnde()

    End Sub

    Public Sub hinzufuegen(pGegenstand As Gegenstand)
        mlstGegenstaende.Add(pGegenstand)
    End Sub

    Public Sub leeren()
        mlstGegenstaende.Clear()
    End Sub
End Class
