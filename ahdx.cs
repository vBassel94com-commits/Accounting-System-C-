using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_Prog.Models
{
    class ahdx
    {
        public int ID { get; set; }
        public Project project { get; set; }
        public Employee emp { get; set; }
        public double mon { get; set; }
        public Client client { get; set; }
        public DateTime dateof { get; set; } = DateTime.Now;
        public Dep Dept { get; set; }
        public int Tax { get; set; }
        public String BillID { get; set; }



    }
}
