<?php
require_once('classes.php');
class User
{




   function checkUser()
   {
      if (isset($_POST['loginPassword']) && isset($_POST['loginEmail'])) {

         $username = $_POST['loginEmail'];
         $password = $_POST['loginPassword'];
         $_dbh = new UserModel();
         if ($_dbh->CheckUsers($username, $password) == true) {
            header("Location:?page=pageAssignedShift");
            $session = session::getInstance();
            return 'welcome';
         } else {
            return 'Check your Email and password please';
         }
      }
   }

   function logout()
   {
      if (isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])) {
         $session = session::getInstance();
         $session->__unset('BSN');
         header("Location:?page=default");
         echo 'session stoped';
         return true;
      }
   }

   function ChangeUserInfoRequest()
   {
      $userModel = new UserModel();
      $session = session::getInstance();

      $BSN = $session->__get("BSN");
      $firstName = null;
      $lastName = null;
      $gender = null;
      $phone = null;
      $adress = null;
      $languages = null;
      $certificates = null;
      $contactEmail = null;

      if (isset($_POST['firstnName']) || isset($_POST['lastName']) || isset($_POST['gender']) || isset($_POST['phone']) || isset($_POST['adress']) || isset($_POST['languages']) || isset($_POST['certificates']) || isset($_POST['contactEmail'])) {
         $firstName = $_POST['firstName'];
         $lastName = $_POST['lastName'];
         $gender = $_POST['gender'];
         $phone = $_POST['phone'];
         $adress = $_POST['adress'];
         $languages = $_POST['languages'];
         $certificates = $_POST['certificates'];
         $contactEmail = $_POST['contactEmail'];

         $userModel->RequestChangeUserInformation($BSN, $firstName, $lastName, $gender, $phone, $adress, $languages, $certificates, $contactEmail);
      }

         
   }

   function ChangePassword()
   {
      $session = session::getInstance();

      $BSN = $session->__get("BSN");
      if (isset($_POST['oldPassword']) && isset($_POST['newPassword']) && isset($_POST['newPasswordCheck'])) {

         $oldpassword = $_POST['oldPassword'];
         $newpassword = $_POST['newPassword'];
         $newPasswordCheck = $_POST['newPasswordCheck'];
         if ($newpassword == $newPasswordCheck) {
            $_dbh = new UserModel();
            if ($_dbh->CheckPassword($BSN, $oldpassword) == true) {
               $_dbh->ChangePassword($BSN, $oldpassword, $newpassword);
               return 'Your password is changed';
            } else {
               return 'Check your old password';
            }
         }
         else{
            return 'New passwords dont match';
         }
      }
   }
}


//if it's inside the class can not accsse the $_post 
if (isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])) {
   $session = session::getInstance();
   $session->__unset('BSN');
   header("Location:?page=default");
   echo 'session stoped';
   return true;
}
