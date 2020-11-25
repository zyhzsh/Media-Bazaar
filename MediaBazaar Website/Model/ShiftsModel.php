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
                        //disposal the object when it's note used
                        unset($AssignedShift);
                    }
                    else 
                    {
                        $AssignedShift=new AssignedShift($currentdate,$result['assigned_shift_type']);
                        $AssignedShifts[$i]=$AssignedShift;
                        //disposal the object when it's note used
                        unset($AssignedShift);
                    }
                    $currentdate=date('Y-m-d',strtotime($currentdate."+1day"));
                }
                $conn=null;
                return $AssignedShifts;
            }
            else
            {
                return null;
            }
     }
     public function LoadPreferenceShift($BSN,$startingdate)
     {
        $session=$this->session();
        $dbh=new Dbh();
        $preferenceShifts=array();
        if($BSN!=0)
        {
           $conn=$dbh->connection();
           $currentdate=$startingdate;
           for($i=0;$i<5;$i++)
           {
            $sql="SELECT * FROM preferedschdule WHERE BSN=(?) and dateShift =(?)";
            $stmt=$conn->prepare($sql);
            $stmt->execute([$BSN,$currentdate]);
            $result=$stmt->fetch();
            if(empty($result))
            {
                $preferenceShift=new PreferenceShift($currentdate,"");               
                $preferenceShifts[$i]=$preferenceShift;
                unset($preferenceShift);
            }
            else
            {
                $preferenceShift=new PreferenceShift($currentdate,$result['preference_shift_type']);
                $preferenceShifts[$i]=$preferenceShift;
                unset($preferenceShift);
            }
            $currentdate=date('Y-m-d',strtotime($currentdate."+1day"));                
           }
           $conn=null;
           return $preferenceShifts;
        }
        else
        {
            return null;
        }
        
    }







    /********************************************/
    /*                 |                        |
    /* Exist Database  |  Not Exist in database |
    /* ----------------|------------------------|               
    /*   1   |    2    |      3      |    4     |
    /* Empty | Exist   |    Empty    |  Exist   |
    /*Object | Object  |    Object   |  Object  |
    /*       |         |             |          | 
    /********************************************/ 
    //1.DELETE
    //2.UPDATE
    //3.Do Nothing
    //4.INSERT
    public function Update_Preference_Shifts($BSN,$PreferenceShifts)
    {
        $session=$this->session();
        $dbh=new Dbh();
        if($BSN!=0)
        {
            $conn=$dbh->connection();
            foreach($PreferenceShifts as $shift)
            {
                $date=date("Y-m-d",strtotime($shift->Get_Shift_Date()));
                $shifttype=$shift->Get_Shift_Type();
                //Check shift exist on database or not
                $sql="SELECT * FROM preferedschdule WHERE BSN=(?) and dateShift =(?)";
                $stmt=$conn->prepare($sql);
                $stmt->execute([$BSN,$date]);
                $result=$stmt->fetch();
                //When it's not exsit in the database
                if(empty($result))
                {   
                    if($shifttype!="")
                    {
                        $sql="INSERT INTO preferedschdule (BSN, dateShift, preference_shift_type) VALUES ((?), (?), (?))";
                        $stmt=$conn->prepare($sql);
                        $stmt->execute([$BSN,$date,$shifttype]);
                    }
                }
                else 
                {   //When it's exsit in the database
                    if($shifttype!="")
                    {
                        $sql='UPDATE preferedschdule SET preference_shift_type=(?) WHERE BSN=(?) AND dateShift=(?)';
                        $stmt=$conn->prepare($sql);
                        $stmt->execute([$shifttype,$BSN,$date]);
                    }
                    else 
                    {
                        $sql='DELETE FROM preferedschdule WHERE BSN=(?) AND dateShift=(?)';
                        $stmt=$conn->prepare($sql);
                        $stmt->execute([$BSN,$date]);
                    }
                }
            }
            $conn=null;
            return true;
        }
        return false; 
        
    }
}
?>