using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobsCorporate_GetLocation.AggregateRoot.Entities
{
    public class Location
    {
        public int L_ID { get; set; }
        public string L_Name { get; set; }
        public bool? OutsideBangladesh { get; set; }
        public string L_Type { get; set; }
        public int? ParentID { get; set; }
    }
}
