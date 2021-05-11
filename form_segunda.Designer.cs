
namespace _2do_corte_orazio_cappadonna
{
    partial class form_segunda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_agg = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_des = new System.Windows.Forms.RadioButton();
            this.btn_asc = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ls_origen = new System.Windows.Forms.ListBox();
            this.ls_destino = new System.Windows.Forms.ListBox();
            this.btn_menor_50 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_0_20 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(119, 31);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(77, 30);
            this.txt_number.TabIndex = 1;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // btn_agg
            // 
            this.btn_agg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agg.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_agg.Location = new System.Drawing.Point(217, 16);
            this.btn_agg.Name = "btn_agg";
            this.btn_agg.Size = new System.Drawing.Size(134, 56);
            this.btn_agg.TabIndex = 2;
            this.btn_agg.Text = "Agregar a lista";
            this.btn_agg.UseVisualStyleBackColor = true;
            this.btn_agg.Click += new System.EventHandler(this.btn_agg_Click);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_new.Location = new System.Drawing.Point(48, 240);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(134, 56);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "Nuevo proceso";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_des);
            this.groupBox1.Controls.Add(this.btn_asc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(22, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // btn_des
            // 
            this.btn_des.AutoSize = true;
            this.btn_des.Location = new System.Drawing.Point(6, 60);
            this.btn_des.Name = "btn_des";
            this.btn_des.Size = new System.Drawing.Size(145, 25);
            this.btn_des.TabIndex = 1;
            this.btn_des.TabStop = true;
            this.btn_des.Text = "Descendente";
            this.btn_des.UseVisualStyleBackColor = true;
            this.btn_des.CheckedChanged += new System.EventHandler(this.btn_des_CheckedChanged);
            // 
            // btn_asc
            // 
            this.btn_asc.AutoSize = true;
            this.btn_asc.Location = new System.Drawing.Point(6, 29);
            this.btn_asc.Name = "btn_asc";
            this.btn_asc.Size = new System.Drawing.Size(133, 25);
            this.btn_asc.TabIndex = 0;
            this.btn_asc.TabStop = true;
            this.btn_asc.Text = "Ascendente";
            this.btn_asc.UseVisualStyleBackColor = true;
            this.btn_asc.CheckedChanged += new System.EventHandler(this.btn_asc_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista Destino:";
            // 
            // ls_origen
            // 
            this.ls_origen.FormattingEnabled = true;
            this.ls_origen.ItemHeight = 21;
            this.ls_origen.Location = new System.Drawing.Point(217, 127);
            this.ls_origen.Name = "ls_origen";
            this.ls_origen.Size = new System.Drawing.Size(156, 151);
            this.ls_origen.TabIndex = 7;
            // 
            // ls_destino
            // 
            this.ls_destino.FormattingEnabled = true;
            this.ls_destino.ItemHeight = 21;
            this.ls_destino.Location = new System.Drawing.Point(388, 127);
            this.ls_destino.Name = "ls_destino";
            this.ls_destino.Size = new System.Drawing.Size(159, 151);
            this.ls_destino.TabIndex = 8;
            // 
            // btn_menor_50
            // 
            this.btn_menor_50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menor_50.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_menor_50.Location = new System.Drawing.Point(329, 284);
            this.btn_menor_50.Name = "btn_menor_50";
            this.btn_menor_50.Size = new System.Drawing.Size(106, 33);
            this.btn_menor_50.TabIndex = 9;
            this.btn_menor_50.Text = "<=50";
            this.btn_menor_50.UseVisualStyleBackColor = true;
            this.btn_menor_50.Click += new System.EventHandler(this.btn_menor_50_Click);
            // 
            // btn_50
            // 
            this.btn_50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_50.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_50.Location = new System.Drawing.Point(441, 284);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(106, 33);
            this.btn_50.TabIndex = 10;
            this.btn_50.Text = ">50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_0_20
            // 
            this.btn_0_20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0_20.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_0_20.Location = new System.Drawing.Point(217, 284);
            this.btn_0_20.Name = "btn_0_20";
            this.btn_0_20.Size = new System.Drawing.Size(106, 33);
            this.btn_0_20.TabIndex = 11;
            this.btn_0_20.Text = ">0 y <20";
            this.btn_0_20.UseVisualStyleBackColor = true;
            this.btn_0_20.Click += new System.EventHandler(this.btn_0_20_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_cerrar.Location = new System.Drawing.Point(413, 16);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(134, 56);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar formulario";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // form_segunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(573, 340);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_0_20);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.btn_menor_50);
            this.Controls.Add(this.ls_destino);
            this.Controls.Add(this.ls_origen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_agg);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_segunda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de numeros";
            this.Load += new System.EventHandler(this.form_segunda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_agg;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_des;
        private System.Windows.Forms.RadioButton btn_asc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ls_origen;
        private System.Windows.Forms.ListBox ls_destino;
        private System.Windows.Forms.Button btn_menor_50;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_0_20;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_cerrar;
    }
}