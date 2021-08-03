Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class BenutzerViewModel
    Private mNachbarschaft As Integer
    Private mBenutzer As Integer

    Public Property Nachbarschaft As Nachbarschaft
        Get
            Return Nothing
        End Get
        Set(value As Nachbarschaft)
        End Set
    End Property

    Public Property Benutzer As Benutzer
        Get
            Return Nothing
        End Get
        Set(value As Benutzer)
        End Set
    End Property
End Class
