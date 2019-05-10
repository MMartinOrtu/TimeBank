using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class User
    {

        private int id;
        private string name;
        private string address;
        private string email;
        private string password;
        private int phone;
        private List<Service> services;

        // Constructor
        public User()
        {
            services = new List<Service>();
        }
        // Métodos

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Phone { get => phone; set => phone = value; }
    }
}
