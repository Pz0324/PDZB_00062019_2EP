using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class EditOrder : UserControl
    {
        public EditOrder()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
              try
              {
                                      
                  ConnectionDB.ExecuteNonQuery($"DELETE FROM ORDER WHERE idOrder = " +
                                               $"{Convert.ToInt32(textIdOrder.Text)}"); 
                                         
                  MessageBox.Show("Se elimino la orden");
                                        
                                      
                                       
              }
              catch (Exception ex) {
                  MessageBox.Show("Ha ocurrido un problema");
              }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
             {
                                          DateTime date = DateTime.Now;         
                 ConnectionDB.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress)  " +
                                              $"VALUES({dateTimePicker1}, {Convert.ToInt32((textIdProduct.Text))}, " +
                                              $"{Convert.ToInt32((textIdAddress.Text))});"); 
                                                     
                 MessageBox.Show("Se agrego la orden");
                                                    
                                                  
                                                   
             }
             catch (Exception ex) {
                 MessageBox.Show("Ha ocurrido un problema");
             }
        }
        }
    }
