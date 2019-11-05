<?php

error_reporting(E_ALL);
ini_set('display_errors', '1');

include_once("scripts/db-connection.php");
$db = connect_db();

//if _GET is set and _GET['post'] is set then we are looking
//for a particular post, otherwise, get latest
$posts = "WARNING!";
if (isset($_GET) && isset($_GET['post']))
{
    //using named parameters
    $posts = $db->prepare("SELECT * FROM posts WHERE id = :id");
    $posts->bindParam(':id', $_GET['post']);
    $posts->execute();
}
else
{
    $posts = $db->query('SELECT * FROM posts ORDER BY post_date ASC');
}
//get the first result from posts, this is the post we want
$post = $posts->fetch();
//post template lays out the post
include("templates/post-template.html");

//get the post id to use for selecting comments
$post_id = $post['id'];
//using numbered parameters
$comments = $db->prepare('SELECT * FROM comments WHERE fk_id_post = ?');
$comments->bindParam(1, $post_id);
$comments->execute();

//we have selected all the comments, so iterate through them and post them
foreach ($comments as $comment)
{
    //comment template lays out the comments
    include("templates/comment-template.html");
}

include("templates/comment-form-template.html");

//close database connection
$db = null;

?>
