using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Password : UserControl
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Equals(" ") || textPass.Text.Equals(" ") || textNewPass.Text.Equals(" "))
            {
                MessageBox.Show("No se pueden dejar espacios vacios");
            }
            else
            {
                try
                {
                    var valid = ConnectionDB.ExecuteQuery(
                        $"SELECT * FROM APPUSER WHERE username ='{textUser.Text}' AND password ='{textPass.Text}'");


                    if (valid.Rows.Count == 1)
                    {
                        ConnectionDB.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textNewPass.Text}' " +
                                                     $"WHERE idUser");

                        MessageBox.Show("Se cambio la contraseña exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña son invalidos");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }


            }
        }
    }
}
