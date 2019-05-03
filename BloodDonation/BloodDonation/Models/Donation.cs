using BloodDonation.Enums;
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
        public DonationType DonationType { get; set; }
        public DateTime Date { get; set; }

        public int GetAmount()
        {
            int amount = 0;

            switch (this.DonationType)
            {
                case DonationType.PureBlood:
                    amount = 450;
                    break;
                case DonationType.Plasma:
                    amount = 216;
                    break;
                case DonationType.Platelets:
                    amount = 500;
                    break;
                case DonationType.RedBloodCells:
                    amount = 1000;
                    break;
                case DonationType.WhiteBloodCells:
                    amount = 2000;
                    break;
            }

            return amount;
        }
    }

}
