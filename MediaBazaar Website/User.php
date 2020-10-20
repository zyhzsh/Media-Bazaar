<?php
   require_once('Dbh.php'); 
 class User extends Dbh{

//public $assignedShitsDate=array();
//public $assignedShitsTime=[];
//private $BSN=$_SESSION["BSN"];


function checkUser(){
if(isset($_POST['loginPassword'])&&isset($_POST['loginEmail'])){

   $username=$_POST['loginEmail'];
   $password=$_POST['loginPassword']; 

   if($this->CheckUsers($username,$password)==true){
    //return $this->AddShiftsToCalander();
   }
   else{
      return'Check your Email and passowrd please';
   }
 
 }
}
 

function ShowSellectedShift($date){

  $selected_date = date('yy-m-d', strtotime($date));   
  $allShiftsDate = $this->GetAllShiftsDate();
  $allShiftsType=$this->GetAllShiftsTypes();

if(empty($date)){

}else{
     if(is_array($allShiftsDate)&&is_array($allShiftsType)){
  // foreach( $allShiftsDate as $date ){
     // foreach( $allShiftsType as $type ){
       // if($date==$selected_date){
            $index=array_search($selected_date, $allShiftsDate);
            if(empty($index)){
               echo  '<div class="grid-container">'
               .'<div class="item1">' .$date. "           "."Not Assigned yet 🙁".'</div></div>';
            }else{
               echo  '<div class="grid-container">'
               .'<div class="item1">' .$date. "           ".$allShiftsType[$index].'🙂</div></div>';
            }
      }
   }

   }
//not in used fo now**
   function logout(){
   if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
      session_destroy();
      header("Location:login.php");
      echo 'session stoped';
      return true;
  }
}
function ShowAllShifts(){
   $allShiftsDate = $this->GetAllShiftsDate();
   $allShiftsTypes=$this->GetAllShiftsTypes();
   foreach( $allShiftsDate as $date ){
     foreach( $allShiftsTypes as $type ){
        if(empty($date)&&empty($type)){

        }else{
         $index=array_search($date, $allShiftsDate);
            echo  '<div class="grid-container">'
            .'<div class="item1">' .$date. "  &nbsp;&nbsp;&nbsp; ".$allShiftsType[$index].'🙂</div></div>';
           break;
         }
      }
   }

 }
}


//if it's inside the class can not accsse the $_post 
 if(isset($_POST['logoutBtn']) && preg_match("/\b(logout)\b/", $_POST['logoutBtn'])){
   session_destroy();
   header("Location:login.php");
   echo 'session stoped';
 }

?>
