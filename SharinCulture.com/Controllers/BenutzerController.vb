Imports System.Web.Mvc
Imports SharingCulture.com.Benutzer

Namespace Controllers
    Public Class BenutzerController
        Inherits Controller

        'Verbindung zur Datenbank
        Private db As Datenbank1Entities

        ' Konstruktor muss Datenbankverbindung initialiseren
        Public Sub New()
            MyBase.New() ' Konstruktor der Oberklasse aufrufen

            db = New Datenbank1Entities

            Debug.Print("Datenbank mit Entity-Framework verbunden.")

        End Sub

        'Destruktor für Controller, der DB-Verbindung beendet
        Protected Overrides Sub Dispose(disposing As Boolean)
            db.Dispose()

            MyBase.Dispose(disposing) 'Aufrufen des Oberklassen-Destruktors
        End Sub

        'hat nicht auf diese weise funktioniert mit dem Anmelden. Siehe untere Anelden_Funktion!
        '        ' GET: Benutzer
        '        Function Anmeldung() As ActionResult
        '
        '            Dim ben As Benutzer
        '            Dim benEntity As BenutzerEntity
        '            Dim nachEntity As NachbarschaftEntity
        '            Dim vmBenutzerListe As BenutzerListe
        '
        '            vmBenutzerListe = New BenutzerListe
        '
        '            ' Jede Zeile in der Tabelle tblBenutzer als Objekt der Entity-Klasse durchlaufen
        '            For Each benEntity In db.tblBenutzer.ToList()
        '                nachEntity = benEntity.tblnachbarschaft ' Vom Datensatz aus tblBenutzer in tblnachbarschaft navigieren
        '
        '                ben = New Benutzer(benEntity) ' Objekt der Entity-Klasse zur Initialisierung eines Objekts der Model-Klasse nutzen
        '
        '                ' Prüfen, ob es eine Nachbarschaft gibt
        '                If nachEntity IsNot Nothing Then
        '                    ' Umwandlung des Objekts der Entity-Klasse in Objekt der Model-Klasse
        '                    ben.Nachbarschaft = New Nachbarschaft(nachEntity)
        '                End If
        '
        '                vmBenutzerListe.hinzufuegen(ben) ' Model-Objekt zur Liste hinzufügen
        '            Next
        '
        '            Return View(vmBenutzerListe) 'Übergabe der Liste aller Benutzer, damit diese dann in der View per Zäherschleife ausgelesen werden kann
        '
        '
        '            Return View()
        '        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Anmeldung(pBen As Benutzer) As ActionResult
            Dim ben As Benutzer
            Dim benE As BenutzerEntity

            If ModelState.IsValid Then
                Using db As Datenbank1Entities = New Datenbank1Entities

                    Try
                        For Each benE In db.tblBenutzer.ToList
                            If (benE.benBenutzername.Equals(pBen.strBenutzername) And benE.benPasswort.Equals(pBen.strPasswort)) Then
                                benE = ben
                            End If
                            Debug.Print("Benutzer zurückgegeben")
                        Next
                    Catch ex As Exception
                        benE = Nothing
                        Debug.Print("Exception aufgetreten.")
                    End Try


                    If benE IsNot Nothing Then
                        System.Web.HttpContext.Current.Session("Benutzername") = benE.benBenutzername.ToString()
                        System.Web.HttpContext.Current.Session("IstKoordinator") = benE.benIstKoordinator.ToString()
                        Return RedirectToAction("Startseite", "Home")

                    End If
                End Using
            Else Debug.Print("ModelState not valid.")
            End If
            Return View(pBen)
        End Function

    End Class
End Namespace