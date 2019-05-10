using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class Movement
    {
        private int id;
        private float hours;
        private Service service;
        private DateTime date;
        private User fromUSer;
        private User toUser;

        // Constructor
        public Movement()
        {
            Date = new DateTime();
        }

        // Methods
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Hours { get => hours; set => hours = value; }
        public Service Service { get => service; set => service = value; }
        public User FromUSer { get => fromUSer; set => fromUSer = value; }
        public User ToUser { get => toUser; set => toUser = value; }
 
    }
}
