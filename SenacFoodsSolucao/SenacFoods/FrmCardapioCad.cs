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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();

        }

        private void SalvarCardapio()
        {
            //Conectar
            using (var banco = new ComandaDBContext())
            {
                //Captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossiuPreparo.Checked;
                //Criar um novo carpadio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                //adicionar o cardapio
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
                //Salvar as alteraçoes no banco
            }
        }
    }
}