<?php
class PreferenceShift
{
    private $shiftdate;
    private $shifttype;
    public function __construct($shiftdate,$shifttype)
    {
     $this->shiftdate=$shiftdate;
     $this->shifttype=$shifttype;
    }
    public function Get_Shift_Date()
    {
        return $this->shiftdate;
    }
    public function Get_Shift_Type()
    {
        return $this->shifttype;
    }
}


?>