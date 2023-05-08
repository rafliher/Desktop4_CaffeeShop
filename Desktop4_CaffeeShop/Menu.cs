using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Desktop4_CaffeeShop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAddDetail menuAddDetail = new MenuAddDetail("Espresso", 10000);
            menuAddDetail.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAddDetail menuAddDetail = new MenuAddDetail("Latte", 15000);
            menuAddDetail.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAddDetail menuAddDetail = new MenuAddDetail("Cappuccino", 12000);
            menuAddDetail.ShowDialog();
        }
    }
}
