namespace SenacFoods
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {   // true, false
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            // SE TRUE
            if (loginValido == true)
            {
                //oculta a tela de Login
                this.Hide();
                //criar uma instancia de FrmPrincipal
                var frmPrincipal = new FormPrincipal(txtLogin.Text, txtSenha.Text);
                //exibe a tela principal
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            if(nome == "admin" && senha == "123")
            {// Retorna Verdadeiro
                return true;
            }
            else
            {// Exibe uma mensagem de erro
                MessageBox.Show("Login ou Senha inválidos");
            }//Retorna falso
                //verifica se o nome e a senha são verdadeiros
                return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a tela de Login
            Close();
            // encerra o aplicativo
            Application.Exit();

        }
    }
}
