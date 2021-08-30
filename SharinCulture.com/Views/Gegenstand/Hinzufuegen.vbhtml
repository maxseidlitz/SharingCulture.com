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
    <div class="items">



        <form accept-charset="UTF-8" action="action_page.php" autocomplete="off" method="GET" target="_blank">
            <fieldset>
                <legend><h1>Neues Angebot erstellen</h1></legend>

                <label for="name"><h3>Name</h3></label>
                <input name="name" type="text" value="" />

                <label for="vorname"><h3>Vorname</h3></label>
                <input vorname="vorname" type="text" value="" />

                <label for="bezeichnung"><h3>Bezeichnung</h3></label>
                <input vorname="bezeichnung" type="text" value="" /> <br />

                <label for="kategorie"><h3>Kategorie</h3></label>
                <select>
                    <option selected="selected" value="1">Keine</option>
                    <option value="10">Raum</option>
                    <option value="2">Küchenutensilien</option>
                    <option value="3">Garten</option>
                    <option value="1">Werkzeug</option>
                    <option value="5">Haushalt</option>
                    <option value="6">Auto, Rad & Boot</option>
                    <option value="7">Dienstleistungen</option>
                    <option value="8">Familie, Kind & Baby</option>
                    <option value="9">Jobs</option>
                    <option value="11">Mode & Beauty</option>
                    <option value="12">Elektronik</option>
                    <option value="13">Musik, Filme & Bücher</option>
                    <option value="14">Nachbarschaftshilfe</option>
                </select><br />


                <label for="ergänzenderText"><h3>Ergänzender Text:</h3></label>
                <textarea cols="30" rows="2">Hallo, ich biete...</textarea><br />

                <label for="zeitraum"><h3>Anbietungszeitraum:</h3></label>
                <div class="anfangsdatum">
                    <label for="anfangsdatum">Von:</label>
                    <input type="date" id="date" value="2018-07-03">
                    <span></span>
                    <input type="time" id="time" value="08:00">
                </div>
                <div class="enndatum">
                    <label for="endatum">Bis:</label>
                    <input type="date" id="date" value="2018-07-03">
                    <span></span>
                    <input type="time" id="time" value="08:00">
                </div>

                <br />

                <div>
                    <form method="post" enctype="multipart/form-data">
                        <label>
                            <h3>
                                Bild hinzufügen:
                                <input name="bilddatei" type="image" size="50">
                            </h3>
                        </label>
                        <button>Durchsuchen...</button>
                    </form>
                </div>

                <br />
                <button type="submit" value="Submit" style="width: 125px; height: 50px;">Angebot speichern</button>


            </fieldset>
        </form>

</div>
</body>
</html>
