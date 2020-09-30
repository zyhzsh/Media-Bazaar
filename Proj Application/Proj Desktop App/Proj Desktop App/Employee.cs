using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
   public class Employee
   {
        private int BSN;
        private string firstName;
        private string lastName;
        private char gender;
        private string phoneNumber;
        private DateTime birthDate;
        private string address;
        private string certificates;
        private string status;
        private Departments department;
        private string contactEmail;
        private PositionType positionType;
        private string jobTitle;
        private double fte;

        private string test; // just to test merging

        public Employee(int BSN, string firstName, string lastName, char gender, string phoneNumber, DateTime birthDate,
            string address, string certificates, string status, Departments department, string contactEmail,
            double fte, PositionType positionType, string jobTitle)
        {
            this.BSN = BSN;
            this.lastName = lastName;
            this.firstName = firstName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.address = address;
            this.certificates = certificates;
            this.status = status;
            this.department = department;
            this.contactEmail = contactEmail;
            this.fte = fte;
            this.positionType = positionType;
            this.jobTitle = jobTitle;
        }

        public int GetBSN()
        {
            return BSN;
        }

        public string GetInfo()
        {
            return $"{BSN} - {lastName}, {department}, {contactEmail}";
        }

        public void UpdateInfo()
        {
            // to be added
        }

        public void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }

        public override string ToString()
        {
            return $"{BSN} - {firstName} {lastName}, gender: {gender}, birthdate: {birthDate.ToShortDateString()}\n" +
                $"phone: {phoneNumber}, address: {address}, email: {contactEmail}\n" +
                $"department: {department}, position: {positionType}, jobTitle: {jobTitle}, fte: {fte}, status: {status}, certificates: {certificates}";
        }

   }
}
