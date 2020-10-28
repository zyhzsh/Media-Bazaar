 <?php
 require_once('Controller/classes.php');
 class Dbh{    
    
private $host ="studmysql01.fhict.local";
private $db ="dbi443880";
private $DbUsername ="dbi443880";
private $DbPassword ="123456";
private $BSN;


private  function session(){
 return session::getInstance();
}

protected function connection(){
    try{
    $dsn='mysql:host='. $this->host  . ';dbname=' . $this->db;
    $conn=new PDO($dsn, $this->DbUsername, $this->DbPassword);
    } 
    catch(PDOException $e) 
        { 
        echo "pdo connection field";
        }
     return $conn;
}


public function CheckUsers($email,$password){
    $sql="SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd)";
    $conn=$this->connection();
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

public function GetAllUserShifts($BSN){
    $session=$this->session();
  
    if($BSN!=0){
        $sql="SELECT * FROM `assignedschdule` WHERE BSN=(:uBSN)";
        $conn=$this->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':uBSN'=>$BSN]);
       $result=$stmt->fetchAll();
       return $result;
    }else{
        
        return 'not availble';
    }
    $conn->close();
 }

 public function GetAllPreferedUserShifts($BSN){
    $session=$this->session();
  
    if($BSN!=0){
        $sql="SELECT * FROM `preferedschdule` WHERE BSN=(:uBSN)";
        $conn=$this->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':uBSN'=>$BSN]);
        $result=$stmt->fetchAll();
       return $result;
    }else{
        
        return 'not availble';
    }
    $conn->close();
 }

 public function AddPreferedShift($BSN,$date,$shiftType){

    $session=$this->session();
    if($BSN!=0){
        $sql="INSERT INTO `preferedschdule` (`BSN`, `date`, `preference_shift_type`) VALUES (':BSN', ':date', ':shiftType')";
        $conn=$this->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':BSN'=>$BSN]);
        $stmt->execute([':date'=>$date]);
        $stmt->execute([':shiftType'=>$shiftType]);
        return $shiftType;
    }else{
        return false;
    }
 }
 
}  
?>