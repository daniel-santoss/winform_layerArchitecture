using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessaBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@NomeCliente", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return idCliente;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();

                return idCliente;
            } 

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ClienteColecao ConsultarPorNome(string nome)
        {
            try
            {
                 ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                // Variável da procedure, parâmetro do método
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                // Tipo de comando, nome da procedure ou texto, comando SQL
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                // Percorrer o DataTable e tranformar em coleção de clientes

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }

        public ClienteColecao ConsultarPorId(int idCliente)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                // Variável da procedure, parâmetro do método
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", idCliente);
                // Tipo de comando, nome da procedure ou texto, comando SQL
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                // Percorrer o DataTable e tranformar em coleção de clientes

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por ID. Detalhes: " + ex.Message);
            }
        }
    }
}
