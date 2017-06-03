
/// Criar Biblioteca de Classes DAL

	// Adicionar Refer�ncia a biblioteca "Modelos"
	// Adicionar Refer�ncia ao MySQL Data

		// Criar Classe "Dados"
				namespace Projeto.nome_da_biblioteca;
				class Dados
				{
					public static string strConexao
					{
						get
						{
							return "server = localhost; Database = !nome_banco!; Uid = root; Connect Timeout = 30"; /*Pwd = !senha_banco!*/
						}
					}
				}

		// Criar Classe de DAL do Objeto
			
				using System.Data;
				using MySql.Data;
				using MySql.Data.MySqlClient;				
				using Projeto.Modelos;
				
				namespace Projeto.nome_da_biblioteca;
				public class ExemploDal
				{
					public string Mensagem { get; set; }
					MySqlConnection conExemplo = new MySqlConnection();
					MySqlCommand cmdExemplo = new MySqlCommand();

					public bool ExemploVerificarExistente(ExemploModelo exExist)
					{
						ExemploLista exLista = new ExemploLista();
						exLista = ExemploListar("");
						bool exist = false;

						exExist = exLista.Find(f => f.ExId == exExist.ExId);
						if(exExist != null)
						{
							exist = true;
						}
						return exist;
					}

					public ExemploLista ExemploListar(string filtro)
					{
						try
						{
							ExemploLista objExemploLista = new ExemploLista();

							conExemplo.ConnectionString = Dados.strConexao;
							cmdExemplo.Connection = conExemplo;
							cmdExemplo.CommandType = CommandType.StoredProcedure;

							cmdExemplo.CommandText = "ExemploSelecionar";

							cmdExemplo.Parameters.AddWithValue("pfiltro", exemplo.exVariavel);

							conExemplo.Open();
			 
							MySqlDataReader dr = cmdExemplo.ExecuteReader()

							if (dr.HasRows)
							{
								while (dr.Read())
								{
									ExemploModelo exemplo = new ExemploModelo();
									exemplo.ExId = Convert.ToInt32(dr["exid"].ToString());
									exemplo.ExNome = dr["exnome"].ToString();
									exemplo.ExNascimento = dr["exnascimento"].ToString();

									objExemploLista.Add(exemplo);
								}
							}
							return objExemploLista;
						}
						catch(Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							cmdExemplo.Parameter.Clear();
							conExemplo.Close();
							dr.Close();
						}
					}

					public string ExemploInserir(ExemploModelo exemplo)
					{
						try
						{
							if (ExemploVerificarExistente(exemplo))
							{
								Mensagem = "Exemplo já existe no cadastro.";
							}
							else
							{
								conExemplo.ConnectionString = Dados.strConexao;
								cmdExemplo.Connection = conExemplo;
								cmdExemplo.CommandType = CommandType.StoredProcedure;

								cmdExemplo.CommandText = "ExemploInserir";

								cmdExemplo.Parameters.AddWithValue("pexVariavel", exemplo.exVariavel);

								conExemplo.Open();

								exemplo.exId = Convert.ToInt32(cmdExemplo.ExecuteScalar());
								Mensagem = "Exemplo cadastrado com sucesso.";
							}
							return Mensagem;							
						}
						catch(Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							cmdExemplo.Parameter.Clear();
							conExemplo.Close();
						}
					}

					publid void ExemploAlterar(ExemploModelo exemplo)
					{
						try
						{
							conExemplo.ConnectionString = Dados.strConexao;
							cmdExemplo.Connection = conExemplo;
							cmdExemplo.CommandType = CommandType.StoredProcedure;

							cmdExemplo.CommandText = "ExemploAlterar";

							cmdExemplo.Parameters.AddWithValue("pexVariavel", exemplo.exVariavel);

							conExemplo.Open();
							cmdExemplo.ExecuteNonQuery();
						}
						catch(Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							cmdExemplo.Parameter.Clear();
							conExemplo.Close();
						}
					}

					publid bool ExcluirExemplo(ExemploModelo exemplo)
					{
						try
						{
							bool resposta = false;

							conExemplo.ConnectionString = Dados.strConexao;
							cmdExemplo.Connection = conExemplo;
							cmdExemplo.CommandType = CommandType.StoredProcedure;

							cmdExemplo.CommandText = "ExcluirExemplo";

							cmdExemplo.Parameters.AddWithValue("pexVariavel", exemplo.exVariavel);

							conExemplo.Open();

							int resultado = cmdExemplo.ExecuteNonQuery();
							if resultado = 1
								resposta = true;
							return resposta;
						}
						catch(Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							cmdExemplo.Parameter.Clear();
							conExemplo.Close();
						}
					}
				}
			}

		// Criar Fun��es da "Classe DAL do Objeto"


				-Excluir
				{
					bool resposta = false
					Executar Conex�o com Banco "AlterarExemplo" "dados,dados,dados"(Usando int resultado = cmdExemplo.ExecuteNonQuery())
					if resultado = 1
						resposta = true
					retornar resposta
				}
	}