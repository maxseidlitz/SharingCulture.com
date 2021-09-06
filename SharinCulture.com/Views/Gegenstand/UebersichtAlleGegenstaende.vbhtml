@ModelType SharingCulture.com.GegenstaendeListe

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/CSS.css" type="text/css" />
    <title>Übersicht alle Gegenstände</title>
</head>
<body>

    <!-- Tabpanel zur Navigation, ist jetzt in die Navbar integriert. Siehe "../Views/Shared/_Layout.vbhtml", hier wurde alles deklariert. (aktuell Zeile 22 ff.)-->

    <h1>Übersicht aller Gegenstände</h1>
    <p>Hier sehen Sie alle ausleihbaren Gegenstände.</p>
    <!-- Link zum Hinzufügen von neuem Gegenstand-->
    @Html.ActionLink("Hinzufügen", "Hinzufuegen")
    <table class="tblAlleGegenstaende">
        <tr>
            <th>ID</th>
            <th>Bild</th>
            <th>Bezeichnung</th>
            <th>Kategorie</th>
            <th>Eigentümer</th>
            <th>Details</th>
        </tr>

        @For Each geg In Model.Gegenstaende
            @<tr>
                <td>@geg.ID</td>
                <td>@geg.Bild</td>
                <td>@geg.Bezeichnung</td>
                <td>@geg.Kategorie</td>
                <td>@geg.Benutzername</td>
                <td>
                    @Html.ActionLink("Details", "Details", New With {.ID = geg.ID})
                </td>
            </tr>
        Next
    </table>

</body>
</html>
