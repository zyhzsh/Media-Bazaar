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
   if(isset($_POST['logoutBtn'])){
      $session=session::getInstance();
      $session->__unset('BSN');
      header("Location:?page=default");
      echo 'session stoped';
      return true;
  }

//the 4 functions below is for changing/reseting password
// if email is true we send him link to change his passowrd
function checkEmail(){
   if(isset($_POST['CheckEmail'])){
   
      $checkEmail=$_POST['CheckEmail'];
      $_dbh =new UserModel();
      if( $_dbh->CheckEmail($checkEmail) == true ){
      echo"We sent you an email check your email and open the link we sent to change yor password";
         
      }
      else{
         echo 'We did not find yor email check your email and try another time';
      }
    
    }
   }
   function checkPasswordKey($passwordKey){
 
         $_dbh =new UserModel();
         if( $_dbh->CheckPasswordKey($passwordKey)== true ){
         return true; 
         }
         else{
            return false;
         }
  }
  function resetPassword(){

   if(isset($_POST['loginEmail'],$_POST['NewLoginPassword'])){

      $email=$_POST['loginEmail'];
      $newPassword=$_POST['NewLoginPassword'];
      $_dbh =new UserModel();
      $session=session:: getInstance();
     $BSN=$session->__get('BSN');
   if( $_dbh->resetPassword($BSN,$newPassword)== true ){
      echo dafd;
      header("Location:?page=pageAssignedShift");

   return true; 
   }
   else{
      echo "check your email";
      return false;
   }
}
}


}
}


//the logout function if it's inside the class can not accssesed the $_post 
if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
   $session=session::getInstance();
   $session->__unset('BSN');
   header("Location:?page=default");
   echo 'session stoped';
   return true;
}
?>
