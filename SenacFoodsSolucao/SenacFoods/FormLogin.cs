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
        {
            //oculta a tela de Login
            this.Hide();
            //criar uma instancia de FrmPrincipal
            var frmPrincipal = new FormPrincipal();
            //exibe a tela principal
            frmPrincipal.Show();
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
