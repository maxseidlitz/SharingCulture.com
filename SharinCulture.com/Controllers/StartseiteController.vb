Imports System.Web.Mvc

Namespace Controllers
    Public Class StartseiteController
        Inherits System.Web.Mvc.Controller

        ' GET: Startseite
        Function Startseite() As ActionResult
            Return View()
        End Function

        Function Test() As ActionResult
            Return View()
        End Function

    End Class
End Namespace