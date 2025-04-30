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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fecha a tela Principal
            Close();
            // cria uma instancia da tela de Login
            var frmLogin = new FormLogin();
            //exibe a tela de login
            frmLogin.Show();


        }

        private void btnCarpadio_Click(object sender, EventArgs e)
        {
            //cria uma instancia do FormCardapio
            var frmCardapio = new FormCardapio();
            // exibe a tela de cardapio em estilo modal()
            frmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //altera o estado da tela
            //para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FormComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FormPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FormUsuario();
            frmUsuarios.ShowDialog();
        }
    }
}
