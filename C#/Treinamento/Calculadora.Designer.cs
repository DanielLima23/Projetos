
namespace Treinamento
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelvalor1 = new System.Windows.Forms.Label();
            this.labelvalor2 = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnsomar = new System.Windows.Forms.Button();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Simples";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelvalor1
            // 
            this.labelvalor1.AutoSize = true;
            this.labelvalor1.Location = new System.Drawing.Point(14, 115);
            this.labelvalor1.Name = "labelvalor1";
            this.labelvalor1.Size = new System.Drawing.Size(51, 13);
            this.labelvalor1.TabIndex = 1;
            this.labelvalor1.Text = "Valor 1:";
            this.labelvalor1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelvalor2
            // 
            this.labelvalor2.AutoSize = true;
            this.labelvalor2.Location = new System.Drawing.Point(14, 150);
            this.labelvalor2.Name = "labelvalor2";
            this.labelvalor2.Size = new System.Drawing.Size(51, 13);
            this.labelvalor2.TabIndex = 2;
            this.labelvalor2.Text = "Valor 2:";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(14, 186);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(40, 13);
            this.labeltotal.TabIndex = 3;
            this.labeltotal.Text = "Total:";
            this.labeltotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(71, 112);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(55, 20);
            this.txtvalor1.TabIndex = 4;
            this.txtvalor1.TextChanged += new System.EventHandler(this.txtvalor1_TextChanged);
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(71, 147);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(55, 20);
            this.txtvalor2.TabIndex = 5;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(71, 183);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(55, 20);
            this.txttotal.TabIndex = 6;
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(17, 257);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(65, 20);
            this.btnsomar.TabIndex = 7;
            this.btnsomar.Text = "SOMAR";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.Location = new System.Drawing.Point(90, 257);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(85, 20);
            this.btnsubtrair.TabIndex = 8;
            this.btnsubtrair.Text = "SUBTRAIR";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(182, 257);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(100, 20);
            this.btnmultiplicar.TabIndex = 9;
            this.btnmultiplicar.Text = "MULTIPLICAR";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(289, 257);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(85, 20);
            this.btndividir.TabIndex = 10;
            this.btndividir.Text = "DIVIDIR";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(124, 283);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(129, 35);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 346);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labelvalor2);
            this.Controls.Add(this.labelvalor1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelvalor1;
        private System.Windows.Forms.Label labelvalor2;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnsair;
    }
}

