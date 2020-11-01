<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale= ">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
    <title>Document</title>
</head>
<body>
    
<div class="sidenav">
<a href="?page=pageLogin">Login</a>
<a href="?page=pageAssignedShift">Assigned shifts</a>
<a href="?page=pagePreferedShift">Prefered shifts</a>

</div>

<?php
switch($_GET['page']) 
{
    case 'pagePreferedShift':
        echo '<div class="main">';      include 'PreferedShift.php' ;echo '</div>';
        break;
    case 'pageAssignedShift':
     echo '<div class="main">';   include 'Calendar.php'; echo '</div>';
        break;
    default:
    echo '<div class="main">';    include 'login.php';echo '</div>';

}
?>
</body>
</html>