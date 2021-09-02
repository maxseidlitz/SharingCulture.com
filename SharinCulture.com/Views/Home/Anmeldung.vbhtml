@ModelType SharingCulture.com.Benutzer

@Code
    Layout = Nothing
    ViewBag.Title = "Anmeldung"
End Code

<!DOCTYPE html>

<html>
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

    <form method="get" action="Anmeldung.html" class="p">
        <!--Formular für die Anmeldung-->
        <h1 class="centertext" style="font-size: 70px; color:limegreen">Anmeldung</h1>

        <!--HTML Helper Try1-->
        @Using Html.BeginForm("Anmeldung", "Benutzer", FormMethod.Post)
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(True)

            @<div>
                @Html.LabelFor(Function(m) m.strBenutzername, New With {.class = "control-label"})
                @Html.TextBoxFor(Function(m) m.strBenutzername, New With {.class = "form-control password"})
                @Html.ValidationMessageFor(Function(m) m.strBenutzername)
            </div>
            @<div>
                @Html.LabelFor(Function(m) m.strPasswort, New With {.Class = "control-label"})
                @Html.TextBoxFor(Function(m) m.strPasswort, New With {.class = "form-control", .type = "password"})
                @Html.ValidationMessageFor(Function(m) m.strPasswort)
            </div>
            @<div>
                <input type="submit" name="btnBestätigen" value="Bestätigen" style="font-size:20px" />
            </div>
            @<div>
                <p>Noch kein Mitglied? Registrieren Sie sich jetzt kostenlos!</p>
                @Html.ActionLink("Registrieren", "Benutzer", Nothing, New With {.class = "btn btn-default", .role = "button"})
            </div>
        End Using
        <!--Ende HTML Helper Try1-->
        <input type="text" autofocus style="font-size:20px" />
        <p><b style="font-size:40px">Passwort: </b></p>
        <input type="password" style="font-size:20px" />

        <p>
            <input type="button" name="btnAbbrechen" value="Abbrechen" style="font-size:20px" />
        </p>
    </form>
</body>
</html>