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
<input  class='input' type="date" data-date="" data-date-format="YYYY MM DD"  name="selctedDate" onchange='this.form.submit()' >
</form>
<?php
 if (isset($_POST['selctedDate'])) {
    $selected_date = date('d-m-yy', strtotime($_POST['selctedDate']));
    $user= new User(); echo  $user->AddShiftsToCalander($_POST['selctedDate']);
    
  }
?>
 
</body>
</html>       