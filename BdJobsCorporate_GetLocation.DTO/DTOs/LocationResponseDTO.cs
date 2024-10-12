using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.DTO.DTOs
{
    public class LocationResponseDTO
    {
        // The ID of the location, typically used as a value in dropdowns or selections
        public string OptionValue { get; set; }

        // The name of the location, typically displayed as text in dropdowns or lists
        public string OptionText { get; set; }
    }
}
