<?php
	include_once 'databaseConnection.inc.php';
	
	$tag = mysqli_real_escape_string($conn, $_POST['tag']) ;
	
	echo $tag ;
	
	$sql = "select * from form where tag = ? ;";
	$stmt = mysqli_stmt_init($conn);
	
	if(!mysqli_stmt_prepare($stmt, $sql)){
		echo "sql error" ;
	}else{
		mysqli_stmt_bind_param($sql,"s", $tag) ;
		mysqli_stmt_execute($stmt) ;
		
		$result = $stmt->get_result();
        while ($row = mysqli_fetch_assoc($result))
        {
			echo $row['id'] ;
        }
	}
	
	header("Location: ../form.php?formdata=success");
	//header("Location: ../form.php?formdata.inc.php=success");
?>