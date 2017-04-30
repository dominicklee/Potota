var fs = require('fs');
var http = require('http');

//SocketIO server declarations
var util  = require('util');
var app = require('http').createServer(handler);
var io = require('socket.io')(app);
var fs = require('fs');

app.listen(3000);	//serve on port 3000


//NodeJS server defaults
function handler (req, res) {
  fs.readFile(__dirname + '/index.html',
  function (err, data) {
    if (err) {
      res.writeHead(500);
      return res.end('Error loading index.html');
    }

    res.writeHead(200);
    res.end(data);
  });
}


//Parse JSON to string
function ParseJson(jsondata) {
    try {
        return JSON.parse(jsondata);
    } catch (error) {
        return null;
    }
}

//Handle connection
io.sockets.on('connection', function (socket) {
	console.log("Connected");
  socket.emit('welcome', { message: 'Browser Connected !!!!' });
  socket.on('connection', function (data) {
    console.log(data);   });


//Show a global message to PC
socket.on('globalSensorStream', function (data) {
	//forward to PC graphs
	io.sockets.emit("toPC", data);
	/*
	//log data stream locally
	var jsonStr = JSON.stringify(data);
	var parsed = ParseJson(jsonStr);
	
	var sensorData = parsed.msg
	var parsedMsg = ParseJson(sensorData);
	
	var filePath = __dirname + "/downloads/" + parsed.sensorID + ".csv";	//get filename
	
	//Retrieve dataFormat header
	var keysResult = Object.keys(parsedMsg);
	var dataFormat = "timestamp,";
	for (var i = 0; i < keysResult.length; i++)
	{
		dataFormat += keysResult[i];
		if (i < keysResult.length - 1)
		{
			dataFormat += ",";
		}
	}
	dataFormat += "\r\n";
	//dataFormat retrieved
	
	//Retrieve data values line
	var valuesResult = Object.keys(parsedMsg).map(function(e) {
	  return parsedMsg[e]
	});
	
	var valueFormat = "";
	//Include timestamp
	var timeStamp = Math.floor(Date.now() / 1000);
	valueFormat += timeStamp.toString();
	valueFormat += ",";
	for (var i = 0; i < valuesResult.length; i++)
	{
		valueFormat += valuesResult[i];
		if (i < valuesResult.length - 1)
		{
			valueFormat += ",";
		}
	}
	valueFormat += "\r\n";
	//values retrieved
		
	if (fs.existsSync(filePath)) {
		//File exists already, just append.
		
		//Add current line of data
		fs.appendFile(filePath, valueFormat, function (err) {
		if (err) throw err;
		//console.log('Updated!');
		});
	}
	else
	{
		//File needs a header. 
		//Create file with header
		fs.appendFile(filePath, dataFormat, function (err) {
		if (err) throw err;
		//console.log('Saved!');
		});
	}
	*/
	
 });



});
