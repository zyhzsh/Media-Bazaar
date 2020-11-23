<?php 
require_once('classes.php');
if(isset($_POST['CheckLastWeek'])){
    $temp=$_SESSION['SeletedDate'];
    $_SESSION['SeletedDate']=date('Y-m-d',strtotime($temp."-1week"));
    unset($_POST['CheckLastWeek']);
}else if(isset($_POST['CheckNextWeek'])){
    $temp=$_SESSION['SeletedDate'];
    $_SESSION['SeletedDate']=date('Y-m-d',strtotime($temp."+1week"));
    unset($_POST['CheckNextWeek']);
}
function Generate_Week_Days()
{
    $Shift=new shifts();
    $_SESSION['SeletedDate']=$Shift->GetFirstDayOfTheWeek($_SESSION['SeletedDate']);
    for($i=0;$i<5;$i++){
        $date=date("F j",strtotime($_SESSION["SeletedDate"].'+'.$i.'day')); 
        $dayoftheweek=date("l",strtotime($date)); 
        //Specifying Today by different color
        if(date('Y-m-d',strtotime($date))==date("Y-m-d"))
        {
            echo '<div class="Week_Day_Today">';
        }
        else
        {
            echo '<div class="Week_Day">';
        }
        echo '('.$date.')';
        echo "<br>";
        echo $dayoftheweek;
        echo '</div>';

    }                          
}
//Auto generate the checkbox
//Box-Model
/**********************/
/*    index of the chebox 
/*Day:  M   T   W   T   F
/*    ----------------------
/*    | 0 | 3 | 6 | 9 | 12 |
/*    |--------------------|
/*    | 1 | 4 | 7 | 10| 13 |
/*    |--------------------|
/*    | 2 | 5 | 8 | 11| 14 |
/*    ----------------------
/**********************/
function Generate_Checkbox()
{   
    $Shift=new shifts();
    $preferenceshifts=$Shift->GetPerferedShifts($_SESSION['SeletedDate']);
    for($i=0;$i<15;$i++)
    {
        echo '<div class="CheckBox_Container">';
        echo '<label class="customer_checkbox_container">';
        echo '<input class="default_checkbox" type="checkbox" name="';
        //Note this date has been change to the first of the week
        $day="";
        //index of the day of the week
        if($i=='0'||$i=='1'||$i=='2'){$weekday=0;}
        else if($i=='3'||$i=='4'||$i=='5'){$weekday=1;}
        else if($i=='6'||$i=='7'||$i=='8'){$weekday=2;}
        else if($i=='9'||$i=='10'||$i=='11'){$weekday=3;}
        else if($i=='12'||$i=='13'||$i=='14'){$weekday=4;}
        $temp=date('Y-m-d',strtotime($preferenceshifts[$weekday]->Get_Shift_Date()));
        //name tag for the input (e.g 2020-11-1[0],2020-11-1[1])
        echo $temp.'[]'.'"';  
        $shifttype="";
        if($i=='0'||$i=='3'||$i=='6'||$i=='9'||$i=='12'){$shifttype='Morning';}
        else if($i=='1'||$i=='4'||$i=='7'||$i=='10'||$i=='13'){$shifttype='Afternoon';} 
        else if($i=='2'||$i=='5'||$i=='8'||$i=='11'||$i=='14'){$shifttype='Evening';}
        echo ' value="'.$shifttype.'"';   
        if($preferenceshifts[$weekday]->Get_Shift_Type()=="")
        {
            echo '>';
        }
        else
        { //Check the shifttype
            $type=$preferenceshifts[$weekday]->Get_Shift_Type();
            if($weekday==0){
                if($i=='0'&&($type=="Morning"||$type=="Morning_Afternoon"||$type=="Morning_Evening")){echo 'checked>';}
                elseif($i=='1'&&($type=="Afternoon"||$type=="Morning_Afternoon"||$type=="Afternoon_Evening")){echo 'checked>';}
                elseif($i=='2'&&($type=="Evening"||$type=="Morning_Evening"||$type=="Afternoon_Evening")){echo 'checked>';}
                else{echo '>';}
            }
            elseif($weekday==1){
                if($i=='3'&&($type=="Morning"||$type=="Morning_Afternoon"||$type=="Morning_Evening")){echo 'checked>';}
                elseif($i=='4'&&($type=="Afternoon"||$type=="Morning_Afternoon"||$type=="Afternoon_Evening")){echo 'checked>';}
                elseif($i=='5'&&($type=="Evening"||$type=="Morning_Evening"||$type=="Afternoon_Evening")){echo 'checked>';}
                else{echo '>';}
            }
            elseif($weekday==2){
                if($i=='6'&&($type=="Morning"||$type=="Morning_Afternoon"||$type=="Morning_Evening")){echo 'checked>';}
                elseif($i=='7'&&($type=="Afternoon"||$type=="Morning_Afternoon"||$type=="Afternoon_Evening")){echo 'checked>';}
                elseif($i=='8'&&($type=="Evening"||$type=="Morning_Evening"||$type=="Afternoon_Evening")){echo 'checked>';}
                else{echo '>';}
            }
            elseif($weekday==3){
                if($i=='9'&&($type=="Morning"||$type=="Morning_Afternoon"||$type=="Morning_Evening")){echo 'checked>';}
                elseif($i=='10'&&($type=="Afternoon"||$type=="Morning_Afternoon"||$type=="Afternoon_Evening")){echo 'checked>';}
                elseif($i=='11'&&($type=="Evening"||$type=="Morning_Evening"||$type=="Afternoon_Evening")){echo 'checked>';}
                else{echo '>';}
            }
            elseif($weekday==4){
                if($i=='12'&&($type=="Morning"||$type=="Morning_Afternoon"||$type=="Morning_Evening")){echo 'checked>';}
                elseif($i=='13'&&($type=="Afternoon"||$type=="Morning_Afternoon"||$type=="Afternoon_Evening")){echo 'checked>';}
                elseif($i=='14'&&($type=="Evening"||$type=="Morning_Evening"||$type=="Afternoon_Evening")){echo 'checked>';} 
                else{echo '>';}
            }            
        }               
        echo' <span class="customer_checkbox">';
        echo'</span>';
        echo '</div>';
    }
}
if(isset($_POST['btn_submit_form']))
{
    $ShiftController=new shifts();
    $startingdate=$ShiftController->GetFirstDayOfTheWeek($_SESSION['SeletedDate']);
    $result=$ShiftController->UpdatePreferenceShift($startingdate);
    if($result==false)
    {
        echo "Error: Submition Unsuccessful ,Please Check You did Submit correct Value ~ !";
    }
    unset($_POST['btn_submit_form']);
}
?>  
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://kit.fontawesome.com/7beb03d50e.js" crossorigin="anonymous"></script>
    <link href="../CSSFiles/PreferedShift.css" type="text/css" rel="stylesheet" />
    <title>Preference Schedule</title>
</head>
<body>
<div class="Container">
<div class="SideNote" >
<h3>Note: For Checking Your Preference Submition</h3>
<div class="lightGreen_Container"><div class="lightGreen">Unset</div></div>
<div class="darkGreen_Container"><div class="darkGreen">Setted</div></div>
</div>
    <div class="Preference_Shift_Form_Container">
        <div class=Form_Title>
            <form method="post" action="#">
                <button class="btn_CheckLastWeek" type="submit" name="CheckLastWeek"><</button>
            </form>
            <?php  $year=date("Y",strtotime($_SESSION["SeletedDate"])); 
                   $week=date("W",strtotime($_SESSION["SeletedDate"])); 
                   echo '<div class="Date_On_Calendar_Title">'.'Year - '.$year.' WEEK - '.$week.'</div>';
            ?>
            <form method="post" action="#">
                <button class="btn_CheckNextWeek" type="submit" name="CheckNextWeek">></button>
            </form>
        </div>
        <div class="Week_Days">
                           <div class="Week_Day_Empty"></div>                          
                               <?php Generate_Week_Days();?>       
        </div>
        <div class="Form_Container">
            <div class="Sift_Types">
                <div class="Shit_Type">Morning<br>(08:00~12:00)</div>
                <div class="Shit_Type">Afternoon<br>(12:30~17:00)</div>
                <div class="Shit_Type">Evening<br>(12:30~17:00)</div>
            </div>
            <div class="Shift_Form_Container">
                <form method="post" action="#" ><!--test.php -->
                    <div class="CheckBox_Shift_Type_Container">
                    <?php
                       Generate_Checkbox(); 
                    ?>
                    </div>
                    <?php 
                        $today=new DateTime("now");
                        $temp=date("Y-m-d",strtotime($_SESSION['SeletedDate']));
                        $SelectedDay=new DateTime($temp);
                        //In Generate_Checkbox() it will always update $_SESSION['SeletedDate'] to the first day of the current week
                        //The User couldn't submit his/her shift on current week or previous version.
                        if($SelectedDay>$today)
                        {
                            echo '<button class="btn_submit_form" type="submit" name="btn_submit_form"><i class="fas fa-arrow-circle-up"> Submit Your Preference</i></button>';
                        }
                        else
                        {
                            echo '<div class="Notice">';
                            echo 'Note: You Can Only Submit Your Preference Shifts For The Future Week~!';
                            echo '</div>';
                        }                        
                    ?>
                    
                </form>
            </div>
        </div>
    </div>
</div>
</body>
</html>