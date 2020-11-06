<?php
 require_once('classes.php');
class UserModel{



private  function session(){

return session::getInstance();

}

public function CheckUsers($email,$password){
    $dbh=new Dbh();
    $sql="SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd)";
    $conn=$dbh->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uEmail'=> $email,'pwd'=>$password]);
    $result=$stmt->fetch();;
    if(empty($result)){
        return false;
    }else{
        
        $BSN=$result['BSN'];
        $sessionName='BSN';
        $session=$this->session();
        $session->startSession();
        $session->__set($sessionName,$BSN);
        return true;
      
    }

}






}
?>