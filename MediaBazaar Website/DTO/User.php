<?php
class User
{
    public $BSN;
    public $firstName;
    public $lastName;
    public $gender;
    public $phone;
    public $dateOfBirth;
    public $adress;
    public $languages;
    public $certificates;
    public $contactEmail;
    public $fte;
    public $weeklyHours;

    public function __construct($BSN, $firstName, $lastName, $gender, $phone, $dateOfBirth, $adress, $languages, $certificates, $contactEmail, $fte)
    {
        $this->BSN = $BSN;
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->gender = $gender;
        $this->phone = $phone;
        $this->dateOfBirth = $dateOfBirth;
        $this->adress = $adress;
        $this->languages = $languages;
        $this->certificates = $certificates;
        $this->contactEmail = $contactEmail;
        $this->fte = $fte;
        $this->weeklyHours = $fte * 40;
    }
     
    
}
