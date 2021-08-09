Imports System.Web.Mvc

Namespace Controllers
    Public Class BenutzerController
        Inherits Controller

        ' GET: Benutzer
        Function Anmeldung() As ActionResult
            Return View()
        End Function
    End Class
End Namespace