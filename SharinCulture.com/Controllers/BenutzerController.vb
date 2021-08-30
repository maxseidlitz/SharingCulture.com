Imports System.Web.Mvc

Namespace Controllers
    Public Class BenutzerController
        Inherits Controller

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

        ' GET: Benutzer
        Function Anmeldung() As ActionResult

            Dim ben As Benutzer
            Dim benEntity As BenutzerEntity
            Dim nachEntity As NachbarschaftEntity
            Dim vmBenutzerListe As BenutzerListe

            vmBenutzerListe = New BenutzerListe

            ' Jede Zeile in der Tabelle tblBenutzer als Objekt der Entity-Klasse durchlaufen
            For Each benEntity In db.tblBenutzer.ToList()
                nachEntity = benEntity.tblnachbarschaft ' Vom Datensatz aus tblBenutzer in tblnachbarschaft navigieren

                ben = New Benutzer(benEntity) ' Objekt der Entity-Klasse zur Initialisierung eines Objekts der Model-Klasse nutzen

                ' Prüfen, ob es eine Nachbarschaft gibt
                If nachEntity IsNot Nothing Then
                    ' Umwandlung des Objekts der Entity-Klasse in Objekt der Model-Klasse
                    ben.Nachbarschaft = New Nachbarschaft(nachEntity)
                End If

                vmBenutzerListe.hinzufuegen(ben) ' Model-Objekt zur Liste hinzufügen
            Next

            Return View(vmBenutzerListe) 'Übergabe der Liste aller Benutzer, damit diese dann in der View per Zäherschleife ausgelesen werden kann


            Return View()
        End Function


    End Class
End Namespace