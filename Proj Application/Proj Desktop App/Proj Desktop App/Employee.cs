<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
   public  class Employee
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Employee
>>>>>>> parent of 83ec41c... ScheduleManager implemented
    {
        public int BSN { get; set; }
        public string Address { get; set; }
        private string firstName;
        private string LastName;
        private string gender;
        private int phoneNumber;
        private DateTime birthDate;
        private string certificates;
        private string status;
        private string department;
        private string contactEmail;
        private PositionType positionType;
        private double fte;
        public Employee(int BSN, string firstName, string LastName, string gender, int phoneNumber, DateTime birthDate,
            string address, string certificates, string status, string department, string contactEmail, double fte, PositionType positionType)
        {
            this.BSN = BSN;
            this.LastName = LastName;
            this.firstName = firstName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.Address = address;
            this.certificates = certificates;
            this.status = status;
            this.department = department;
            this.contactEmail = contactEmail;
            this.fte = fte;
            this.positionType = positionType;
        }


   

        public string GetBsnAndName()
        {
<<<<<<< HEAD
            return $"BSN: {this.BSN} Name:{this.firstName} {this.LastName}";
=======
            return $"BSN:{this.BSN} ----- Name:{this.firstName} {this.LastName}";
>>>>>>> parent of 83ec41c... ScheduleManager implemented
        }

        public string Biscinfo()
        {
<<<<<<< HEAD
            return $"Name:{this.firstName} {this.LastName} Department:{this.department} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{this.fte}";   
        }
        public string[] GetDetial()
        {
            List<string> temp = new List<string>();
            temp.Add($"Employee BSN:{this.BSN}");
            temp.Add($"Name: {this.firstName} {this.LastName}");
            temp.Add($"Gender: {this.gender}");
            temp.Add($"Department: {this.department}");
            temp.Add($"ContactEmail:  {this.contactEmail}");
            temp.Add($"Certificates:  {this.certificates}");
            temp.Add($"FTE:  {this.fte}");
            temp.Add($"----------------------------------");
            return temp.ToArray();
        
        }

    
    
    }
}
=======
            return $"Name:{this.firstName} {this.LastName} Department:{this.department} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{this.fte}";
        
        }
    
    
    
    }
}
>>>>>>> parent of 83ec41c... ScheduleManager implemented
