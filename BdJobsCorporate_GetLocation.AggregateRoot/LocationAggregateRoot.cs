using BdJobsCorporate_GetLocation.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.AggregateRoot
{
    public class LocationAggregateRoot
    {
        public string DistrictId { get; private set; }
        public string OutsideBd { get; private set; }

        // Manual mapping of LocationRequestDTO to internal properties
        public LocationAggregateRoot(LocationRequestDTO dto)
        {
            DistrictId = !string.IsNullOrEmpty(dto.DistrictId) ? dto.DistrictId : null;
            OutsideBd = dto.OutsideBd;
        }
    }
}
