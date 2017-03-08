using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace's que contem as classes que manipulam dados
using System.Data;
using System.Data.SqlClient; //Classes para trabalhar com Sql Server
using AcessoBancoDados.Properties; //importar a String de conexão

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar a conexão
        private SqlConnection CriarConexao() //retorna um SqlConnection
        {
            return new SqlConnection(Settings.Default.stringConexao); //dentro vai a string de conexão
        }


        //Parâmetros que vão para banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;


        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }


        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }


        //Persistência - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlcommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlcommand.CommandTimeout = 7200; //segs

                //adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Execultar o comando, ou seja, mandar o comando ir até o banco e voltar
                return sqlcommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
            

        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //segs

                //adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }


                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = Tabela de dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
   
    }
}
