<?php
   require_once('Dbh.php'); 
class User extends Dbh{

public $assignedShitsDate=array();
public $assignedShitsTime=[];



function checkUser(){
if(isset($_POST['loginPassword'])&&isset($_POST['loginEmail'])){

   $username=$_POST['loginEmail'];
   $password=$_POST['loginPassword']; 

   if($this->CheckUsers($username,$password)==true){
     return $this->GetalluserShiftsToString();
   }
 
 }
}
 

function AddShiftsToCalander($date){
   if (isset($_POST['selctedDate'])) {
   $selected_date = date('m-d-y', strtotime($_POST['selctedDate']));
   return $selected_date;
   foreach( $this->GetAllShiftsForEmployee($_SESSION["BSN"]) as $value ){
      echo $value;
   }
   }
   }

 
}


function GetalluserShiftsToString(){
   foreach( $this->GetAllShiftsForEmployee($_SESSION["BSN"]) as $value ){
      echo $value;
   }
   

   function logout(){
      if (isset($_POST['logoutlogoutBtnBt'])) {
         session_destroy();
         header("Location:login.php");
         echo 'session stoped';
     }
  
   }
}

?>
