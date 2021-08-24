@ModelType SharingCulture.com.GegenstaendeListe

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/CSS.css" type="text/css" />
    <title>Übersicht alle Gegenstände</title>
</head>
<body>

    <!-- Tabpanel zur Navigation-->
    <p>
        <a href="frmÜbersichtAlleGegenstände.html">Ausleihbare Gegenstände</a>
        <a href="frmNeuesAngebot.html">Neues Angebot erstellen</a>
        <a href="frmNeuerSuchauftrag.html">Neuen Suchauftrag anlegen</a>
    </p>

    <h1>Übersicht aller Gegenstände</h1>
    <p>Hier sehen Sie alle zur Ausleihe verfügbaren Gegenstände.</p>
    <!-- Link zum Hinzufügen von neuem Gegenstand-->
    @Html.ActionLink("Hinzufügen", "Hinzufuegen")
    <table class="tblAlleGegenstaende">
        <tr>
            <th>ID</th>
            <th>Bild</th>
            <th>Bezeichnung</th>
            <th>Kategorie</th>
            <th>Leihende Person</th>
            <th>Details</th>
        </tr>

        @For Each geg In Model.Gegenstaende
            @<tr>
                <td>@geg.intID</td>
                <td>@geg.binaryBild</td>
                <td>@geg.strBezeichnung</td>
                <td>@geg.Kategorie</td>
                <td>@geg.strBenutzername</td>
                <td>
                    @Html.ActionLink("Details", "DetailsAnzeigen", New With {.ID = geg.intID})
                </td>
            </tr>
        Next
    </table>
</body>
</html>
