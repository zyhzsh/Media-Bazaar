<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale= ">
    <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
    <title>Media Bazaar</title>
</head>
<body>
 <?php 
require_once('classes.php');
include('navigation.php');

 if(isset($_GET['page'])){
 switch($_GET['page']) 
 {
     case 'pagePreferedShift':
         echo '<div class="main">'; include 'PreferedShift.php' ;echo '</div>';
         break;
     case 'pageAssignedShift':
         echo '<div class="main">'; include 'Calendar.php'; echo '</div>';
         break;
     default:
         echo '<div class="main">'; include 'login.php';echo '</div>';
 }
 }
 
 ?>  
</body>
</html>