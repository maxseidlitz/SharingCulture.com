@ModelType SharingCulture.com.BenutzerListe


@Code
    Layout = Nothing
    ViewBag.Title = "Anmeldung"
End Code

<!DOCTYPE html>


<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>SharingCulture - Log In</title>
    <link rel="stylesheet" type="text/css" href="~/Content/CSS.css" />
    <!--Steuert das icon was im "Browser-Tab"(also Header)angezeigt wird!-->
    <link rel="icon" href="https://cdn.dribbble.com/users/765531/screenshots/2679710/step-05-6-drib.gif">
    <!--hier wird der Style für Bilder festgelegt; sorgt dafür, dass unser Logo mittig positioniert ist!-->

</head>

<body class="centertext">
    <!--Die Klasse .hintergrundbildAnmelden kann hier einen Muster-Hintergrund einfügen in grün-->
    <p>
        <!--hier wird auch auf CSS.css zugegriffen um die Style-Anpassung aus dem CSS mit dem class-Attribut auszulesen-->
        <img id="GifAnmeldung" src="https://cdn.dribbble.com/users/765531/screenshots/2679710/step-05-6-drib.gif" alt="Logo" class="centerblock" style="width:25%" />
        <!--<img  src="../Bilder/SharingCulture-Motiv.png" alt="Logo" class="center" style="width:100%"/> -->

    </p>

    <form method="get" action="Anmelden.html" class="p">
        <!--Formular für die Anmeldung-->
        <h1 class="centertext" style="font-size: 70px; color:limegreen">Anmeldung</h1>

        <!--HTML Helper Try1-->
        @Using Html.BeginForm
            @<div>
                <!-- Titel der Aufgabe -->
                @Html.LabelFor(Function(m) Model.Benutzer.strBenutzername)
                @Html.TextBoxFor(Function(m) Model.Benutzer.strBenutzername)
                @Html.ValidationMessageFor(Function(m) Model.Benutzer.strBenutzername)
            </div>

        End Using
        <!--Ende HTML Helper Try1-->
        <input type="text" autofocus style="font-size:20px" />
        <p><b style="font-size:40px">Passwort: </b></p>
        <input type="password" style="font-size:20px" />

        <p>
            <input type="submit" name="btnBestätigen" value="Bestätigen" style="font-size:20px" />
            <input type="button" name="btnAbbrechen" value="Abbrechen" style="font-size:20px" />
        </p>
        <div>
            <p style="font-size:20px; background-color:lightblue">Noch kein Mitglied? Hier kostenlos <a href="../Webseiten/frmRegistrieren.html" style="font-size:20px; color:limegreen; font-weight:bold">registrieren</a></p>

        </div>
    </form>
</body>
