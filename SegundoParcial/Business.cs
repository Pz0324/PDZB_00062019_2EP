using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Business : UserControl
    {
        public Business()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
             {
                                                  
                 ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = " +
                                              $"{Convert.ToInt32(textIdBusiness.Text)}"); 
                                                     
                 MessageBox.Show("Se elimino el negocio");
                                                    
                                                  
                                                   
             }
             catch (Exception ex) {
                 MessageBox.Show("Ha ocurrido un problema");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                                                              
                ConnectionDB.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) " +
                $"VALUES ('{textBussiness.Text}', '{textDescription.Text}');"); 
                                                                 
                MessageBox.Show("Se agrego el negocio");
                                                                
                                                              
                                                               
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}