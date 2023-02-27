
namespace App_Helping_Hearts___Projeto_Integrador
{
    partial class BD_Doacoes
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbD_Tipo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbD_DataDoacao = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbD_UsuarioID = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbD_Entrega = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(515, 434);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 27);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(625, 434);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 27);
            this.btnRemover.TabIndex = 32;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(410, 434);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 27);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipo da Doação";
            // 
            // lbD_Tipo
            // 
            this.lbD_Tipo.FormattingEnabled = true;
            this.lbD_Tipo.Location = new System.Drawing.Point(605, 63);
            this.lbD_Tipo.Name = "lbD_Tipo";
            this.lbD_Tipo.Size = new System.Drawing.Size(150, 277);
            this.lbD_Tipo.TabIndex = 29;
            this.lbD_Tipo.SelectedIndexChanged += new System.EventHandler(this.lbD_Tipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Data da Doação";
            // 
            // lbD_DataDoacao
            // 
            this.lbD_DataDoacao.FormattingEnabled = true;
            this.lbD_DataDoacao.Location = new System.Drawing.Point(398, 63);
            this.lbD_DataDoacao.Name = "lbD_DataDoacao";
            this.lbD_DataDoacao.Size = new System.Drawing.Size(150, 277);
            this.lbD_DataDoacao.TabIndex = 27;
            this.lbD_DataDoacao.SelectedIndexChanged += new System.EventHandler(this.lbD_DataDoacao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID do Doador";
            // 
            // lbD_UsuarioID
            // 
            this.lbD_UsuarioID.FormattingEnabled = true;
            this.lbD_UsuarioID.Location = new System.Drawing.Point(208, 63);
            this.lbD_UsuarioID.Name = "lbD_UsuarioID";
            this.lbD_UsuarioID.Size = new System.Drawing.Size(132, 277);
            this.lbD_UsuarioID.TabIndex = 25;
            this.lbD_UsuarioID.SelectedIndexChanged += new System.EventHandler(this.lbD_UsuarioID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Entrega";
            // 
            // lbD_Entrega
            // 
            this.lbD_Entrega.FormattingEnabled = true;
            this.lbD_Entrega.Location = new System.Drawing.Point(796, 63);
            this.lbD_Entrega.Name = "lbD_Entrega";
            this.lbD_Entrega.Size = new System.Drawing.Size(150, 277);
            this.lbD_Entrega.TabIndex = 34;
            this.lbD_Entrega.SelectedIndexChanged += new System.EventHandler(this.lbD_Entrega_SelectedIndexChanged);
            // 
            // BD_Doacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1119, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbD_Entrega);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbD_Tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbD_DataDoacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbD_UsuarioID);
            this.Name = "BD_Doacoes";
            this.Text = "BD_Doacoes";
            this.Load += new System.EventHandler(this.BD_Doacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbD_Tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbD_DataDoacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbD_UsuarioID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbD_Entrega;
    }
}