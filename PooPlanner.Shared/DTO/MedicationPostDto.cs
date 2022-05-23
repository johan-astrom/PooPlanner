using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Shared.DTO
{
    public class MedicationPostDto
    {
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public long MedicineId { get; set; }
    }
}
