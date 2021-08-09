Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class KategorienListe
    Private mlstKategorien As List(Of Kategorie)
    'Konstruktor parameterlos
    Public Sub New()
        mlstKategorien = New List(Of Kategorie)
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(plstKategorien As List(Of Kategorie))
        mlstKategorien = plstKategorien
    End Sub

    Public Property Kategorien As List(Of Kategorie)
        Get
            Return mlstKategorien
        End Get
        Set(value As List(Of Kategorie))
            mlstKategorien = value
        End Set
    End Property

    Public Sub LadenAlleKategorien()

    End Sub

    Public Sub hinzufuegen(pKat As Kategorie)
        mlstKategorien.Add(pKat)
    End Sub

    Public Sub leeren()
        mlstKategorien.Clear()
    End Sub
End Class
