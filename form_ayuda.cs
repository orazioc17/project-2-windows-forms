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
    public partial class form_ayuda : Form
    {
        public form_ayuda()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_volver_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea volver al formulario de bienvenida?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
