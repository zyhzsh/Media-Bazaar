<html>
<head>   
<link href="CSSFiles/calanderStyle.css" type="text/css" rel="stylesheet" />
<?php include('User.php');?> 
</head>
<header>
    <form  method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
    <input class='logoutbt' type="submit" name="logoutBtn" value='logout' />
</form>
</header>

<body>
<form  method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
<h3> Select a day to see when are you assigned : </h3>
<input  class='input' type="date" data-date="" data-date-format="YYYY MM DD"  name="selctedDate" onchange='this.form.submit()'><br> 
<input class='' type="submit" name="ShowAllShifts" value='show all assigned shifts' />
</form>

<?php
$user= new User();
$user= new User();
if(isset($_POST['selctedDate'])){
echo"";
}
 if (isset($_POST['selctedDate'])) {
  if(empty($user->ShowSellectedShift($_POST['selctedDate']))){
  }else{
    $selected_date = date('d-m-yy', strtotime($_POST['selctedDate']));
    echo'<h3>Date:   &nbsp;&nbsp;&nbsp;   Shift:</h3>';
     echo  $user->ShowSellectedShift($_POST['selctedDate']);
  }
  }

  if (isset($_POST['ShowAllShifts'])) {
    echo'<h3>Date:    &nbsp;&nbsp;&nbsp;   Shift:</h3>';
     echo  $user->ShowAllShifts();
    
  }
?>
 
</body>
</html>       