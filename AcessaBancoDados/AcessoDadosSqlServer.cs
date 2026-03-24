using Microsoft.Data.SqlClient;
using System.Data;


namespace AcessaBancoDados
{
    public class AcessoDadosSqlServer
    {
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings1.Default.stringConexao);
        }

        private SqlParameterCollection sqlParameterCollecion = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollecion.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollecion.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        // CommandType é ENUM -> Conjunto de opções que não mudam. Ex: Dias da semana, meses do ano, etc..
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                // Comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                // Colocando os parâmetros dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;

                // Tempo máximo para o comando ser executado em segundos
                sqlCommand.CommandTimeout = 7200;

                // Adiconar os parâmetros do comando
                foreach (SqlParameter sqlParameter in sqlParameterCollecion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Manda o comnado para o banco de dados e retorna o resultado
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                // Comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                // Colocando os parâmetros dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;

                // Tempo máximo para o comando ser executado em segundos
                sqlCommand.CommandTimeout = 7200;

                // Adiconar os parâmetros do comando
                foreach (SqlParameter sqlParameter in sqlParameterCollecion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Montando adapter para preencher o DataTable
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Manda o comando ir até o banco, busca os dados e preenche o DataTable
                DataTable dataTable = new DataTable();
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
