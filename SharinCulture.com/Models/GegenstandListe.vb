﻿Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class GegenstaendeListe
    Public Property Gegenstände As Gegenstand
        Get
            Return Nothing
        End Get
        Set(value As Gegenstand)
        End Set
    End Property

    Public Sub LadenAlleGegenstände()

    End Sub
End Class

Public Class BenutzerListe
    Public Property Benutzer As Benutzer
        Get
            Return Nothing
        End Get
        Set(value As Benutzer)
        End Set
    End Property

    Public Sub LadenAlleGegenstände()

    End Sub
End Class