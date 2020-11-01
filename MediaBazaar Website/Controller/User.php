<?php
 require_once('classes.php');
 class User {




function checkUser(){
if(isset($_POST['loginPassword'])&&isset($_POST['loginEmail'])){

   $username=$_POST['loginEmail'];
   $password=$_POST['loginPassword']; 
   $_dbh =new UserModel();
   if( $_dbh->CheckUsers($username,$password) == true ){
    header("Location:calendar.php");
    $session=session:: getInstance();
    return 'true'; 
   }
   else{
      return'Check your Email and passowrd please';
   }
 
 }
}

   function logout(){
   if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
      $session=session::getInstance();
      $session->__unset('BSN');
      header("Location:login.php");
      echo 'session stoped';
      return true;
  }
}
}


//if it's inside the class can not accsse the $_post 
if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
   $session=session::getInstance();
   $session->__unset('BSN');
   header("Location:login.php");
   echo 'session stoped';
   return true;
}
?>
