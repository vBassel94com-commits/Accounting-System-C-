using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_Prog.Models
{
    class Ahde_Class
    {
        public int ID { get; set; }
       
        public Employee employee { get; set; }
        public Project project { get; set; }
      
        public virtual List<ahde_mon> Mon { get; set; }
        public List<ahdx> ahdxs { get; set; }
        public List<ahdxpurch> ahdxpurchs { get; set; }

    }
}
