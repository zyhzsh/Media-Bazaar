<?php 
 require_once('classes.php');
class ShiftsModel {
    private  function session(){
        return session::getInstance();
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

 
    public function Get_Availabity($BSN)
    {   
        if($BSN!=0)
        {
            $session=$this->session();
            $dbh=new Dbh(); 
            $conn=$dbh->connection();  
            $sql='SELECT * FROM availability WHERE BSN=(?)';
            $stmt=$conn->prepare($sql);
            $stmt->execute([$BSN]);
            $result=$stmt->fetch();
            if(empty($result)){return null;}
            else{ 
                $availability =new Availability($result['Monday'],$result['Tuesday'],$result['Wednesday'],$result['Thursday'],$result['Friday']);
                return $availability;
            }
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
    public function Update_Availabity($BSN,$availabilitySetting)
    {
        //if empty insert
        if($BSN!=0)
        {
            $session=$this->session();
            $dbh=new Dbh();
            $conn=$dbh->connection();
            //Check shift exist on database or not
            $sql="SELECT * FROM availability WHERE BSN=(?)";
            $stmt=$conn->prepare($sql);
            $stmt->execute([$BSN]);
            $result=$stmt->fetch();
            //Prepare shifttype
            $monday=$availabilitySetting->Get_Availability_By_Day_Of_The_Week(1);
            $tuesday=$availabilitySetting->Get_Availability_By_Day_Of_The_Week(2);
            $wednesday=$availabilitySetting->Get_Availability_By_Day_Of_The_Week(3);
            $thursday=$availabilitySetting->Get_Availability_By_Day_Of_The_Week(4);
            $friday=$availabilitySetting->Get_Availability_By_Day_Of_The_Week(5);
            //When it's not exsit in the database
            if(empty($result))
            {   
 
                $sql="INSERT INTO availability (BSN, Monday, Tuesday,Wednesday,Thursday,Friday) VALUES ((?),(?),(?),(?),(?),(?))";
                $stmt=$conn->prepare($sql);
                $stmt->execute([$BSN,$monday,$tuesday,$wednesday,$thursday,$friday]);
            }
            else 
            {   //When it's exsit in the database
                $sql='UPDATE availability SET Monday=(?),Tuesday=(?),Wednesday=(?),Thursday=(?),Friday=(?) WHERE BSN=(?)';
                $stmt=$conn->prepare($sql);
                $stmt->execute([$monday,$tuesday,$wednesday,$thursday,$friday,$BSN]);
            }           
            $conn=null;
            return true;
        }
        return false; 
    }
}
?>