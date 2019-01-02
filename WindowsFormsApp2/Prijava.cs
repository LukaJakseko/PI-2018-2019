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
    public partial class form_Prijava : Form
    {
        public form_Prijava()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Izbornik fi = new form_Izbornik();
            fi.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
  
        private void btn_Registriraj2_Click(object sender, EventArgs e)
        {
            form_Registracija fr = new form_Registracija();
            fr.ShowDialog();
        }
    }
}
