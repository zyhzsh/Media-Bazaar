<html>
<head>   
<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale= ">
    <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
    <title>Prefered shifts</title>
<link href="../CSSFiles/calendarStyle.css" type="text/css" rel="stylesheet" />
<link href="../CSSFiles/loginStyle.css" type="text/css" rel="stylesheet" />

<?php   require_once('classes.php');?> 
</head>
<header>
    <form  method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
    <input class='logoutbt' type="submit" name="logoutBtn" value='logout' />
    </form>


</header>

<body>

<form  method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
<h3> Select a day to choose a prefered shift : </h3>
<input  class='input' type="date" data-date="" data-date-format="YYYY MM DD"  name="selctedPreferedDate"><br> 
<label for="myCheck">Morning:</label> 
<input type="checkbox" id="Morning"  name="Morning"><br>
<label for="myCheck">Afternone:</label> 
<input type="checkbox" id="Afternone"  name="Afternoon"><br>
<label for="myCheck">Evening:</label> 
<input type="checkbox" id="Evening"  name="Evening"><br>
<input class='input' type="submit" name="savePreferedSchudle" value='save my prefered schudle ' /><br>
</form>
<form  method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
<input class='input' type="submit" name="ShowAllPreferedShifts" value='show all my prefered shifts'/>
</form>
<?php
$shift= new shifts();
 
if(empty($_POST['selctedPreferedDate'])){
echo"choose date to save your prefered shift";
}else
{


  if(empty($_POST['Morning'])&&empty($_POST['Afternoon'])&&empty($_POST['Evening'])){
    echo "Selecet a shift time to save a prefered shift time";
  }else
  {
    $shiftType="";
    if(!empty($_POST['Morning'])){$shiftType=$shiftType.'Morning';}
    if(!empty($_POST['Afternoon'])){$shiftType=$shiftType.'Afternoon';}
    if(!empty($_POST['Evening'])){$shiftType=$shiftType.'Evening';}
    $selected_date = date('yy-m-d', strtotime($_POST['selctedPreferedDate']));
    if($shift->AddPreferedShift($selected_date,$shiftType)==true){
  echo'<h3 style="color:#831d03">Added sucssfuly</h3>';
  }else
  {
    echo"something wrong";
  }
  }


}

  if (isset($_POST['ShowAllPreferedShifts'])) {
    echo'<h3>Date:    &nbsp;&nbsp;&nbsp;   Shift:</h3>';
     echo  $shift->ShowAllPreferedShifts();
    
  }
?>
 
</body>
</html>       