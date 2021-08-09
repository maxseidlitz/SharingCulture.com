﻿@ModelType SharingCulture.com.GegenstandViewModel

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


        <!--Linker Block für die Navigation
        div class "Primaernavigation"-->
        <div>
            <h1>Navigation</h1>
        </div>

        <div class="Primaernavigation">
            <img src="../Content/Bilder/typ.jpg" style="float:left;width:10%" />

            <label style="text-align: left">Name, Vorname:</label> <br />
            <input type="text" value="Dent, Arthur" /> <br />
            <label>Community:</label> <br />
            <input type="text" value="Studiwohnheim Prenzlberg" /> <br />


            <button type="button">Startseite</button> <br />
            <button type="button">Alle verfügbaren Gegenstände</button> <br />
            <button type="button">Meine geliehenen Gegenstände</button> <br />
            <button type="button">Meine angebotenen Gegenstände</button> <br />
            <button type="button">Meldungen</button> <br />
        </div>


        <!-- Tabpanel zur Navigation-->
        <p>
            <a href="frmÜbersichtAlleGegenstände.html">Ausleihbare Gegenstände</a>
            <a href="frmNeuesAngebot.html">Neues Angebot erstellen</a>
            <a href="frmNeuerSuchauftrag.html">Neuen Suchauftrag anlegen</a>
        </p>

        <div class="items">

            <!--TODO: hier ist noch einige Verweise so, dass sie auf Websites verweisen (../Webseiten/xyz.html). 
                Diese Verweise müssen mit HTML-Helpern ausgestattet werden.-->

            <p id="item1">
                <!--Oberer Block mit Titel, Suchleiste und Neuerstellung-->
                <div class="topnav">
                    <form>
                        <input type="text" placeholder="Search..">
                        <input type="checkbox" id=gegenstaende name=gegenstaende value="Gegenstände">
                        <label for=gegenstaende>Gegenstände</label>
                        <input type="checkbox" id=raeume name=raeume value="Räume">
                        <label for=raeume>Räume</label>
                        <br />
                    </form>
                </div>

                <!-- NEUE TABELLE
                Die eingefügten Gegenstände dienen vorerst als Platzhalter und sollen nachher durch eine Eingabe ersetzt werden
                L.S. 16.05.2021 18 Uhr-->
                <!--Ab hier sind Beipsieldaten eingetragen! 30.6.21; Max Seidlitz -->
                <!--Hier müssen dann mit HTML-Helpern die Daten aus der DB gelesen werden.-->
                <table class="tblAlleGegenstaende">
                    <thead>
                        <tr>
                            <th>Bild</th>
                            <th>Bezeichnung</th>
                            <th>Kategorie</th>
                            <th>Leihende Person</th>
                            <th>Details</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <td colspan="5">
                                <div class="links">
                                    <a href="#">&laquo;</a> <a class="active" href="#">1</a> <a href="#">2</a> <a href="#">3</a> <a href="#">4</a> <a href="#">&raquo;</a>
                                </div>
                            </td>
                        </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td><img src="../Content/Bilder/schaufel.jpg" style="float:left;width: 240px;" /></td>
                            <td>Schaufel</td>
                            <td>Garten</td>
                            <td>Leonard Sinden</td>
                            <td><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                        </tr>
                        <tr>
                            <td><img src="../Content/Bilder/Akkuschrauber.jpg" style="float:left;width: 240px;" /></td>
                            <td>Akkuschrauber</td>
                            <td>Werkzeug</td>
                            <td>Max Seidlitz</td>
                            <td><a href="../Webseiten/dlgBeispielDialog.html"><button type="button" style="width: 200px; height: 100px;">Details</button></a></td>
                        </tr>
                        <tr>
                            <td><img src="../Content/Bilder/kaffemühle.jpg" style="float:left;width: 240px;" /></td>
                            <td>Kaffeemühle</td>
                            <td>Küchenutensilien</td>
                            <td>Carolina Kowando</td>
                            <td><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                        </tr>
                        <tr>
                            <td><img src="../Content/Bilder/vacuum-24229_1280.png" style="float:left;width: 240px;"</td>
                            <td>Staubsauger</td>
                            <td>Haushalt</td>
                            <td>Alexandra Bendzko</td>
                            <td><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                        </tr>
                        <tr>
                            <td><img src="../Content/Bilder/lastenfahrrad.jpg" style="float:left;width:240px"></td>
                            <td>Lastenfahrrad</td>
                            <td>Mobilität</td>
                            <td>Leonard Sinden</td>
                            <td><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                        </tr>
                    </tbody>
                    </tr>
                </table>

                <!-- Alte Tabelle Auskommentiert
           <p>
            <table style="width:100%", class=t1>
                <tr>
                  <th>Bild</th>
                  <th>Beschreibung</th>
                  <th>Kategorie</th>
                  <th>Leihende Person</th>
                  <th> </th>
                </tr>
                <tr>
                  <td style="height: 240px; width: 240px;"><img src="../Bilder/schaufel.jpg" style="float:left;width: 240px;" /></td>
                  <td>Schaufel</td>
                  <td>Haushalts- und gartengegenstände</td>
                  <td>Leonard Sinden</td>
                  <td style="height: 200px; width: 100px"><button type="button" style="width: 200px; height: 100px;">Details</button></td>

                </tr>

                <tr>
                  <td style="height: 240px; width: 240px;"><img src="../Bilder/Akkuschrauber.jpg" style="float:left;width: 240px;" /></td>
                  <td>Akkuschrauber</td>
                  <td>Werkzeug</td>
                  <td>Max Seidlitz</td>
                  <td style="height: 200px; width: 100px"><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                </tr>

                <tr>
                    <td style="height: 240px; width: 240px;"><img src="../Bilder/kaffemühle.jpg" style="float:left;width: 240px;" /></td>
                    <td>Kaffeemühle</td>
                    <td>Küchenutensilien</td>
                    <td>Carolina Kowando</td>
                    <td style="height: 200px; width: 100px"><button type="button" style="width: 200px; height: 100px;">Details</button></td>
                </tr>
              </table>
           </p>
        -->



            </p>



        </div>



    </body>
</html>