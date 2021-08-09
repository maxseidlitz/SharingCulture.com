Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class NachbarschaftenListe

    Private mlstNachbarschaften As List(Of Nachbarschaft)

    'Konstruktor parameterlos
    Public Sub New()
        mlstNachbarschaften = New List(Of Nachbarschaft)
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(plstNachbarschaften As List(Of Nachbarschaft))
        mlstNachbarschaften = plstNachbarschaften
    End Sub

    Public Property Nachbarschaft As List(Of Nachbarschaft)
        Get
            Return mlstNachbarschaften
        End Get
        Set(value As List(Of Nachbarschaft))
        End Set
    End Property

    Public Sub LadenAlleNachbarschaften()

    End Sub

    Public Sub hinzufuegen(pNach As Nachbarschaft)
        mlstNachbarschaften.Add(pNach)
    End Sub

    Public Sub leeren()
        mlstNachbarschaften.Clear()
    End Sub

End Class
