<?php
class Availability{
    private $monday;
    private $tuesday;
    private $wednesday;
    private $thursday;
    private $friday;
    public function __construct($monday,$tuesday,$wednesday,$thursday,$friday)
    {
        $this->monday=$monday;
        $this->tuesday=$tuesday;
        $this->wednesday=$wednesday;
        $this->thursday=$thursday;
        $this->friday=$friday;
    }
    public function Get_Availability_By_Day_Of_The_Week($day)
    {
        switch($day)
        {
            case 1: return $this->monday;
            case 2: return $this->tuesday;
            case 3: return $this->wednesday;
            case 4: return $this->thursday;
            case 5: return $this->friday;
            return null;
        }        
    }
    public function Set_Availability_By_Day_Of_The_Week($day,$shiftType)
    {
        switch($day)
        {
            case 1: $this->monday=$shiftType; break;
            case 2: $this->tuesday=$shiftType;break;
            case 3: $this->wednesday=$shiftType;break;
            case 4: $this->thursday=$shiftType;break;
            case 5: $this->friday=$shiftType;break;            
        }        
    }
}
?>
