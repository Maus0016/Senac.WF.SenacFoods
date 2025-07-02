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
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            // Conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar tabela cardapio SELECT * FROM CARDAPIO
                var cardapios = bd.CardapioItems.AsQueryable();
                if(!string.IsNullOrEmpty(TxtPesquisa.Text) )
                {
                    cardapios = cardapios.Where(c=> c.Titulo.Contains(TxtPesquisa.Text) || c.Descricao.Contains(TxtPesquisa.Text));

                }
                // popular o frid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void btnEditar(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CardapioFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Chamar o metodo buscar Cardapio
            BuscarCardapio();
        }
    }
}