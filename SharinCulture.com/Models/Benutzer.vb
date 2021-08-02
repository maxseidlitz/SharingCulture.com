Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Benutzer
    Private mbolIstEigentuemer As Boolean
    Private mbolIstKoordinator As Boolean
    Private mdatGeburtstag As Date
    Private mNachbarschaft As Nachbarschaft
    Private mstrBenutzername As String
    Private mstrEmail As String
    Private mstrName As String
    Private mstrPasswort As String
    Private mstrTelefonnummer As String
    Private mstrVorname As String

    'Parameterloser Kostruktor
    Public Sub New()
        mbolIstEigentuemer = False
        mbolIstKoordinator = False
        mdatGeburtstag = Date.Today
        mNachbarschaft = Nothing
        mstrBenutzername = String.Empty
        mstrEmail = String.Empty
        mstrName = String.Empty
        mstrPasswort = String.Empty
        mstrTelefonnummer = String.Empty
    End Sub

    'Kostruktor mit Parametern
    Public Sub New(pbolIstEigentuemer As Boolean, pbolIstKoordinator As Boolean, pdatGeburtstag As Date,
                   pNachbarschaft As Nachbarschaft, pstrBenutzername As String, pstrEmail As String,
                   pstrName As String, pstrPasswort As String, pstrTelefonnummer As String)

        mbolIstEigentuemer = pbolIstEigentuemer
        mbolIstKoordinator = pbolIstKoordinator
        mdatGeburtstag = pdatGeburtstag
        mNachbarschaft = Nothing
        mstrBenutzername = pstrBenutzername
        mstrEmail = pstrEmail
        mstrName = pstrName
        mstrPasswort = pstrPasswort
        mstrTelefonnummer = pstrTelefonnummer

    End Sub

    'Konstruktor mit Parametern und Fremdschlüssel für Nachbarschaft
    Public Sub New(pbolIstEigentuemer As Boolean, pbolIstKoordinator As Boolean, pdatGeburtstag As Date,
                   pintNachFk As Integer, pstrBenutzername As String, pstrEmail As String,
                   pstrName As String, pstrPasswort As String, pstrTelefonnummer As String)

        mbolIstEigentuemer = pbolIstEigentuemer
        mbolIstKoordinator = pbolIstKoordinator
        mdatGeburtstag = pdatGeburtstag

        mstrBenutzername = pstrBenutzername
        mstrEmail = pstrEmail
        mstrName = pstrName
        mstrPasswort = pstrPasswort
        mstrTelefonnummer = pstrTelefonnummer

    End Sub


    Public Property strBenutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strName As String
        Get
            Return mstrName
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strVorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strEmail As String
        Get
            Return mstrEmail
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strTelefonnummer As String
        Get
            Return mstrTelefonnummer
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strPasswort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property datGeburtsdatum As Date
        Get
            Return mdatGeburtstag
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property bolIstKoordinator As Boolean
        Get
            Return mbolIstKoordinator
        End Get
        Set(value As Boolean)
        End Set
    End Property

    Public Property bolIstEigentümer As Boolean
        Get
            Return mbolIstEigentuemer
        End Get
        Set(value As Boolean)
        End Set
    End Property

    Public Property intNachbarschaft As Integer
        Get
            Return mintNachbarschaft
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Gegenstand As Gegenstand
        Get
            Return Nothing
        End Get
        Set(value As Gegenstand)
        End Set
    End Property

    Public Property Nachbarschaft As Nachbarschaft
        Get
            Return Nothing
        End Get
        Set(value As Nachbarschaft)
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
