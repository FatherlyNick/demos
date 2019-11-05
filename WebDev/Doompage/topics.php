<?php

include_once("scripts/db-connection.php");
$db = connect_db();

$posts = $db->prepare('SELECT * FROM posts ORDER BY post_date DESC');
$posts->execute();

?>

<?php if($page==="about"){ echo '<a id="new-post" href="blog-new.php">New Post</a>';}  ?>

<h4 id ="topics-title">Forum Posts:</h4>
<ul>
    <?php
    foreach ($posts as $id => $post)
    {
        include("templates/link-template.html");
    }
    echo '<li class="list-last"><a href=""></a></li>';
?>

</ul>
