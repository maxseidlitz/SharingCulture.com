﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Der Code wurde von einer Vorlage generiert.
'
'     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
'     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class Datenbank1Entities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Datenbank1Entities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblAusleihe() As DbSet(Of AusleiheEntity)
    Public Overridable Property tblBenutzer() As DbSet(Of BenutzerEntity)
    Public Overridable Property tblGegenstand() As DbSet(Of GegenstandEntity)
    Public Overridable Property tblKategorie() As DbSet(Of KategorieEntity)
    Public Overridable Property tblnachbarschaft() As DbSet(Of NachbarschaftEntity)

End Class