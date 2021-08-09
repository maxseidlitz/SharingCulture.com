Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return RedirectToAction("Index", "Benutzer")
    End Function

End Class
