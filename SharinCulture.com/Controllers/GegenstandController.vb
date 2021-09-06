Imports System.Data.Entity
Imports System.Web.Mvc

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
            'Ich glaube Ausleihe muss hier nicht integriert werden, sondern eher in einem separaten Controller??? M.S. 29.8. 14h
            'Dim ausEntity As AusleiheEntity
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

        ' POST: /Gegenstand/Hinzufuegen
        <HttpPost>
        Function Hinzufuegen(pvmGeg As GegenstandViewModel) As ActionResult
            Dim geg As Gegenstand
            Dim gegEntity As GegenstandEntity
            Dim kat As Kategorie
            Dim lstKategorienAlle As List(Of Kategorie)

            If Not ModelState.IsValid Then
                ' Alle Kategorien aus Datenbank laden
                lstKategorienAlle = New List(Of Kategorie)

                For Each katEntity In db.tblKategorie.ToList
                    kat = New Kategorie(katEntity)
                    lstKategorienAlle.Add(kat)
                Next

                pvmGeg.KategorienAlle = lstKategorienAlle
                Return View(pvmGeg)
            End If

            ' Gegenstand aus dem ViewModel ziehen und in GegenstandEntity umwandeln
            geg = pvmGeg.Gegenstand
            gegEntity = geg.UmwandelnInGegenstandEntity

            ' Speichern vorbereiten
            db.tblGegenstand.Attach(gegEntity) ' Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(gegEntity).State = EntityState.Added ' als Hinzugefügt markieren

            'Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                ' Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Hinzufügen war nicht erfolgreich.")
            End Try

            Return RedirectToAction("UebersichtMeineGegenstaende") ' Zurück zur Übersicht über alle Aufgaben
        End Function


        Function Details(ID As Integer) As ActionResult
            'Deklaration
            Dim geg As Gegenstand
            Dim gegE As GegenstandEntity
            Dim kat As Kategorie
            Dim katE As KategorieEntity
            Dim vmGeg As GegenstandViewModel

            'Datenbankzugriff über Entity Framework
            gegE = db.tblGegenstand.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblGegenstand nachschlagen
            katE = gegE.tblKategorie 'Vom Datensatz aus tblGegenstand in tblKategorie navigieren

            If gegE Is Nothing Then
                Return New HttpNotFoundResult("Gegenstand mit der ID " & ID & " wurde nicht gefunden")
            End If
            'Gefundenen Datensatz aus der Datenbank entnehmen
            db.Entry(gegE).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            geg = New Gegenstand(gegE)

            'Prüfen, ob Branche vorhanden
            If katE IsNot Nothing Then
                geg.Kategorie = New Kategorie(katE)
            End If

            katE = db.tblKategorie.Find(gegE.gegkatKategorieFk)

            If katE Is Nothing Then
                Return New HttpNotFoundResult("Kategorie mit der ID " & gegE.gegkatKategorieFk & " wurde nicht gefunden")
            End If
            db.Entry(katE).State = EntityState.Detached
            kat = New Kategorie(katE)

            geg.Kategorie = kat

            'Vorbereitung des View-Models
            vmGeg = New GegenstandViewModel
            vmGeg.Gegenstand = geg

            Return View(vmGeg)
        End Function
    End Class
End Namespace