using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Employee
    {
        // Personal details:
        private int BSN;
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public char gender { get; private set; }
        public DateTime birthDate { get; private set; }
        public string languages { get; private set; }
        public string certificates { get; private set; }

        // Contact details:
        public string phoneNumber { get; private set; }
        public string address { get; private set; }
        public string contactEmail { get; private set; }

        // Contracts:
        private List<Contract> contracts;

        public Employee(int BSN, string firstName, string lastName, char gender, DateTime birthDate,
            string languages, string certificates, string phoneNumber, string address, string contactEmail)
        {
            this.BSN = BSN;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.address = address;
            this.certificates = certificates;
            this.languages = languages;
            this.contactEmail = contactEmail;
            this.contracts = new List<Contract>();
        }

        /// <summary>
        /// Update an employee's personal and contact details
        /// </summary>
        public void UpdateInfo(string firstName, string lastName, char gender, string languages,
            string certificates, string phoneNumber, string address, string contactEmail)
        {
            if (IsEmployed())
            {
                // Set information to update
                if (firstName == null) { firstName = this.firstName; }
                if (lastName == null) { lastName = this.lastName; }
                if (gender.ToString() == null) { gender = this.gender; }
                if (certificates == null) { certificates = this.certificates; }
                if (languages == null) { languages = this.languages; }
                if (phoneNumber == null) { phoneNumber = this.phoneNumber; }
                if (address == null) { address = this.address; }
                if (contactEmail == null) { contactEmail = this.contactEmail; }

                // Update details in database
                EmployeeManagement emplMan = new EmployeeManagement();
                if (emplMan.UpdateEmployee(BSN, firstName, lastName, gender, languages,
                    certificates, phoneNumber, address, contactEmail))
                {
                    // Update details locally
                    if (this.firstName != firstName) { this.firstName = firstName; }
                    if (this.lastName != lastName) { this.lastName = lastName; }
                    if (this.gender != gender) { this.gender = gender; }
                    if (this.certificates != certificates) { this.certificates = certificates; }
                    if (this.languages != languages) { this.languages = languages; }
                    if (this.phoneNumber != phoneNumber) { this.phoneNumber = phoneNumber; }
                    if (this.address != address) { this.address = address; }
                    if (this.contactEmail != contactEmail) { this.contactEmail = contactEmail; }
                }
                else
                {
                    throw new Exception("Failed to update details. Check database connection.");
                }
            }
            else
            {
                throw new Exception("You can't update this employee's details since they are no loger employed.");
            }
        }

        public void AddContract(Contract contract)
        {
            if (contract != null)
            {
                this.contracts.Add(contract);
            }
        }

        public void AddContracts(Contract[] contracts)
        {
            if (contracts != null && contracts.Length > 0)
            {
                this.contracts.AddRange(contracts);
            }
        }

        public PositionType GetPosition()
        {
            Contract activeContract = GetActiveContract();
            if (activeContract != null)
            {
                return GetActiveContract().Position;
            }
            else
            {
                throw new Exception("This employee doesnt have a position");
            }
        }

        public int GetBSN()
        {
            return BSN;
        }

        public Departments GetDepartment()
        {
            Contract activeContract = GetActiveContract();
            if (activeContract != null)
            {
                return GetActiveContract().Department;
            }
            else
            {
                throw new Exception("This employee doesnt have a deparment");
            }
        }

        public decimal GetFTE()
        {
            Contract activeContract = GetActiveContract();
            if (activeContract != null)
            {
                return GetActiveContract().Fte;
            }
            else
            {
                throw new Exception("This employee doesnt have fte");
            }
        }

        public Contract GetActiveContract()
        {
            foreach (Contract contract in contracts)
            {
                if (contract.IsActive())
                {
                    return contract;
                }
            }
            return null;
        }

        public Contract GetLatestContract()
        {
            return contracts[contracts.Count - 1];
        }

        public Contract[] GetContracts()
        {
            return contracts.ToArray();
        }

        public bool IsEmployed()
        {
            if (GetActiveContract() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Biscinfo()
        {
            return $"Name:{this.firstName} {this.lastName} Department:{GetDepartment()} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{GetFTE()}";
        }

        public string[] GetDetail()
        {
            List<string> temp = new List<string>();

            temp.Add($"Employee BSN:{this.BSN}");

            temp.Add($"Name: {this.firstName} {this.lastName}");

            temp.Add($"Gender: {this.gender}");

            temp.Add($"Department: {GetDepartment()}");

            temp.Add($"ContactEmail: {this.contactEmail}");

            temp.Add($"Certificates: {this.certificates}");

            temp.Add($"FTE: {GetFTE()}");

            temp.Add($"----------------------------------");

            return temp.ToArray();
        }

        public override string ToString()
        {
            return $"{BSN}   {firstName} {lastName}";
        }
    }
}
