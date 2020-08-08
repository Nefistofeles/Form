<html>
	<header>	
		<?php 
			include_once 'includes/htmlbasic.inc.php';
		?>
	</header>
	<body style = "background: linear-gradient(to right, #ff6699 0%, #66ccff 100%);">
	<?php  
		$question_number1 = $_POST['question_number'] ;
		$sonuc = 0 ;
		
		while($question_number1 > 1 ){
			if(!empty($_POST['id' . $question_number1])){
				$sonuc += $_POST['id' . $question_number1];
				
			}
			$question_number1-- ;
		}
		echo '<div style = " padding : 10rem ; ">' ; 
			echo '<div style ="text-align : center ; font-size = 10rem ; font-weight : bold ;  margin : 2rem ; ">' . 
					'<h1 style = " padding : 2rem ; font-weight : bold ; "> Form Sonucunuz : </h1>'.
				'</div>'
			;
			echo '<div style = "text-align : center ; ">' . 
					
					'<h1 style = "font-size : 4rem ; ">'.$sonuc.'</h1>' . 
				
				'</div>'
			;
		echo '</div>' ; 
	?>
	
	</body>
</html>

