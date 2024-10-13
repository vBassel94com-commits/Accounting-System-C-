using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_Prog.Models
{
    class DB_Cont :DbContext
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Ahde_Class> ahdes { get; set; }
        public DbSet<Dep> depts { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<ahdx> ahdxs { get; set; }
        public DbSet<ahdxpurch> ahdxpurchs { get; set; }
        public DbSet<ahde_mon> ahde_mon { get; set; }
        public DbSet<Inputs> inputss { get; set; }
        public DbSet<SubDept> subdepts { get; set; }

    }
}
