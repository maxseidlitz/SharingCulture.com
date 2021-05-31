Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Benutzer
    Public Property strBenutzername As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strName As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strVorname As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strEmail As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strTelefonnummer As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strPasswort As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property datGeburtsdatum As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property bolIstKoordinator As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property bolIstEigentümer As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property intNachbarschaft As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Nachbarschaft As NachbarschaftenListe
        Get
            Return Nothing
        End Get
        Set(value As NachbarschaftenListe)
        End Set
    End Property

    Public Property Gegenstand As Gegenstand
        Get
            Return Nothing
        End Get
        Set(value As Gegenstand)
        End Set
    End Property

    Public Sub buchenGegenstand()

    End Sub

    Public Sub zurückgebenGegenstand()

    End Sub

    Public Sub anbietenGegenstand()

    End Sub

    Public Sub loeschenGegenstand()

    End Sub

    Public Sub verlängernAusleihe()

    End Sub

    Public Sub neuenBenutzerHizufuegen()

    End Sub
End Class
