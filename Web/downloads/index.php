<?php
	//error_reporting(E_ALL);
	//ini_set('display_errors', '1');
if(!empty($_GET['sensorid']))
{
  // check if user is logged in
  if( true )
  {
    $file_name = $_GET['sensorid'];
    //$fullPath = "{$_SERVER['DOCUMENT_ROOT']}/realtime/downloads/{$file_name}.csv";
$fullPath = "{$file_name}.csv";
echo $fullPath;
    if( file_exists( $fullPath ) )
    {
      header( 'Content-Description: File Transfer' );
      header('Content-Type: application/octet-stream');
      header( "Content-Disposition: attachment; filename={$fullPath}" );
	  header('Expires: 0');
	  header('Cache-Control: must-revalidate');
	  header('Pragma: public');
	  header('Content-Length: ' . filesize($fullPath));
	  readfile($fullPath);
	  //exit;
    }
  }
}
die( "ERROR: Invalid file or you don't have permissions to download it." );
?>