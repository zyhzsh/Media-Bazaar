<?php
require_once('classes.php');
class UserModel
{



    private  function session()
    {

        return session::getInstance();
    }


    public function CheckUsers($email, $password)
    {
        $dbh = new Dbh();
        $sql = "SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd)";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':uEmail' => $email, 'pwd' => $password]);
        $result = $stmt->fetch();;
        if (empty($result)) {
            return false;
        } else {

            $BSN = $result['BSN'];
            $sessionName = 'BSN';
            $session = $this->session();
            $session->startSession();
            $session->__set($sessionName, $BSN);
            return true;
        }
    }

    public function CheckPassword($BSN, $password)
    {
        $dbh = new Dbh();
        $sql = "SELECT * FROM `employee` Where BSN=(:uBSN) And password=(:pwd)";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':uBSN' => $BSN, 'pwd' => $password]);
        $result = $stmt->fetch();;
        if (empty($result)) {
            return false;
        } else {
            return true;
        }
    }

    public function ChangePassword($BSN, $oldPassword, $newPassword)
    {
        $dbh = new Dbh();
        $sql = "UPDATE `employee` SET password=(:nPassword) WHERE passsword=(:oPassword) AND BSN=(:b) ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':nPassword' => $newPassword, ':oPassword' => $oldPassword, ':b' => $BSN]);
    }


    public function ChangeUserEmail($oldEmail, $newEmail, $BSN)
    {
        $dbh = new Dbh();
        $sql = "UPDATE `employee` SET username=(:nEmail) WHERE username=(:oEmail) AND BSN=(:b) ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':nEmail' => $newEmail, ':oEmail' => $oldEmail, ':b' => $BSN]);
    }

    public function ChangeUserAdres($oldAdress, $newAdress, $BSN)
    {
        $dbh = new Dbh();
        $sql = "UPDATE `employee` SET adress=(:nAdress) WHERE adress=(:oAdress) AND BSN=(:b) ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':nAdress' => $newAdress, ':oAdress' => $oldAdress, ':b' => $BSN]);
    }

    public function ChangeUserPhone($oldPhone, $newPhone, $BSN)
    {
        $dbh = new Dbh();
        $sql = "UPDATE `employee` SET phone=(:nPhone) WHERE phone=(:oPhone) AND BSN=(:b) ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':nPhone' => $newPhone, ':oPhone' => $oldPhone, ':b' => $BSN]);
    }

    public function RequestChangeUserInformation($BSN, $firstName, $lastName, $gender, $phone, $adress, $languages, $certificates, $email)
    {
        $dbh = new Dbh();
        $sql = "INSERT INTO `employeechange` (`BSN`, `first_name`, `last_name`, `gender`, `phone`, `adress`, `languages`, `certificates`, `contact_email` VALUES (:BSN, :firstName, :lastName, :gender, :phone, :adress, :languages, :certificates, :email ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute([':BSN' => $BSN, ':firstName' => $firstName, ':lastName' => $lastName, ':gender' => $gender, ':phone' => $phone, ':adress' => $adress, ':certificates' => $certificates, ':email' => $email]);
    }
}
