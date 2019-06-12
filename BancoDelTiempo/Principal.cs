using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BancoDelTiempo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CREATE AN USER AN ITS ACCOUNT AND STORE IN DATA BASE

            /*using (var db = new BancoContext())
            {
                var user = new User
                {
                    Name = "Miguel",
                    Email = "pomikelor@gmaiom",
                    Password = "admin",
                    Phone = 654654654
                };
                var accountMiguel = new Account(user_id);
                db.Accounts.Add(accountMiguel);
                db.Users.Add(user);
                db.SaveChanges();
            }*/

            //Get user´s name from data base and show in principal form when logged in
            int userId = 2;
            using (var db = new BancoContext())
            {
                var currentUser = from user in db.Users where user.Id == userId select user;

                foreach (var user in currentUser)
                {
                    labelSaludo.Text = "¡Hola " + user.Name + "!";
                }

                var currentAccount = from account in db.Accounts where account.User_Id == userId select account;

                foreach (var account in currentAccount)
                {
                    //List current user's account movements
                    listMovements(account.Id);
                    account.updateAccount();
                    txtBalance.Text = account.Balance.ToString();
           
                }
                db.SaveChanges();
            }
           
            // List all services
            listServices();
        }

        private void listServices()
        {
            listViewServices.Items.Clear();
            using (var db = new BancoContext())
             {
                 var query = from service in db.Services
                             select service;
                 foreach (var item in query)
                 {
                     ListViewItem listItem = listViewServices.Items.Add(item.Name);
                     listItem.SubItems.Add(item.User_Id.ToString());
                     listItem.SubItems.Add(item.Type);
                     listItem.SubItems.Add(item.Hours.ToString());
                     listItem.SubItems.Add(item.Description);
                     listItem.SubItems.Add(item.Schedule);
                     listItem.SubItems.Add(item.Category_Id.ToString());
                 }

             }

        }

        private void listMovements(int accountId)
        {
            listViewMovements.Items.Clear();
            using (var db = new BancoContext())
            {
                var query = from movement in db.Movements where movement.Account_Id == accountId
                            select movement;
                foreach (var item in query)
                {
                    ListViewItem listItem = listViewMovements.Items.Add(item.Date.ToString());
                    listItem.SubItems.Add(item.Hours.ToString());
                    listItem.SubItems.Add(item.Service_Id.ToString());
                    listItem.SubItems.Add(item.FromUser_Id.ToString());
                }

            }

        }

        private void listViewServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            ServiceForm form = new ServiceForm();
            form.Show();
     
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void labelSaludo_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateMovement_Click(object sender, EventArgs e)
        {
            MovementForm form = new MovementForm();
            form.Show();
        }
    }
}
