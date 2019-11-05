<?php

error_reporting(E_ALL);
ini_set('display_errors', '1');

include_once("db-connection.php");
$db = connect_db();

//if POST is set, then this page was reached from a form
if (isset($_POST))
{
    $username = $_POST['username'];
    $title = $_POST['title'];
    $content = $_POST['content'];

    //insert these values into the db as a new comment
    //example using array syntax to insert values
    $statement = "INSERT INTO posts (content, post_date, author, title) VALUES (?, now(), ?, ?)";
    $sth = $db->prepare($statement);
    $data = array($content, $username, $title);
    $sth->execute($data);

    $posts = $db->prepare('SELECT * FROM posts ORDER BY post_date DESC');
    $posts->execute();
    $post = $posts->fetch();
    $post_id = $post['id'];
}

$db = null;

//redirect users browser to blog post they were on
header("Location: ../forum.php?post=$post_id");
?>
