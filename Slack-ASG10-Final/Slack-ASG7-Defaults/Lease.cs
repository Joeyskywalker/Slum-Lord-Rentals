using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_ASG7_Defaults
{
    public class Lease: SlumLordRentalBase, ILease
    {
        private static int leaseObjectCount;
        private int propertyID;
        private int tenantID;
        private string description;
        private DateTime dateLeaseStarts;
        private DateTime dateLeaseEnds;
        private decimal monthlyRate;
        private string notes;

        public int PropertyID { get => propertyID; set => propertyID = value; }
        public int TenantID { get => tenantID; set => tenantID = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateLeaseStarts { get => dateLeaseStarts; set => dateLeaseStarts = value; }
        public DateTime DateLeaseEnds { get => dateLeaseEnds; set => dateLeaseEnds = value; }
        public decimal MonthlyRate { get => monthlyRate; set => monthlyRate = value; }
        public string Notes { get => notes; set => notes = value; }
        public static int LeaseObjectCount { get => leaseObjectCount; set => leaseObjectCount = value; }

        public Lease(int propertyID, int tenantID, string description, DateTime dateLeaseStarts, DateTime dateLeaseEnds, decimal monthlyRate, string notes)
        {
            this.propertyID = propertyID;
            this.tenantID = tenantID;
            this.description = description;
            this.dateLeaseStarts = dateLeaseStarts;
            this.dateLeaseEnds = dateLeaseEnds;
            this.monthlyRate = monthlyRate;
            this.notes = notes;

            LeaseObjectCount++;
            this.Id = LeaseObjectCount;
            this.DateAdded = DateTime.Now;
            
        }

        public Lease(int propertyID, int tenantID)
        {
            this.Id = LeaseObjectCount;
            this.DateAdded = DateTime.Now;

            LeaseObjectCount++;
            this.propertyID = propertyID;
            this.tenantID = tenantID;
        }

        public Lease()
        {
            LeaseObjectCount++;
            this.Id = LeaseObjectCount;
            this.DateAdded = DateTime.Now;

        }

        public override string ToString()
        {
            string result = "";

            result = this.Id + " " + this.description;

            return result;
        }
    }
}
