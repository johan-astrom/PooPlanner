using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.Entities
{
    public class Medicine : EntityBase
    {
        public string? Name { get; set; }    
        public string? Description { get; set; } 
        public int Amount { get; set; }
        public MedicinalUnit Unit{ get; set; }

        public enum MedicinalUnit
        {
            g,
            ml,
            st
        }
    }
}
