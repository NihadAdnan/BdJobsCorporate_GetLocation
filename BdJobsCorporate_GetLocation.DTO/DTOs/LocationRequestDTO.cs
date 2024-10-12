using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.DTO.DTOs
{
    public class LocationRequestDTO
    {
        // Represents the district ID passed in the request
        public string DistrictId { get; set; }

        // Represents whether the request is for locations outside Bangladesh
        public string OutsideBd { get; set; }
    }
}
