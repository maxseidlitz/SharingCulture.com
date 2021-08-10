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
    <h1>Übersicht aller Gegenstände</h1>
    <p>hier sehen Sie alle verfügbaren Gegenstände.</p>
<table>    
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
