using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Imobiliaria.Modelos;

namespace Imobiliaria.DAL
{
    public class ClientesDal
    {

        public string Mensagem { get; set; }
        MySqlConnection conCliente = new MySqlConnection();
        MySqlCommand cmdCliente = new MySqlCommand();

        public ClientesLista ListarClientes(string filtro)
        {
            try
            {
                ClientesLista objClientesLista = new ClientesLista();
                conCliente.ConnectionString = Dados.strConexao;

                cmdCliente.Connection = conCliente;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "ClientesSelecionar";
                cmdCliente.Parameters.AddWithValue("pfiltro", filtro);
                conCliente.Open();

                MySqlDataReader dr = cmdCliente.ExecuteReader();
                cmdCliente.Parameters.Clear();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClientesModelo cliente = new ClientesModelo();
                        cliente.CliId = Convert.ToInt32(dr["id_cliente"].ToString());
                        cliente.CliNome = dr["nome_cliente"].ToString();
                        cliente.CliCPF = dr["cpf"].ToString();
                        cliente.CliRG = dr["rg"].ToString();
                        cliente.CliEndereco = dr["endereco_completo"].ToString();
                        cliente.CliCEP = dr["cep"].ToString();
                        cliente.CliTelefone1 = dr["telefone1"].ToString();
                        cliente.CliTelefone2 = dr["telefone2"].ToString();
                        cliente.CliEmail = dr["email"].ToString();
                        cliente.CliDataNascimento = dr["dt_nascimento"].ToString();

                        objClientesLista.Add(cliente);
                    }
                }
                return objClientesLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conCliente.Close();
            }
        }

        public bool VerificarClienteExistente(ClientesModelo cliExists)
        {
            ClientesLista cliLista = new ClientesLista();
            cliLista = ListarClientes("");
            bool exist = false;

            cliExists = cliLista.Find(f => f.CliCPF == cliExists.CliCPF);
            if (cliExists != null)
            {
                exist = true;
            }

            return exist;
        }

        public string InserirCliente(ClientesModelo cliente)
        {
            try
            {
                if (VerificarClienteExistente(cliente))
                {
                    Mensagem = "Cliente já está cadastrado";
                }
                else
                {
                    conCliente.ConnectionString = Dados.strConexao;
                    cmdCliente.CommandType = CommandType.StoredProcedure;

                    cmdCliente.CommandText = "ClientesInserir";
                    cmdCliente.Parameters.AddWithValue("pclinome_cliente", cliente.CliNome);
                    cmdCliente.Parameters.AddWithValue("pclicpf", cliente.CliCPF);
                    cmdCliente.Parameters.AddWithValue("pclirg", cliente.CliRG);
                    cmdCliente.Parameters.AddWithValue("pcliendereco_completo", cliente.CliEndereco);
                    cmdCliente.Parameters.AddWithValue("pclicep", cliente.CliCEP);
                    cmdCliente.Parameters.AddWithValue("pclitelefone1", cliente.CliTelefone1);
                    cmdCliente.Parameters.AddWithValue("pclitelefone2", cliente.CliTelefone2);
                    cmdCliente.Parameters.AddWithValue("pcliemail", cliente.CliEmail);
                    cmdCliente.Parameters.AddWithValue("pclidt_nascimento", cliente.CliDataNascimento);


                    cmdCliente.Connection = conCliente;
                    conCliente.Open();
                    cliente.CliId = Convert.ToInt32(cmdCliente.ExecuteScalar());

                    Mensagem = "Cliente cadastrado com sucesso!";
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conCliente.Close();
            }
        }

        public void AlterarCliente(ClientesModelo cliente)
        {
            try
            {
                conCliente.ConnectionString = Dados.strConexao;
                cmdCliente.Connection = conCliente;
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.CommandText = "ClientesAlterar";
                cmdCliente.Parameters.AddWithValue("pcliid_cliente", cliente.CliId);
                cmdCliente.Parameters.AddWithValue("pclinome_cliente", cliente.CliNome);
                cmdCliente.Parameters.AddWithValue("pclicpf", cliente.CliCPF);
                cmdCliente.Parameters.AddWithValue("pclirg", cliente.CliRG);
                cmdCliente.Parameters.AddWithValue("pcliendereco_completo", cliente.CliEndereco);
                cmdCliente.Parameters.AddWithValue("pclicep", cliente.CliCEP); 
                cmdCliente.Parameters.AddWithValue("pclitelefone1", cliente.CliTelefone1);
                cmdCliente.Parameters.AddWithValue("pclitelefone2", cliente.CliTelefone2);
                cmdCliente.Parameters.AddWithValue("pcliemail", cliente.CliEmail);
                cmdCliente.Parameters.AddWithValue("pclidt_nascimento", cliente.CliDataNascimento);


                conCliente.Open();
                cmdCliente.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conCliente.Close();
            }
        }

        public bool ExcluirCliente(ClientesModelo cliente)
        {
            bool resposta = false;
            int resultado = 0;

            try
            {
                conCliente.ConnectionString = Dados.strConexao;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = conCliente;

                cmdCliente.CommandText = "ClientesExcluir";
                cmdCliente.Parameters.AddWithValue("pcliid_cliente", cliente.CliId);

                conCliente.Open();
                resultado = cmdCliente.ExecuteNonQuery();
                cmdCliente.Parameters.Clear();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente" + cliente.CliNome.ToString());
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conCliente.Close();
            }
        }

    }
}

