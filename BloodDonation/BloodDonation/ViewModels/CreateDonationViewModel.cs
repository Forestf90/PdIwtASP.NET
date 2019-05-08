using BloodDonation.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.ViewModels
{
    public class CreateDonationViewModel
    {
        public string Pesel { get; set; }
        public DonationType DonationType { get; set; }
        public int Amount { get; set; }
    }

    public class DonationValidator : AbstractValidator<CreateDonationViewModel>
    {
        public DonationValidator()
        {

            // Rules here
            //RuleFor(x => x.Amount).Equal(xd=>xd.DonationType == DonationType.PureBlood);
            When(x => x.DonationType == DonationType.PureBlood, () =>
            {
                RuleFor(x => x.Amount)
                    .NotEmpty()
                    .ExclusiveBetween(405, 495)
                    .WithMessage("Jednorazowao można oddac od 405 do 495 ml krwi");
            });
            When(x => x.DonationType == DonationType.Plasma, () =>
            {

                RuleFor(x => x.Amount)
                    .NotEmpty()
                    .ExclusiveBetween(585, 715)
                    .WithMessage("Jednorazowao można oddac od 585 do 715 ml osocza");
            });
            When(x => x.DonationType == DonationType.Platelets, () =>
            {
                RuleFor(x => x.Amount)
                    .NotEmpty()
                    .ExclusiveBetween(270, 330)
                    .WithMessage("Jednorazowao można oddac od 270 do 330 ml płytek krwi");
            });
            When(x => x.DonationType == DonationType.RedBloodCells, () =>
            {
                RuleFor(x => x.Amount)
                    .NotEmpty()
                    .ExclusiveBetween(270, 330)
                    .WithMessage("Jednorazowao można oddac od 270 do 330 ml czerwonych krwinek");
            });
            When(x => x.DonationType == DonationType.WhiteBloodCells, () =>
            {
                RuleFor(x => x.Amount)
                    .NotEmpty()
                    .ExclusiveBetween(180, 220)
                    .WithMessage("Jednorazowao można oddac od 180 do 220 ml białyk krwinek");
            });
        }
    }
}
