Imports System.Web.Mvc

Namespace Controllers
    Public Class GegenstandController
        Inherits System.Web.Mvc.Controller

        ' GET: Gegenstand
        Function UebersichtAlleGegenstaende() As ActionResult
            Dim vmGegenstaendeListe As GegenstaendeListe
            Return View(vmGegenstaendeListe)                    'Übergabe der Liste aller Gegenstände, damit diese dann in der View per Zäherschleife ausgelesen werden kann
        End Function

    End Class
End Namespace