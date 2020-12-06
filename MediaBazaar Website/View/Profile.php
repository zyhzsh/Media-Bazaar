<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale= ">
   <script src="https://kit.fontawesome.com/7beb03d50e.js" crossorigin="anonymous"></script>
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
</div>
<div class="flex-container">
   <div>
      <form class="form-changeInfo" role="form" action="" method="post">
         <h4>Request change your personal information</h4>
         <?php $user = new UserController();
            $user->ChangeUserInfoRequest();
            ?>
         <input type="text" class="form-control" name="firstName" placeholder="first name"></br>
         <input type="text" class="form-control" name="lastName" placeholder="last name"></br>
         <input type="text" class="form-control" name="gender" placeholder="gender"></br>
         <input type="text" class="form-control" name="phone" placeholder="phone"></br>
         <input type="text" class="form-control" name="adress" placeholder="adress"></br>
         <input type="text" class="form-control" name="languages" placeholder="languages"></br>
         <input type="text" class="form-control" name="certificates" placeholder="certificates"></br>
         <input type="text" class="form-control" name="contactEmail" placeholder="contact email"></br>

         <button class="buttonBlue" type="submit" name="submitRequest">Submit request</button>
         </form>
   </div>


      <form class=" form-changeInfo" role="form" action="" metehod="post">
         <h4 class="form-changeInfo-heading">
            Change password
            <?php $user = new UserController();
            $user->ChangePassword();
            ?>
         </h4>
         <input type="password" class="form-control" name="oldPassword" placeholder="old password"></br>
         <input type="password" class="form-control" name="newPassword" placeholder="new password"></br>
         <input type="password" class="form-control" name="newPasswordCheck" placeholder="new password"></br>
         <button class="buttonBlue" type="submit" name="submitChangePassword">Change passsword</button>
      </form>
</div>>
