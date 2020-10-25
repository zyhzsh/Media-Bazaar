<?php
 require_once('classes/classes.php');
class shifts{
 


 public function GetAllShifts(){
    $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    $dbh=new Dbh;
  return $dbh-> GetAllUserShifts($bsn); 
 }


function ShowSellectedShift($date){
$selected_date = date('yy-m-d', strtotime($date)); 
$allshifts=$this->GetAllShifts();  
  if(empty($date)){
  }else{
       if(is_array( $this->GetAllShifts())){
        foreach( $this->GetAllShifts() as $shift ){
              $index=array_search($selected_date,$allshifts);
              $shifttypes=array($shift['assigned_shift_type']);
              if(empty($index)){
                 echo  '<div class="grid-container">'
                 .'<div class="item1">' .$date. "           "."Not Assigned yet ".'</div></div>';
                 print_r($allshifts['date']);
              }
              if(!empty($index)){
                 echo  '<div class="grid-container">'
                 .'<div class="item1">' .$date. "           ".$shift['assigned_shift_type'].'</div></div>';
            break;
            }
        break;
        }
        }
    }
}


function ShowAllShifts(){
          if(is_array($this->GetAllShifts())){
          foreach( $this->GetAllShifts() as $shifts ){
           echo  '<div class="grid-container">'
           .'<div class="item1">' .$shifts['date']. " &nbsp;&nbsp;&nbsp;".$shifts['assigned_shift_type'].'</div></div>';
          }       
         }else{
           echo 'not available yet';
          }
      }

}


?>