using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //Instanciar = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        public string Inserir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.limiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.limiteCompra);
                string id = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.idCliente);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();

                return idCliente;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        public ClienteColecao ConsultarPorNome(string nome)
        {
            try
            {
                //instanciar nova coleção de clientes (aqui está vazia)
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                
                //metodo ExecultarConsulta retorna um objeto tipo DataTable
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                //cada linha do DataTable é um cliente
                //Data=Dados e Row=Linha

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar um cliente vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleção

                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.limiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }

                return clienteColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }


        public ClienteColecao ConsultarPorId(int idCliente)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", idCliente);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.nome = Convert.ToString(linha["Nome"]);
                    cliente.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.limiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }

    }
}
