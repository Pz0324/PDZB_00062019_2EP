using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                                                  
                ConnectionDB.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = {Convert.ToInt32(textIdProduct.Text)}"); 
                                                     
                MessageBox.Show("Se elimino el producto");
                                                    
                                                  
                                                   
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                                                  
                ConnectionDB.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) " +
                $"VALUES({Convert.ToInt32((textIdBusiness.Text))},'{textProduct}');"); 
                                                     
                MessageBox.Show("Se agrego el producto");
                                                    
                                                  
                                                   
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}