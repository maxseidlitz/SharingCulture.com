Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Nachbarschaft
    Private mintID As Integer
    Private mstrName As String
    Private mstrOrt As String

    'parameterloser Konstruktor
    Public Sub New()
        mintID = -1
        mstrName = String.Empty
        mstrOrt = String.Empty
    End Sub

    'Konstruktor mit Parametern
    Public Sub New(pintID As Integer, pstrName As String, pstrOrt As String)
        mintID = -1
        mstrName = String.Empty
        mstrOrt = String.Empty
    End Sub

    'Konstruktor mit Parametern UND Fremdschlüssel ist hier nicht nötig, denn es gibt keine Fremdschlüssel

    Public Property intID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strName As String
        Get
            Return mstrName
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strOrt As String
        Get
            Return mstrOrt
        End Get
        Set(value As String)
        End Set
    End Property
End Class
