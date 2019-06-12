using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class Account
    {
        public int Id { get; set; }
        public float Balance { get; set; }
        public int User_Id { get; set; }

        public virtual ICollection<Movement> Movements { get; set; }
        public virtual User User { get; set; }

        // Constructor

        public Account()
        {

        }
        public Account(int user_id)
        {
            Movements = new List<Movement>();
            Balance = 0.0f;
            User_Id = user_id;

        }

        public void updateAccount ()
        {
            this.Balance = 0.0f;
            foreach( var movement in this.Movements)
            {
                this.Balance = this.Balance + movement.Hours;
            };
        }


    }
}
