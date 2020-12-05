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
            $this->FetchUsers($BSN);
            return true;
        }
    }

    public function FetchUsers($BSN)
    {
        $dbh = new Dbh();
        $sql = "SELECT * FROM `employee` Where BSN=(:bBSN) ";
        $conn = $dbh->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute(['bBSN' => $BSN]);
        $result = $stmt->fetch();;
        if (empty($result)) {
            return false;
        } else {
            $BSN = $result['BSN'];
            $firstName = $result['first_name'];
            $lastName = $result['last_name'];
            $gender = $result['gender'];
            $phone = $result['phone'];
            $dateBirth = $result['date_birth'];
            $address = $result['address'];
            $languages = $result['languages'];
            $certificates = $result['certificates'];
            $contactEmail = $result['contact_email'];

            //note, not selected for current contract just any contract
            $sql = "SELECT * FROM `contract` Where BSN=(:bBSN) ";
            $conn = $dbh->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute(['bBSN' => $BSN]);
            $result = $stmt->fetch();
            $fte = $result['fte'];
            $user = new User($BSN, $firstName, $lastName, $gender, $phone, $dateBirth, $address, $languages, $certificates, $contactEmail, $fte);
            $session = $this->session();
            $session->__set("user", $user);
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

    public function RequestChangeUserInformation($BSN, $firstName, $lastName, $gender, $phone, $address, $languages, $certificates, $email)
    {
        $dbh = new Dbh();
        $sql = "INSERT INTO `employeechange` (`BSN`, `first_name`, `last_name`, `gender`, `phone`, `address`, `languages`, `certificates`, `contact_email`) VALUES (:BSN, :firstName, :lastName, :gender, :phone, :address, :languages, :certificates, :email) ";

        try {
            $conn = $dbh->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute(['BSN' => $BSN, 'firstName' => $firstName, 'lastName' => $lastName, 'gender' => $gender, 'phone' => $phone, 'address' => $address, 'languages' => $languages,  'certificates' => $certificates, 'email' => $email]);
        } catch (\PDOException $e) {
            echo $e->getMessage();
            return;
        }
    }
}
