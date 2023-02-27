
namespace App_Helping_Hearts___Projeto_Integrador
{
    partial class FormCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnC_Salvar = new System.Windows.Forms.Button();
            this.txbC_Senha = new System.Windows.Forms.TextBox();
            this.txbC_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbC_Telefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbC_Endereço = new System.Windows.Forms.TextBox();
            this.rbC_Receber = new System.Windows.Forms.RadioButton();
            this.rbC_Realizar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnC_Salvar
            // 
            this.btnC_Salvar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_Salvar.Location = new System.Drawing.Point(714, 372);
            this.btnC_Salvar.Name = "btnC_Salvar";
            this.btnC_Salvar.Size = new System.Drawing.Size(100, 28);
            this.btnC_Salvar.TabIndex = 7;
            this.btnC_Salvar.Text = "Salvar";
            this.btnC_Salvar.UseVisualStyleBackColor = true;
            // 
            // txbC_Senha
            // 
            this.txbC_Senha.Location = new System.Drawing.Point(629, 131);
            this.txbC_Senha.Name = "txbC_Senha";
            this.txbC_Senha.Size = new System.Drawing.Size(289, 20);
            this.txbC_Senha.TabIndex = 6;
            // 
            // txbC_Nome
            // 
            this.txbC_Nome.Location = new System.Drawing.Point(629, 70);
            this.txbC_Nome.Name = "txbC_Nome";
            this.txbC_Nome.Size = new System.Drawing.Size(289, 20);
            this.txbC_Nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // txbC_Telefone
            // 
            this.txbC_Telefone.Location = new System.Drawing.Point(629, 191);
            this.txbC_Telefone.Name = "txbC_Telefone";
            this.txbC_Telefone.Size = new System.Drawing.Size(289, 20);
            this.txbC_Telefone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Endereço";
            // 
            // txbC_Endereço
            // 
            this.txbC_Endereço.Location = new System.Drawing.Point(629, 255);
            this.txbC_Endereço.Name = "txbC_Endereço";
            this.txbC_Endereço.Size = new System.Drawing.Size(289, 20);
            this.txbC_Endereço.TabIndex = 12;
            // 
            // rbC_Receber
            // 
            this.rbC_Receber.AutoSize = true;
            this.rbC_Receber.Location = new System.Drawing.Point(629, 302);
            this.rbC_Receber.Name = "rbC_Receber";
            this.rbC_Receber.Size = new System.Drawing.Size(112, 17);
            this.rbC_Receber.TabIndex = 14;
            this.rbC_Receber.TabStop = true;
            this.rbC_Receber.Text = "Receber Doações";
            this.rbC_Receber.UseVisualStyleBackColor = true;
            // 
            // rbC_Realizar
            // 
            this.rbC_Realizar.AutoSize = true;
            this.rbC_Realizar.Location = new System.Drawing.Point(629, 325);
            this.rbC_Realizar.Name = "rbC_Realizar";
            this.rbC_Realizar.Size = new System.Drawing.Size(109, 17);
            this.rbC_Realizar.TabIndex = 15;
            this.rbC_Realizar.TabStop = true;
            this.rbC_Realizar.Text = "Realizar Doações";
            this.rbC_Realizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::App_Helping_Hearts___Projeto_Integrador.Properties.Resources.heart_3147976_1280;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(62, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 387);
            this.panel1.TabIndex = 6;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.rbC_Realizar);
            this.Controls.Add(this.rbC_Receber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbC_Endereço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbC_Telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbC_Nome);
            this.Controls.Add(this.btnC_Salvar);
            this.Controls.Add(this.txbC_Senha);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnC_Salvar;
        private System.Windows.Forms.TextBox txbC_Senha;
        private System.Windows.Forms.TextBox txbC_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbC_Telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbC_Endereço;
        private System.Windows.Forms.RadioButton rbC_Receber;
        private System.Windows.Forms.RadioButton rbC_Realizar;
    }
}