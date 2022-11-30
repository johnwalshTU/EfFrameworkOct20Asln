using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Models
{
    public class Lecturer
    {
        public int ID { get; set; }                 // PK and identity
        public string Name { get; set; }            // null
        public string Phone { get; set; }           // null

        public virtual ICollection<Module> Modules { get; set; }
    }
}

