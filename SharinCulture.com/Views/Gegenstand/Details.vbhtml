@ModelType SharingCulture.com.GegenstandViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/CSS.css" type="text/css" />
    <title>Gegenstand Details</title>

</head>
<body>
    <div>
        <h1>
            @Html.DisplayFor(Function(m) m.Gegenstand.strBezeichnung)
        </h1>
        <p style="font-style:italic;color: grey; text-align:right">
            Kategorie:
            @Html.DisplayFor(Function(m) m.Gegenstand.Kategorie.intID)
        </p>
    </div>

        <div>
            <p>
                Besitzer:
            </p>
            <p style="font-style:italic;color: grey;">
                @Html.DisplayFor(Function(m) m.Gegenstand.strBenutzername)
            </p>
          
           
        </div>
</body>
</html>
