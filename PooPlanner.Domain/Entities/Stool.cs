using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.Entities
{
    public class Stool : EntityBase
    {
        public StoolConsistency Consistency { get; set; }
        public DateTime Timestamp { get; set; }
        public StoolSize Size { get; set; }
    }

    public enum StoolConsistency
    {
        Runny,
        Soft,
        Normal,
        Hard
    }
    public enum StoolSize
    {
        Small,
        Normal,
        Large
    }
}
