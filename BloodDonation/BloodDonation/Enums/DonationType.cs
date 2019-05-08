using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BloodDonation.Enums
{
    public enum DonationType
    {
        [Display(Name ="Czysta krew")]
        PureBlood =0,
        [Display(Name = "Osocze")]
        Plasma,
        [Display(Name = "Płytki krwi")]
        Platelets,
        [Display(Name = "Czerwone Krwinki")]
        RedBloodCells,
        [Display(Name = "Białe krwinki")]
        WhiteBloodCells
    }

}
