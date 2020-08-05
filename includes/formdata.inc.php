<?php
	include_once 'databaseConnection.inc.php';
	
	$tag = mysqli_real_escape_string($conn, $_POST['tag']) ;
	$sql = "select * from form where tag = '$tag' ;";
	
	$result = $conn->query($sql) ;
	
	echo x ;
	while($row = $result->fetch_assoc()){
		echo $row["id"] ;
		echo $row["name"] ;
		echo $row["tag"] ;
		echo $row["information"] ;
	}

	header("Location: ../form.php?formdata=success");
	//header("Location: ../form.php?formdata.inc.php=success");
?>