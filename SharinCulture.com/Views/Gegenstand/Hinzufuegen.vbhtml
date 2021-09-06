@ModelType SharingCulture.com.GegenstandViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/CSS.css" type="text/css" />
    <title>Gegenstand hinzufügen</title>
</head>
<body>
    <!--Linker Block für die Navigation
    div class "Primärnavigation"-->

    <div>
        <h1>Neuen Gegenstand hinzufügen</h1>
        <p>Hier können Sie einen neuen Gegenstand hinzufügen.</p>

        @Using Html.BeginForm
            @<div>
                @Html.HiddenFor(Function(m) Model.Gegenstand.intID)
            </div>
            @<div>
                <!--Bezeichnung des Gegenstands-->
                @Html.LabelFor(Function(m) Model.Gegenstand.strBezeichnung)
                @Html.TextBoxFor(Function(m) Model.Gegenstand.strBezeichnung)
                @Html.ValidationMessageFor(Function(m) Model.Gegenstand.strBezeichnung)
            </div>
             @<div>
                 <!--Kategorie des Gegenstandes-->
                @Html.LabelFor(Function(m) Model.Gegenstand.Kategorie.strBezeichnung)
                @Html.DropDownListFor(Function(m) Model.Gegenstand.Kategorie.intID, New SelectList(Model.KategorienAlle, "ID", "Bezeichnung"))
                @Html.ValidationMessageFor(Function(m) Model.Gegenstand.Kategorie.strBezeichnung)
            </div>
            @<div>
                <!-- Link zum Abbrechen, d.h. zur Navigation zur frmUebersichtAlleGegenstaende-Seite und Schaltfläche zum Absenden des Formulars -->
                @Html.ActionLink("Abbrechen", "Index")
                <input type="submit" value="Speichern" />
            </div>
        End Using
    </div>
</body>
</html>