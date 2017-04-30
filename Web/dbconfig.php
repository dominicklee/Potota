<?php
//MySQLi Procedural

//Define MySQL credentials
$servername = "";
$username = "";
$password = "";
$dbname = "pototadb";

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
die("Connection failed: " . mysqli_connect_error());
}
