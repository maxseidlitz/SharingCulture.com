﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class GegenstandController
        Inherits System.Web.Mvc.Controller

        'Verbindung zur Datenbank
        Private db As Datenbank1Entities

        ' Konstruktor muss Datenbankverbindung initialiseren
        Public Sub New()
            MyBase.New() ' Konstruktor der Oberklasse aufrufen

            db = New Datenbank1Entities
        End Sub

        'Destruktor für Controller, der DB-Verbindung beendet
        Protected Overrides Sub Dispose(disposing As Boolean)
            db.Dispose()

            MyBase.Dispose(disposing) 'Aufrufen des Oberklassen-Destruktors
        End Sub



        ' GET: Gegenstand
        <HttpGet>
        Function UebersichtAlleGegenstaende() As ActionResult
            Dim geg As Gegenstand
            Dim gegEntity As GegenstandEntity
            Dim katEntity As KategorieEntity
            Dim vmGegenstaendeListe As GegenstaendeListe

            vmGegenstaendeListe = New GegenstaendeListe

            ' Jede Zeile in der Tabelle tblGegenstaende als Objekt der Entity-Klasse durchlaufen
            For Each gegEntity In db.tblGegenstand.ToList()
                katEntity = gegEntity.tblKategorie ' Vom Datensatz aus tblGegenstaende in tblKategorien navigieren

                geg = New Gegenstand(gegEntity) ' Objekt der Entity-Klasse zur Initialisierung eines Objekts der Model-Klasse nutzen

                ' Prüfen, ob es eine Kategorie gibt
                If katEntity IsNot Nothing Then
                    ' Umwandlung des Objekts der Entity-Klasse in Objekt der Model-Klasse
                    geg.Kategorie = New Kategorie(katEntity)
                End If

                vmGegenstaendeListe.hinzufuegen(geg) ' Model-Objekt zur Liste hinzufügen
            Next

            Return View(vmGegenstaendeListe) 'Übergabe der Liste aller Gegenstände, damit diese dann in der View per Zäherschleife ausgelesen werden kann
        End Function

        ' GET: /Gegenstand/Hinzufuegen
        <HttpGet>
        Function Hinzufuegen() As ActionResult
            Dim geg As Gegenstand
            Dim kat As Kategorie
            Dim lstKategorienAlle As List(Of Kategorie)
            Dim vmGeg As GegenstandViewModel

            geg = New Gegenstand ' Neue leere Aufgabe erzeugen

            ' Alle Kategorien aus Datenbank laden
            lstKategorienAlle = New List(Of Kategorie)

            For Each katEntity In db.tblKategorie.ToList
                kat = New Kategorie(katEntity)
                lstKategorienAlle.Add(kat)
            Next

            ' ViewModel vorbereiten
            vmGeg = New GegenstandViewModel

            vmGeg.Gegenstand = geg
            vmGeg.KategorienAlle = lstKategorienAlle

            Return View(vmGeg) ' Neue Aufgabe und Liste aller Kategorien als ViewModel an die View übergeben
        End Function

        'TODO: POST Prozedur erledigen!!!! @MS, 14.8.
        '' POST: /Aufgabe/Hinzufuegen
        '<HttpPost>
        'Function Hinzufuegen(pvmAuf As AufgabeViewModel) As ActionResult
        '    Dim auf As Aufgabe
        '    Dim aufEntity As AufgabeEntity
        '    Dim kat As Kategorie
        '    Dim lstKategorienAlle As List(Of Kategorie)
        '
        '    If Not ModelState.IsValid Then
        '        ' Alle Kategorien aus Datenbank laden
        '        lstKategorienAlle = New List(Of Kategorie)
        '
        '        For Each katEntity In db.tblKategorien.ToList
        '            kat = New Kategorie(katEntity)
        '            lstKategorienAlle.Add(kat)
        '        Next
        '
        '        pvmAuf.KategorienAlle = lstKategorienAlle
        '        Return View(pvmAuf)
        '    End If
        '
        '    ' Aufgabe aus dem ViewModel holen und in AufgabeEntity umwandeln
        '    auf = pvmAuf.Aufgabe
        '    aufEntity = auf.gibAlsAufgabeEntity
        '
        '    ' Speichern vorbereiten
        '    db.tblAufgaben.Attach(aufEntity) ' Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
        '    db.Entry(aufEntity).State = EntityState.Added ' als Hinzugefügt markieren
        '
        '    ' Vorsichtig Änderungen speichern
        '    Try
        '        db.SaveChanges()
        '    Catch ex As Exception
        '        ' Im Fehlerfall wird der Fehler im ViewModel vermerkt
        '        ModelState.AddModelError(String.Empty, "Hinzufügen war nicht erfolgreich.")
        '    End Try
        '
        '    Return RedirectToAction("Index") ' Zurück zur Übersicht über alle Aufgaben
        'End Function


    End Class
End Namespace