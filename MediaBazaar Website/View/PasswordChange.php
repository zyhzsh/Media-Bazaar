<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>change password</title>
    <script src="../JavaScriptFiles/ValidateInput.js"> </script>
   <link href="../CSSFiles/Profile.css" type="text/css" rel="stylesheet" />
   <title>Media Bazaar</title>
   <?php require_once('Classes.php'); ?>
</head>
<body>
<div class="item">
       <form class=" form-changeInfo" name="changePassword" role="form"   onsubmit="return validateChangePassword()" method="post">
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
         <p style="color:red; size:24%;" id="validInput"></p></br>
      </form>

   </div>
</body>
</html>