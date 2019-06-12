using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDelTiempo
{
    public partial class MovementForm : Form
    {
        //Simulate Logged in userID and AccountID
        private int userID = 1;
        private int accountID = 1;
  

        public MovementForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFromUser.Text) == true && string.IsNullOrEmpty(txtService.Text) == true && string.IsNullOrEmpty(txtHours.Text) == true)
            {
                MessageBox.Show("Debe rellenar los campos que faltan");
            }
            else
            {
                addMovement();
                updateAccount();
                MessageBox.Show("Se guardó el registro correctamente");
                this.Close();
            }
        }

        private void MovementForm_Load(object sender, EventArgs e)
        {

        }

        private void addMovement()
        {
            int fromUserAccountID = 1;

            using (var db = new BancoContext())
            {
                Movement newMovementToUser = new Movement();
                newMovementToUser.addMovement(Convert.ToDateTime(dateMovement.Text) , -Convert.ToInt64(txtHours.Text), Convert.ToInt32(txtService.Text), Convert.ToInt32(txtFromUser.Text), accountID);
                db.Movements.Add(newMovementToUser);

                Movement newMovementFromUser = new Movement();
                int fromUserID = Convert.ToInt32(txtFromUser.Text);
                var fromUserAccount = from account in db.Accounts where account.User_Id == fromUserID select account;
                foreach (var account in fromUserAccount)
                {
                    fromUserAccountID = account.Id;
                }
                newMovementFromUser.addMovement(Convert.ToDateTime(dateMovement.Text), Convert.ToInt64(txtHours.Text), Convert.ToInt32(txtService.Text), Convert.ToInt32(txtFromUser.Text), fromUserAccountID);
                db.Movements.Add(newMovementFromUser);
                db.SaveChanges();
            }
        }

        private void updateAccount()
        {
            using (var db = new BancoContext())
            {

                var currentAccount = from account in db.Accounts where account.User_Id == userID select account;

                foreach (var account in currentAccount)
                {
                    account.updateAccount();
                }
                db.SaveChanges();
            }
        }
    }
}
