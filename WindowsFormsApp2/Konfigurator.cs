using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class form_Konfigurator : Form
    {
        public form_Konfigurator()
        {
            InitializeComponent();
        }

        private void Konfigurator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            form_Izbornik fi = new form_Izbornik();
            fi.ShowDialog();
        }

        private void VrstaAut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VrsteA_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Model_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Gorivo_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Gorivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Mjenjač_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Mjenjač_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Oprema_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Oprema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
