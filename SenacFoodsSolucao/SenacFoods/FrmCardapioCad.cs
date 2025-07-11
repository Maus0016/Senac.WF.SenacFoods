using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        private CardapioItem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            _cardapioItem = cardapioItem;
            InitializeComponent();

            //carregar dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos de texto e checkbox
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossiuPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if( _cardapioItem == null) 
            {
                InserirCardapio();
            
            }
            //Atualizar
            else
            {
                AtualizarCardapio();
            }
                

        }

        private void AtualizarCardapio()
        {
            using(var banco = new ComandaDBContext())
            {
                //Captar aos dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossiuPreparo.Checked;
                //Atualizar o cardapio
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem .Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;
                //Salvar todas as alteraçoes
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();
            }
        }

        private void InserirCardapio()
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
                MessageBox.Show("Cardapio salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}