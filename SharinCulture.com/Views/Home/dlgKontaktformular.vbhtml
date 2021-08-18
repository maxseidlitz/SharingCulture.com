@Code
    ViewData("Title") = "Contact"
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

    <div class="container">
        <form action="action_page.php">

            <label for="fname">First Name</label>
            <input type="text" id="fname" name="firstname" placeholder="Your name..">

            <label for="lname">Last Name</label>
            <input type="text" id="lname" name="lastname" placeholder="Your last name..">

            <label for="country">Country</label>
            <select id="country" name="country">
                <option value="australia">Australia</option>
                <option value="canada">Canada</option>
                <option value="usa">USA</option>
            </select>

            <label for="subject">Subject</label>
            <textarea id="subject" name="subject" placeholder="Write something.." style="height:200px"></textarea>

            <input type="submit" value="Submit">

        </form>
    </div>


    </body>