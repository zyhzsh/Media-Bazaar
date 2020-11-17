<!DOCTYPE html>
<html>

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link href="../CSSFiles/loginStyle.css" type="text/css" rel="stylesheet" />
   <title>Home</title>
   <?php   require_once('classes.php');?>
   <style>
      
   </style>
</head>
<header>
</header>
<body>
         <form class = "form-signin" role = "form" 
            action ="" method = "post">
            <h4> Writ your email and we will send you a link to your email account were you can change your password</h4>
            <h4 class = "form-signin-heading">
               <?php $user= new User(); echo $user->checkEmail();
               ?>
             </h4>
            <input type = "text" class = "form-control" 
               name = "CheckEmail" placeholder = "Email" 
               required autofocus></br>

            <button class = "btn btn-lg btn-primary btn-block" type = "submit" 
               name = "ChangePassword">Send a verification </button>

         </form>
  



</body>

<footer>
</footer>



</html>