<?php
$host = "localhost";  
      $user = "root";  
      $pass = "";  
      $database = "siolong";  
      $table = "users"; 
	  
      // Create connection
		$conn = new mysqli($host, $user, $pass, $database);
		// Check connection
		if ($conn->connect_error) {
			die("Connection failed: " . $conn->connect_error);
		}  

if (!empty($_POST['email'])) {
	# code...
	$email = $mysqli->real_escape_string($_POST['email']);
	$query = "SELECT id FROM users WHERE email {$email} LIMIT 1;";
	$result = $mysqli->query($query);
	if ($result->num_rows==0) {
		echo "true";
	}else{
		echo "false";
	}
}else{
	echo "invalid vallidation";
}



?>