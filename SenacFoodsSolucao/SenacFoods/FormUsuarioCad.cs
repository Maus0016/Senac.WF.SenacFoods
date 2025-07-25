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
    public partial class FormUsuarioCad : Form
    {
        private Usuario? _usuario;
        public FormUsuarioCad()
        {
            InitializeComponent();
        }
        public FormUsuarioCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            // Carregar dados do usuário na tela
            CarregarDadosDoUsuario();
        }

        private void CarregarDadosDoUsuario()
        {
            if (_usuario != null)
            {
                txtNomeDoUsuario.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
                txtSenhaDoUsuario.Text = _usuario.Senha;
                txtConfirmarSenha.Text = _usuario.Senha;
            }
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                InserirUsuario();

            }
            //Atualizar
            else
            {
               AtualizarUsuaruio();
            }
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                //Captar os dados da tela
                string nome = txtNomeDoUsuario.Text;
                string email = txtEmail.Text;
                string senha = txtSenhaDoUsuario.Text;
                string confirmarsenha = txtConfirmarSenha.Text;

                var user = new Usuario()
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha
                };
                //adicionar o cardapio
                banco.Usuarios.Add(user);
                banco.SaveChanges();
                //Salvar as alteraçoes no banco
                MessageBox.Show("Usuario salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void AtualizarUsuaruio()
        {
            using (var banco = new ComandaDBContext())
            {
                
                string nome = txtNomeDoUsuario.Text;
                string email = txtEmail.Text;
                string senha = txtSenhaDoUsuario.Text;
                string confirmar = txtConfirmarSenha.Text;
                //Atualizar o cardapio
                var user = banco.Usuarios.First(x => x.Id == _usuario.Id);
                user.Nome = nome;
                user.Email = email;
                user.Senha = senha;
               
                //Salvar todas as alteraçoes
                banco.Usuarios.Update(user);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuario salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnFecharUsuarioCad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
