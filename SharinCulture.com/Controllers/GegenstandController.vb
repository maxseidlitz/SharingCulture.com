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

    End Class
End Namespace