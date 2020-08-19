using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_circuferensia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            double valor, area;


            valor = double.Parse(txtValor.Text);

            area = Math.PI * Math.Pow(valor, 2);

            label4.Visible = true;

            lblArea.Text = Convert.ToString(area);
            lblArea.Visible = true; 


        }

       
        
    }
}
