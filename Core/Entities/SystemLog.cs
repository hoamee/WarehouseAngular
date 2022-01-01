using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SystemLog
    {
        public int Id { get; set; }
        public string Feature { get; set; }
        public string Attribute { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ModifiedBy { set; get; }
        public DateTime ModifiedOn { set; get; }
    }
}