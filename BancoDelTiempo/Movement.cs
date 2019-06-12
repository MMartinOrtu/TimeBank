using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class Movement
    {
        public int Id { get; set; }
        public float Hours { get; set; }
        public DateTime Date { get; set; }
        public int FromUser_Id { get; set; }
        public int Service_Id { get; set; }
        public int? Account_Id { get; set; }

        public virtual Service Service { get; set; }
        public virtual User FromUser { get; set; }
        public virtual User ToUser { get; set; }

        [ForeignKey("Account_Id")]
        public virtual Account Account { get; set; }
        
 

        // Constructor
        public Movement()
        {
            Date = new DateTime();
        }

        public void addMovement(DateTime date, float hours, int service, int  fromUser, int account)
        {
            this.Date = date;
            this.Hours = hours;
            this.Service_Id = service;
            this.FromUser_Id = fromUser;
            this.Account_Id = account;
        }
        // Methods


    }
}
