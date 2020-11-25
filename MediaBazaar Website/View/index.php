<!DOCTYPE html>
<html lang="en">
<link href="../CSSFiles/PreferedShift.css" type="text/css" rel="stylesheet" />
<link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
 <?php 
  
require_once('classes.php');
include('navigation.php');
 if(isset($_GET['page'])){
 switch($_GET['page']) 
 {
     case 'pagePreferedShift':
          include 'PreferedShift.php' ;
         break;
     case 'pageAssignedShift':
         include 'Calendar.php';
         break;
         case 'PersonalInfo':
            echo '<div class="main">'; include 'profile.php'; echo '</div>';
            break;
     default:
         echo '<div class="main">'; include 'login.php';echo '</div>';
 }
 }
 
 ?>  

</html>