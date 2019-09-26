using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeProject
{
    public partial class Dashboard : Form
    {
        public Dashboard(int UserID)
        {
            InitializeComponent();

            SalesmanID = UserID;

            DataAccess _DataAccess = new DataAccess();

            Username = _DataAccess.ReturnUserName(UserID);
        }
        public int SalesmanID = 0;
        public string Username = string.Empty;

        public int RowIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
