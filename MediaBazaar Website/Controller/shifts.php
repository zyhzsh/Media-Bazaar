<?php
 require_once('Controller/classes.php');
class shifts{
 


 public function GetAllShifts(){
    $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    $dbh=new Dbh;
  return $dbh-> GetAllUserShifts($bsn); 
 }

 public function GetAllPreferedShifts(){
  $session=session:: getInstance();
  $bsn=$session-> __get('BSN'); 
  $dbh=new Dbh;
return $dbh-> GetAllPreferedUserShifts($bsn); 
}


function ShowSellectedShift($date){
$selected_date = date('yy-m-d', strtotime($date)); 
$allshifts=$this->GetAllShifts(); 
  foreach( $allshifts as $shifts ){

    if($selected_date==$shifts['date']){
      echo  '<div class="grid-container">'
      .'<div class="item1">' .$shifts['date']. " &nbsp;&nbsp;&nbsp;".$shifts['assigned_shift_type'].'</div></div>';
    }
  }
}


public function ShowAllShifts(){
          if(is_array($this->GetAllShifts())){
          foreach( $this->GetAllShifts() as $shifts ){
           echo  '<div class="grid-container">'
           .'<div class="item1">' .$shifts['date']. " &nbsp;&nbsp;&nbsp;".$shifts['assigned_shift_type'].'</div></div>';
          }       
         }else{
           echo 'not available yet';
          }
}


public function ShowAllPreferedShifts(){
  if(is_array($this->GetAllPreferedShifts())){
  foreach( $this->GetAllPreferedShifts() as $preferdedShifts ){
   echo  '<div class="grid-container">'
   .'<div class="item1">' .$preferdedShifts['date']. " &nbsp;&nbsp;&nbsp;".$preferdedShifts['preference_shift_type'].'</div></div>';
  }       
 }else{
   echo 'not available yet';
  }
}

public function AddPreferedShift($date,$shiftType){
  $session=session:: getInstance();
  $BSN=$session-> __get('BSN'); 
  $selected_date = date('yy-m-d', strtotime($date)); 
  $db=new Dbh();
  return $db->AddPreferedShift($BSN,$selected_date,$shiftType);

  }
    
}


?>