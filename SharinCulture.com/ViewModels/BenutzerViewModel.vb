Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class BenutzerViewModel
    Private mBenutzer As Benutzer

    Private mNachbarschaftenAlle As List(Of Nachbarschaft)

    Public Property Benutzer As Benutzer
        Get
            Return Nothing
        End Get
        Set(value As Benutzer)
            mBenutzer = value
        End Set
    End Property

    Public Property Nachbarschaft() As List(Of Nachbarschaft)
        Get
            Return mNachbarschaftenAlle
        End Get
        Set(value As List(Of Nachbarschaft))
            mNachbarschaftenAlle = value
        End Set
    End Property
End Class
