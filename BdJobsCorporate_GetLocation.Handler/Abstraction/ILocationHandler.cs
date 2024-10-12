using BdJobsCorporate_GetLocation.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.Handler.Abstraction
{
    public interface ILocationHandler
    {
        Task<List<LocationResponseDTO>> Handle(LocationRequestDTO request);
    }
}
