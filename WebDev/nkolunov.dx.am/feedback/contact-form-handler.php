<?php
$errors = '';
$myemail = 'admin@nkolunov.dx.am';//<-----Put Your email address here.
if(empty($_POST['name'])  || empty($_POST['email']) || empty($_POST['messagebod'])) {
    
	$errors .= "\n Error: all fields are required";
	echo $_POST['name'];
	echo $_POST['email'];
	echo $_POST['messagebod'];
	echo $errors;
}

$name = $_POST['name'];
$email_address = $_POST['email'];
$category = $_POST['category'];
$messageBod = $_POST['messagebod'];
if (!preg_match("/^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$/i",$email_address)) {
    
	$errors .= "\n Error: Invalid email address";
	echo $errors;
}


require_once 'swift/lib/swift_required.php';

$transport = Swift_SmtpTransport::newInstance('mail.nkolunov.dx.am', 25)
  ->setUsername('admin@nkolunov.dx.am')
  ->setPassword('1oddworld1');

$mailer = Swift_Mailer::newInstance($transport);

$message = Swift_Message::newInstance('Definitionary: '. $category)
	->setEncoder(Swift_Encoding::get8BitEncoding()) //Makes sure that the quoted-prinatble characters appear normal in the mail.
	->setFrom(array($email_address => $name))
	->setTo(array('admin@nkolunov.dx.am'))
	->setBody($messageBod);

$result = $mailer->send($message);



if(empty($errors)) {

	$to = $myemail;
	$email_subject = "Contact form submission: $name - $category";
	$email_body = "Here are the details:\n
	Name: $name \n 
 	"."Email: $email_address\n Category: $category \n
 Message \n $message";
$headers = "From: $myemail\n";
$headers .= "Reply-To: $email_address";
mail($to,$email_subject,$email_body,$headers);
header('Location: contact-form-thank-you.php'); //redirect to the 'thank you' page
}
?>