 <?php
 class Dbh{    
    
private $host ="studmysql01.fhict.local";
private $db ="dbi443880";
private $DbUsername ="dbi443880";
private $DbPassword ="123456";
private $BSN;




public function connection(){
    try{
    $dsn='mysql:host='. $this->host  . ';dbname=' . $this->db;
    $conn=new PDO($dsn, $this->DbUsername, $this->DbPassword);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    } 
    catch(PDOException $e) 
        { 
        echo "pdo connection field";
        }
     return $conn;
}



 
}  
?>