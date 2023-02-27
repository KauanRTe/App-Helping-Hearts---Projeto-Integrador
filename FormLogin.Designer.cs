
namespace App_Helping_Hearts___Projeto_Integrador
{
    partial class FormLogin
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
            this.txbL_Usuario = new System.Windows.Forms.TextBox();
            this.txbL_Senha = new System.Windows.Forms.TextBox();
            this.btnL_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_FormDoacao = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbL_Usuario
            // 
            this.txbL_Usuario.Location = new System.Drawing.Point(613, 172);
            this.txbL_Usuario.Name = "txbL_Usuario";
            this.txbL_Usuario.Size = new System.Drawing.Size(289, 20);
            this.txbL_Usuario.TabIndex = 0;
            // 
            // txbL_Senha
            // 
            this.txbL_Senha.Location = new System.Drawing.Point(613, 251);
            this.txbL_Senha.Name = "txbL_Senha";
            this.txbL_Senha.Size = new System.Drawing.Size(289, 20);
            this.txbL_Senha.TabIndex = 1;
            // 
            // btnL_Login
            // 
            this.btnL_Login.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL_Login.Location = new System.Drawing.Point(637, 317);
            this.btnL_Login.Name = "btnL_Login";
            this.btnL_Login.Size = new System.Drawing.Size(100, 28);
            this.btnL_Login.TabIndex = 2;
            this.btnL_Login.Text = "Login";
            this.btnL_Login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::App_Helping_Hearts___Projeto_Integrador.Properties.Resources.heart_3147976_1280;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(43, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 387);
            this.panel1.TabIndex = 5;
            // 
            // btn_FormDoacao
            // 
            this.btn_FormDoacao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FormDoacao.Location = new System.Drawing.Point(840, 530);
            this.btn_FormDoacao.Name = "btn_FormDoacao";
            this.btn_FormDoacao.Size = new System.Drawing.Size(100, 28);
            this.btn_FormDoacao.TabIndex = 17;
            this.btn_FormDoacao.Text = "Doacao";
            this.btn_FormDoacao.UseVisualStyleBackColor = true;
            this.btn_FormDoacao.Click += new System.EventHandler(this.btn_FormDoacao_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(782, 317);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(100, 28);
            this.btnCadastro.TabIndex = 18;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btn_FormDoacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnL_Login);
            this.Controls.Add(this.txbL_Senha);
            this.Controls.Add(this.txbL_Usuario);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbL_Usuario;
        private System.Windows.Forms.TextBox txbL_Senha;
        private System.Windows.Forms.Button btnL_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_FormDoacao;
        private System.Windows.Forms.Button btnCadastro;
    }
}

