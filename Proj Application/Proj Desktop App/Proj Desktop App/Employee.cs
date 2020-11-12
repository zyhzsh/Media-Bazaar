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

        /// <summary>
        /// For new employees. Requires employee info and one contact
        /// </summary>
        public Employee(int BSN, string firstName, string lastName, char gender, DateTime birthDate,
            string languages, string certificates, string phoneNumber, string address, string contactEmail,
            DateTime startDate, DateTime endDate, PositionType position, Departments department, decimal fte)
        {
            this.BSN = BSN;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.languages = languages;
            this.certificates = certificates;

            this.phoneNumber = phoneNumber;
            this.address = address;
            this.contactEmail = contactEmail;

            // Initialize first contract
            this.contracts = new List<Contract>();
            AddContract(startDate, endDate, department, position, fte);
        }

        /// <summary>
        /// For existing employees. Requires employee info and all contacts
        /// </summary>
        public Employee(int BSN, string firstName, string lastName, char gender, DateTime birthDate,
            string languages, string certificates, string phoneNumber, string address, string contactEmail,
            Contract[] contracts)
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
            this.contracts.AddRange(contracts);
        }

        /// <summary>
        /// Update an employee's personal and contact details
        /// </summary>
        public void UpdateInfo(string firstName, string lastName, char gender, string languages,
            string certificates, string phoneNumber, string address, string contactEmail)
        {
            if (this.firstName != firstName) { this.firstName = firstName; }
            if (this.lastName != lastName) { this.lastName = lastName; }
            if (this.gender != gender) { this.gender = gender; }
            if (this.certificates != certificates) { this.certificates = certificates; }
            if (this.languages != languages) { this.languages = languages; }
            if (this.phoneNumber != phoneNumber) { this.phoneNumber = phoneNumber; }
            if (this.address != address) { this.address = address; }
            if (this.contactEmail != contactEmail) { this.contactEmail = contactEmail; }
        }

        public void AddContract(DateTime startDate, DateTime endDate, Departments department, PositionType position, decimal fte)
        {
            this.contracts.Add(new Contract(startDate, endDate, contracts.Count + 1, department, position, 1000 /* get starting salary */, fte));
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

        private Contract GetActiveContract()
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

        public string GetBsnAndName()
        {
            return $"BSN:{this.BSN} ----- Name:{this.firstName} {this.lastName}";
        }

        public string Biscinfo()
        {
            return $"Name:{this.firstName} {this.lastName} Department:{GetDepartment()} ContactEmail:{this.contactEmail} Certificates:{this.certificates}"
                +$" FTE:{GetFTE()}";   
        }

        public int GetBSN()
        {
            return BSN;
        }

        public override string ToString()
        {
            return $"{BSN}   {firstName} {lastName}";
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
    }
}
