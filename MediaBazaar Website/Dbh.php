 <?php
 class Dbh{    
    
private $host ="studmysql01.fhict.local";
private $db ="dbi443880";
private $DbUsername ="dbi443880";
private $DbPassword ="123456";
public $assignedShitsDate =[];
public $assignedShitsTime=[];


protected function connection(){
$dsn='mysql:host='. $this->host  . ';dbname=' .  $this->db;
$conn=new PDO($dsn, $this->DbUsername, $this->DbPassword);
// if ($conn->connect_error) {
//     die("Connection failed: " . $conn->connect_error);
// }
return $conn;
}



public function CheckUsers($email,$password){
    $sql="SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd)";
    $conn= $this->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uEmail'=> $email,'pwd'=>$password]);
    $result=$stmt->fetch();
    $BSN=$result['BSN'];
    
    if($BSN!=0){
        session_start();
        $_SESSION["BSN"]=$BSN;
        header("Location:seeCalender.php");
        return true;
    }
// $conn->close();
}

public function GetAllShiftsForEmployee($BSN){
    $sql="SELECT * FROM `assignedschdule` Where BSN=(:uBSN)";
    $conn= $this->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uBSN'=> $BSN]);
    $result=$stmt->fetch();
//add all values to assignedShitsDate array
    for($i = 0 ; $i <$result=$stmt->fetch() ; $i++) {
        $assignedShitsDate[$i] = $result['date'] ;
        }
        for($i = 0 ; $i <$result=$stmt->fetch() ; $i++) {
            $assignedShitsTime[$i] = $result['assigned_shift_type'] ;
            }
    return $assignedShitsDate;

 }
 public function __destruct()
{
 unset($this->Dbh);
}

}  
?>