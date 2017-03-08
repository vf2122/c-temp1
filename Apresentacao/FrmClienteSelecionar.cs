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
            //desligar auto gerar colunas para serem criadas manualmente
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }


        private void atualizarGrid()
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
            this.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }
            
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover este Cliente?", "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if ( resultado == DialogResult.No )
            {
                return;
            }


            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            ClienteNegocios clienteNegocios = new ClienteNegocios();
            string retorno = clienteNegocios.Excluir(clienteSelecionado);


            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente excluido com sucesso", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(null, AcaoNaTela.Inserir);
            DialogResult resultado = frmCadastrarCliente.ShowDialog();

            if (resultado == DialogResult.Yes)
                atualizarGrid();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha foi selecionada", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cliente cliente = new Cliente();
            cliente = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(cliente, AcaoNaTela.Alterar);
            DialogResult resultado = frmCadastrarCliente.ShowDialog();

            if (resultado == DialogResult.Yes)
                atualizarGrid();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(null, AcaoNaTela.Consultar);
            frmCadastrarCliente.ShowDialog();
        }

    }
}
