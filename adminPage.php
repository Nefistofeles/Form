<html>
	<head>
		<?php 
			include_once 'includes/htmlbasic.inc.php';
		?>
	</head>
	<body>
		<form action='adminPage.php' method='GET'>
			<div>
				<div>
					<label for="tag">Tag:</label><br>
					<input type="text" id="tag" name="tag"><br>
				 </div>
				<input class="btn btn-primary btn-lg" type="submit" name="insertValue" value="Bitir">
			</div>
		</form>
		<form>
		<div class="form-group">
			<label for="exampleFormControlTextarea1">Example textarea</label>
				<textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
		</div>
			
		</form>
		<ul style = "column : 3 ; ">
		<?php
			include_once 'includes/databaseConnection.inc.php';
			
			if(isset($_GET['tag'])){
				$sql = "select * from form where tag = '" .  $_GET['tag']  .  "';";
			
				$result = $conn->query($sql) ;
				
				 while($row = $result->fetch_assoc()){
					echo '<div class="container-fluid">' ;
						echo '<div style = "margin-right : 50rem ;" >' ; 
							echo '<li><pre>' .  $row['id'] . '    ' . $row['tag'] .'    ' . $row['information'] .'</pre></li>';
						echo '</div>' ; 
					echo '</div>' ;
				}
			}
		?>
		</ul>
	</body>

</html>