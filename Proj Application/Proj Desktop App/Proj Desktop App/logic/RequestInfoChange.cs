using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    class RequestInfoChange
    {
        // Personal details:
        public int BSN { get; private set; }
        public string dateOfRequest { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public char gender { get; private set; }
        public string languages { get; private set; }
        public string certificates { get; private set; }

        // Contact details:
        public string phoneNumber { get; private set; }
        public string address { get; private set; }
        public string contactEmail { get; private set; }

        public RequestInfoChange(int BSN, string firstName, string lastName, char gender,
            string languages, string certificates, string phoneNumber, string address, string contactEmail,string dateOfRequest)
        {
            // Set the values
            this.BSN = BSN;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.certificates = certificates;
            this.languages = languages;
            this.contactEmail = contactEmail;
            this.dateOfRequest = dateOfRequest;
            
        }
        public RequestInfoChange()
        {

        }
    }
}
