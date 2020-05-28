using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class User : Form
    {
        private UserControl current = null;
        public User()
        {
            InitializeComponent();
            current = welcomeUser1;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Address();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void bienvenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new WelcomeUser();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EditOrder();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }
    }
}