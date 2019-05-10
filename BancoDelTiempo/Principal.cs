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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listData();
        }

        private void listData()
        {
            listViewServices.Items.Clear();
            using (BdTEntities db = new BdTEntities())
            {
                var query = from service in db.Services
                            select service;
                foreach (var item in query)
                {
                    ListViewItem listItem = listViewServices.Items.Add(item.name);
                    listItem.SubItems.Add(item.type);
                    listItem.SubItems.Add(item.hours.ToString());
                    listItem.SubItems.Add(item.description);
                    listItem.SubItems.Add(item.schedule);
                    listItem.SubItems.Add(item.category.ToString());
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
    }
}
