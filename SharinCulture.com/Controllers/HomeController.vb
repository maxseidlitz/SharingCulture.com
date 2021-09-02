Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller
        ' GET: Home
        Function Index() As ActionResult
            Return RedirectToAction("Startseite", "Home")
        End Function

        Function Startseite() As ActionResult
            Return View()
        End Function

    End Class
End Namespace