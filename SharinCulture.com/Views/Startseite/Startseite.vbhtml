@Code
    ViewData("Title") = "Startseite"

End Code

<!DOCTYPE html>
<html lang="de">

<head runat="server">
    <meta charset="utf-8" />
    <title>SharingCulture - Startseite</title>
    <link rel="stylesheet" type="text/css" href="CSS.css" media="screen" />
    <link rel="icon" href="https://cdn.dribbble.com/users/765531/screenshots/2679710/step-05-6-drib.gif">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <div class="centerdiv">
        <p style="font-size: 30px; color:yellowgreen;">Hallo, !</p>
        <table class="AnmeldeMenü">
            <tr>
                <!--hier übernimmt er die Klasse 'AnmeldeMenüInhalt' nicht mehr.... WARUM?-->
                <th>
                    <!--<a href="Meldungen.html">Meldungen</a>-->
                    <input name="btnMeldungen" class="AnmeldeMenüInhalt" type="button" value="Meldungen" />
                </th>
                <th>
                    <!--<a href="MeineGegenstände.html">Meine Gegenständen</a>-->
                    <input name="btnMeineGegenstände" class="AnmeldeMenüInhalt" type="button" value="Meine Gegenstände" />
                </th>
                <th>
                    <!--<a href="frmGelieheneGegenstände.html">Aktuell geliehene Gegenstände</a>-->
                    <input name="btnGelieheneGegenstände" class="AnmeldeMenüInhalt" type="button" value="Geliehene Gegenstände" />
                </th>
            </tr>
        </table>
    </div>
</body>
</html>
