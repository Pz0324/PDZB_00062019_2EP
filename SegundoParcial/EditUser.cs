using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class EditUser : UserControl
    {
        public EditUser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text.Equals(" ") || textUsername.Text.Equals(" ") || textPassword.Text.Equals(" "))
            {
                MessageBox.Show("No se pueden dejar espacios vacios");
            }
            else
            {
                var dt = ConnectionDB.ExecuteQuery(
                    $"SELECT username FROM APPUSER WHERE username = '{textUsername.Text}");
            }
            try
            {
                if(comboType.Text.Equals("Administrador")){
                    
                    ConnectionDB.ExecuteNonQuery(
                        $"INSERT INTO APPUSER(fullname, username, password, userType) " +
                        $"VALUES('{textName.Text}', '{textUsername.Text}', '{textPassword.Text}', {true});"); 
                 
                    MessageBox.Show("Se agrego el usuario");
                
                }
                else if(comboType.Text.Equals("Usuario")){
                   
                    ConnectionDB.ExecuteNonQuery(
                        $"INSERT INTO APPUSER(fullname, username, password, userType) " +
                        $"VALUES('{textName.Text}', '{textUsername.Text}', '{textPassword.Text}', {false});"); 
                 
                    MessageBox.Show("Se agrego el usuario");
                
                    
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
             {
                          
                  ConnectionDB.ExecuteNonQuery($"DELETE FROM APPUSER WHERE idUser" +
                                               $" = {Convert.ToInt32(textIdUser.Text)}"); 
                             
                            MessageBox.Show("Se elimino el usuario");
                            
                          
                           
             }
             catch (Exception ex) {
                 MessageBox.Show("Ha ocurrido un problema");
             }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
               try
               {
                   var dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER;");
                   dataGridView1.DataSource = dt;
                        
               }
               catch (Exception ex) {
                   MessageBox.Show("Ha ocurrido un problema");
               }
        }
    }
   }


    
