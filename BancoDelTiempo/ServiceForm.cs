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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {

        }
        private void addService()
        {
            using (BdTEntities db = new BdTEntities())
            {
                Service nuevoServicio = new Service()
                {
                    name = txtName.Text,
                    category = Convert.ToInt32(comboBoxCategory.Text),
                    type = comboBoxType.Text,
                    description = textDescription.Text,
                    hours = Convert.ToInt64(txtHours.Text),
                    schedule = txtSchedule.Text,
                };

                db.Services.Add(nuevoServicio);
                db.SaveChanges();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                MessageBox.Show("Debe rellenar el campo nombre");
            }
            else
            {
                addService();
                MessageBox.Show("Se guardó el registro correctamente");
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
