Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Gegenstand
    Private mstrBezeichnung As String
    Private mintID As Integer
    Private mbolIstGebucht As Boolean
    Private mbinaryBild As image
    Private mintNachbarschaft As Integer
    Private mstrBenutzername As String
    Private mKategorie As Kategorie

    'Paramterloser Konstruktor
    Public Sub New()
        mstrBezeichnung = String.Empty
        mintID = -1
        mbolIstGebucht = False
        mbinaryBild = Nothing
        mintNachbarschaft = -1              'muss mintNachbarschaft und intNachbarschaft nicht als Fremdschlüssel gekennzeichnet sein? [M.S./02.08.]
        mstrBenutzername = String.Empty

        mKategorie = Nothing
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pstrBezeichnung As String, pintID As Integer, pbolIstGebucht As Boolean,
                  pbinaryBild As Image, pintNachbarschaft As Integer, pstrBenutzername As String, pKat As Kategorie)
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
                   pbinaryBild As Image, pintNachbarschaft As Integer, pstrBenutzername As String, pintKatFk As Integer)
        mstrBezeichnung = pstrBezeichnung
        mintID = pintID
        mbolIstGebucht = pbolIstGebucht
        mbinaryBild = pbinaryBild
        mintNachbarschaft = pintNachbarschaft
        mstrBenutzername = pstrBenutzername
        mKategorie = Nothing
    End Sub

    '*** Auskommentiert am 3.8. - Aufgrund desFehlers das mbinaryBild nicht im DatTyp short? gespeichert werden kann | Wir planen Bilder komplett raus zu lassen!
    'Public Sub New(pGegenstandEntity As GegenstandEntity, pKategorie As KategorieEntity)
    '    mbinaryBild = pGegenstandEntity.gegBild
    '    mbolIstGebucht = pGegenstandEntity.gegIstGebucht
    '    mintID = pGegenstandEntity.gegID_
    '    mintNachbarschaft = pGegenstandEntity.gegnachIDFk
    '    mstrBenutzername = pGegenstandEntity.gegbenBenutzernameFk
    '    mstrBezeichnung = pGegenstandEntity.gegBezeichnung
    '
    'End Sub

    Public Property strBezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property intID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property bolIstGebucht As Boolean
        Get
            Return mbolIstGebucht
        End Get
        Set(value As Boolean)
        End Set
    End Property

    Public Property binaryBild As Image
        Get
            Return mbinaryBild
        End Get
        Set(value As Image)
        End Set
    End Property

    Public Property intNachbarschaft As Integer
        Get
            Return mintNachbarschaft
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strBenutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
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
