using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public Donor Donor { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
