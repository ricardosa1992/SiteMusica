<?php
	 
    $form_data['success'] = true;
    $form_data['posted'] = 'Data Was Posted Successfully';


    //Return the data back to form.php
    echo json_encode($form_data);