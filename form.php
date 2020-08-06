<!DOCTYPE html>

<html>
	<head>
		<link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
		<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
		<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
		<script src="https://kit.fontawesome.com/d6d9da6692.js" crossorigin="anonymous"></script>
		
		<link rel="stylesheet" href="index.css">
		<link rel="stylesheet" href="SelectedCard.css">
	</head>
	<body>
	<!-- action="includes/formdata.inc.php" -->
		<form action="form.php" method="POST">
			<input type="number" name="number" placeholder="number">
			<button type="submit" name="submit">Find</button>
		</form>

		<?php
			include_once 'includes/databaseConnection.inc.php';
			
			$number = mysqli_real_escape_string($conn, $_POST['number']) ;
			$sql = "select * from question_option 
			inner join question on question.id = question_option.question_id 
			inner join form on question.form_id = '$number';";
			
			
			$result = $conn->query($sql) ;
		?>
		
		<form action="result.php" method= "POST">
			<div>
				<?php 
					echo '<ul class="list-group">' ;
					$question_data = "";
					$question_number = 0 ;
					  echo '<div class="container-fluid">' . 
							  '<div class="row">'; 
					  while($row = $result->fetch_assoc()){
						
						$question_string = $row["question_string"] ;
						if(strcmp ($question_string , $question_data) == 0){
						}else{
							echo '<div class="col-sm-12">' ;
							echo '<div class="col-sm-4">' ;
							echo '<li class="list-group-item overflow-visible">'.$question_number.'. '.$question_string.'</li>' ;
							echo '</div>' ;
							$question_data = $question_string ;
							$question_number++ ;
							
							echo '</div>' ;
						}
						
						$question_option = $row["option_string"] ;
						$question_point = $row["point"] ;
						echo 	'<div class="col-sm-1">' .
									'<input type="radio" name="id'.$question_number.'" value="'.$question_point.'">'.$question_option.' </input>' .
								'</div>' 
						;
						
						
						
					}
					echo '</div>' .
							'</div>' ; 
					echo "</ul>" ;
				?>
				<div>
					<input type="submit" name="insertValue" value="insert">
				</div>
			</div>
		</form>
	</body>
</html>