using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Enums
{
    public enum Gender
    {
        [Display(Name="Męzczyzna")]
        Male,
        [Display(Name = "Kobieta")]
        Female
    }
}
