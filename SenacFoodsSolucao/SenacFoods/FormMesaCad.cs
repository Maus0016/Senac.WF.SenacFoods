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
        private MesaCad _mesa;
        public FormMesaCad()
        {
            InitializeComponent();
        }

        public FormMesaCad(MesaCad _mesaCad)
        {
            _mesaCad = mesa;
            InitializeComponent();

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_mesa != null)
            {
                txtTitulo.Text = _mesa.ToString();
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
                int.TryParse(txtTitulo.Text, out int numeroMesa);
                string titulo = txtTitulo.Text;

                var MesaCad = bancoMesa.Mesas.First(M => M.Id == _mesa.Id);
                titulo.mesaCad = numeroMesa;

                    bancoMesa.Mesas.Update(MesaCad);
                bancoMesa.SaveChanges();
            }
            MessageBox.Show("Mesa atualizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void SalvarMesa()
        {

        }

        private void BtnCanselarMesa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
