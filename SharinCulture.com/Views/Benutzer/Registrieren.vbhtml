<!DOCTYPE html>

<head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>SharingCulture - Startseite</title>
        <link rel="stylesheet" type="text/css" href="~/Content/CSS.css" />


   

    <!--Kleines Script um direkt Alter anzuzeigen nachdem das Dgeburtsdatum angegeben wurde-->
    <script type="text/javascript">

        function getAge() {
            var dob = document.getElementById('date').value;
            dob = new Date(dob);
            var today = new Date();
            var age = Math.floor((today - dob) / (365.25 * 24 * 60 * 60 * 1000));
            document.getElementById('age').value = age;
        }

    </script>
</head>
<body class="centertext">
    <img src="../Bilder/SharingCulture-Motiv.png" alt="Logo" style="width:50%" />

    <p class="centertext">
        <h1 class="centertext">Registrieren</h1>
    </p>
    <p>
        Anrede:
        <select name="cmbAnrede">
            <option value="0">Männlich</option>
            <option value="1">Weiblich</option>
            <option value="2">Divers</option>
        </select>
    </p>
    <p>
        Vorname:
        <input value="" type="text" />
    </p>
    <p>
        Nachname:
        <input value="" type="text" />
    </p>
    <p>
        Benutzername:
        <input value="" type="text" />
    </p>
    <p>
        Geburtsdatum:
        <!--<input value="" type="date" data-date-inline-picker="true"/>-->
        <input type="text" value="" id="date" name="dob" onblur="getAge();" placeholder="JJJJ-MM-TT" />
        <!--Zeigt Alter als Zahl an! ACHTUNG wegen der Hilfsfunktion muss man das AMERIKANISCHE DATUMSFORMAT nehmen!-->
        <input type="text" id="age" name="age" value="" class="form-control" placeholder="Age" readonly="readonly" />
    </p>
    <p>
        Telefonnummer:
        <input value="" style="position:center" type="tel" />
    </p>
    <p>
        E-Mail:
        <input value="" style="position:center" type="email" />
    </p>
    <p>
        Passwort:
        <input style="position:center" type="password" />
    </p>
    <p>
        <!-- Abbrechen führt zurück zur Anmeldungsseite-->
        <input type="button" value="Abbrechen" />
        <input type="submit" value="Bestätigen" />
    </p>
</body>
