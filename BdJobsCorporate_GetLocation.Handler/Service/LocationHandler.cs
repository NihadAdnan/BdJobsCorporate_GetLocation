using BdJobsCorporate_GetLocation.DTO.DTOs;
using BdJobsCorporate_GetLocation.Handler.Abstraction;
using BdJobsCorporate_GetLocation.Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.Handler.Service
{
    public class LocationHandler:ILocationHandler
    {
        private readonly IGenericRepository _genericRepository;

        public LocationHandler(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<List<LocationResponseDTO>> Handle(LocationRequestDTO request)
        {
            var locations = await _genericRepository.GetLocationsAsync(request.DistrictId, request.OutsideBd);
            return locations;
        }
    }
}
