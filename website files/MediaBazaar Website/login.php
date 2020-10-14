<?php session_start(); //maybe use a session class?
include('User.php');
?>
<!DOCTYPE html>
<html>

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link href="CSSFiles/loginStyle.css" type="text/css" rel="stylesheet" />
   <title>Home</title>
   <style>

   </style>
</head>
<header>
</header>

<body>


   <h2>Sign in</h2>
   <div class="container">

      <form class="form-signin" role="form" action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']);
                                                      ?>" method="post">
         <h4 class="form-signin-heading">
            <?php $user = new User();
            if ($user->checkUser() != null) {
               $_SESSION["bsn"] = $user->checkUser();
            } else {
               echo "Password or Username is incorrect";
            } ?>
         </h4>
         <input type="text" class="form-control" name="loginEmail" placeholder="Email" required autofocus></br>
         <input type="password" class="form-control" name="loginPassword" placeholder="password " required><br>
         <button class="btn btn-lg btn-primary btn-block" type="submit" name="login">Login</button>
      </form>
   </div>



</body>

<footer>
</footer>



</html>