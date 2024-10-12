using BdJobsCorporate_GetLocation.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.Repository.Repository.Abstraction
{
    public interface IGenericRepository
    {
        Task<List<LocationResponseDTO>> GetLocationsAsync(string districtId, string outsideBd);
    }
}
