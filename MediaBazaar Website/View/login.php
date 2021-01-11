<!DOCTYPE html>
<html>
<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link href="../CSSFiles/Login.css" type="text/css" rel="stylesheet" />
   <title>Home</title>
   <?php   require_once('Classes.php');?>
</head>
<body>
   
   <div class="Content">
      <div class="Login_Container">
         <form class = "form-signin" role = "form" 
            action ="" method = "post">
            <h2>Sign in</h2>     
            <h4 class = "form-signin-heading">
               <?php $user= new UserController();   print_r($user->checkUser());
               ?>
             </h4>
            <input type = "text" class = "form-control" 
               name = "loginEmail" placeholder = "Email" 
               required autofocus></br>
            <input type = "password" class = "form-control"
               name = "loginPassword" placeholder = "password " required><br>
            <button class = "btn btn-lg btn-primary btn-block" type = "submit" 
               name = "login">Login</button>
         </form>
      </div>
   </div>
</body>

<footer>
</footer>
</html>