
namespace CalculadoraWindowsForms
{
    partial class Form1
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
            this.oito = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.somar = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oito
            // 
            this.oito.Location = new System.Drawing.Point(51, 67);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(30, 30);
            this.oito.TabIndex = 1;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(87, 67);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(30, 30);
            this.nove.TabIndex = 2;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.button3_Click);
            // 
            // quatro
            // 
            this.quatro.Location = new System.Drawing.Point(15, 103);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(30, 30);
            this.quatro.TabIndex = 3;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(51, 103);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(30, 30);
            this.cinco.TabIndex = 4;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(87, 103);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(30, 30);
            this.seis.TabIndex = 5;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(15, 139);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(30, 30);
            this.um.TabIndex = 6;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // dois
            // 
            this.dois.Location = new System.Drawing.Point(51, 139);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(30, 30);
            this.dois.TabIndex = 7;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(87, 139);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(30, 30);
            this.tres.TabIndex = 8;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(15, 175);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(102, 30);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // sete
            // 
            this.sete.Location = new System.Drawing.Point(15, 67);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(30, 30);
            this.sete.TabIndex = 10;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // tela
            // 
            this.tela.AutoSize = true;
            this.tela.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tela.Location = new System.Drawing.Point(12, 9);
            this.tela.MinimumSize = new System.Drawing.Size(176, 40);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(176, 40);
            this.tela.TabIndex = 11;
            this.tela.Click += new System.EventHandler(this.label1_Click);
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(123, 67);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(30, 30);
            this.somar.TabIndex = 12;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(123, 103);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(30, 30);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(123, 139);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(30, 30);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(123, 175);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(30, 30);
            this.mult.TabIndex = 15;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(160, 139);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(30, 66);
            this.result.TabIndex = 16;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(15, 211);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(173, 30);
            this.apagar.TabIndex = 19;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 253);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.MaximumSize = new System.Drawing.Size(230, 300);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button apagar;
    }
}

