using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    class BancoContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Movement> Movements { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
