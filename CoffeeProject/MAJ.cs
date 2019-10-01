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
    public partial class MAJ : UserControl
    {
        public MAJ()
        {
            InitializeComponent();
        }
        public event EventHandler TrushButton;
        public event EventHandler EditButton;
        private void MAJ_Load(object sender, EventArgs e)
        {

        }
        DataAccess d = new DataAccess();
        public void trush(string table,string id)
        {
           DialogResult r= MessageBox.Show("Voulez vous vraiment supprimer votre "+table+" ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                bool respond = d.Remove(table, id);
                if(respond)
                    MessageBox.Show("Supprimé avec succés");
                else MessageBox.Show("Vérifier vos données");
            }
        }
        public void edit(string Table, string[] parameters, string[] values)
        {
            DialogResult r = MessageBox.Show("Voulez vous vraiment modifier votre " + Table + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                bool respond = d.Update(Table, parameters,values);
                if (respond)
                    MessageBox.Show("Modifié avec succés");
                else MessageBox.Show("Vérifier vos données");
            }
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (this.TrushButton != null)
                this.TrushButton(this, e);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
