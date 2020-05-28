using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Administrator : Form
    {
        private UserControl current = null;
        public Administrator()
        {
            InitializeComponent();
            current = welcomeAdmin1;
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EditUser();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Business();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Product();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Order();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void bienvenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new WelcomeAdmin();
            
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }
    }
}