
namespace App_Helping_Hearts___Projeto_Integrador
{
    partial class FormDoacao
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
            this.btnD_Salvar = new System.Windows.Forms.Button();
            this.txbD_Tipo = new System.Windows.Forms.TextBox();
            this.txbD_Data = new System.Windows.Forms.TextBox();
            this.rbD_Ir = new System.Windows.Forms.RadioButton();
            this.rbD_Vir = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbD_UsuarioID = new System.Windows.Forms.TextBox();
            this.btnD_BDDoacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Doação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data de Entrega/Retirada";
            // 
            // btnD_Salvar
            // 
            this.btnD_Salvar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD_Salvar.Location = new System.Drawing.Point(683, 339);
            this.btnD_Salvar.Name = "btnD_Salvar";
            this.btnD_Salvar.Size = new System.Drawing.Size(100, 28);
            this.btnD_Salvar.TabIndex = 7;
            this.btnD_Salvar.Text = "Salvar";
            this.btnD_Salvar.UseVisualStyleBackColor = true;
            this.btnD_Salvar.Click += new System.EventHandler(this.btnD_Salvar_Click);
            // 
            // txbD_Tipo
            // 
            this.txbD_Tipo.Location = new System.Drawing.Point(594, 220);
            this.txbD_Tipo.Name = "txbD_Tipo";
            this.txbD_Tipo.Size = new System.Drawing.Size(289, 20);
            this.txbD_Tipo.TabIndex = 6;
            // 
            // txbD_Data
            // 
            this.txbD_Data.Location = new System.Drawing.Point(594, 141);
            this.txbD_Data.Name = "txbD_Data";
            this.txbD_Data.Size = new System.Drawing.Size(289, 20);
            this.txbD_Data.TabIndex = 5;
            // 
            // rbD_Ir
            // 
            this.rbD_Ir.AutoSize = true;
            this.rbD_Ir.Location = new System.Drawing.Point(594, 255);
            this.rbD_Ir.Name = "rbD_Ir";
            this.rbD_Ir.Size = new System.Drawing.Size(117, 17);
            this.rbD_Ir.TabIndex = 10;
            this.rbD_Ir.TabStop = true;
            this.rbD_Ir.Text = "Irei até a ONG doar";
            this.rbD_Ir.UseVisualStyleBackColor = true;
            // 
            // rbD_Vir
            // 
            this.rbD_Vir.AutoSize = true;
            this.rbD_Vir.Location = new System.Drawing.Point(594, 278);
            this.rbD_Vir.Name = "rbD_Vir";
            this.rbD_Vir.Size = new System.Drawing.Size(155, 17);
            this.rbD_Vir.TabIndex = 11;
            this.rbD_Vir.TabStop = true;
            this.rbD_Vir.Text = "Desejo que venham buscar";
            this.rbD_Vir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::App_Helping_Hearts___Projeto_Integrador.Properties.Resources.heart_3147976_1280;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(39, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 387);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seu ID";
            // 
            // txbD_UsuarioID
            // 
            this.txbD_UsuarioID.Location = new System.Drawing.Point(594, 75);
            this.txbD_UsuarioID.Name = "txbD_UsuarioID";
            this.txbD_UsuarioID.Size = new System.Drawing.Size(289, 20);
            this.txbD_UsuarioID.TabIndex = 12;
            this.txbD_UsuarioID.TextChanged += new System.EventHandler(this.txbD_UsuarioID_TextChanged);
            // 
            // btnD_BDDoacoes
            // 
            this.btnD_BDDoacoes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD_BDDoacoes.Location = new System.Drawing.Point(622, 534);
            this.btnD_BDDoacoes.Name = "btnD_BDDoacoes";
            this.btnD_BDDoacoes.Size = new System.Drawing.Size(344, 28);
            this.btnD_BDDoacoes.TabIndex = 14;
            this.btnD_BDDoacoes.Text = "Banco de Dados: Doacoes";
            this.btnD_BDDoacoes.UseVisualStyleBackColor = true;
            this.btnD_BDDoacoes.Click += new System.EventHandler(this.btnD_BDDoacoes_Click);
            // 
            // FormDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.btnD_BDDoacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbD_UsuarioID);
            this.Controls.Add(this.rbD_Vir);
            this.Controls.Add(this.rbD_Ir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbD_Data);
            this.Controls.Add(this.btnD_Salvar);
            this.Controls.Add(this.txbD_Tipo);
            this.Name = "FormDoacao";
            this.Text = "FormDoacao";
            this.Load += new System.EventHandler(this.FormDoacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnD_Salvar;
        private System.Windows.Forms.TextBox txbD_Tipo;
        private System.Windows.Forms.TextBox txbD_Data;
        private System.Windows.Forms.RadioButton rbD_Ir;
        private System.Windows.Forms.RadioButton rbD_Vir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbD_UsuarioID;
        private System.Windows.Forms.Button btnD_BDDoacoes;
    }
}