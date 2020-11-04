<?php 
 require_once('classes.php');
class ShiftsModel {


    private  function session(){

        return session::getInstance();
        
        }

    public function GetAllUserShifts($BSN){
        $session=$this->session();
        $dbh=new Dbh();
        if($BSN!=0){
            $sql="SELECT * FROM `assignedschdule` WHERE BSN=(:uBSN)";
            $conn=$dbh->connection();
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
        $dbh=new Dbh();
        if($BSN!=0){
            $sql="SELECT * FROM `preferedschdule` WHERE BSN=(:uBSN)";
            $conn=$dbh->connection();
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
        $dbh=new Dbh();
        $session=$this->session();
        if($BSN!=0){
            $sql="INSERT INTO `preferedschdule` (`BSN`, `dateShift`, `preference_shift_type`) VALUES (:BSN, :selectedDate, :shiftType)";
            $conn=$dbh->connection();
            $stmt=$conn->prepare($sql);
            $stmt->execute(['BSN'=>$BSN,'selectedDate'=>$date,'shiftType'=>$shiftType]);
            return $shiftType;
        }else{
            return false;
        }
     }

}
?>