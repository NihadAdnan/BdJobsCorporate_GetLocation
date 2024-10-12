using BdJobsCorporate_GetLocation.DTO.DTOs;
using BdJobsCorporate_GetLocation.Repository.Data;
using BdJobsCorporate_GetLocation.Repository.Repository.Abstraction;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.Repository.Repository
{
    public class GenericRepository:IGenericRepository
    {
        private readonly DapperDbContext _context;

        public GenericRepository(DapperDbContext context)
        {
            _context = context;
        }

        public async Task<List<LocationResponseDTO>> GetLocationsAsync(string districtId, string outsideBd)
        {
            string sqlQuery = "";
            DynamicParameters parameters = new DynamicParameters();

            // Build the SQL query based on input parameters
            if (!string.IsNullOrEmpty(outsideBd) && outsideBd == "1")
            {
                sqlQuery = "SELECT L_ID AS OptionValue, L_Name AS OptionText FROM Locations WHERE OutsideBangladesh = 1 ORDER BY L_Name";
            }
            else if (string.IsNullOrEmpty(districtId))
            {
                sqlQuery = "SELECT L_ID AS OptionValue, L_Name AS OptionText FROM Locations WHERE OutsideBangladesh = 0 AND L_Type = 'District' ORDER BY L_Name";
            }
            else
            {
                if (districtId == "0")
                {
                    sqlQuery = "SELECT L_ID AS OptionValue, L_Name AS OptionText FROM Locations WHERE OutsideBangladesh = 0 AND L_Type = 'District' ORDER BY L_Name";
                }
                else
                {
                    sqlQuery = "SELECT L_ID AS OptionValue, L_Name AS OptionText FROM Locations WHERE OutsideBangladesh = 0 AND L_Type = 'thana' AND ParentID = @ParentID ORDER BY L_Name";
                    parameters.Add("@ParentID", int.Parse(districtId), DbType.Int32);
                }
            }

            // Use Dapper to query the database with the connection
            using (var dbConnection = _context.CreateConnection())
            {
                var locations = await dbConnection.QueryAsync<LocationResponseDTO>(sqlQuery, parameters);
                return locations.ToList();
            }
        }


    }
}
