Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Gegenstand
    Private mstrBezeichnung As String
    Private mintID As Integer
    Private mbolIstGebucht As Boolean
    Private mbinaryBild As Integer
    Private mintNachbarschaft As Integer
    Private mstrBenutzername As String
    Private mKategorie As Kategorie

    'Paramterloser Konstruktor
    Public Sub New()
        mstrBezeichnung = String.Empty
        mintID = -1
        mbolIstGebucht = False
        mbinaryBild = Nothing
        mintNachbarschaft = -1
        mstrBenutzername = String.Empty

        mKategorie = Nothing
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pstrBezeichnung As String, pintID As Integer, pbolIstGebucht As Boolean,
                   pbinaryBild As Integer, pintNachbarschaft As Integer, pstrBenutzername As String, pKat As Kategorie)
        mstrBezeichnung = pstrBezeichnung
        mintID = pintID
        mbolIstGebucht = pbolIstGebucht
        mbinaryBild = pbinaryBild
        mintNachbarschaft = pintNachbarschaft
        mstrBenutzername = pstrBenutzername

        mKategorie = pKat
    End Sub

    'Konstruktor mit Parametern und Fremdschlüssel für Kategorie
    Public Sub New(pstrBezeichnung As String, pintID As Integer, pbolIstGebucht As Boolean,
                   pbinaryBild As Integer, pintNachbarschaft As Integer, pstrBenutzername As String, pintKatFk As Kategorie)
        mstrBezeichnung = pstrBezeichnung
        mintID = pintID
        mbolIstGebucht = pbolIstGebucht
        mbinaryBild = pbinaryBild
        mintNachbarschaft = pintNachbarschaft
        mstrBenutzername = pstrBenutzername

        mKategorie = Nothing
    End Sub

    Public Property strBezeichnung As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property intID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property bolIstGebucht As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property binaryBild As Integer
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

    Public Property strBenutzername As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Kategorie As Kategorie
        Get
            Return Nothing
        End Get
        Set(value As Kategorie)
        End Set
    End Property

    Public Sub neuenGegenstandHinzufuegen()

    End Sub
End Class
