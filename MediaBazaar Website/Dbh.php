 <?php
 class Dbh{    
    
private $host ="studmysql01.fhict.local";
private $db ="dbi443880";
private $DbUsername ="dbi443880";
private $DbPassword ="123456";
public $assignedShitsDate=array(1 =>'18-10-2020');
public $assignedShitsType=[];


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
    $BSN;
    
    if(empty( $result=$stmt->fetch())){
        return false;
    }else{
     
        session_start();
        $BSN=$result['BSN'];
        $_SESSION["BSN"]=$BSN;
        header("Location:seeCalender.php");
        return true;
    }
// $conn->close();
}

public function AddShiftsDate(){
    if(isset($_POST['BSN'])){
        $BSN=$_POST['BSN'];
        $sql="SELECT * FROM `preferedschdule` WHERE BSN=(:uBSN)";
        $conn= $this->connection();
        $stmt=$conn->prepare($sql);
        $stmt->execute([':uBSN'=> $BSN]);
        $result=$stmt->fetch_array();
       
    //add all values to assignedShitsDate array
        // for($i = 0 ; $i <$result=$stmt->fetch_array() ; $i++) {
        //     $assignedShitsDate[$i] =array(  $i =>$result['date'] );
        // }
    }
 }

 public function AddShiftsTypes(){
    if(isset($_POST['BSN'])){
        $BSN=$_POST['BSN'];
    $sql="SELECT * FROM `preferedschdule` WHERE BSN=(:uBSN)";
    $conn= $this->connection();
    $stmt=$conn->prepare($sql);
    $stmt->execute([':uBSN'=> $BSN]);
    $result=$stmt->fetch_array();
 
    //add all values to assignedShitsType array
   // while ($row = $result=$stmt->fetch_array() ) {
     //  for($i = 0 ; $i <$result=$stmt->fetch_array() ; $i++) {
        //    $assignedShitsType=array( 1 =>  $result['preference_shift_type'] );
     //   }
    //}
   }
 }
 
 public function GetAllShiftsDate(){
    $this->AddShiftsDate();
    //****untill i fix the array tha takes values from fetched database i added a mock data  */
    //if(isset($assignedShitsDate)){
  $assignedShitsDate=array(1 =>'2020-10-20',2 =>'2020-10-18',3 =>'2020-10-17');
    return  $assignedShitsDate;
  //  }
 }

 public function GetAllShiftsTypes(){
     $this->AddShiftsTypes();
    //if(isset($assignedShitsType)){
        $assignedShitsType=array(1 =>'Evening',2 =>'Morning',3 =>'Afternoon');
        return $assignedShitsType;
//}
 }



//  public function __destruct()
// {
//  unset($this->Dbh);
// }

}  
?>