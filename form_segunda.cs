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
    public partial class form_segunda : Form
    {

        List<int> list_origin = new List<int>();
        List<int> list_destiny = new List<int>();

        public form_segunda()
        {
            InitializeComponent();
        }

        private void form_segunda_Load(object sender, EventArgs e)
        {
            btn_0_20.Enabled = false;
            btn_menor_50.Enabled = false;
            btn_50.Enabled = false;
            btn_asc.Enabled = false;
            btn_des.Enabled = false;
            btn_new.Enabled = false;
        }

        private void imprimir()
        {
            ls_origen.Items.Clear();
            ls_origen.BeginUpdate();
            foreach (int num in list_origin)
            {
                ls_origen.Items.Add(num);
            }
            ls_origen.EndUpdate();
        }

        private void agg_logic()
        {
            if (txt_number.Text != string.Empty)
            {
                errorProvider1.SetError(txt_number, "");
                int number = int.Parse(txt_number.Text);
                list_origin.Add(number);
                imprimir();
                btn_des.Checked = false;
                btn_asc.Checked = false;
                txt_number.Text = "";
                txt_number.Focus();
                btn_0_20.Enabled = true;
                btn_menor_50.Enabled = true;
                btn_50.Enabled = true;
                btn_asc.Enabled = true;
                btn_des.Enabled = true;
                btn_new.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txt_number, "Debe introducir un numero");
            }
        }

        private void btn_agg_Click(object sender, EventArgs e)
        {
            agg_logic();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agg_logic();
            }
        }

        private void ascendente()
        {
            list_origin.Sort();
            list_origin.Reverse();
            imprimir();
        }

        private void descendente()
        {
            list_origin.Sort();
            imprimir();
        }

        private void btn_asc_CheckedChanged(object sender, EventArgs e)
        {
            ascendente();
        }

        private void btn_des_CheckedChanged(object sender, EventArgs e)
        {
            descendente();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar este formulario?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imprimir_destino()
        {
            ls_destino.Items.Clear();
            ls_destino.BeginUpdate();
            foreach (int num in list_destiny)
            {
                ls_destino.Items.Add(num);
            }
            ls_destino.EndUpdate();
        }

        private void btn_0_20_Click(object sender, EventArgs e)
        {
            list_destiny.Clear();
            foreach(int number in list_origin)
            {
                if(number > 0 && number <20)
                {
                    list_destiny.Add(number);
                }
                imprimir_destino();
            }
        }

        private void btn_menor_50_Click(object sender, EventArgs e)
        {
            list_destiny.Clear();
            foreach (int number in list_origin)
            {
                if (number <= 50)
                {
                    list_destiny.Add(number);
                }
                imprimir_destino();
            }
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            list_destiny.Clear();
            foreach (int number in list_origin)
            {
                if (number > 50)
                {
                    list_destiny.Add(number);
                }
                imprimir_destino();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_asc.Checked = false;
            btn_des.Checked = false;
            btn_des.Enabled = false;
            btn_asc.Enabled = false;
            ls_destino.Items.Clear();
            ls_origen.Items.Clear();
            list_destiny.Clear();
            list_origin.Clear();
        }
    }
}
