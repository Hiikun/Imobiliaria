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
    public class ImoveisDal
    {
        public string Mensagem { get; set; }
        MySqlConnection conImoveis = new MySqlConnection();
        MySqlCommand cmdImoveis = new MySqlCommand();

        public bool ImoveisVerificarExistente(ImoveisModelo exExist)
        {
            ImoveisLista exLista = new ImoveisLista();
            exLista = ImoveisListar("");
            bool exist = false;

            exExist = exLista.Find(f => f.NomeImovel == exExist.NomeImovel);
            if (exExist != null)
            {
                exist = true;
            }
            return exist;
        }

        public ImoveisLista ImoveisListar(string filtro)
        {
            try
            {
                ImoveisLista objImoveisLista = new ImoveisLista();

                conImoveis.ConnectionString = Dados.strConexao;
                cmdImoveis.Connection = conImoveis;
                cmdImoveis.CommandType = CommandType.StoredProcedure;

                cmdImoveis.CommandText = "ImoveisSelecionar";

                cmdImoveis.Parameters.AddWithValue("pfiltro", filtro);

                conImoveis.Open();

                MySqlDataReader dr = cmdImoveis.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ImoveisModelo imovel = new ImoveisModelo();
                        imovel.IdImovel = Convert.ToInt32(dr["id_imovel"].ToString());
                        imovel.IdCliente = Convert.ToInt32(dr["id_cliente"].ToString());
                        imovel.NomeImovel = dr["nome_imovel"].ToString();
                        imovel.Endereco = dr["endereco"].ToString();
                        imovel.Bairro = dr["bairro"].ToString();
                        imovel.ZonaCidade = dr["zona_cidade"].ToString();
                        imovel.Cep = dr["cep"].ToString();
                        imovel.TipoImovel = dr["tipo_imovel"].ToString();
                        imovel.Condominio = dr.GetBoolean(dr.GetOrdinal("condominio"));
                        imovel.Metragem = Convert.ToDouble(dr["metragem"].ToString());
                        imovel.Dormitorios = Convert.ToInt32(dr["dormitorios"].ToString());
                        imovel.Banheiros = Convert.ToInt32(dr["banheiros"].ToString());
                        imovel.Suites = Convert.ToInt32(dr["suites"].ToString());
                        imovel.VagasGaragem = Convert.ToInt32(dr["vagas_garagem"].ToString());
                        imovel.ValorAluguelSugerido = Convert.ToDouble(dr["valor_aluguel_sugerido"].ToString());
                        imovel.ValorIptu = Convert.ToDouble(dr["valor_iptu"].ToString());
                        imovel.RequisitosInquilino = dr["requisitos_inquilino"].ToString();
                        imovel.Obs = dr["obs"].ToString();

                        objImoveisLista.Add(imovel);
                    }
                }
                dr.Close();
                return objImoveisLista;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdImoveis.Parameters.Clear();
                conImoveis.Close();                
            }
        }

        public string ImoveisInserir(ImoveisModelo imovel)
        {
            try
            {
                if (ImoveisVerificarExistente(imovel))
                {
                    Mensagem = "Imovel já existe no cadastro.";
                }
                else
                {
                    conImoveis.ConnectionString = Dados.strConexao;
                    cmdImoveis.Connection = conImoveis;
                    cmdImoveis.CommandType = CommandType.StoredProcedure;

                    cmdImoveis.CommandText = "ImoveisInserir";

                    cmdImoveis.Parameters.AddWithValue("pid_cliente",imovel.IdCliente);
                    cmdImoveis.Parameters.AddWithValue("pnome_imovel",imovel.NomeImovel);
                    cmdImoveis.Parameters.AddWithValue("pendereco",imovel.Endereco);
                    cmdImoveis.Parameters.AddWithValue("pbairro",imovel.Bairro);
                    cmdImoveis.Parameters.AddWithValue("pzona_cidade",imovel.ZonaCidade);
                    cmdImoveis.Parameters.AddWithValue("pcep",imovel.Cep);
                    cmdImoveis.Parameters.AddWithValue("ptipo_imovel", imovel.TipoImovel);
                    cmdImoveis.Parameters.AddWithValue("pcondominio", imovel.Condominio);
                    cmdImoveis.Parameters.AddWithValue("pmetragem",imovel.Metragem);
                    cmdImoveis.Parameters.AddWithValue("pdormitorios",imovel.Dormitorios);
                    cmdImoveis.Parameters.AddWithValue("pbanheiros",imovel.Banheiros);
                    cmdImoveis.Parameters.AddWithValue("psuites",imovel.Suites);
                    cmdImoveis.Parameters.AddWithValue("pvagas_garagem",imovel.VagasGaragem);
                    cmdImoveis.Parameters.AddWithValue("pvalor_aluguel_sugerido",imovel.ValorAluguelSugerido);
                    cmdImoveis.Parameters.AddWithValue("pvalor_iptu",imovel.ValorIptu);
                    cmdImoveis.Parameters.AddWithValue("prequisitos_inquilino",imovel.RequisitosInquilino);
                    cmdImoveis.Parameters.AddWithValue("pobs",imovel.Obs);

                    conImoveis.Open();

                    imovel.IdImovel = Convert.ToInt32(cmdImoveis.ExecuteScalar());
                    Mensagem = "Imovel cadastrado com sucesso.";
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdImoveis.Parameters.Clear();
                conImoveis.Close();
            }
        }

        public void ImoveisAlterar(ImoveisModelo imovel)
        {
            try
            {
                conImoveis.ConnectionString = Dados.strConexao;
                cmdImoveis.Connection = conImoveis;
                cmdImoveis.CommandType = CommandType.StoredProcedure;

                cmdImoveis.CommandText = "ImoveisAlterar";

                cmdImoveis.Parameters.AddWithValue("pid_imovel", imovel.IdImovel);
                cmdImoveis.Parameters.AddWithValue("pid_cliente", imovel.IdCliente);
                cmdImoveis.Parameters.AddWithValue("pnome_imovel", imovel.NomeImovel);
                cmdImoveis.Parameters.AddWithValue("pendereco", imovel.Endereco);
                cmdImoveis.Parameters.AddWithValue("pbairro", imovel.Bairro);
                cmdImoveis.Parameters.AddWithValue("pzona_cidade", imovel.ZonaCidade);
                cmdImoveis.Parameters.AddWithValue("pcep", imovel.Cep);
                cmdImoveis.Parameters.AddWithValue("ptipo_imovel", imovel.TipoImovel);
                cmdImoveis.Parameters.AddWithValue("pcondominio", imovel.Condominio);
                cmdImoveis.Parameters.AddWithValue("pmetragem", imovel.Metragem);
                cmdImoveis.Parameters.AddWithValue("pdormitorios", imovel.Dormitorios);
                cmdImoveis.Parameters.AddWithValue("pbanheiros", imovel.Banheiros);
                cmdImoveis.Parameters.AddWithValue("psuites", imovel.Suites);
                cmdImoveis.Parameters.AddWithValue("pvagas_garagem", imovel.VagasGaragem);
                cmdImoveis.Parameters.AddWithValue("pvalor_aluguel_sugerido", imovel.ValorAluguelSugerido);
                cmdImoveis.Parameters.AddWithValue("pvalor_iptu", imovel.ValorIptu);
                cmdImoveis.Parameters.AddWithValue("prequisitos_inquilino", imovel.RequisitosInquilino);
                cmdImoveis.Parameters.AddWithValue("pobs", imovel.Obs);

                conImoveis.Open();
                cmdImoveis.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdImoveis.Parameters.Clear();
                conImoveis.Close();
            }
        }

        public bool ImoveisExcluir(ImoveisModelo imovel)
        {
            try
            {
                bool resposta = false;

                conImoveis.ConnectionString = Dados.strConexao;
                cmdImoveis.Connection = conImoveis;
                cmdImoveis.CommandType = CommandType.StoredProcedure;

                cmdImoveis.CommandText = "ImoveisExcluir";

                cmdImoveis.Parameters.AddWithValue("pid_imovel", imovel.IdImovel);

                conImoveis.Open();

                int resultado = cmdImoveis.ExecuteNonQuery();
                if (resultado == 1)
                    resposta = true;
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdImoveis.Parameters.Clear();
                conImoveis.Close();
            }                      
        }
    }
}
















