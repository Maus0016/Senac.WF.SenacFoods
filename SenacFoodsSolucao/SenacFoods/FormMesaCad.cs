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
        private FormMesaCad _mesaCad;
        public FormMesaCad()
        {
            InitializeComponent();
        }

        public FormMesaCad(MesaCad mesaCad)
        {
            _mesaCad = mesaCad;
            InitializeComponent();

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_mesaCad != null)
            {
                txtTitulo.Text = _mesaCad.ToString();
            }
        }
        private void BtnFecharMesaCad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarMesa_Click(object sender, EventArgs e)
        {
            if (_mesaCad == null)
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
                string titulo = txtTitulo.Text;

                var MesaCad = bancoMesa.Mesas.First(M => M.Id == _mesaCad.Id);

                bancoMesa.Mesas)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            using (var bancodb = new ComandaDBContext())
            {
                string titulo = txtTitulo.Text;

                var Mesa = new MesaCad()
                {
                    titulo = MesaCad.Update()
                };
            }
        }

        private void BtnCanselarMesa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}