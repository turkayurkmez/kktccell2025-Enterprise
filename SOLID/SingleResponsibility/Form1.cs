using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {

            var name = textBoxProductName.Text;
            var price = decimal.Parse(textBoxPrice.Text);
            int affectedRows = new ProductService().CreateProduct(name,price);
            string output = affectedRows > 0 ? "Baþarýlý" : "Baþarýsýz";
            MessageBox.Show(output);

        }

     

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                BackColor = colorDialog.Color;

            }
        }
    }
}
