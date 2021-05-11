using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_corte_orazio_cappadonna
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void primeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_primera primera = new form_primera();
            primera.Show();
        }

        private void segunda20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_segunda segunda = new form_segunda();
            segunda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ayuda ayuda = new form_ayuda();
            ayuda.Show();
        }
    }
}
