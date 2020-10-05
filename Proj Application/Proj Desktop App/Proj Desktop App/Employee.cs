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
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public char gender { get; private set; }
        public string phoneNumber { get; private set; }
        public DateTime birthDate { get; private set; }
        public string address { get; private set; }
        public string certificates { get; private set; }
        public string status { get; private set; }
        public Departments department { get; private set; }
        public string contactEmail { get; private set; }
        public PositionType positionType { get; private set; }
        public string jobTitle { get; private set; }
        public double fte { get; private set; }

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

        public void UpdateInfo(string firstName, string lastName, char gender, string phoneNumber,
            string address, string certificates, Departments department, string contactEmail,
            double fte, PositionType positionType, string jobTitle)
        {
            if (this.firstName != firstName) { this.firstName = firstName; }
            if (this.lastName != lastName) { this.lastName = lastName; }
            if (this.gender != gender) { this.gender = gender; }
            if (this.phoneNumber != phoneNumber) { this.phoneNumber = phoneNumber; }
            if (this.address != address) { this.address = address; }
            if (this.certificates != certificates) { this.certificates = certificates; }
            if (this.department != department) { this.department = department; }
            if (this.contactEmail != contactEmail) { this.contactEmail = contactEmail; }
            if (this.fte != fte) { this.fte = fte; }
            if (this.positionType != positionType) { this.positionType = positionType; }
            if (this.jobTitle != jobTitle) { this.jobTitle = jobTitle; }
        }

        public string GetBsnAndName()
        {
            return $"BSN:{this.BSN} ----- Name:{this.firstName} {this.lastName}";
        }

        public string Biscinfo()
        {
            return $"Name:{this.firstName} {this.lastName} Department:{this.department} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{this.fte}";   
        }

        public int GetBSN()
        {
            return BSN;
        }

        public string GetInfo()
        {
            return $"{BSN} - {lastName}, {department}, {contactEmail}";
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

        public string[] GetDetail()

        {

            List<string> temp = new List<string>();

            temp.Add($"Employee BSN:{this.BSN}");

            temp.Add($"Name: {this.firstName} {this.lastName}");

            temp.Add($"Gender: {this.gender}");

            temp.Add($"Department: {this.department}");

            temp.Add($"ContactEmail: {this.contactEmail}");

            temp.Add($"Certificates: {this.certificates}");

            temp.Add($"FTE: {this.fte}");

            temp.Add($"----------------------------------");

            return temp.ToArray();
        }
    }
}
