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
   $userModel = new UserModel();
   $session=session::getInstance();

   $BSN = $session->__get("BSN");
   $firstName =null;
   $lastName =null;
   $gender = null;
   $phone = null;
   $adress =null;
   $languages =null;
   $certificates =null;
   $contactEmail =null;

   if(isset($__POST['firstnName']) || isset($__POST['lastName']) || isset($__POST['gender']) || isset($__POST['phone']) || isset($__POST['adress']) || isset($__POST['languages']) || isset($__POST['certificates']) || isset($__POST['contactEmail']) ){
   $firstName = $_POST['firstName'];
   $lastName =$_POST['lastName'];
   $gender = $_POST['gender'];
   $phone = $_POST['phone'];
   $adress =$_POST['adress'];
   $languages =$_POST['languages'];
   $certificates =$_POST['certificates'];
   $contactEmail =$_POST['contactEmail'];
   
   $userModel->RequestChangeUserInformation($BSN, $firstName, $lastName, $gender, $phone, $adress, $languages, $certificates, $contactEmail);
   }


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
