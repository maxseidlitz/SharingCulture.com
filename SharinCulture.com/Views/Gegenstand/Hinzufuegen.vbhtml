@ModelType SharingCulture.com.GegenstandViewModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Hinzufuegen</title>
</head>
<body>
    <!--Linker Block für die Navigation
    div class "Primärnavigation"-->
    <div>
        <h1>Navigation</h1>
    </div>

    <div Class="Primärnavigation">
        <img src="../Bilder/typ.jpg" style="float:left;width:10%" />

        <Label style="text-align: left"> Name, Vorname :   </Label> <br />
        <input type="text" value="Dent, Arthur" /> <br />
        <Label> Community :   </Label> <br />
        <input type="text" value="Studiwohnheim Prenzlberg" />

        <Button type="button"> Startseite</Button> <br />
        <Button type="button"> Alle verfügbaren Gegenstände</Button> <br />
        <Button type="button"> Meine geliehenen Gegenstände</Button> <br />
        <Button type="button"> Meine angebotenen Gegenstände</Button> <br />
        <Button type="button"> Meldungen</Button> <br />
    </div>

    <div>
        <h1>Hier Neuen Gegenstand hinzufügen</h1>
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
                <!--Kategorie des Ggenstandes-->
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
