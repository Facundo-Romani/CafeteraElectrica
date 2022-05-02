using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteraElectrica
{
    public partial class Cafetera : Form
    {
        public Cafetera()
        {
            InitializeComponent();
        }

        //Pantalla de carga Inicial.
        private void Cafetera_Load(object sender, EventArgs e)
        {   
             DialogResult respuesta = MessageBox.Show(" ¿Quieres Encender la cafetera? "," PREPARAR CAFÉ " , MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                btnOn.Enabled = true;
                anularCheckBox();
            }
            else
            {
                Close();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.BackColor = Color.Green;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (btnOff.Enabled == true)
            {
                Close();
            }
        }

        private void rbtnCapsula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCapsula.Checked)
            {
                btnCapsulaCafe.BackColor = Color.Green;
                desbloquearCheckBox();
            }
        }


        //Métodos para CheckBox.
        private void anularCheckBox()
        {
            checkBoxCortado.Enabled = false;
            checkBoxCappuccino.Enabled = false;
            checkBoxExpreso.Enabled = false;
        }

        private void desbloquearCheckBox()
        {
            checkBoxCortado.Enabled = true;
            checkBoxCappuccino.Enabled = true;
            checkBoxExpreso.Enabled = true;
        }

       
    }
}
