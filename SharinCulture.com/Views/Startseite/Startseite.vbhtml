﻿@Code
    ViewData("Title") = "Startseite"
End Code

<div class="jumbotron">
    <h1>SharingCultrue.com</h1>
    <p class="lead">Die bewusste Art zu teilen.</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

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
