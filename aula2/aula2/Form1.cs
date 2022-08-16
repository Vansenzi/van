using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {
            //comentario de uma linha
            /*
             * comentarios
             * varias
             * linhas
             */
         
           /*
            double bas, alt, area;
            bas = Convert.ToDouble(txtbase.Text);
            alt = Convert.ToDouble(txtaltura.Text);

            area = bas * alt / 2;

            txtarea.Text=Convert.ToString(area);
            */

            txtarea.Text= Convert.ToString(Convert.ToDouble(txtbase.Text)*Convert.ToDouble(txtaltura.Text)/2);

        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtarea.Text = "";
            txtbase.Text = "";
            txtaltura.Text = "";
        }
    }
}
