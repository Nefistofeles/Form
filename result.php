<html>
	<header>	
		<?php 
			include_once 'includes/htmlbasic.inc.php';
		?>
				
		<script>
			function validateForm() {
			  var x = document.forms["myForm"]["ename"].value;
			  if (x == "" || x == null) {
				alert("Lütfen e-mailinizi giriniz");
				return false;
			  }
			}
		</script>
	</header>
	<body style = "background: linear-gradient(to right, #ff6699 0%, #66ccff 100%);">
	<form method= "POST" action="index.php">
		<?php  
			$question_number1 = $_POST['question_number'] ;
			$form_id1 = 0;
			$form_id1= $_POST['form_id'] ;
			$email = $_POST['ename'] ;
			
			$result = 0 ;
			while($question_number1 > 1 ){
				if(!empty($_POST['id' . $question_number1])){
					$result += $_POST['id' . $question_number1];
					
				}
				$question_number1-- ;
			}
			include_once 'includes/databaseConnection.inc.php';
			$sql = "insert into result(id, e_mail, point, form_id) values(DEFAULT, '".$email."',".$result. ",".$form_id1.") ; ";
			$conn->query($sql) ;
			mysqli_close($conn) ;
			
			echo '<div style = " position : fixed ; top : 50% ; left : 50% ; margin-top: -200px; margin-left: -200px;">' ; 
				echo '<div>' . 
						'<h1 style = " padding : 2rem ; font-weight : bold ; "> Form Sonucunuz : </h1>'.
					'</div>'
				;
				echo '<div style = "text-align : center ; ">' . 
						
						'<h1 style = "font-size : 4rem ; ">'.$result.'</h1>' . 
					
					'</div>'
				;
			echo '</div>' ; 
			
			$headers = 'From: nefistofelesgame@hotmail.com\r\n'. 'Reply-To: ' . $email. "\r\n" . 'X-Mailer: PHP/' . phpversion();
			$to      = $email ;
			$subject      = 'Sending from localhost';
			$message     = 'Thank you for solving to the form... Your point is ' . $result ;
			if(mail($to, $subject, $message, $headers)){
				echo 'success' ;
			}else{
				echo 'unsuccessfull' ;
			}
			
		?>
		<div class="d-flex justify-content-center" style="margin-top : 500px ;">
			<input class="btn btn-primary btn-lg" type="submit" value="Anasayfa">
		</div>
		
	</form>
	</body>
</html>

