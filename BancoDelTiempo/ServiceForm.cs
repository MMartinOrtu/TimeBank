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
            using (var db = new BancoContext())
            {
                Service nuevoServicio = new Service();
                nuevoServicio.addService(txtName.Text, textDescription.Text, Convert.ToInt64(txtHours.Text), txtSchedule.Text, comboBoxType.Text, 1, Convert.ToInt32(comboBoxCategory.Text));
                db.Services.Add(nuevoServicio);
                db.SaveChanges();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true && string.IsNullOrEmpty(txtHours.Text) == true && string.IsNullOrEmpty(comboBoxType.Text) == true && string.IsNullOrEmpty(comboBoxCategory.Text) == true)
            {
                MessageBox.Show("Debe rellenar los campos que faltan");
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
