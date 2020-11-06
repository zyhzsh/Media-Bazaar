<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale= ">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="../CSSFiles/navigationbar.css" type="text/css" rel="stylesheet" />
    <?php   require_once('classes.php');?>
    <title>Document</title>
</head>
<body>
    
<div class="sidenav">
<a href="?page=pageLogin">Login</a>
<a href="?page=pageAssignedShift"><?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn!=0){echo 'Assigned shifts';} ?></a>
<a href="?page=pagePreferedShift"><?php $session=session:: getInstance();
    $bsn=$session-> __get('BSN'); 
    if($bsn!=0){echo 'Assigned shifts';} ?></a>

</div>


</body>
</html>