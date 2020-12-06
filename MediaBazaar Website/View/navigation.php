<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
<?php   require_once('classes.php');?>
<div id="mySidenav" class="sidenav">
<a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
<a href="?page=pageLogin"><?php $session=session:: getInstance();
    if(!$session-> __isset('BSN')){echo 'Login';} ?></a>
<a href="?page=pageProfile"><?php $session=session:: getInstance();

    if($session-> __isset('BSN')){echo 'Profile';} ?></a>
<a href="?page=pageAssignedShift"><?php $session=session:: getInstance();
    if($session-> __isset('BSN')){echo 'Assigned shifts';} ?></a>
<a href="?page=pageAvailability"><?php $session=session:: getInstance();
    if($session-> __isset('BSN')){echo 'Availability shifts';} ?></a>    
<form method="post" action="">
    <?php $session=session:: getInstance();
    if($session-> __isset('BSN')){echo '<button class="btn_logout" value="logout" type="submit" name="logoutBtn"> <i class="fas fa-sign-out-alt"> SignOut</i></button>';} ?>
    </form>
</div>
<span style="font-size:30px;cursor:pointer;position: fixed;" onclick="openNav()">&#9776; Menu</span>

<script>
function openNav() {
  document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
}
</script>