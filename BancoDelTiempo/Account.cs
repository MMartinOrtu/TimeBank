using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDelTiempo
{
    public class Account
    {
        private int id;
        private string state;
        private float balance;
        private DateTime startingDate;
        private DateTime leavingDate;
        private List<Movement> movements;
 
        // Constructor
        public Account()
        {
            Movements = new List<Movement>();
        }

        public int Id { get => id; set => id = value; }
        public string State { get => state; set => state = value; }
        public float Balance { get => balance; set => balance = value; }
        public DateTime StartingDate { get => startingDate; set => startingDate = value; }
        public DateTime LeavingDate { get => leavingDate; set => leavingDate = value; }
        public List<Movement> Movements { get => movements; set => movements = value; }
    }
}
