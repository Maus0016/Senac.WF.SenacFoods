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

        }

        private void BtnFecharUsuarioCad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
