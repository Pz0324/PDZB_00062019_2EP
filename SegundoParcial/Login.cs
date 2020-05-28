using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    var valid = ConnectionDB.ExecuteQuery(
                        $"SELECT * FROM APPUSER WHERE username ='{textBox1.Text}' AND password ='{textBox2.Text}'");

                    
                    if (valid.Rows.Count == 1)
                    {
                        if (valid.Rows[0][4].ToString().Equals("True"))
                        {
                            
                            new Administrator().Show();
                        }
                        else if (valid.Rows[0][4].ToString().Equals("False"))
                        {
                           

                            new User().Show();
                        }
                    }
                    else
                    {

                        MessageBox.Show("El usuario o la contraseña no es valido");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            new Password().Show();
        }
    }
}