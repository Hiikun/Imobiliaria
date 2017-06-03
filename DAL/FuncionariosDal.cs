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
   public class FuncionariosDal
    {

        public string Mensagem { get; set; }

        MySqlConnection conFuncionario = new MySqlConnection();
        MySqlCommand cmdFuncionario = new MySqlCommand();

        public FuncionariosLista Listagem(string filtro)
        {
            try
            {
                FuncionariosLista objListaFuncionarios = new FuncionariosLista();
                conFuncionario.ConnectionString = Dados.strConexao;
                cmdFuncionario.Connection = conFuncionario;
                cmdFuncionario.CommandType = CommandType.StoredProcedure;
                cmdFuncionario.CommandText = "FuncionarioSelecionar";
                cmdFuncionario.Parameters.AddWithValue("pfiltro", filtro);
                conFuncionario.Open();
                MySqlDataReader dr = cmdFuncionario.ExecuteReader();
                cmdFuncionario.Parameters.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionariosModelo funcionario = new FuncionariosModelo();
                        funcionario.FunId = Convert.ToInt32(dr["funid"].ToString());
                        funcionario.FunLogin = dr["funlogin"].ToString();
                        funcionario.FunNome = dr["funnome"].ToString();
                        funcionario.FunTipo = dr["funtipo"].ToString();
                        funcionario.FunSenha = dr["funsenha"].ToString();

                        objListaFuncionarios.Add(funcionario);
                    }
                }
                return objListaFuncionarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conFuncionario.Close();
            }
        }

        public bool VerificarFuncionarioExistente(FuncionariosModelo funExist)
        {
            string filtro = "";
            FuncionariosLista listaFun = new FuncionariosLista();
            bool verifica = false;
            listaFun = Listagem(filtro);

            funExist = listaFun.Find(f => f.FunNome == funExist.FunNome);
            if (funExist != null)
            {
                verifica = true;
            }
            return verifica;
        }

        public bool Login(FuncionariosModelo funcionario)
        {
            try
            {

                bool resposta = false;

                conFuncionario.ConnectionString = Dados.strConexao;
                cmdFuncionario.CommandType = CommandType.StoredProcedure;
                cmdFuncionario.Connection = conFuncionario;

                cmdFuncionario.CommandText = "FuncionarioAutenticar";
                cmdFuncionario.Parameters.AddWithValue("pfunlogin", funcionario.FunLogin);
                cmdFuncionario.Parameters.AddWithValue("pfunsenha", funcionario.FunSenha);
                cmdFuncionario.Parameters.AddWithValue("pfuntipo", funcionario.FunTipo);

                conFuncionario.Open();

                MySqlDataReader drFuncionario = cmdFuncionario.ExecuteReader();

                if (drFuncionario.HasRows)
                {
                    while (drFuncionario.Read())
                    {
                        if (drFuncionario["funlogin"].ToString() == funcionario.FunLogin)
                        {
                            if (drFuncionario["funsenha"].ToString() == funcionario.FunSenha)
                            {
                                if (drFuncionario["funtipo"].ToString() == funcionario.FunTipo)
                                {
                                    resposta = true;
                                }
                            }
                        }
                    }
                }
                drFuncionario.Close();
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conFuncionario.Close();
            }
        }

        public string Inserir(FuncionariosModelo funcionario)
        {
            try
            {
                if (VerificarFuncionarioExistente(funcionario) == true)
                {
                    Mensagem = "O funcionário já existe no cadastro";
                }
                else
                {
                    conFuncionario.ConnectionString = Dados.strConexao;
                    cmdFuncionario.CommandType = CommandType.StoredProcedure;
                    cmdFuncionario.Connection = conFuncionario;

                    cmdFuncionario.CommandText = "FuncionarioInserir";
                    cmdFuncionario.Parameters.AddWithValue("pfunnome", funcionario.FunNome);
                    cmdFuncionario.Parameters.AddWithValue("pfunlogin", funcionario.FunLogin);
                    cmdFuncionario.Parameters.AddWithValue("pfunsenha", funcionario.FunSenha);
                    cmdFuncionario.Parameters.AddWithValue("pfuntipo", funcionario.FunTipo);

                    conFuncionario.Open();
                    funcionario.FunId = Convert.ToInt32(cmdFuncionario.ExecuteScalar());
                    Mensagem = "Funcionário inserido com sucesso!";
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conFuncionario.Close();
            }
        }

        public void Alterar(FuncionariosModelo funcionario)
        {
            try
            {
                conFuncionario.ConnectionString = Dados.strConexao;
                cmdFuncionario.CommandType = CommandType.StoredProcedure;
                conFuncionario.Open();

                cmdFuncionario.CommandText = "FuncionarioAlterar";
                cmdFuncionario.Parameters.AddWithValue("pfunid", funcionario.FunId);
                cmdFuncionario.Parameters.AddWithValue("pfunnome", funcionario.FunNome);
                cmdFuncionario.Parameters.AddWithValue("pfunlogin", funcionario.FunLogin);
                cmdFuncionario.Parameters.AddWithValue("pfunsenha", funcionario.FunSenha);
                cmdFuncionario.Parameters.AddWithValue("pfuntipo", funcionario.FunTipo);

                cmdFuncionario.Connection = conFuncionario;
                cmdFuncionario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conFuncionario.Close();
            }
        }

        public bool Excluir(FuncionariosModelo funcionario)
        {
            int resultado = 0;
            bool resposta = false;
            try
            {
                conFuncionario.ConnectionString = Dados.strConexao;
                cmdFuncionario.CommandType = CommandType.StoredProcedure;
                cmdFuncionario.Connection = conFuncionario;

                cmdFuncionario.CommandText = "FuncionarioExcluir";
                cmdFuncionario.Parameters.AddWithValue("pfunid", funcionario.FunId);

                conFuncionario.Open();
                resultado = cmdFuncionario.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o funcionário" + funcionario.FunNome.ToString());
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
                conFuncionario.Close();
            }
        }
    }
}
