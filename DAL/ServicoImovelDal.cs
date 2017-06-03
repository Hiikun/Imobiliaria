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
    public class ServicoImoveisDal
    {
        private string mensagem;

        public string Mensagem
        {
            get
            {
                return mensagem;
            }

            set
            {
                mensagem = value;
            }
        }

        MySqlConnection conServicos = new MySqlConnection();

        MySqlCommand cmdServicos = new MySqlCommand();


        public string InserirServicoImovel(ServicoImovelModelo servicos)
        {
            try
            {
                if (VerificarServicoImovel(servicos))
                {
                    Mensagem = "Serviço já cadastrado";
                }
                else
                {
                    conServicos.ConnectionString = Dados.strConexao;

                    cmdServicos.CommandType = CommandType.StoredProcedure;

                    cmdServicos.CommandText = "Servicos_imovelInserir";

                    cmdServicos.Parameters.AddWithValue("pid_profissional", servicos.SerProfissionalId);
                    cmdServicos.Parameters.AddWithValue("pid_imovel", servicos.SerImovelId);
                    cmdServicos.Parameters.AddWithValue("pdata_servico", servicos.SerData);
                    cmdServicos.Parameters.AddWithValue("pvalor_total", servicos.SerValor);
                    cmdServicos.Parameters.AddWithValue("pobs", servicos.SerObs);

                    conServicos.Open();

                    servicos.SerId = Convert.ToInt32(cmdServicos.ExecuteScalar());
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conServicos.Close();
            }
        }
        public bool VerificarServicoImovel(ServicoImovelModelo servicoExist)
        {
            string filtro = "";
            ServicoImovelLista listaservicos = new ServicoImovelLista();
            bool verifica = false;
            listaservicos = Listagem(filtro);

            servicoExist = listaservicos.Find(p => p.SerId == servicoExist.SerId);
            if (servicoExist != null)
            {
                verifica = true;
            }
            return verifica;
        }

        public ServicoImovelLista Listagem(string filtro)
        {
            try
            {
                ServicoImovelLista objListaServicos = new ServicoImovelLista();
                conServicos.ConnectionString = Dados.strConexao;
                cmdServicos.Connection = conServicos;
                cmdServicos.CommandType = CommandType.StoredProcedure;
                cmdServicos.CommandText = "Servicos_imovelSelecionar";
                cmdServicos.Parameters.AddWithValue("pfiltro", filtro);
                conServicos.Open();
                MySqlDataReader dr = cmdServicos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ServicoImovelModelo servicos = new ServicoImovelModelo();
                        servicos.SerId = Convert.ToInt32(dr["id_trabalho"].ToString());
                        servicos.SerProfissionalId = Convert.ToInt32(dr["id_profissional"].ToString());
                        servicos.SerImovelId = Convert.ToInt32(dr["id_imovel"].ToString());
                        servicos.SerData = dr["data_servico"].ToString();
                        servicos.SerValor = Convert.ToDouble(dr["valor_total"].ToString());
                        servicos.SerObs = dr["obs"].ToString();

                        objListaServicos.Add(servicos);
                    }
                }
                return objListaServicos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdServicos.Parameters.Clear();
                conServicos.Close();
            }
        }

        public void Alterar(ServicoImovelModelo servicoImoveis)
        {
            try
            {
                conServicos.ConnectionString = Dados.strConexao;

                cmdServicos.CommandType = CommandType.StoredProcedure;

                cmdServicos.CommandText = "Servicos_imovelAlterar";

                cmdServicos.Parameters.AddWithValue("pidImovel", servicoImoveis.SerImovelId);
                cmdServicos.Parameters.AddWithValue("pidPprofissional", servicoImoveis.SerProfissionalId);
                cmdServicos.Parameters.AddWithValue("pdata_servico", servicoImoveis.SerData);
                cmdServicos.Parameters.AddWithValue("pvalor_total", servicoImoveis.SerValor);
                cmdServicos.Parameters.AddWithValue("pobs", servicoImoveis.SerObs);
                cmdServicos.Connection = conServicos;

                conServicos.Open();

                cmdServicos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conServicos.Close();
            }
        }

        public bool Excluir(ServicoImovelModelo servicos)
        {
            int resultado = 0;
            bool response = false;
            try
            {
                conServicos.ConnectionString = Dados.strConexao;
                cmdServicos.CommandType = CommandType.StoredProcedure;
                cmdServicos.CommandText = "Servicos_imovelExcluir";
                cmdServicos.Parameters.AddWithValue("pidServicoImovel", servicos.SerId);
                cmdServicos.Connection = conServicos;
                conServicos.Open();
                resultado = cmdServicos.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o serviço" + servicos.SerId.ToString());
                }
                else
                {
                    response = true;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conServicos.Close();
            }
        }
    }
}
