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
      
    
     public function LoadAssignedShift($BSN,$startingdate)
     {
        $session=$this->session();
        $dbh=new Dbh();
        $AssignedShifts=array();
        if($BSN!=0)
        {
            $conn=$dbh->connection();
            $currentdate=$startingdate;
            for($i=0;$i<42;$i++)
            {
                $sql="SELECT * FROM assignedschdule WHERE BSN=(?) and date = (?);";
                $stmt=$conn->prepare($sql);
                $stmt->execute([$BSN,$currentdate]);
                $result=$stmt->fetch();
                if(empty($result))
                {
                    $AssignedShift=new AssignedShift($currentdate,"");
                    $AssignedShifts[$i]=$AssignedShift;
                }
                else 
                {
                    $AssignedShift=new AssignedShift($currentdate,$result['assigned_shift_type']);
                    $AssignedShifts[$i]=$AssignedShift;
                }
                $currentdate=date('Y-m-d',strtotime($currentdate."+1day"));
            }
           return $AssignedShifts;
        }
        else
        {
            return null;
        }
            $conn->close();
     }
}
?>