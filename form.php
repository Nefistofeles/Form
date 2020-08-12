<!DOCTYPE html>
<html>
	<head>
		<?php 
			include_once 'includes/htmlbasic.inc.php';
		?>
		
		<link rel="stylesheet" href="index.css">
		<link rel="stylesheet" href="SelectedCard.css">
	</head>
	<body>
		<?php
			include_once 'includes/databaseConnection.inc.php';
			//$number = mysqli_real_escape_string($conn, $_POST['number']) ;
			$sql = "select * from question_option 
			inner join question on question.id = question_option.question_id 
			inner join form on question.form_id = form.id and form.tag = '" .  $_POST['tag']  .  "' and form.isActive = true order by form.id ;";
			
			$result = $conn->query($sql) ;
			if($row = $result->fetch_assoc()){
				$name = $row['name'] ; 
				$information = $row['information'] ;
					
				echo '<div class = "container-fluid overflow-visible" style="text-align : center ;  background-color : #00ff99 ; padding-bottom : 1rem ;  padding-top : 1rem ;  ">' .
						'<div style = "background-color : #e6ffff ; margin-left : 20rem ; margin-right : 20rem ;  margin-bottom : 1rem ;  padding-bottom : 1rem ; padding-top : 1rem ; ">' . 
						'<h1 style = "font-size : 3rem ; text-transform:uppercase; font-weight : bold ;">'.$name.'</h1>' .
						'</div>'.
					'</div>'
				; 
				echo '<div class="container-fluid overflow-visible" style = "text-align : center ; padding-top : 2rem ; padding-bottom : 2rem ; ">' . 
						'<div class="container-fluid" style = "padding : 2rem ; ">' . 
							'<p style = "font-size : 1.5rem ; ">'.$information.'</p>' .
						'</div>' . 
					'</div>'
				;
			}else{
				header("Location: index.php");
				exit;
			}
			mysqli_close($conn); 
		?>
		<?php 
		
		?>
		
		<form action="result.php" method= "POST">
			<div class="container" style="position : relative ; height:380px">
				<div >
					<?php 
						echo '<ul class="list-group">' ;
						$question_data = "";
						$question_number = 1 ;
						$question_option_number = 0 ;
						  echo '<div class="container-fluid">' . 
								  '<div class="row">'; 
						  while($row = $result->fetch_assoc()){
							
							$question_string = $row["question_string"] ;
							if(strcmp ($question_string , $question_data) == 0){
								$question_option_number++ ;
							}else{
								echo '<div class="col-sm-12" style = "background: linear-gradient(to right, #ff6699 0%, #66ccff 100%); font-size : 1.5rem ; ">' ;
								echo 	'<div class="col-sm-10">' ;
								echo 		'<li class="list-group-item overflow-visible" style = "background-color : #b3ffb3;"><span class="badge badge-primary">'.$question_number.'</span>'.$question_string.'</li>' ;
								echo 	'</div>' ;
								$question_data = $question_string ;
								$question_number++ ;
								$question_option_number = 0 ; 
								echo '</div>' ;
							}
							
							$question_option = $row["option_string"] ;
							$question_point = $row["point"] ;
							echo 	'<div class="col-sm-2 custom-radio custom-control-inline mb-3">' .
										'<div style="padding : 1rem ; padding-left :3rem;">' . 
											'<input type="radio" class="custom-control-input" style="font-size = 1.2rem ;" id="id'.$question_number . $question_option_number.'"  name="id'.$question_number.'" value="'.$question_point.'"></input>' .
											'<label class = "custom-control-label" for="id'.$question_number . $question_option_number.'">'.$question_option.'</label>' .
										'</div>' .
									'</div>'
							;
							echo '<input type ="hidden" name= "question_number" value='.$question_number.'>' ;
							
							
						}
						echo '</div>' .
								'</div>' ; 
						echo "</ul>" ;
					?>
					<div class="container-fluid" style=" text-align: center; padding : 1rem ; size: 4rem ; ">
						<input class="btn btn-primary btn-lg" type="submit" name="insertValue" value="Bitir">
					</div>
				</div>
			</div>
		</form>
	</body>
</html>