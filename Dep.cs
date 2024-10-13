using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_Prog.Models
{
    class Dep
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public List<SubDept> subdespts { get; set; }
    }
}
