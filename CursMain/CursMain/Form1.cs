using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_sklad_Click(object sender, EventArgs e)
        {
            Form2 sklad = new Form2();
            sklad.Show();
        }

        private void but_recept_Click(object sender, EventArgs e)
        {
            Form3 recept = new Form3();
            recept.Show();
        }
    }
}
