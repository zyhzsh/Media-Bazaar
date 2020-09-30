using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Employee
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
            return $"BSN:{this.BSN} ----- Name:{this.firstName} {this.LastName}";
        }

        public string Biscinfo()
        {
            return $"Name:{this.firstName} {this.LastName} Department:{this.department} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{this.fte}";
        
        }
    
    
    
    }
}
