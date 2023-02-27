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
    public partial class FormLogin : Form
    {
        private SqlConnection conexao = new SqlConnection("Data Source=OSA0625222W10-1;Initial Catalog=HelpingHearts;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader dr;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_FormDoacao_Click(object sender, EventArgs e)
        {
            FormDoacao FormDoacao = new FormDoacao();
            FormDoacao.Show();
        }
    }
}
