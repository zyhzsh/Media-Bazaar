<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale= ">
   <script src="../JavaScriptFiles/ValidateInput.js"> </script>
   <link href="../CSSFiles/Profile.css" type="text/css" rel="stylesheet" />
   <title>Media Bazaar</title>
   <?php require_once('Classes.php'); ?>
</head>

<body>
<div class="main">
      <h1>Profile</h1>
      <?php $userController = new UserController();
         $session = SessionController::getInstance();
         $user = $session->__get("user");
         echo " <p><strong> name : </strong>   " . $user->firstName . " " . $user->lastName . " </p>";
         echo "<p><strong>date of Birth : </strong> " . $user->dateOfBirth. " </p>";
         echo "<p><strong>weekly hours : </strong> " . $user->weeklyHours. " </p>";
      ?>
         <button class="buttonBlue" onclick="window.location.href='?page=PasswordChange'" name="editPrivacy">Edit privacy</button>

<div class="container"><div class="item"> 
      <form class="form-changeInfo" role="form" action="" method="post">
         <h4>Request change your personal information</h4>
         <?php $user = new UserController();
            $user->ChangeUserInfoRequest();
            ?>
             <?php $userController = new UserController();
         $session = SessionController::getInstance();
         $user = $session->__get("user");
         
        echo'<p class="form-control"><strong>First name: </strong> </p> <input type="text" class="form-control" name="firstName" value=" '.$user->firstName .'"></br>';
        echo'<p class="form-control"><strong> Last name : </strong>  </p><input type="text" class="form-control" name="lastName" value= "'.$user->lastName .'"></br>';
        echo'<p class="form-control"><strong> Gender : </strong>  </p><input type="text" class="form-control" name="gender" value= '.$user->gender .'></br>';
        echo'<p class="form-control"><strong> Phone : </strong>  </p><input type="text" class="form-control" name="phone" value="'.$user->phone .'"></br>';
        echo'<p class="form-control"><strong> Adress : </strong>  </p><input type="text" class="form-control" name="adress" value=" '.$user->adress .'"></br>';
        echo'<p class="form-control"><strong> Languages : </strong>  </p><input type="text" class="form-control" name="languages" value= "'.$user->languages .'"></br></P>';
        echo'<p class="form-control"><strong> Certificates : </strong>  </p><input type="text"  name="certificates" value= "'.$user->certificates .'"></br></P>';
        echo'<p class="form-control"><strong> Contact email : </strong>  </p><input type="text"  name="contactEmail" value= "'.$user->contactEmail .'"></br></P>';
         ?>
         <button class="buttonBlue" type="submit" name="submitRequest">Submit request</button>
      </form>
   </div>
     
     
 </div>
</div>
</body>
