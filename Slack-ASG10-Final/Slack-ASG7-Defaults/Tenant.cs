using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_ASG7_Defaults
{
    public class Tenant : SlumLordRentalBase, ITenant
    {

        private static int tenantObjectCount; // This is Static, it is a member of the Class, not an instance of the class.
        private String firstName;
        private String lastName;
        private String phone;
        private String email;
        private String city;
        private String state;
        private string zip;
        private int addedByID;

        public static int TenantObjectCount { get => tenantObjectCount; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }

        // Zero parameter constructor
        public Tenant()
        {
            tenantObjectCount++;  // Increase the STATIC tenantObjectCount

            this.Id = tenantObjectCount;
            this.DateAdded = DateTime.Now;
        }


        // Example of three parameter constructor
        public Tenant(String firstName, String lastName, int addedByID)
        {
            tenantObjectCount++;  // Increase the STATIC tenantObjectCount

            this.Id = tenantObjectCount;
            this.firstName = firstName;
            this.lastName = lastName;
            this.addedByID = addedByID;
            this.DateAdded = DateTime.Now;

        }


        // Example of eight parameter contstructor
        public Tenant(String firstName, String lastName,
                        String email,
                        String phone,
                        String city,
                        String state,
                        String zip,
                        int addedByID)
        {
            tenantObjectCount++;   // Increase the STATIC tenantObjectCount

            this.Id = tenantObjectCount;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.StatusTypeID = 1; 
            this.DateAdded = DateTime.Now;
            this.addedByID = addedByID;
        }

        public Tenant(String firstName, String lastName,
                        String email,
                        String phone,
                        String city,
                        String state,
                        String zip)
        {
            tenantObjectCount++;   // Increase the STATIC tenantObjectCount

            this.Id = tenantObjectCount;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.StatusTypeID = 1;
            this.DateAdded = DateTime.Now;
        }

        public override string ToString()
        {
            string result = "";

            result = this.Id.ToString() + " " + this.firstName + " " + this.lastName;

            return result;
        }
    }
}
