using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FormUsuario : Form
    {
        Usuario? UsuarioSelecionado;
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void BuscarUsuario()
        {
            // Conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar tabela cardapio SELECT * FROM CARDAPIO
                var Usuario = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(TxtPesquisaDeUsuario.Text))
                {
                    Usuario = Usuario.Where(U => U.Nome
                    .Contains(TxtPesquisaDeUsuario.Text) || U.Email
                    .Contains(TxtPesquisaDeUsuario.Text) || U.Senha
                    .Contains(TxtPesquisaDeUsuario.Text));

                }
                // popular o frid com a tabela consultada
                dataGridView1.DataSource = Usuario.ToList();

            }
        }


        private void UsuarioFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            new FormUsuarioCad().ShowDialog();
            BuscarUsuario();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Usuarios.Remove(UsuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Usuario excluido com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuario();
                UsuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um usuario para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPesquisaDeUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                BtnEditar.Enabled = true;


            }
        }

        private void btnEditarIUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                //abrir o formulario de edição
                var User = new FormUsuarioCad(UsuarioSelecionado);
                User.ShowDialog();
                //Atualizar a lista de cardapios
                BuscarUsuario();
                UsuarioSelecionado = null;
            }
        }
    }
}
        

    


