
<div class="sidenav">
<a href=?page=pageLogin> <?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn==0){echo 'Login';}?> </a>
    <a href=?page=PersonalInfo> <?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if(isset($bsn)){echo'Personal Info' ;}?> </a>
<a href="?page=pageAssignedShift"><?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn!=0){echo 'Assigned shifts';} ?></a>
<a href="?page=pagePreferedShift"><?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn!=0){echo 'Prefered shifts';} ?></a>
<form method="post" action="">
    <?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn!=0){echo '<button class="btn_logout" value="logout" type="submit" name="logoutBtn"> <i class="fas fa-sign-out-alt"> SignOut</i></button>';} ?>
    </form>
</div>
