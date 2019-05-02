using BloodDonation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.ViewModels
{
    public class CreateDonorViewModel
    {
        public string Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public BloodGroup Group { get; set; }
        public int MyProperty { get; set; }
    }
}
