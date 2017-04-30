<?php
//Connect to DB
include("dbconfig.php");

/**
* Sanitize Method
* Desc: Method that prevents injection and data hijack
* 
* Inputs: Any string variable
* Outputs: String variable
*/
function sanitizeString($str)
{
	// To protect MySQL injection
	$sanitizeString = trim($str);
	$sanitizeString = strip_tags($sanitizeString);
	$sanitizeString = htmlspecialchars($sanitizeString);
	return $sanitizeString;
}

if ($_GET['apikey'] == "1234")
{
	$auth = 1;
}
else
{
	$auth = 0;
}


?>
<!doctype html>
<html>
    <head>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
	<script src="http://code.jquery.com/jquery-latest.min.js"></script>
	<!--<script src="/socket.io/socket.io.js"></script>-->
	<script src="node_modules/socket.io-client/dist/socket.io.js"></script>

        <script>

            var socket = io.connect('http://'+window.location.hostname+':3000');
			$(document).ready(function(){

            })
			
			<?php
			
				if ($auth == 1)
				{
					echo "			function sendEvent(sensorID, msg) {\n";
					echo "				if (sensorID != \"\" && msg != \"\")\n";
					echo "				{\n";
					echo "					socket.emit('globalSensorStream', { sensorID : sensorID, msg : msg });\n";
					echo "				}\n";
					echo "			}";
				}
			
			?>
		
            socket.on('error', function() { console.error(arguments) });
            socket.on('message', function() { console.log(arguments) });
        </script>
    </head>
    <body>

    </body>
</html>
