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
    public partial class FormMesa : Form
    {
        Mesa? mesaSelecionada;
        public FormMesa()
        {
            InitializeComponent();
        }

        private void CardapioFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaMesa_Click(object sender, EventArgs e)
        {
            new FormMesaCad().ShowDialog();
            BuscarMesa();
        }
        private void FormMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var Mesas = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    Mesas = Mesas
                        .Where(m => m.NumeroMesa == int.Parse(TxtPesquisa.Text));
                }
                dataGridView1.DataSource = Mesas.ToList();
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BtnExcluirMesa_Click(object sender, EventArgs e)
        {
            if (mesaSelecionada != null)
            {
                using (var bancoDeDado = new ComandaDBContext())
                {
                    bancoDeDado.Mesas.Remove(mesaSelecionada);
                    bancoDeDado.SaveChanges();
                }
                MessageBox.Show("Mesa excluida com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                mesaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione uma mesa para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEditarMesa_Click(object sender, EventArgs e)
        {
            if (mesaSelecionada != null)
            {
                var messs = new FormMesaCad(mesaSelecionada);
                messs.ShowDialog();
                BuscarMesa();
                mesaSelecionada = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mesaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btEditarMesa.Enabled = true;
            }
        }
    }
}