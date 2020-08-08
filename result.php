<?php  
	$question_number1 = $_POST['question_number'] ;
	$sonuc = 0 ;
	while($question_number1 > 0 ){
		
		$sonuc += $_POST['id' . $question_number1];
		$question_number1-- ;
	}
	
	echo $sonuc ;
?>