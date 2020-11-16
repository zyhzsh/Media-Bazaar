<?php
include('classes.php');


    // $Tests=array();
    // $shift1=new PreferenceShift("2020-11-21","Morning");
    // $shift2=new PreferenceShift("2020-11-22","Morning");
    // $shift3=new PreferenceShift("2020-11-23","Morning_Afternoon");
    // $Tests[0]=$shift1;
    // $Tests[1]=$shift2;
    // $Tests[2]=$shift3;
    // $db=new ShiftsModel();
    // $result=$db->Update_Preference_Shifts("4",$Tests);
    
    // if($result==true)
    // {
    //     echo "Chenggong";
    // }

if(isset($_POST['btn_submit_form']))
{
    var_dump($_POST['2020-12-21']);
    $ShiftController=new shifts();
    $startingdate=$ShiftController->GetFirstDayOfTheWeek("2020-12-21");
    $result=$ShiftController->UpdatePreferenceShift($startingdate);
    if($result==true)
    {
        echo "Chenggong";
    }
    unset($_POST['btn_submit_form']);
}



?>