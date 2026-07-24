using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();

            // Não gerar colunas automaticamente
            dataGridViewPrincipal.AutoGenerateColumns = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClienteSelecionar_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            ClienteColecao clienteColecao = new ClienteColecao();

            clienteColecao = clienteNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = clienteColecao;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou algum cliente
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Pergunta ao usuário se ele tem certeza que deseja excluir o registro
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            ClienteNegocios clienteNegocios = new ClienteNegocios();
            string retorno = clienteNegocios.Excluir(clienteSelecionado);

            // Verifica se houve erro na exclusão
            try
            {

            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
