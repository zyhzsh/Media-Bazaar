<?php
require_once('classes.php');
//Pretreatment
//Redirect Post Request (Submition of the Availability Shift) 
if (isset($_POST['btn_submit_form'])) {
    $ShiftController = new ShiftController();
    $result = $ShiftController->UpdateAvailability();
    if ($result == false) {
        echo "The submission has to be more than your FTE, Please Check Your Submission Again.";
    }
    unset($_POST['btn_submit_form']);
}
//Auto Genrate GUI Functions
//Box-Model
/**********************/
/*    index of the checkbox 
/*Day:  M   T   W   T   F
/*    ----------------------
/*    | 0 | 3 | 6 | 9 | 12 |
/*    |--------------------|
/*    | 1 | 4 | 7 | 10| 13 |
/*    |--------------------|
/*    | 2 | 5 | 8 | 11| 14 |
/*    ----------------------
/**********************/
//1.Day of the Week in the Box 
function Generate_Week_Days()
{
    echo '<div class="Week_Day">Monday</div>';
    echo '<div class="Week_Day">Tuesday</div>';
    echo '<div class="Week_Day">Wednesday</div>';
    echo '<div class="Week_Day">Thursday</div>';
    echo '<div class="Week_Day">Friday</div>';
}
//2.Avialbility checkBoxs*15 
function Generate_Checkbox()
{
    $Shift = new ShiftController();
    $availability = $Shift->GetAvailability();
    $dayontheweek = "";
    $name = "";
    $value = "";
    if ($availability != null) {
        for ($i = 0; $i < 15; $i++) {    //1.filter the index to the day
            //2.formulating $_POST request name to met the checkbox setting
            //3.Setting Posting value
            if ($i == '0' || $i == '1' || $i == '2') {
                $dayontheweek = 1;
                $name = "Monday[]";
            } //monday
            else if ($i == '3' || $i == '4' || $i == '5') {
                $dayontheweek = 2;
                $name = 'Tuesday[]';
            } //tuesday
            else if ($i == '6' || $i == '7' || $i == '8') {
                $dayontheweek = 3;
                $name = 'Wednesday[]';
            } //wednsday
            else if ($i == '9' || $i == '10' || $i == '11') {
                $dayontheweek = 4;
                $name = 'Thursday[]';
            } //thursday
            else if ($i == '12' || $i == '13' || $i == '14') {
                $dayontheweek = 5;
                $name = 'Friday[]';
            } //friday                              
            //formulating shifttype to met the checkbox setting
            $checked = "";
            $shifttype = $availability->Get_Availability_By_Day_Of_The_Week($dayontheweek);
            if ($i == '0' || $i == '3' || $i == '6' || $i == '9' || $i == '12') {
                $value = "Morning";
                if ($shifttype == "Morning" || $shifttype == "Morning_Afternoon" || $shifttype == "Morning_Evening" || $shifttype == "FullDay") {
                    $checked = 'checked';
                }
            } elseif ($i == '1' || $i == '4' || $i == '7' || $i == '10' || $i == '13') {
                $value = "Afternoon";
                if ($shifttype == "Afternoon" || $shifttype == "Morning_Afternoon" || $shifttype == "Afternoon_Evening" || $shifttype == "FullDay") {
                    $checked = 'checked';
                }
            } elseif ($i == '2' || $i == '5' || $i == '8' || $i == '11' || $i == '14') {
                $value = "Evening";
                if ($shifttype == "Evening" || $shifttype == "Morning_Evening" || $shifttype == "Afternoon_Evening" || $shifttype == "FullDay") {
                    $checked = 'checked';
                }
            }
            echo
                '<div class="CheckBox_Container">
            <label class="customer_checkbox_container">
            <input class="default_checkbox" type="checkbox" name="' . $name . '" value="' . $value . '"' . $checked . '>
            <span class="customer_checkbox"></span>
            </div>';
        }
    } else { //The user first time setting his Availibility
        for ($i = 0; $i < 15; $i++) {
            if ($i == '0' || $i == '1' || $i == '2') {
                $dayontheweek = 1;
                $name = "Monday[]";
            } //monday
            else if ($i == '3' || $i == '4' || $i == '5') {
                $dayontheweek = 2;
                $name = 'Tuesday[]';
            } //tuesday
            else if ($i == '6' || $i == '7' || $i == '8') {
                $dayontheweek = 3;
                $name = 'Wednesday[]';
            } //wednsday
            else if ($i == '9' || $i == '10' || $i == '11') {
                $dayontheweek = 4;
                $name = 'Thursday[]';
            } //thursday
            else if ($i == '12' || $i == '13' || $i == '14') {
                $dayontheweek = 5;
                $name = 'Friday[]';
            } //friday                              
            //formulating shifttype to met the checkbox setting
            $checked = "";
            if ($i == '0' || $i == '3' || $i == '6' || $i == '9' || $i == '12') {
                $value = "Morning";
            } elseif ($i == '1' || $i == '4' || $i == '7' || $i == '10' || $i == '13') {
                $value = "Afternoon";
            } elseif ($i == '2' || $i == '5' || $i == '8' || $i == '11' || $i == '14') {
                $value = "Evening";
            }
            echo
                '<div class="CheckBox_Container">
            <label class="customer_checkbox_container">
            <input class="default_checkbox" type="checkbox" name="' . $name . '" value="' . $value . '"' . $checked . '>
            <span class="customer_checkbox"></span>
            </div>';
        }
    }
}

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=yes ">
    <script src="https://kit.fontawesome.com/7beb03d50e.js" crossorigin="anonymous"></script>
    <link href="../CSSFiles/AvailibilityShift.css" type="text/css" rel="stylesheet" />
    <title>Preference Schedule</title>
</head>

<body>
    <div class="Container">
        <div class="SideNote">
            <h3>Note: For Checking Your Preference Submition</h3>
            <div class="Unset_Container">
                <div class="Unset_box">Unset</div>
            </div>
            <div class="Setted_Container">
                <div class="Setted_box">Setted</div>
            </div>
        </div>
        <div class="Container">
            <div class="Preference_Shift_Form_Container">
                <div class=Form_Title>
                    <?php
                    echo '<div class="Date_On_Calendar_Title">Setting You Availability For the Next Week</div>';
                    ?>
                </div>
                <div class="Week_Days">
                    <div class="Week_Day_Empty"></div>
                    <?php Generate_Week_Days(); ?>
                </div>
                <div class="Form_Container">
                    <div class="Sift_Types">
                        <div class="Shit_Type">Morning<br>(08:00~12:00)</div>
                        <div class="Shit_Type">Afternoon<br>(12:30~17:00)</div>
                        <div class="Shit_Type">Evening<br>(12:30~17:00)</div>
                    </div>
                    <div class="Shift_Form_Container">
                        <form method="post" action="#">
                            <!--test.php -->
                            <div class="CheckBox_Shift_Type_Container">
                                <?php
                                Generate_Checkbox();
                                ?>
                            </div>
                            <button class="btn_submit_form" type="submit" name="btn_submit_form"><i class="fas fa-arrow-circle-up"> Submit Your Preference</i></button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
</body>

</html>