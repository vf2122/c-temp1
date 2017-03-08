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
    public partial class FrmCadastrarCliente : Form
    {
        AcaoNaTela acaoNaTela;

        public FrmCadastrarCliente(Cliente cliente, AcaoNaTela acao)
        {
            InitializeComponent();
            acaoNaTela = acao;

            if (acao.Equals(AcaoNaTela.Alterar))
            {
                textBoxIdCliente.Text = cliente.idCliente.ToString();
                textBoxNome.Text = cliente.nome;
                dateDataNascimento.Value = cliente.dataNascimento;

                if (cliente.sexo == true) //true = masculino || false = feminino
                    radioMasculino.Checked = true;
                else
                    radioFeminino.Checked = true;

                textBoxLimiteCompra.Text = cliente.limiteCompra.ToString();
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            if (acaoNaTela == AcaoNaTela.Alterar)
            {

                this.Text = "Alterar";

                Cliente cliente = new Cliente();

                cliente.idCliente = Convert.ToInt32(textBoxIdCliente.Text);
                cliente.nome = textBoxNome.Text;
                cliente.dataNascimento = dateDataNascimento.Value;

                if (radioFeminino.Checked == true)
                    cliente.sexo = false; //feminino
                else
                    cliente.sexo = true; //masculino

                cliente.limiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Alterar(cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso. Codigo: " + retorno);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar. Erro: " + retorno);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTela == AcaoNaTela.Inserir)
            {

                this.Text = "Inserir";

                Cliente cliente = new Cliente();

                cliente.nome = textBoxNome.Text;
                cliente.dataNascimento = dateDataNascimento.Value;

                if (radioFeminino.Checked == true)
                    cliente.sexo = false; //feminino
                else
                    cliente.sexo = true; //masculino

                cliente.limiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Inserir(cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso. Codigo: " + retorno);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel Inserir. Erro: " + retorno);
                    this.DialogResult = DialogResult.No;
                }
            }

        
        }

    }
}
