Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel


Public Class Ausleihe

    Private mintID As Integer
    Private mdatAusleiheStart As Date
    Private mdatAusleiheEnde As Date
    Private mGegenstand As Gegenstand
    Private mBenutzer As Benutzer

    'Konstruktor parameterlos
    Public Sub New()
        mintID = -1
        mdatAusleiheStart = Date.Today
        mdatAusleiheEnde = Date.Today
        mGegenstand = Nothing
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pintID As Integer, pdatAusleiheStart As Date, pdatAusleiheEnde As Date, pGegenstand As Gegenstand, pBenutzer As Benutzer)
        mintID = pintID
        mdatAusleiheStart = pdatAusleiheStart
        mdatAusleiheEnde = pdatAusleiheEnde
        mGegenstand = pGegenstand
        mBenutzer = pBenutzer
    End Sub

    'Konstuktor für di Entity Klasse
    Public Sub New(pAusleiheEntity As AusleiheEntity)
        'mbinaryBild = pGegenstandEntity.gegBild
        mintID = pAusleiheEntity.ausID
        mdatAusleiheStart = pAusleiheEntity.ausStart
        mdatAusleiheEnde = pAusleiheEntity.ausEnde
        mGegenstand = pAusleiheEntity.ausgegIDFk
        mBenutzer = pAusleiheEntity.ausbenBenutzernameFk
    End Sub

    'erstmal o erstelt, komischerweise ist die Ausleie Entity aber noch nicht da... obwohl sie schon im DataModel integriert ist.
    Public Function UmwandelnInAusleiheEntity() As AusleiheEntity
        Dim ausE As AusleiheEntity
        ausE = New AusleiheEntity

        ausE.ausID = mintID
        ausE.ausStart = mdatAusleiheStart
        ausE.ausEnde = mdatAusleiheEnde
        ausE.ausgegIDFk = mGegenstand
        ausE.ausbenBenutzernameFk = mBenutzer

        If mGegenstand IsNot Nothing Then
            ausE.ausgegIDFk = mGegenstand.intID
        End If

        If mBenutzer IsNot Nothing Then
            ausE.ausbenBenutzernameFk = mBenutzer.strBenutzername
        End If

        Return ausE
    End Function

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

    Public Property Benutzer As Benutzer
        Get
            Return mBenutzer
        End Get
        Set(value As Benutzer)
        End Set
    End Property

    Public Sub neueAusleihe()

    End Sub
End Class

Public Class CopyOfAusleihe
End Class
