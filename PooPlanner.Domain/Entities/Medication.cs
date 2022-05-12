using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.Entities
{
    public class Medication : EntityBase
    {
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; } 
        public Medicine MedicineId { get; set; }    
    }
}
