Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Kategorie
    Private mintID As Integer
    Private mstrBezeichnung As String

    'parameterloser Kontruktor
    Public Sub New()
        mintID = -1
        mstrBezeichnung = String.Empty
    End Sub

    'Konstrutor mit Parametern
    Public Sub New(pintID As Integer, pstrBezeichnung As String)
        mintID = pintID
        mstrBezeichnung = pstrBezeichnung
    End Sub

    Property intID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strBezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
        End Set
    End Property
End Class
