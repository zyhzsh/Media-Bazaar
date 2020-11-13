<?php
 require_once('classes.php');
class shifts{
 


 public function GetAllShifts(){
    $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    $dbh=new ShiftsModel();
  return $dbh-> GetAllUserShifts($bsn); 
 }

 public function GetAllPreferedShifts(){
  $session=session:: getInstance();
  $bsn=$session-> __get('BSN'); 
  $dbh=new ShiftsModel();
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
            $selected_date = date('y-m-d', strtotime($shifts['date']));
            if($selected_date>=date('y-m-d')){
           echo  '<div class="grid-container">'
           .'<div class="item1">' .$shifts['date']. " &nbsp;&nbsp;&nbsp;".$shifts['assigned_shift_type'].'</div></div>';
            }
          }       
         }else{
           echo 'not available yet';
          }
}


public function ShowAllPreferedShifts(){
  if(is_array($this->GetAllPreferedShifts())){
  foreach( $this->GetAllPreferedShifts() as $preferdedShifts ){
    $selected_date = date('y-m-d', strtotime($preferdedShifts['dateShift']));
    if($selected_date>=date('y-m-d')){
   echo  '<div class="grid-container">'
   .'<div class="item1">' .$preferdedShifts['dateShift']. " &nbsp;&nbsp;&nbsp;".$preferdedShifts['preference_shift_type'].'</div></div>';
    }
  }       
 }else{
   echo 'not available yet';
  }
}

public function AddPreferedShift($date,$shiftType){
  $session=session:: getInstance();
  $BSN=$session-> __get('BSN'); 
  $selected_date = date('yy-m-d', strtotime($date)); 
  $shifts=new ShiftsModel();
  return $shifts->AddPreferedShift($BSN,$selected_date,$shiftType);
  }
    



  
  public function GetShifts($date)
  {
    $session=session:: getInstance();
    $BSN=$session-> __get('BSN'); 
    //Calculate the starting date need to be load from database
    $startingdate="";
    //1.Get the first day of SeletedDate of the month
    $first_day_of_the_month=date('Y-m-1',strtotime($date));
    //2.Get the week day of the firstday of the month
    $day_of_week=date('l', strtotime($date));
    //3.Estimate the starting date
    if($day_of_week=="Monday"){
      $startingdate=$date;
    }else if($day_of_week=="Tuesday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-1day"));
    }else if($day_of_week=="Wednesday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-2day"));
    }else if($day_of_week=="Thursday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-3day"));
    }else if($day_of_week=="Friday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-4day"));
    }else if($day_of_week=="Saturday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-5day"));
    }else if($day_of_week=="Sunday"){
      $startingdate=date('Y-m-d',strtotime($first_day_of_the_month."-6day"));
    }
    //4.Load shifts info data from database
    $db=new ShiftsModel();
    $result=$db->LoadAssignedShift($BSN,$startingdate);
    return $result;
  }





}






?>