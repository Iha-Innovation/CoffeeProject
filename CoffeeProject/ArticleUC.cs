using System;
using System.IO;
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
    public partial class ArticleUC : UserControl
    {
        int ProductID;
        string ProductName, ProductCategory;
        decimal ProductPrice;
        byte[] ProductPicture;
        public ArticleUC(int GivenProductID, string GivenProductName, decimal GivenProductPrice, string GivenProductCategory, byte[] GivenProductPicture)
        {
            InitializeComponent();

            ProductID = GivenProductID;
            ProductName = GivenProductName;
            ProductPrice = GivenProductPrice;
            ProductCategory = GivenProductCategory;

            ProductPicture = GivenProductPicture;
        }
      
    
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            /*THIS IS THE MAIN CODE FOR HASHING*/

            /*initializing memory stream class for creating a stream of binary numbers*/
            MemoryStream ms = new MemoryStream();

            /*saving the image in raw format from picture box*/
            bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);

            /*Array of Binary numbers that have been converted*/
            byte[] ProductPicture = ms.GetBuffer();

            /*closing the memory stream*/
            ms.Close();

            /*HASHING END HERE*/


            if (_DataAccess.AddNewProductToDatabase(bunifuTextBox3.Text, Convert.ToDecimal(bunifuTextBox3.Text), _DataAccess.ReturnCategoryID(bunifuDropdown1.selectedValue.ToString()), bunifuTextBox3.Text, ProductPicture))
            {
                MessageBox.Show("Article bien ajouté");
            }
            else MessageBox.Show("Impossible d'ajouter cet article");
        }

        private void ArticleUC_Load(object sender, EventArgs e)
        {

            bunifuTextBox1.Text = bunifuTextBox1.ToString();
            bunifuTextBox3.Text = ProductName;
            bunifuTextBox4.Text = bunifuTextBox4.ToString();
            bunifuDropdown1.Text = ProductCategory;
           
            MemoryStream ms = new MemoryStream(ProductPicture);
            bunifuPictureBox1.Image = Image.FromStream(ms);

            DataAccess _DataAccess = new DataAccess();

          
        

            foreach (Details Category in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                bunifuDropdown1.Items.Add(Category.Name);
            }
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment modifier cet article?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int ProductID = Convert.ToInt32(bunifuTextBox1.Text);

                string ProductName = bunifuTextBox3.Text;

                decimal ProductPrice = Convert.ToDecimal(bunifuTextBox4.Text);

                string ProductCategory = bunifuDropdown1.Text;

                int ProductCategoryID = _DataAccess.ReturnCategoryID(ProductCategory);


                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] MyProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                if (_DataAccess.UpdateProduct(ProductID, ProductName, ProductPrice, ProductCategoryID, MyProductPicture))
                {
                    this.Close();
                }
                else MessageBox.Show("Produit n'est pas mis à jour", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            /*selecting image*/

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*if picture selected then load in the picture box*/
                bunifuPictureBox1.Load(ofd.FileName);
            }
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = string.Empty;
            bunifuTextBox3.Text = string.Empty;
            bunifuTextBox4.Text = string.Empty;
            bunifuTextBox1.Text = string.Empty;
            bunifuPictureBox1.Image = null;
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer cet article?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int ProductID = Convert.ToInt32(bunifuTextBox1.Text);



                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

           

                /*Array of Binary numbers that have been converted*/
                byte[] MyProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                if (_DataAccess.RemoveProduct(ProductID))
                {
                    this.Close();
                }
                else MessageBox.Show("Produit non supprimé", "Erreur", MessageBoxButtons.OK);
            }
        }
    }
}