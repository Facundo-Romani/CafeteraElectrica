namespace CafeteraElectrica
{
    partial class Cafetera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExpreso = new System.Windows.Forms.Label();
            this.lblCortado = new System.Windows.Forms.Label();
            this.lblCappuccino = new System.Windows.Forms.Label();
            this.checkBoxExpreso = new System.Windows.Forms.CheckBox();
            this.checkBoxCortado = new System.Windows.Forms.CheckBox();
            this.checkBoxCappuccino = new System.Windows.Forms.CheckBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnCapsulaCafe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCapsula = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpreso
            // 
            this.lblExpreso.AutoSize = true;
            this.lblExpreso.Location = new System.Drawing.Point(106, 56);
            this.lblExpreso.Name = "lblExpreso";
            this.lblExpreso.Size = new System.Drawing.Size(67, 20);
            this.lblExpreso.TabIndex = 0;
            this.lblExpreso.Text = "Expreso";
            // 
            // lblCortado
            // 
            this.lblCortado.AutoSize = true;
            this.lblCortado.Location = new System.Drawing.Point(106, 101);
            this.lblCortado.Name = "lblCortado";
            this.lblCortado.Size = new System.Drawing.Size(66, 20);
            this.lblCortado.TabIndex = 1;
            this.lblCortado.Text = "Cortado";
            // 
            // lblCappuccino
            // 
            this.lblCappuccino.AutoSize = true;
            this.lblCappuccino.Location = new System.Drawing.Point(106, 143);
            this.lblCappuccino.Name = "lblCappuccino";
            this.lblCappuccino.Size = new System.Drawing.Size(93, 20);
            this.lblCappuccino.TabIndex = 2;
            this.lblCappuccino.Text = "Cappuccino";
            // 
            // checkBoxExpreso
            // 
            this.checkBoxExpreso.AutoSize = true;
            this.checkBoxExpreso.Location = new System.Drawing.Point(216, 57);
            this.checkBoxExpreso.Name = "checkBoxExpreso";
            this.checkBoxExpreso.Size = new System.Drawing.Size(22, 21);
            this.checkBoxExpreso.TabIndex = 3;
            this.checkBoxExpreso.UseVisualStyleBackColor = true;
            // 
            // checkBoxCortado
            // 
            this.checkBoxCortado.AutoSize = true;
            this.checkBoxCortado.Location = new System.Drawing.Point(216, 99);
            this.checkBoxCortado.Name = "checkBoxCortado";
            this.checkBoxCortado.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCortado.TabIndex = 4;
            this.checkBoxCortado.UseVisualStyleBackColor = true;
            // 
            // checkBoxCappuccino
            // 
            this.checkBoxCappuccino.AutoSize = true;
            this.checkBoxCappuccino.Location = new System.Drawing.Point(216, 143);
            this.checkBoxCappuccino.Name = "checkBoxCappuccino";
            this.checkBoxCappuccino.Size = new System.Drawing.Size(22, 21);
            this.checkBoxCappuccino.TabIndex = 5;
            this.checkBoxCappuccino.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(39, 89);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(65, 40);
            this.btnOn.TabIndex = 6;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(317, 89);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(60, 40);
            this.btnOff.TabIndex = 7;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnCapsulaCafe
            // 
            this.btnCapsulaCafe.Location = new System.Drawing.Point(304, 177);
            this.btnCapsulaCafe.Name = "btnCapsulaCafe";
            this.btnCapsulaCafe.Size = new System.Drawing.Size(28, 21);
            this.btnCapsulaCafe.TabIndex = 8;
            this.btnCapsulaCafe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxExpreso);
            this.groupBox1.Controls.Add(this.lblExpreso);
            this.groupBox1.Controls.Add(this.lblCortado);
            this.groupBox1.Controls.Add(this.lblCappuccino);
            this.groupBox1.Controls.Add(this.checkBoxCortado);
            this.groupBox1.Controls.Add(this.checkBoxCappuccino);
            this.groupBox1.Location = new System.Drawing.Point(39, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE CAFÉ";
            // 
            // rbtnCapsula
            // 
            this.rbtnCapsula.AutoSize = true;
            this.rbtnCapsula.Location = new System.Drawing.Point(73, 175);
            this.rbtnCapsula.Name = "rbtnCapsula";
            this.rbtnCapsula.Size = new System.Drawing.Size(225, 24);
            this.rbtnCapsula.TabIndex = 11;
            this.rbtnCapsula.TabStop = true;
            this.rbtnCapsula.Text = "CAPSULA INTRODUCIDA";
            this.rbtnCapsula.UseVisualStyleBackColor = true;
            this.rbtnCapsula.CheckedChanged += new System.EventHandler(this.rbtnCapsula_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeteraElectrica.Properties.Resources._229408895847d8dabf22167e049c88b7_icono_plano_de_taza_de_caf_eacute_caliente_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(165, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Cafetera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(460, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnCapsula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapsulaCafe);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Name = "Cafetera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAFETERA";
            this.Load += new System.EventHandler(this.Cafetera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpreso;
        private System.Windows.Forms.Label lblCortado;
        private System.Windows.Forms.Label lblCappuccino;
        private System.Windows.Forms.CheckBox checkBoxExpreso;
        private System.Windows.Forms.CheckBox checkBoxCortado;
        private System.Windows.Forms.CheckBox checkBoxCappuccino;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnCapsulaCafe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCapsula;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

