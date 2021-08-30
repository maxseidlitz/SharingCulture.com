Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return RedirectToAction("Anmeldung", "Benutzer")
    End Function

    Function Startseite() As ActionResult
        Return View()
    End Function


End Class