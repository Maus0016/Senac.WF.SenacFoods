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
    public partial class FormMesaCad : Form
    {
        private Mesa _mesa;
        public FormMesaCad()
        {
            InitializeComponent();
        }

        public FormMesaCad(Mesa mesa)
        {
            _mesa = mesa;
            InitializeComponent();

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_mesa != null)
            {
                txtNumeroMesa.Text = _mesa.ToString();
            }
        }
        private void BtnFecharMesaCad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarMesa_Click(object sender, EventArgs e)
        {
            if (_mesa == null)
            {
                SalvarMesa();
            }
            else
            {
                AtualizarMesa();
            }
        }

        private void AtualizarMesa()
        {
            using (var bancoMesa = new ComandaDBContext())
            {
                int.TryParse(txtNumeroMesa.Text, out int numeroMesa);
                string titulo = txtNumeroMesa.Text;

                var mesa = bancoMesa.Mesas.First(M => M.Id == _mesa.Id);
                 bancoMesa.Mesas.Update(mesa);
                 bancoMesa.SaveChanges();
            }
            MessageBox.Show("Mesa atualizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void SalvarMesa()
        { 
            //Conectar
            using (var banco = new ComandaDBContext())
            {
                //Captar os dados da tela
                string NumeroMesa = txtNumeroMesa.Text;
               
                //Criar um novo carpadio
                var mesa = new Mesa()
                {
                    //Por ser numero inteiro, é necessário converter o texto para inteiro
                    NumeroMesa = int.Parse(NumeroMesa)

                };
                //adicionar o cardapio
                banco.Mesas.Add(mesa);
                banco.SaveChanges();
                //Salvar as alteraçoes no banco
                MessageBox.Show("Mesa salva com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }
        
        
        private void BtnCanselarMesa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
