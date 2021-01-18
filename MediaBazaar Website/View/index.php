<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
    <title>Media Bazaar</title>
</head>
<body>
 <?php 
require_once('Classes.php');
include('Navigation.php');
 if(isset($_GET['page'])){
 switch($_GET['page']) 
 {
     case 'pageAssignedShift':
        include 'Calendar.php';
         break;
     case 'pageAvailability':
         echo '<div class="main">'; include 'Availability.php'; echo '</div>';
         break;
     case 'pageProfile':
        echo '<div class="main">'; include 'Profile.php'; echo '</div>';
        break;
        case 'PasswordChange':
            echo '<div class="main">'; include 'PasswordChange.php'; echo '</div>';
            break;
     default:
         echo '<div class="main">'; include 'login.php';echo '</div>';
 }
 }
 ?>  
</body>
</html>