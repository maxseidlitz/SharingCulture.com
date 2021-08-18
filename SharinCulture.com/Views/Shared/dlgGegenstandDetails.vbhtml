<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>SharingCulture - Startseite</title>
    <link rel="stylesheet" type="text/css" href="~/Content/CSS.css" />
</head>
<body>
    
        <h2>Details</h2>
        <form style="width: 10cm;">
            <p>
                <img src="~/Content/Bilder/Akkuschrauber.jpg" style="float: left; width:50%" />
            </p>

            <p>
                <label for="bezeichnung">Gegenstand Bezeichnung: </label><input id="bezeichnung" type="text" /> <br />
            </p>
            <p>
                <label for="kategorie">Kategorie: </label><input id="kategorie" type="text" /> <br />
            </p>
            <p>
                <label for="ausleihendeperson">Ausleihende Person: </label><input id="ausleihendeperson" type="text" /> <br />
            </p>
        </form>
        <div class="timeline">
            <div class="container left">
                <div class="content">
                    <h3>Ausgeliehen am:</h3>
                    <p>Lorem ipsum..</p>
                </div>
            </div>
            <div class="container right">
                <div class="content">
                    <h3>Rückgabe bis</h3>
                    <p>Lorem ipsum..</p>
                </div>
            </div>
        </div>

        <button type="button">Zurück</button>
        <button type="button" style="width: 100px; height: 50px; float: right">Anbieter kontaktieren</button>
        <button type="button" style="width: 100px; height: 50px; float: right">Ausborgen</button>

    
</body>
</html>