<?php
 require_once('classes.php');
class shifts{
 

  //Get List of asigned shift 7*6=42 days 
  public function GetShifts($date)
  {
    $session=session:: getInstance();
    $BSN=$session-> __get('BSN'); 
    //Calculate the starting date need to be load from database
    $startingdate="";
    //1.Get the first day of SeletedDate of the month
    $first_day_of_the_month=date('Y-m-1',strtotime($date));
    //2.Get the week day of the firstday of the month
    $day_of_week=date('l', strtotime($first_day_of_the_month));
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
  //Get first day of the week
  public function GetFirstDayOfTheWeek($date)
  {
    $year=date("Y",strtotime($date)); 
    $week=date("W",strtotime($date)); 
    $temp = new DateTime();
    //setISoDate will set date =  first day of the week
    $temp->setISODate($year, $week);
    return $temp->format('Y-m-d');   
  }
  public function GetAvailability()
  {
    $session=session:: getInstance();
    $BSN=$session-> __get('BSN'); 
    $db=new ShiftsModel();
    $result=$db->Get_Availabity($BSN);
    return $result;
  }

  public function UpdateAvailability()
  {
    $Submition_Result=false;
    //Get Bsn
    $session=session:: getInstance();
    $BSN=$session-> __get('BSN'); 
    //Formating and Check User Input
    //1.Get User's FTE 
    //( 1 FTE= 40 hours/week)
    //( 1 Shift = 4 Hours)
    //( 1 FTE= 10 Shift/Week)
    //( Constrain-> User Input Result have to >= FTE*10 )
    $userController = new UserController();
    $session = session::getInstance();
    $user = $session->__get("user");
    //var_dump($user);
    //Get user' fte
    $fte=$user->Get_Fte();
    //User's Working Shift 
    $working_shift_conter=$fte*10;
    $submiton_shift_counter=0;
    //2.Formulating Data And Calculate Submiton Shift
    $tempcounter=0;
    //Preparing variable
    $Mondayshift="";
    $Tuesdayshift="";
    $Wednesdayshift="";
    $Thursdayshift="";
    $Fridayshift="";
    //Formulate Shift date
    for($i=0;$i<5;$i++)
    {  
      $day="";
      $shifttype="";
      switch($i)
      {
        case 0:$day='Monday'; break;
        case 1:$day="Tuesday";break;
        case 2:$day="Wednesday";break;
        case 3:$day="Thursday";break;
        case 4:$day="Friday";break;
      }
      if(isset($_POST[$day]))
      {
        $tempcounter=count($_POST[$day]);
        $submiton_shift_counter+=$tempcounter;
        if($tempcounter==3){$shifttype="FullDay";$submiton_shift_counter-=1;}
        else if($_POST[$day][0]=="Morning"){
        $shifttype="Morning";
        if(isset($_POST[$day][1])){
          if($_POST[$day][1]=="Afternoon")
          {$shifttype="Morning_Afternoon";}
          elseif($_POST[$day][1]=="Evening")
          {$shifttype="Morning_Evening";}
          }
        }
        else if($_POST[$day][0]=="Afternoon"){
          $shifttype="Afternoon";
          if(isset($_POST[$day][1])){
          if($_POST[$day][1]=="Evening")
          {
            $shifttype="Afternoon_Evening";}
          }
        }
        else if($_POST[$day][0]=="Evening"){
          $shifttype="Evening";
        }
      }
      switch($i)
      {
        case 0:$Mondayshift=$shifttype; break;
        case 1:$Tuesdayshift=$shifttype;break;
        case 2:$Wednesdayshift=$shifttype;break;
        case 3:$Thursdayshift=$shifttype;break;
        case 4:$Fridayshift=$shifttype;break;
      }
    }
    //Checking fte result
    if($submiton_shift_counter<$working_shift_conter)
    {
      $Submition_Result=false; 
    }
    else
    {
      $availabilitySetting=new Availability($Mondayshift,$Tuesdayshift,$Wednesdayshift,$Thursdayshift,$Fridayshift);
      //Update Availbility into database
      $db=new ShiftsModel();
      $Submition_Result=$db->Update_Availabity($BSN,$availabilitySetting);
    }
    return $Submition_Result;
  }
}
?>