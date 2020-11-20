<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale= ">
   <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
   <link href="../CSSFiles/profileStyle.css" type="text/css" rel="stylesheet" />
   <title>Media Bazaar</title>
   <?php require_once('classes.php'); ?>
</head>

<body>



   <div>
   <?php $user = new User();
      //here profile would be loaded in
      //use a data transfer object (DTO) to efficiently populate??
   ?>
   profile will come here

   </div>


   <div>
   <form class="form-changeInfo" role="form" action="" method="post">
      <h4 class="form-changeInfo-heading">
         Request change user information
         <?php $user = new User();
         $user-> ChangeUserInfoRequest();
         ?>
      </h4>
      <input type="text" class="form-control" name="firstName" placeholder="first name"></br>
      <input type="text" class="form-control" name="lastName" placeholder="last name"></br>
      <input type="text" class="form-control" name="gender" placeholder="gender"></br>
      <input type="text" class="form-control" name="phone" placeholder="phone"></br>
      <input type="text" class="form-control" name="adress" placeholder="adress"></br>
      <input type="text" class="form-control" name="languages" placeholder="languages"></br>
      <input type="text" class="form-control" name="certificates" placeholder="certificates"></br>
      <input type="text" class="form-control" name="contactEmail" placeholder="contact email"></br>
      
      <button class="btn btn-lg btn-primary btn-block" type="submit" name="submitRequest">Submit request</button>
      </div>
   </form>