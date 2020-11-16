<?php
 require_once('classes.php');
 class User {




function checkUser(){
if(isset($_POST['loginPassword'])&&isset($_POST['loginEmail'])){

   $username=$_POST['loginEmail'];
   $password=$_POST['loginPassword']; 
   $_dbh =new UserModel();
   if( $_dbh->CheckUsers($username,$password) == true ){
    header("Location:?page=pageAssignedShift");
    $session=session:: getInstance();
    return 'welocme'; 
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
      header("Location:?page=default");
      echo 'session stoped';
      return true;
  }
}

function ChangeUserInfoRequest(){
   #check if anything is filled in

   #check what is filled in, pass that. if nothing is filled in give null
}
}


//if it's inside the class can not accsse the $_post 
if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
   $session=session::getInstance();
   $session->__unset('BSN');
   header("Location:?page=default");
   echo 'session stoped';
   return true;
}
