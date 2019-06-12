using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        // Constructor
        public User()
        {
            Services = new List<Service>();
        }


    }
}
