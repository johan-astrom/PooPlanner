using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Shared.DTO
{
    public class MedicationGetDto
    {
        public long Id { get; set; }
        public int Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string Medicine { get; set; }
        public string Unit { get; set; }
    }
}
