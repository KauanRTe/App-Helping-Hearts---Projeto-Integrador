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
    public partial class BD_Doacoes : Form
    {
        private SqlConnection conexao = new SqlConnection("Data Source=OSA0625222W10-1;Initial Catalog=HelpingHearts;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader dr;
        public BD_Doacoes()
        {
            InitializeComponent();
        }

        private void CarregarLista()
        {
            conexao.Open();
            comando.CommandText = "select * from Doacoes";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lbD_UsuarioID.Items.Add(dr[0].ToString());
                    lbD_DataDoacao.Items.Add(dr[1].ToString());
                    lbD_Tipo.Items.Add(dr[2].ToString());
                    lbD_Entrega.Items.Add(dr[3].ToString());
                }
            }
            conexao.Close();
        }

        private void Alinhar(object sender)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lbD_UsuarioID.SelectedIndex = l.SelectedIndex;
                lbD_DataDoacao.SelectedIndex = l.SelectedIndex;
                lbD_Tipo.SelectedIndex = l.SelectedIndex;
                lbD_Entrega.SelectedIndex = l.SelectedIndex;
            }
        }
        private void BD_Doacoes_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            CarregarLista();
        }

        private void lbD_UsuarioID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbD_DataDoacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbD_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbD_Entrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }
    }
}
