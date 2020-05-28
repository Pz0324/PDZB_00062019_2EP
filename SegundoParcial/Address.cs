using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Address : UserControl
    {
        public Address()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
             {
                                                              
                 ConnectionDB.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress " +
                                              $"= {Convert.ToInt32(textIdAddress.Text)}"); 
                                                                 
                 MessageBox.Show("Se elimino la dirección");
                                                                
                                                              
                                                               
             }
             catch (Exception ex) {
                 MessageBox.Show("Ha ocurrido un problema");
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                                                                          
                ConnectionDB.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                              $" VALUES({Convert.ToInt32(textIdUser.Text)}, '{textAddress.Text}' "); 
                                                                             
                MessageBox.Show("Se agrego la dirección");
                                                                            
                                                                          
                                                                           
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}