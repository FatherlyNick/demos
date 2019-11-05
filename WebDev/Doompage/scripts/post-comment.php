<?php

error_reporting(E_ALL);
ini_set('display_errors', '1');

include_once("db-connection.php");
$db = connect_db();

//if POST is set, then this page was reached from a form
if (isset($_POST))
{
    $post_id = $_POST['post_id'];
    $username = $_POST['commenter_name'];
    $content = $_POST['content'];

    //insert these values into the db as a new comment
    //example using array syntax to insert values
    $statement = "INSERT INTO comments (username, content, time, fk_id_post) VALUES (?, ?, now(), ?)";
    $sth = $db->prepare($statement);
    $data = array($username, $content, $post_id);
    $sth->execute($data);
}

$db = null;

//redirect users browser to blog post they were on
header("Location: ../forum.php?post=$post_id");
?>
