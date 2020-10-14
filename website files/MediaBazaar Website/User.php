<?php
include('Dbh.php');
class User extends Dbh
{

   function checkUser()
   {
      if (isset($_POST['loginPassword']) && isset($_POST['loginEmail'])) {

         $username = $_POST['loginEmail'];
         $password = $_POST['loginPassword'];
         if ($this->CheckUsers($username, $password) != null) {

            return $this->CheckUsers($username, $password);
         } else {

            return null;
         }
      }
   }
}
