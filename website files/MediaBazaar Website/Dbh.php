 <?php
    class Dbh
    {

        private $host = "studmysql01.fhict.local";
        private $db = "dbi443880";
        private $DbUsername = "dbi443880";
        private $DbPassword = "123456";



        protected function connection()
        {
            $dsn = 'mysql:host=' . $this->host  . ';dbname=' .  $this->db;
            $conn = new PDO($dsn, $this->DbUsername, $this->DbPassword);
            // if ($conn->connect_error) {
            //     die("Connection failed: " . $conn->connect_error);
            // }
            return $conn;
        }



        public function CheckUsers($email, $password)
        {
            $sql = "SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd)";
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute([':uEmail' => $email, 'pwd' => $password]);
            $result = $stmt->fetch();


            //     if($result!=null){
            //         $sql="SELECT * FROM `employee` Where username=(:uEmail) And password=(:pwd) And BSN";
            //     $conn= $this->connection();
            //     $stmt=$conn->prepare($sql);
            //     $stmt->execute([':uEmail'=> $email,'pwd'=>$password]);
            //     $result=$stmt->fetch();
            //     $BSN=0;
            //   //  foreach($result as $row){
            //         $BSN=$result[0];
            //       //  $username=$row['username'];
            //         return "BSN";
            //     //}
            //$_SESSION

            //     }
            return "BSN";
        }

        public function GetAllShiftsForEmployee($BSN)
        {
            $sql = "SELECT * FROM `assignedschdule` Where BSN=(:uBSN)";
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute([':uBSN' => $BSN]);
            $result = $stmt->fetchAll();
            $date;
            $assignedShits;
            foreach ($result as $row) {
                $date = $row['date'];
                $assignedShits = $row['assigned_shift_type'];
            }
            return $date . $assignedShits;
        }
    }
    ?>