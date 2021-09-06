@Modeltype SharingCulture.com.BenutzerViewModel

@Code
    ViewData("Title") = "Startseite"
End Code


<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>SharingCulture - Startseite</title>
    <link rel="stylesheet" type="text/css" href="~/Content/CSS.css" />


</head>

<body class="body">


    <div class="jumbotron">
        <h1>SharingCulture.com</h1>
        <p class="lead" style="text-align:center;">Die bewusste Art zu teilen.</p>

    </div>

    <div>
        <p class="AnmeldeMenue" style="font-size: 30px; color:black; font-weight:900; ">Hallo, Leo!</p> <!--Wie fügt man hier noch den passenden Benutzernamen ein? (LS 13.08.)-->
        <br />

        <p class="AnmeldeMenueInhalt">

            <!--<a href="Meldungen.html">Meldungen</a>-->
            <input name="btnMeldungen" type="button" value="Meldungen" class="btnAuswahl" title="Klicke hier um dir aktuelle Meldungen anzusehen" />
            <br />

            <!--<a href="MeineGegenstände.html">Meine Gegenständen</a>-->
            <input name="btnMeineGegenstände" class="btnAuswahl" type="button" value="Meine Gegenstände" title="Klicke hier um dir deine aktuell angebotenen Gegenstände anzusehen" />
            <br />

            <!--<a href="frmGelieheneGegenstände.html">Aktuell geliehene Gegenstände</a>-->
            <input name="btnGelieheneGegenstände" class="btnAuswahl" type="button" value="Geliehene Gegenstände" title="Klicke hier um dir deine aktuell ausgeliehenen Gegenstände anzusehen" />
            <br />

             @Html.ActionLink("Gegenstand", "UebersichtAlleGegenstaende")

            <br />
        </p>
    </div>
</body>