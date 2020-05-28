using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
               try
               {
                   var dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPORDER;");
                   dataGridView1.DataSource = dt;
                        
               }
               catch (Exception ex) {
                   MessageBox.Show("Ha ocurrido un problema");
               }
        }
    }
}