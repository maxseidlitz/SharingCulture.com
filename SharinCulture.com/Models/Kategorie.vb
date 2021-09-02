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

    Public Sub New(pkatEntity As KategorieEntity)
        mintID = pkatEntity.katID
        mstrBezeichnung = pkatEntity.katBezeichnung
    End Sub

    Public Function gibAlsEntity() As KategorieEntity
        Dim katEntity As KategorieEntity
        katEntity = New KategorieEntity

        katEntity.katID = mintID
        katEntity.katBezeichnung = mstrBezeichnung

        Return katEntity
    End Function

    Property intID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
            mintID = value
        End Set
    End Property

    Public Property strBezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
            mstrBezeichnung = value
        End Set
    End Property
End Class
