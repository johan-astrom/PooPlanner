using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Shared.DTO
{
    public class StoolGetDto
    {
        public long Id { get; set; }
        public string Consistency { get; set; }
        public DateTime Timestamp { get; set; }
        public string Size { get; set; }
    }

    public class StoolPostDto
    {
        public int Consistency { get; set; }
        public DateTime Timestamp { get; set; }
        public int Size { get; set; }
    }
}
