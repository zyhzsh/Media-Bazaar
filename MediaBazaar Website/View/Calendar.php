<?php

//When the user click the button to check next month
//Change the "SeletedDate" to first day of the next month.
if(isset($_POST['CheckLastMonth'])){
    $temp=$_SESSION['SeletedDate'];
    $_SESSION['SeletedDate']=date('Y-m-1',strtotime($temp."-1months"));
    unset($_POST['CheckLastMonth']);
}else if(isset($_POST['CheckNextMonth'])){
    $temp=$_SESSION['SeletedDate'];
    $_SESSION['SeletedDate']=date('Y-m-1',strtotime($temp."+1months"));
    unset($_POST['CheckNextMonth']);
}
$shifts=new shifts();
$assignedshifts=$shifts->GetShifts($_SESSION['SeletedDate']);
function Grid_Item_In_Calendar($assignedshifts)
{   
    for($i=0;$i<42;$i++)
    {         
        $day=$assignedshifts[$i]->Get_Shift_Date();
        $shifttype=$assignedshifts[$i]->Get_Shift_Type();
        if(date('Y-m',strtotime($day))==date('Y-m',strtotime($_SESSION['SeletedDate'])))
        {
            if(date('Y-m-d',strtotime($day))==date('Y-m-d'))
            {
                echo '<div class="Grid_Item_In_Calendar_Today">';
            }
            else
            {
                echo '<div class="Grid_Item_In_Calendar_Current_Month">';
            }
        }
        else
        {
            echo '<div class="Grid_Item_In_Calendar">';
        }              
            echo '<div class="Day"><div>';
            echo date('d',strtotime($day));
            echo '</div></div><div class="ShiftInfo">';
            //echo $shifttype;
            if($shifttype=="Morning")
            {
                echo '<i class="far fa-sun"></i>';
            }
            else if ($shifttype=="Afternoon")
            {
                echo '<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path d="M24 23h-24v-2h24v2zm-24-6v2h4.069c-.041-.328-.069-.661-.069-1s.028-.672.069-1h-4.069zm7.103-5.312l-2.881-2.881-1.415 1.414 2.881 2.881c.412-.529.886-1.003 1.415-1.414zm5.897-10.688h-2v5h-3l4 4 4-4h-3v-5zm6.931 16c.041.328.069.661.069 1s-.028.672-.069 1h4.069v-2h-4.069zm-7.931-5c-3.314 0-6 2.686-6 6 0 .341.035.674.09 1h11.82c.055-.326.09-.659.09-1 0-3.314-2.686-6-6-6zm7.778-3.193l-2.881 2.881c.528.411 1.003.886 1.414 1.414l2.881-2.881-1.414-1.414z"/></svg>';
            }
            else if ($shifttype=="Evening")
            {
                echo '<i class="far fa-moon"></i>';
            }
            else if($shifttype=="Morning_Afternoon")
            {
                echo '<i class="far fa-sun"></i>'.'<br>';
                echo '<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path d="M24 23h-24v-2h24v2zm-24-6v2h4.069c-.041-.328-.069-.661-.069-1s.028-.672.069-1h-4.069zm7.103-5.312l-2.881-2.881-1.415 1.414 2.881 2.881c.412-.529.886-1.003 1.415-1.414zm5.897-10.688h-2v5h-3l4 4 4-4h-3v-5zm6.931 16c.041.328.069.661.069 1s-.028.672-.069 1h4.069v-2h-4.069zm-7.931-5c-3.314 0-6 2.686-6 6 0 .341.035.674.09 1h11.82c.055-.326.09-.659.09-1 0-3.314-2.686-6-6-6zm7.778-3.193l-2.881 2.881c.528.411 1.003.886 1.414 1.414l2.881-2.881-1.414-1.414z"/></svg>';

            }
            else if($shifttype=="Morning_Evening")
            {
                echo '<i class="far fa-sun"></i>'.'<br>';
                echo '<i class="far fa-moon"></i>';
            }
            else if($shifttype=="Afternoon_Evening")
            {
                echo '<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path d="M24 23h-24v-2h24v2zm-24-6v2h4.069c-.041-.328-.069-.661-.069-1s.028-.672.069-1h-4.069zm7.103-5.312l-2.881-2.881-1.415 1.414 2.881 2.881c.412-.529.886-1.003 1.415-1.414zm5.897-10.688h-2v5h-3l4 4 4-4h-3v-5zm6.931 16c.041.328.069.661.069 1s-.028.672-.069 1h4.069v-2h-4.069zm-7.931-5c-3.314 0-6 2.686-6 6 0 .341.035.674.09 1h11.82c.055-.326.09-.659.09-1 0-3.314-2.686-6-6-6zm7.778-3.193l-2.881 2.881c.528.411 1.003.886 1.414 1.414l2.881-2.881-1.414-1.414z"/></svg>';
                echo '<i class="far fa-moon"></i>';
            }
            echo'</div></div>';   
    }  
}
?>
<html>
<head>   
<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale= ">
    <title>Calendar</title>
<link href="../CSSFiles/CalendarStyle.css" type="text/css" rel="stylesheet" />
</head>
<header>
<form method="post" action="">
    <input class='btn-logout' type="submit" name="logoutBtn" value='logout' />
</form>
<script src="https://kit.fontawesome.com/7beb03d50e.js" crossorigin="anonymous"></script>
</header>
<div class="Container">
    <div class="Calendar_Container">
        <div class="Calendar_Title">
            <form method="post" action="#">
                <button type="submit" name="CheckLastMonth"><</button>
            </form>
            <?php echo $_SESSION["SeletedDate"]; ?>
            <form method="post" action="#">
                <button type="submit" name="CheckNextMonth">></button>
            </form>
        </div>
        <div class="Week_Days">
                           <div class="Week_Day">Monday</div>
                           <div class="Week_Day">Tuesday</div>
                           <div class="Week_Day">Wednesday</div>
                           <div class="Week_Day">Thursday</div>
                           <div class="Week_Day">Friday</div>
                           <div class="Week_Day">Saturday</div>
                           <div class="Week_Day">Sunday</div>
        </div>
        <div class="Calendar">
            <?php        
            Grid_Item_In_Calendar($assignedshifts);
            ?>


        </div> 
    </div>
</div>
</html>       