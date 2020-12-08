<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale= ">
   <script src="https://kit.fontawesome.com/7beb03d50e.js" crossorigin="anonymous"></script>
   <script src="JavaScriptFiles/ValidateInput.js"> </script>
   <link href="../CSSFiles/profileStyle.css" type="text/css" rel="stylesheet" />
   <title>Media Bazaar</title>
   <?php require_once('classes.php'); ?>
</head>

<body>
<div class="main">
   <div>
      <h1>Profile</h1>
      <?php $userController = new UserController();
         $session = session::getInstance();
         $user = $session->__get("user");
         
         echo " <p><strong> name : </strong>   " . $user->firstName . " " . $user->lastName . " </p>";
         echo "<p> <strong>gender : </strong> " . $user->gender. " </p>";
         echo "<p><strong>phone : </strong> " . $user->phone. " </p>";
         echo "<p><strong>date of Birth : </strong> " . $user->dateOfBirth. " </p>";
         echo "<p><strong>adress : </strong> " . $user->adress. " </p>";
         echo "<p><strong>languages : </strong> " . $user->languages. " </p>";
         echo "<p><strong>certificates : </strong> " . $user->certificates. " </p>";
         echo "<p><strong>contact email : </strong> " . $user->contactEmail. " </p>";
         echo "<p><strong>weekly hours : </strong> " . $user->weeklyHours. " </p>";
      ?>

   
 </div>
 <div class="flex-container">
      <form class="form-changeInfo" role="form" action="" method="post">
         <h4>Request change your personal information</h4>
         <?php $user = new UserController();
            $user->ChangeUserInfoRequest();
            ?>
             <?php $userController = new UserController();
         $session = session::getInstance();
         $user = $session->__get("user");
        echo'<p class="form-control"><strong>First name: </strong>  <input type="text" class="form-control" name="firstName" value= '.$user->firstName .'></br></P>';
        echo'<p class="form-control"><strong> Last name : </strong>  <input type="text" class="form-control" name="lastName" value= '.$user->lastName .'></br></P>';
        echo'<p class="form-control"><strong> gender : </strong>  <input type="text" class="form-control" name="gender" value= '.$user->gender .'></br></P>';
        echo'<p class="form-control"><strong> phone : </strong>  <input type="text" class="form-control" name="phone" value='.$user->phone .'></br></P>';
        echo'<p class="form-control"><strong> adress : </strong>  <input type="text" class="form-control" name="adress" value= '.$user->adress .'></br></P>';
        echo'<p class="form-control"><strong> languages : </strong>  <input type="text" class="form-control" name="languages" value= '.$user->languages .'></br></P>';
        echo'<p class="form-control"><strong> certificates : </strong>  <input type="text"  name="certificates" value= '.$user->certificates .'></br></P>';
        echo'<p class="form-control"><strong> contact email : </strong>  <input type="text"  name="contactEmail" value= '.$user->contactEmail .'></br></P>';
         ?>
         <button class="buttonBlue" type="submit" name="submitRequest">Submit request</button>
      </form>
  


      <form class=" form-changeInfo" name="changePassword" role="form" action="" 
       onsubmit="return validateChangePassword()" metehod="post">
         <h4 class="form-changeInfo-heading">
            Change password
            <?php $user = new UserController();
            $user->ChangePassword();
            ?>
         </h4>
         <input type="password" class="form-control" id="oldPassword" name="oldPassword" placeholder="old password" required></br>
         <input type="password" class="form-control" id="newPassword" name="newPassword" placeholder="new password" required></br>
         <input type="password" class="form-control" id="newPasswordCheck" name="newPasswordCheck" placeholder="new password" required>
         <button class="buttonBlue" type="submit" name="submitChangePassword">Change passsword</button>
         <p style="color:red" id="validInput"></p></br>
      </form>
   </div>
</div>
</body>
