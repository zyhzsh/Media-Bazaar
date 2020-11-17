<!DOCTYPE html>
<html lang="en">
<?php 
require_once('classes.php');
echo $_GET['Key'];
if(isset($_GET['Key'])){
$passwordKey=$_GET['Key'];

$user=new User();
if($user->CheckPasswordKey($passwordKey)==true){

?>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>reset password</title>
</head>
<body>
<h4>Write your email and new password </h4>
<form class = "form-signin" role = "form" 
            action ="" method = "post">
            <h4 class = "form-signin-heading">
               <?php $user= new User();   $user->resetPassword();
               ?>
             </h4>
            <input type = "text" class = "form-control" 
               name = "loginEmail" placeholder = "Email" 
               required autofocus></br>
        
            <input type = "password" class = "form-control"
               name = "NewLoginPassword" placeholder = "New password " required><br>
            <button class = "btn btn-lg btn-primary btn-block" type = "submit" 
               name = "resetPasswordBtn">Reset password</button>

         </form>
</body>
<?php
}else{
   echo'<h1>404</h1>';
}
}else{
   echo'<h1>404 not found</h1>';
}
?>
</html>