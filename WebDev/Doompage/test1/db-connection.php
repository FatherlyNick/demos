<?php
    error_reporting(E_ALL);
    
ini_set('display_errors', '1');

    
function connect_db()
    {

       
 $username = 'se212020';
        $password = 'vqk6630';
       
 $db = new PDO('pgsql:host=webcourse.cs.nuim.ie;dbname=cs230',
           
 $username, $password);
        


	return $db;
    

}	

?>
