<html>
<head>   
<link href="CSSFiles/calanderStyle.css" type="text/css" rel="stylesheet" />
<?php include_once('User.php');?> 
</head>
<header>
<button class='logoutbt' type="submit" name="logoutBtn" onClick=<?php  $user->logout(); ?> > Logout </button>
</header>
<body>

 <input type="date" id="selctedDate" value="dd/mm/yyyy"   onClick=<?php  $user->AddShiftsToCalander(); ?> >]
 

</body>
</html>       