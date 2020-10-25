 <?php
  require_once('classes.php');
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
    // if (!$conn) { 
    //     die("Connection failed: " . mysqli_connect_error()); 
    // } 
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

    if(empty( $result=$stmt->fetch())){
        return false;
    }else{
        $BSN=$result['BSN'];
        $sessionName='BSN';
        $session=$this->session();
        $session->startSession();
        $session->__set($sessionName,$BSN);
        //header("Location:seeCalender.php");
        return true;
    }
 $conn->close();
}

public function GetAllUserShifts($BSN){
    $session=$this->session();
  
    if($BSN!=0){
        //$BSN=$session-> __get('BSN');
        $sql="SELECT * FROM `assignedschdule` WHERE BSN=(:uBSN)";
        $conn=$this->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':uBSN'=>$BSN]);
       // $result=$stmt->fetch_array();
       $result=$stmt->fetchAll();
       return $result;
    }else{
        
        return 'not availble';
    }
    $conn->close();
 }
 
}  
?>