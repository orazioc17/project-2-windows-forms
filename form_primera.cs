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
    public partial class form_primera : Form
    {
        public form_primera()
        {
            InitializeComponent();
        }

        private void form_primera_Load(object sender, EventArgs e)
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
            txt7.Enabled = false;
            txt8.Enabled = false;
            txt9.Enabled = false;
            txt10.Enabled = false;
            btn_evaluar.Enabled = false;
            btn_new.Enabled = false;
        }

        private void begin()
        {
            txt_number.Enabled = false;
            lbl1.Text = txt_number.Value.ToString();
            lbl2.Text = txt_number.Value.ToString();
            lbl3.Text = txt_number.Value.ToString();
            lbl4.Text = txt_number.Value.ToString();
            lbl5.Text = txt_number.Value.ToString();
            lbl6.Text = txt_number.Value.ToString();
            lbl7.Text = txt_number.Value.ToString();
            lbl8.Text = txt_number.Value.ToString();
            lbl9.Text = txt_number.Value.ToString();
            lbl10.Text = txt_number.Value.ToString();
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            txt7.Enabled = true;
            txt8.Enabled = true;
            txt9.Enabled = true;
            txt10.Enabled = true;
            btn_comenzar.Enabled = false;
            btn_new.Enabled = true;
            btn_evaluar.Enabled = true;
        }

        private void btn_comenzar_Click(object sender, EventArgs e)
        {
            begin();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar este formulario?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void calcular()
        {
            int contador = 0;
            int number = (int)txt_number.Value;

            //Textbox 1
            if ((number * 1) == (int.Parse(txt1.Text)))
            {
                contador++;
                txt1.BackColor = Color.Green;
            } else
            {
                txt1.BackColor = Color.Red;
            }

            //Textbox2
            if ((number * 2) == (int.Parse(txt2.Text)))
            {
                contador++;
                txt2.BackColor = Color.Green;
            }
            else
            {
                txt2.BackColor = Color.Red;
            }

            //Textbox 3
            if ((number * 3) == (int.Parse(txt3.Text)))
            {
                contador++;
                txt3.BackColor = Color.Green;
            }
            else
            {
                txt3.BackColor = Color.Red;
            }

            //Textbox 4
            if ((number * 4) == (int.Parse(txt4.Text)))
            {
                contador++;
                txt4.BackColor = Color.Green;
            }
            else
            {
                txt4.BackColor = Color.Red;
            }

            //Textbox 5
            if ((number * 5) == (int.Parse(txt5.Text)))
            {
                contador++;
                txt5.BackColor = Color.Green;
            }
            else
            {
                txt5.BackColor = Color.Red;
            }

            //Textbox 6
            if ((number * 6) == (int.Parse(txt6.Text)))
            {
                contador++;
                txt6.BackColor = Color.Green;
            }
            else
            {
                txt6.BackColor = Color.Red;
            }

            //Textbox 7
            if ((number * 7) == (int.Parse(txt7.Text)))
            {
                contador++;
                txt7.BackColor = Color.Green;
            }
            else
            {
                txt7.BackColor = Color.Red;
            }

            //Textbox 8
            if ((number * 8) == (int.Parse(txt8.Text)))
            {
                contador++;
                txt8.BackColor = Color.Green;
            }
            else
            {
                txt8.BackColor = Color.Red;
            }

            //Textbox 9
            if ((number * 9) == (int.Parse(txt9.Text)))
            {
                contador++;
                txt9.BackColor = Color.Green;
            }
            else
            {
                txt9.BackColor = Color.Red;
            }

            //Textbox 10
            if ((number * 10) == (int.Parse(txt10.Text)))
            {
                contador++;
                txt10.BackColor = Color.Green;
            }
            else
            {
                txt10.BackColor = Color.Red;
            }

            lbl_result.Text = "El puntaje obtenido es: " + contador.ToString() + " puntos";
            if(contador <= 5)
            {
                lbl_nota.Text = "Reprobado :(";
            }
            else
            {
                lbl_nota.Text = "Aprobado :)";
            }
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            if (txt1.Text != string.Empty && txt2.Text != string.Empty && txt3.Text != string.Empty && txt4.Text != string.Empty && txt5.Text != string.Empty && txt6.Text != string.Empty && txt7.Text != string.Empty && txt8.Text != string.Empty && txt9.Text != string.Empty && txt10.Text != string.Empty)
            {
                errorProvider1.SetError(btn_evaluar, "");
                calcular();
                btn_evaluar.Enabled = false;
            } else
            {
                errorProvider1.SetError(btn_evaluar, "Debe ingresar los resultados de las tablas de multiplicar");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
            txt7.Enabled = false;
            txt8.Enabled = false;
            txt9.Enabled = false;
            txt10.Enabled = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            lbl_nota.Text = "";
            txt1.BackColor = Color.White;
            txt2.BackColor = Color.White;
            txt3.BackColor = Color.White;
            txt4.BackColor = Color.White;
            txt5.BackColor = Color.White;
            txt6.BackColor = Color.White;
            txt7.BackColor = Color.White;
            txt8.BackColor = Color.White;
            txt9.BackColor = Color.White;
            txt10.BackColor = Color.White;
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl_result.Text = "";
            txt_number.Enabled = true;
            txt_number.Value = 1;
            txt_number.Focus();
            btn_comenzar.Enabled = true;
            btn_evaluar.Enabled = false;
            btn_new.Enabled = false;
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                begin();
            }
        }
    }
}
