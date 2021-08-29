Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Gegenstand
    Private mstrBezeichnung As String
    Private mintID As Integer
    Private mbolIstGebucht As Boolean
    Private mbinaryBild As Image
    Private mNachbarschaft As Nachbarschaft
    Private mstrBenutzername As String
    Private mKategorie As Kategorie
    Private mAusleihe as Ausleihe

    'Paramterloser Konstruktor
    Public Sub New()
        mstrBezeichnung = String.Empty
        mintID = -1
        mbolIstGebucht = False
        mbinaryBild = Nothing
        mNachbarschaft = Nothing 'muss mintNachbarschaft und intNachbarschaft nicht als Fremdschlüssel gekennzeichnet sein? [M.S./02.08.]
        mstrBenutzername = String.Empty
        mKategorie = Nothing
        mAusleihe = Nothing
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pstrBezeichnung As String, pintID As Integer, pbolIstGebucht As Boolean,
                  pbinaryBild As Image, pNachbarschaft As Nachbarschaft, pstrBenutzername As String, pKat As Kategorie, pAus As Ausleihe)
        mstrBezeichnung = pstrBezeichnung
        mintID = pintID
        mbolIstGebucht = pbolIstGebucht
        mbinaryBild = pbinaryBild
        mNachbarschaft = pNachbarschaft
        mstrBenutzername = pstrBenutzername
        mKategorie = pKat
        mAusleihe = pAus

    End Sub

    'Konstruktor mit Parametern und Fremdschlüssel für Kategorie
    Public Sub New(pstrBezeichnung As String, pintID As Integer, pbolIstGebucht As Boolean,
                   pbinaryBild As Image, pNachbarschaft As Nachbarschaft, pstrBenutzername As String, pintKatFk As Integer)
        mstrBezeichnung = pstrBezeichnung
        mintID = pintID
        mbolIstGebucht = pbolIstGebucht
        mbinaryBild = pbinaryBild
        mNachbarschaft = pNachbarschaft
        mstrBenutzername = pstrBenutzername
        mKategorie = Nothing
        mAusleihe = Nothing

    End Sub

    Public Sub New(pGegenstandEntity As GegenstandEntity)
        'mbinaryBild = pGegenstandEntity.gegBild
        mbolIstGebucht = pGegenstandEntity.gegIstGebucht
        mintID = pGegenstandEntity.gegID

        mstrBenutzername = pGegenstandEntity.gegbenBenutzernameFk
        mstrBezeichnung = pGegenstandEntity.gegBezeichnung

    End Sub

    Public Function UmwandelnInGegenstandEntity() As GegenstandEntity
        Dim gegE As GegenstandEntity
        gegE = New GegenstandEntity

        gegE.gegID = mintID

        gegE.gegBezeichnung = mstrBezeichnung
        gegE.gegIstGebucht = mbolIstGebucht
        'gegE.gegBild = mbinaryBild                      'Wir müssen diese Bilder raushauen, das nervt unnormal! Lass ein JavaScript schreiben was anhand des Namens ein beliebiges Bild sucht und im HTML abbildet!
        gegE.gegbenBenutzernameFk = mstrBenutzername

        If mKategorie IsNot Nothing Then
            gegE.gegkatKategorieFk = mKategorie.intID
        End If

        If mNachbarschaft IsNot Nothing Then
            gegE.gegnachIDFk = mNachbarschaft.intID
        End If

        'Hier muss so etwas [siehe 4 Zeilen oberhalb] nicht für Ausleihe gemacht werden, denn die Daten der DB für die Ausleihe werden separat in die "AusleiheEnitity" geladen und dann per Fk 
        'mit dem Gegenstand verknüpft.

        Return gegE
    
    End Function


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

    Public Property intNachbarschaft As Nachbarschaft
        Get
            Return mNachbarschaft
        End Get
        Set(value As Nachbarschaft)
            mNachbarschaft = value
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
