using BloodDonation.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Amount { get; set; }

        public int GetAmount()
        {
            int amount = 0;

            switch (this.DonationType)
            {
                case DonationType.PureBlood:
                    amount = Amount;
                    break;
                case DonationType.Plasma:
                    amount = Convert.ToInt32(Amount*0.33f);
                    break;
                case DonationType.Platelets:
                    amount = Convert.ToInt32(Amount * 1.66f);
                    break;
                case DonationType.RedBloodCells:
                    amount = Convert.ToInt32(Amount * 3.33f);
                    break;
                case DonationType.WhiteBloodCells:
                    amount = Amount*5;
                    break;
            }

            return amount;
        }
    }


}
