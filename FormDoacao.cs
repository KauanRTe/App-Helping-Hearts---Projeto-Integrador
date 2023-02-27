using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Helping_Hearts___Projeto_Integrador
{
    public partial class FormDoacao : Form
    {
        private SqlConnection conexao = new SqlConnection("Data Source=OSA0625222W10-1;Initial Catalog=HelpingHearts;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader dr;
        public FormDoacao()
        {
            InitializeComponent();
        }

        private void txbD_UsuarioID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnD_Salvar_Click(object sender, EventArgs e)
        {
           conexao.Open();
           comando.CommandText = "insert into Doacoes(UsuarioID, DataDoacao, TipoDoacao, Entrega) values ('" + txbD_UsuarioID.Text + "','" + txbD_Data.Text + "','" + txbD_Tipo.Text + "','" + rbD_Ir.Text + "')";
           comando.ExecuteNonQuery();
           conexao.Close();
        }

        private void btnD_BDDoacoes_Click(object sender, EventArgs e)
        {
            BD_Doacoes BD_Doacoes = new BD_Doacoes();
            BD_Doacoes.Show();
        }

        private void FormDoacao_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;

        }
    }
}
