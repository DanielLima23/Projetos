using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = 0, pesoIdeal = 0;
                string nome;

                nome = txtNome.Text;
                altura = Convert.ToDouble(txtAltura.Text);

                CalculoPesoIdeal calcPeso = new CalculoPesoIdeal();
                

                if (cmbSexo.Text == "Feminino")
                {
                  
                    pesoIdeal = calcPeso.pesoFeminino(altura);   
                    
                    MessageBox.Show(nome + " seu peso ideal é: " + pesoIdeal.ToString(), "Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino	")
                {
                    pesoIdeal = calcPeso.pesoMasculino(altura);
                    MessageBox.Show(nome + " seu peso ideal é: " + pesoIdeal.ToString(), "Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Pesoa Ideal", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            
        }
    }
}
