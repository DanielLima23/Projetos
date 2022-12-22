using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

      
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsomar_Click(object sender, EventArgs e)
        {

            double n1, n2, total;

            n1 = Convert.ToDouble(txtvalor1.Text);
            n2 = Convert.ToDouble(txtvalor2.Text);
            total = n1 + n2;

            txttotal.Text = total.ToString();
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {        
    
                double n1, n2, total;
                n1 = Convert.ToDouble(txtvalor1.Text);
                n2 = Convert.ToDouble(txtvalor2.Text);
                total = n1 - n2;

                txttotal.Text = total.ToString();            
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, total;

            n1 = Convert.ToDouble(txtvalor1.Text);
            n2 = Convert.ToDouble(txtvalor2.Text);
            total = n1 * n2;

            txttotal.Text = total.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double n1, n2, total;

            n1 = Convert.ToDouble(txtvalor1.Text);
            n2 = Convert.ToDouble(txtvalor2.Text);
            total = n1 / n2;

            txttotal.Text = total.ToString();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
