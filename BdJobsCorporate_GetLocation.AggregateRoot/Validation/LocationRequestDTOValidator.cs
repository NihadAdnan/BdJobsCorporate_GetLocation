using BdJobsCorporate_GetLocation.DTO.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.AggregateRoot.Validation
{
    public class LocationRequestDTOValidator : AbstractValidator<LocationRequestDTO>
    {
        public LocationRequestDTOValidator()
        {
            RuleFor(x => x.DistrictId)
                .Must(BeNumericOrEmpty).WithMessage("DistrictId must be a numeric value or empty.");

            RuleFor(x => x.OutsideBd)
                .Must(BeValidOutsideBd).WithMessage("OutsideBd must be '0' or '1'.");
        }

        private bool BeNumericOrEmpty(string districtId)
        {
            return string.IsNullOrEmpty(districtId) || int.TryParse(districtId, out _);
        }

        private bool BeValidOutsideBd(string outsideBd)
        {
            return outsideBd == "0" || outsideBd == "1";
        }
    }
}
