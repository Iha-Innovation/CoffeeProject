using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeProject
{
    public partial class EmployeUC : UserControl
    {
        public EmployeUC()
        {
            InitializeComponent();
        }

        private void maj1_TrushButton(object sender, EventArgs e)
        {
            maj1.trush("commande","1");
        }
    }
}
