Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel


Public Class Ausleihe

    Private mintID As Integer
    Private mdatAusleiheStart As Date
    Private mdatAusleiheEnde As Date
    Private mGegenstand As Gegenstand

    'Konstruktor parameterlos
    Public Sub New()
        mintID = -1
        mdatAusleiheStart = Date.Today
        mdatAusleiheEnde = Date.Today
        mGegenstand = Nothing
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pintID As Integer, pdatAusleiheStart As Date, pdatAusleiheEnde As Date, pGegenstand As Gegenstand)
        mintID = pintID
        mdatAusleiheStart = pdatAusleiheStart
        mdatAusleiheEnde = pdatAusleiheEnde
        mGegenstand = pGegenstand
    End Sub

    Public Property intID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property datAusleiheStart As Date
        Get
            Return mdatAusleiheStart
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property datAusleiheEnde As Date
        Get
            Return mdatAusleiheEnde
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property Gegenstand As Gegenstand
        Get
            Return mGegenstand
        End Get
        Set(value As Gegenstand)
        End Set
    End Property

    Public Sub neueAusleihe()

    End Sub
End Class

Public Class CopyOfAusleihe
End Class
