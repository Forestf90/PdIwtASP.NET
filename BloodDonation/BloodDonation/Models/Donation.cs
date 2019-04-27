using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{
    public class Donation
    {
        public Client Client { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
