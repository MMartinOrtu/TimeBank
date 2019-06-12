using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Hours { get; set; }
        public string Schedule { get; set; }
        public string Type { get; set; }
        public int User_Id { get; set; }
        public int Category_Id { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }

        public Service()
        {

        }

        public void addService(string name, string description, float hours, string schedule, string type, int user, int category)
        {
                this.Name = name;
                this.Description = description;
                this.Hours = hours;
                this.Schedule = schedule;
                this.Type = type;
                this.User_Id = user;
                this.Category_Id = category;
        }
    }
}
