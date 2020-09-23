using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Employee
    {
        private int BSN;
        private string firstName;
        private string LastName;
        private string gender;
        private int phoneNumber;
        private DateTime birthDate;
        private string adress;
        private string certificates;
        private string status;
        private string department;
        private string contactEmail;
        private double fte;

        public Employee(int BSN, string firstName, string LastName, string gender, int phoneNumber, DateTime birthDate,
            string adress, string certificates,string status, string department, string contactEmail,double fte)
        {
            this.BSN = BSN;
            this.LastName = LastName;
            this.firstName = firstName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.adress = adress;
            this.certificates = certificates;
            this.status = status;
            this.department = department;
            this.contactEmail = contactEmail;
            this.fte = fte;
        }
    }
}
