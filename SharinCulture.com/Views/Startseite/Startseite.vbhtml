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
        <h1>SharingCultrue.com</h1>
        <p class="lead">Die bewusste Art zu teilen.</p>

    </div>

    <div>
        <p class="AnmeldeMenue" style="font-size: 30px; color:black; font-weight:900; ">Hallo, Leo!</p> <!--Wie fügt man hier noch den passenden Benutzernamen ein? (LS 13.08.)-->
        <br />

        <p class="AnmeldeMenueInhalt">

            <!--WIESO KRIEG ICH DIE BESCHRIFTUNG NICHT MITTIG BZW. LINKSBÜNDIG?-->
            <!--<a href="Meldungen.html">Meldungen</a>-->
            <input name="btnMeldungen" type="button" value="Meldungen" class="btnAuswahl" />
            <br />

            <!--Wie verweisen wir mit den Buttons auf die anderen Seiten? Bitte gemeinsame Session-->
            <!--<a href="MeineGegenstände.html">Meine Gegenständen</a>-->
            <input name="btnMeineGegenstände" class="btnAuswahl" type="button" value="Meine Gegenstände" />
            <br />

            <!--<a href="frmGelieheneGegenstände.html">Aktuell geliehene Gegenstände</a>-->
            <input name="btnGelieheneGegenstände" class="btnAuswahl" type="button" value="Geliehene Gegenstände" />
            <br />

        </p>
        <p>
            <img class="AnmeldeMenueBild" src="~/Content/Bilder/Berlin.gif" style="width:50%;">
        </p><!--WIE KRIEG ICH DAS SCHEISS BILD AUF DIE SELBE HÖHE WIE DEN RESTLICHEN SCHEISS?!?!?!?!?!!-->
    </div>
</body>