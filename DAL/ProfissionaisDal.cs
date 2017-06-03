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
    public class ProfissionaisDal
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

        MySqlConnection conProfissional = new MySqlConnection();

        MySqlCommand cmdProfissional = new MySqlCommand();

        public void Inserir(ProfissionalModelo profissional)
        {
            try
            {
                if (VerificarProfissionalExistente(profissional) == true)
                {
                    mensagem = "Este profissional já possui cadastro!";
                }
                else
                {
                    cmdProfissional.Connection = conProfissional;

                    conProfissional.ConnectionString = Dados.strConexao;

                    cmdProfissional.CommandType = CommandType.StoredProcedure;

                    cmdProfissional.CommandText = "ProfissionaisInserir";

                    cmdProfissional.Parameters.AddWithValue("pnome", profissional.ProfNome);
                    cmdProfissional.Parameters.AddWithValue("pprofissao", profissional.ProfProfissao);
                    cmdProfissional.Parameters.AddWithValue("ptelefone1", profissional.ProfTel1);
                    cmdProfissional.Parameters.AddWithValue("ptelefone2", profissional.ProfTel2);
                    cmdProfissional.Parameters.AddWithValue("pvalor_hora", profissional.ProfValorHora);
                    cmdProfissional.Parameters.AddWithValue("pobs", profissional.ProfObs);

                    conProfissional.Open();

                    profissional.ProfId = Convert.ToInt32(cmdProfissional.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conProfissional.Close();
            }
        }

        private bool VerificarProfissionalExistente(ProfissionalModelo profExist)
        {
            string filtro = "";
            ProfissionaisLista listaProf = new ProfissionaisLista();
            bool verifica = false;
            listaProf = Listagem(filtro);

            profExist = listaProf.Find(p => p.ProfNome == profExist.ProfNome);

            if (profExist != null)
            {
                verifica = true;
            }
            return verifica;
        }

        public ProfissionaisLista Listagem(string filtro)
        {
            try
            {
                ProfissionaisLista objListaProfissionais = new ProfissionaisLista();
                conProfissional.ConnectionString = Dados.strConexao;
                cmdProfissional.Connection = conProfissional;
                cmdProfissional.CommandType = CommandType.StoredProcedure;
                cmdProfissional.CommandText = "ProfissionaisSelecionar";
                cmdProfissional.Parameters.AddWithValue("pfiltro", filtro);

                conProfissional.Open();

                MySqlDataReader dr = cmdProfissional.ExecuteReader();
                cmdProfissional.Parameters.Clear();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        ProfissionalModelo profissional = new ProfissionalModelo();
                        profissional.ProfId = int.Parse(dr["id_profissional"].ToString());
                        profissional.ProfNome = dr["nome"].ToString();
                        profissional.ProfProfissao = dr["profissao"].ToString();
                        profissional.ProfTel1 = dr["telefone1"].ToString();
                        profissional.ProfTel2 = dr["telefone2"].ToString();
                        profissional.ProfValorHora = double.Parse(dr["valor_hora"].ToString());
                        profissional.ProfObs = dr["obs"].ToString();
                        objListaProfissionais.Add(profissional);
                    }
                }
                return objListaProfissionais;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conProfissional.Close();
            }
        }

        public void Alterar(ProfissionalModelo profissional)
        {
            try
            {
                conProfissional.ConnectionString = Dados.strConexao;

                cmdProfissional.CommandType = CommandType.StoredProcedure;

                cmdProfissional.CommandText = "ProfissionaisAlterar";

                cmdProfissional.Parameters.AddWithValue("pid_profissional", profissional.ProfId);
                cmdProfissional.Parameters.AddWithValue("pnome", profissional.ProfNome);
                cmdProfissional.Parameters.AddWithValue("pprofissao", profissional.ProfProfissao);
                cmdProfissional.Parameters.AddWithValue("ptelefone1", profissional.ProfTel1);
                cmdProfissional.Parameters.AddWithValue("ptelefone2", profissional.ProfTel2);
                cmdProfissional.Parameters.AddWithValue("pvalor_hora", profissional.ProfValorHora);
                cmdProfissional.Parameters.AddWithValue("pobs", profissional.ProfObs);

                cmdProfissional.Connection = conProfissional;

                conProfissional.Open();

                cmdProfissional.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conProfissional.Close();
            }
        }

        public bool Excluir(ProfissionalModelo profissional)
        {
            int resultado = 0;
            bool resposta = false;

            try
            {
                conProfissional.ConnectionString = Dados.strConexao;
                cmdProfissional.CommandType = CommandType.StoredProcedure;
                cmdProfissional.CommandText = "ProfissionaisExcluir";
                cmdProfissional.Parameters.AddWithValue("pid_profissional", profissional.ProfId);
                cmdProfissional.Connection = conProfissional;
                conProfissional.Open();
                resultado = cmdProfissional.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o profissional: " + profissional.ProfNome);
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
                conProfissional.Close();
            }
        }
    }
}