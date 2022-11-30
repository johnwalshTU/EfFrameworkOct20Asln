using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Models
{
    public class Module
    {
        public int ID { get; set; }                             // PK and identity
        public string Name { get; set; }                        // null
        public int Credits { get; set; }                        // not null, use int? for null


        public virtual Lecturer Lecturer { get; set; }           // virtual enables "lazy loading" 
    }
}
