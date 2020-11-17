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

//** the 4 functions below this comment is for changing password **//


public function resetPassword($BSN,$password){
    // the password get change hire
    echo $BSN . $password;
    $str=rand(); 
    $randomKey = md5($str); 
    $dbh=new Dbh();
    $sql="UPDATE `employee` SET `password` =(:ps) WHERE `employee`.`BSN` =(:bsn)";
    $conn=$dbh->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute(['ps'=>$password,'bsn'=> $BSN]);
    $result=$stmt->fetch();
     

   //delete the the password key after the passsword was sucsufully changed
   //***NOT WORKING */
   $email=$result['contact_email'];
   echo $email;
   $sql="DELETE FROM `changepassword` WHERE `changepassword`.`Email` =(:em)";
   $conn=$dbh->connection();
   $stmt=$conn->prepare($sql);
   $stmt->execute(['em'=> $email]);
   return true;
 }


 //thise function check when the user open the reset page if he have the right to enter the page 
 //if he have the right to open the reset page a new session wil start with his BSN number 
public function CheckPasswordKey($passwordKey){
    $dbh=new Dbh();
    $sql="SELECT * FROM `changepassword` Where PasswordKey=(:uPasswordKey)";
    $conn=$dbh->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uPasswordKey'=> $passwordKey]);
    $result=$stmt->fetch();;
    if(empty($result)){
        return false;
    }
    if($result['PasswordKey']==$passwordKey){
        $email=$result['Email'];
        $sql="SELECT `BSN` FROM `employee` Where contact_email=(:uEmail) ";
        $conn=$dbh->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':uEmail'=> $email]);
        $result=$stmt->fetch();
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

//*****THIS IS THE MEDIABAZAAR REAL EMAIL AND PASSWORD */
//email:mediabazaar4@gmail.com
//password:mediabazaar4-pass
//**NOTE WORKING(Sending an email with the link of the reseting page and password Key) */
public function SendverificationEmail($email,$passwordKey){
    $to_email = $email;
    $subject = 'Click this link to change your mediabazaar password';
    $message = 'index.php?page=PageresetPassword?Key='.$passwordKey;
    $headers = 'From:mediabazaar4@gmail.com';
    mail($to_email,$subject,$message,$headers);
    }

//this method add a random password key and save it in the database(table:changepassword) 
//after that we pass the email and randome password key to the  "SendverificationEmail" function
public function AddverificationPassword($email){
    $str=rand(); 
    $randomKey = md5($str); 
    $dbh=new Dbh();
    $sql="INSERT INTO `changepassword` (`Email`, `PasswordKey`) VALUES  ((:uEmail),(:PasswordKey))";
    $conn=$dbh->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uEmail'=> $email,':PasswordKey'=>$randomKey]);
    $result=$stmt->fetch();;
    $this->SendverificationEmail($email,$randomKey);

}

//this function check  if the entered email exist in the database and returm bool
public function CheckEmail($checkEmail){
    $dbh=new Dbh();
    $sql="SELECT * FROM `employee` Where contact_email=(:uEmail)";
    $conn=$dbh->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uEmail'=> $checkEmail]);
    $result=$stmt->fetch();;
    if(empty($result)){
        return false;
    }else{
        $this->AddverificationPassword($checkEmail);
        return true;
    }

}

}




?>