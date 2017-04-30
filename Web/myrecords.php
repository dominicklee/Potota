<?php

	error_reporting(E_ALL);
	ini_set('display_errors', '1');
	
//Connect to DB
include("dbconfig.php");
$rows = array();	//Create array for final list of sensor elements
$allParams = array();	//Create array for final list of sensors params
$sensorIDs = array();	//Create array for final list of sensorIDs
		
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


/**
* List Sensors Method
* Desc: Method that returns a list of (sensorIDs with parameters) for a particular gateway
* 
* Inputs: atewayID
* Outputs: JSON formatted sensors list
*/
function listSensors($gatewayID)
{
	$gatewayID = sanitizeString($gatewayID);
	
		//Prepare query to list all sensors
		global $conn;
		$sql = "SELECT * FROM pt_sensors WHERE gatewayID='$gatewayID'";	//List all sensors
		$result = mysqli_query($conn,$sql);
		
		//$rows = array();	//Create array for final list of sensors
		$numCharts = 0;		//start counting charts to make
		
		while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC))
		{
			$dataFormat = $row['dataFormat'];
			$dataPieces = explode(",", $dataFormat);
			foreach ($dataPieces as &$dataParam) {
				//update array
				global $rows;
				global $allParams;
				global $sensorIDs;
				$sensorName = str_replace(' ', '', $row['sensorID']."_".$dataParam);
				array_push($rows, $sensorName);
				array_push($allParams, $dataParam);
				array_push($sensorIDs, $row['sensorID']);
				$numCharts++;
			}
			unset($dataParam);	//unset after for loop
		}
		mysqli_close($conn);	//Close MySQL connection
		
		/*
		//List each sensorElement
		foreach ($rows as &$sensorElements)
		{
			echo $sensorElements . ",";
		}
		*/
}

//Handle API inputs here
if (isset($_GET['gatewayid']))
{
	$gatewayID = $_GET['gatewayid'];
	//Get list of sensorparameters associated with gatewayID
	listSensors($gatewayID);
	
	
}
else
{
	$sensorID = "";
	$msg = "";
	echo "Wrong parameters";
	exit;
}

?>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
	<script src="https://code.jquery.com/jquery-latest.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.matchHeight/0.7.2/jquery.matchHeight-min.js" type="text/javascript"></script>
	<script src="node_modules/socket.io-client/dist/socket.io.js"></script>

    <title>Zeblok Realtime Chart</title>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
	<link rel="stylesheet" type="text/css" href="//fonts.googleapis.com/css?family=Lato" />
	<link rel="stylesheet" type="text/css" href="bootstrap-custom.css" />
	<script type='text/javascript' src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.1.0/Chart.min.js'></script>
	<style>
	.cont {
	  width: 100%;
	  margin: 10px;
	}

	.p {
	  text-align: center;
	  font-size: 14px;
	  padding-top: 140px;
	}
	
	h3 {
		color: #FFFFFF;
		font-family: Lato;
		font-size: 18px;
		font-style: normal;
		font-variant: normal;
		font-weight: 500;
		line-height: 15.4px;
		padding-left: 20px;
	}

	h1 {
		font-family: Lato;
		font-size: 48px;
		font-style: normal;
		font-variant: normal;
		font-weight: 650;
		line-height: 26.4px;
		color: #FFFFFF;
	}
	</style>
	
	<script>
		//Parse JSON to string
		function ParseJson(jsondata) {
			try {
				return JSON.parse(jsondata);
			} catch (error) {
				return null;
			}
		}

		var socket = io.connect('http://'+window.location.hostname+':3000');
			
		socket.on('welcome', function(data) {
			$('#messages').append('<li>' + data.message + '</li>');

			socket.emit('atime', {data: 'foo!'});
		});

		socket.on('toPC', function(data) {
			//Parse incoming data

			var jsonStr = JSON.stringify(data);
			var parsed = ParseJson(jsonStr);
			
			var sensorData = parsed.msg
			var parsedMsg = ParseJson(sensorData);
			
			<?php
			for ($i = 0; $i < count($rows); $i++)
			{
				echo "if (parsed.sensorID == \"" . $sensorIDs[$i] . "\")\n";
				echo "{\n";
				
				echo "    if (parsedMsg." . $allParams[$i] . " != null)\n";
				echo "    {\n";
				//echo "		alert(parsedMsg." . $allParams[$i] . "); \n";
				echo "        updateSensor" . $i . "(parsedMsg." . $allParams[$i] . ");\n";
				echo "    }\n";
				
				echo "}\n\n";
			}
			?>
			
		});
	
		socket.on('error', function() { console.error(arguments) });
		socket.on('message', function() { console.log(arguments) });
	</script>
</head>

<body style="background-color:#02020f;">

	
	<?php
		$ind = 0;
		$colorSel = 0;	//color selected index
		//List each sensorElement
		foreach ($rows as &$sensorElements)
		{
			echo "<div class=\"col-xs-10 match\"> <div class=\"ppanel\" style=\"margin-bottom: 20px;\">";
			echo "<h3>" . $sensorElements . "</h3>";
			echo "<div class=\"zpanel\"><div class=\"cont\">\n";
			echo "<canvas id=\"sensor" . $ind . "\" height=\"70%\"></canvas>\n";
			echo "</div></div>";
			echo "</div>\n";
			//Select colors in order (red, orange, yellow, green, cyan, pink, white) - 7 colors
			$colors = array("rgba(230, 230, 230, 1)", "rgba(255, 0, 220, 1)", "rgba(0, 200, 255, 1)", "rgba(76, 255, 0, 1)", "rgba(255, 216, 0, 1)", "rgba(255, 106, 0, 1)", "rgba(255, 0, 0, 1)");
			
			echo "</div><div class=\"col-xs-2 match\" style=\"text-align: center;padding-top:65px;\"><h1 id=\"lblSensor" . $ind . "\" style=\"color:".$colors[$colorSel]."\">0</h1></div>\n";
			echo "		\n";
			if ($colorSel < 6)
			{
				$colorSel++;
			}
			else
			{
				$colorSel = 0;
			}

			
			$ind++;
		}
		
		echo "		<script>";	//moving on to JS
		
		//globals for chart
		echo "\n";
		echo "var maxItems = 15;\n";
		echo "var dData = function() {\n";
		echo "  return Math.round(Math.random() * 90) + 10\n";
		echo "};\n";
		echo "\n";

		$ind = 0;	//reset index
		$colorSel = 0;	//color selected index
		//List each sensorElement
		foreach ($rows as &$sensorElements)
		{
			//chart specific
			echo "var index" . $ind . " = 1;\n";
			echo "var ctx = document.getElementById('sensor" . $ind . "').getContext('2d');\n";
			echo "  var sensor" . $ind . " = new Chart(ctx, {\n";
			echo "    type: 'line',\n";
			echo "	responsive: true,\n";
			echo "	barValueSpacing: 2,\n";
			echo "    data: {\n";
			echo "	labels: [\"1\", \"2\", \"3\", \"4\", \"5\", \"6\", \"7\", \"8\", \"9\", \"10\", \"11\", \"12\", \"13\", \"14\", \"15\"],\n";
			echo "	datasets: [{\n";
			echo "    label: \"\",\n";
			echo "	lineTension: 0.3,\n";
			echo "	fill: false,\n";
			echo "    backgroundColor: \"rgba(3, 118, 195, 0.4)\",\n";
			
			//Select colors in order (red, orange, yellow, green, cyan, pink, white) - 7 colors
			$colors = array("rgba(240, 240, 240, 1)", "rgba(255, 0, 220, 1)", "rgba(0, 200, 255, 1)", "rgba(76, 255, 0, 1)", "rgba(255, 216, 0, 1)", "rgba(255, 106, 0, 1)", "rgba(255, 0, 0, 1)");
			
			echo "    borderColor: \"" . $colors[$colorSel] . "\",\n";
			if ($colorSel < 6)
			{
				$colorSel++;
			}
			else
			{
				$colorSel = 0;
			}
			
			echo "    fillColor: \"rgba(0,160,14,0.6)\",\n";
			echo "    strokeColor: \"white\",\n";
			echo "    data: [0]\n";
			echo "	}]\n";
			echo "	},\n";
			echo "	options: {\n";
			echo "		\n";
			echo "		animation: {\n";
			echo "                    duration: 0,\n";
			echo "					easing: \"linear\"\n";
			echo "                },\n";
			echo "		\n";
			echo "		legend:{\n";
			echo "			   display:false\n";
			echo "		},  \n";
			echo "\n";
			echo "		scales: {\n";
			echo "			yAxes: [{\n";
			echo "			  ticks: {\n";
			echo "				suggestedMin: 0,\n";
			echo "				suggestedMax: 30,\n";
			echo "			  },\n";
			echo "			  gridLines: { show: true, color: \"rgba(0,25,50,0.3)\", }\n";
			echo "			}],\n";
			echo "			xAxes: [{\n";
			echo "			  ticks: {\n";
			echo "				suggestedMin: 0,\n";
			echo "				suggestedMax: 100,\n";
			echo "			  },\n";
			echo "			  gridLines: { show: true, color: \"rgba(0,25,50,0.3)\", }\n";
			echo "			}]\n";
			echo "		 }\n";
			echo "    }\n";
			echo "  });\n";
			echo "\n";
			echo "function updateSensor" . $ind . "(value) {\n";
			echo "	//Update label and populate chart\n";
			echo "  document.getElementById(\"lblSensor" . $ind . "\").innerHTML = value;";
			echo "	var data = sensor" . $ind . ".data.datasets[0].data;\n";
			echo "	data.push(value);    // add the new value to the right\n";
			echo "	\n";
			echo "	if (index" . $ind . " > (maxItems - 1))\n";
			echo "	{\n";
			echo "		data.shift();        // remove the first left value\n";
			echo "	}\n";
			echo "	index" . $ind . "++;\n";
			echo "	sensor" . $ind . ".update();\n";
			echo "}\n";
			
			$ind++;
		}	//end of for loop iteration
		echo "</script>";
	?>
	
	<script>
		$(function() {
			$('.match').matchHeight();
		});
	
	</script>
</body>
</html>
