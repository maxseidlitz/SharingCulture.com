'------------------------------------------------------------------------------
' <auto-generated>
'     Der Code wurde von einer Vorlage generiert.
'
'     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
'     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class KategorieEntity
    Public Property katID As Integer
    Public Property katBezeichnung As String

    Public Overridable Property tblGegenstand As ICollection(Of GegenstandEntity) = New HashSet(Of GegenstandEntity)

End Class
