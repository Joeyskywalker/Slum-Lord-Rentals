using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_ASG7_Defaults
{
    public class Property: SlumLordRentalBase, IProperty
    {

        private String address;
        private String city;
        private String state;
        private String zip;
        private Decimal price;
        private String descriptionBrief;
        private String descriptionFull;
        private int bathrooms;
        private int bedrooms;
        private bool onsiteParking;
        private bool onsiteLaundry;
        private DateTime leaseEndOn;
        private DateTime availableOn;
        private static int propertyObjectCount;
        private DateTime dateAdded;
        private int userID;
        private string addedByName;


        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public decimal Price { get => price; set => price = value; }
        public string DescriptionBrief { get => descriptionBrief; set => descriptionBrief = value; }
        public string DescriptionFull { get => descriptionFull; set => descriptionFull = value; }
        public int Bathrooms { get => bathrooms; set => bathrooms = value; }
        public int Bedrooms { get => bedrooms; set => bedrooms = value; }
        public bool OnsiteParking { get => onsiteParking; set => onsiteParking = value; }
        public bool OnsiteLaundry { get => onsiteLaundry; set => onsiteLaundry = value; }
        public DateTime LeaseEndOn { get => leaseEndOn; set => leaseEndOn = value; }
        public DateTime AvailableOn { get => availableOn; set => availableOn = value; }
        public static int PropertyObjectCount { get => propertyObjectCount; }
        public int UserID { get => userID; set => userID = value; }
        public string AddedByName { get => addedByName; set => addedByName = value; }

        public Property()
        {
            propertyObjectCount++;
            this.Id = propertyObjectCount;
            this.dateAdded = DateTime.Now;
        }

        public Property(int propertyID, string address)
        {
            propertyObjectCount++;
            this.Id = propertyID;
            this.address = address;
            this.dateAdded = DateTime.Now;
        }

        public Property(string address, string city, string state, string zip, decimal price, string descriptionBrief, string descriptionFull, int bathrooms, int bedrooms, bool onSiteParking, bool onSiteLaundry)
        {
            propertyObjectCount++;
            this.Id = propertyObjectCount;
            this.dateAdded = DateTime.Now;
        }

        public Property(string address, string city, string state, string zip, decimal price, string descriptionBrief, string descriptionFull, int bathrooms, int bedrooms, bool onsiteParking, bool onsiteLaundry, DateTime availableOn) : this(address, city, state, zip, price, descriptionBrief, descriptionFull, bathrooms, bedrooms, onsiteParking, onsiteLaundry)
        {
            //Auto generated construtor
            this.availableOn = availableOn;
            propertyObjectCount++;
            this.Id = propertyObjectCount;
            this.dateAdded = DateTime.Now;
        }

        public Property(string city, string state, string zip, int userID)
        {
            //Only default settings
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.userID = userID;
            propertyObjectCount++;
            this.Id = propertyObjectCount;
            this.dateAdded = DateTime.Now;
        }

        public Property(string city, string state, string zip)
        {
            //Only default settings
            this.city = city;
            this.state = state;
            this.zip = zip;
            propertyObjectCount++;
            this.Id = propertyObjectCount;
            this.dateAdded = DateTime.Now;
        }

        public override string ToString()
        {
            string result = "";

            result = this.Id.ToString() + " " + this.Address + " " + this.City;

            return result;
        }
    }
}
