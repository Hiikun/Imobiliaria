
/// Criar Biblioteca de Classes BLL

		// Adicionar Refer�ncia a biblioteca "Modelos"
		// Adicionar Refer�ncia a biblioteca "DAL"

		// Criar Classe BLL do Objeto

using Projeto.Modelos;
using Projeto.DAL;
namespace Projeto.nome_da_biblioteca;
{
	public class ExemploBll
	{
		public string Mensagem { get; set; }
		ExemploDal objExemploDal = new ExemploDal();

		/* Criar Funcoes de Validacao de Dados Aqui */

		/* Funcoes da Classe */
		public bool ExemploValidar(ExemploModelo exemplo)
		{
			// Valida Objeto chegando padrao antes de entrar nas funcoes abaixo
		} 

		public ExemploLista ExemploListar(string filtro)
		{
			return objExemploDal.ExemploListar(filtro);
		}

		public string ExemploInserir(ExemploModelo exemplo)
		{
			try
			{
				if (!ExemploValidar(exemplo))
				{
					return Mensagem;
				}
				else
				{
					Mensagem = objExemploDal.ExemploInserir(exemplo);
				}
				return Mensagem;
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void ExemploAlterar(ExemploModelo exemplo)
		{
			try
			{
				if (!ExemploValidar(exemplo))
				{
					return Mensagem;
				}
				else
				{
					if (exemplo.ExId <= 0)
					{
						Mensagem = "Selecione um cliente para poder alter�-lo.";
					}
					else
					{
						objExemploDal.ExemploAlterar(exemplo);
						Mensagem = "Exemplo alterado com sucesso.";
					}
				}
				return Mensagem;
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public bool ExemploExcluir(ExemploModelo exemplo)
		{
			try
			{
				if (exemplo.ExId < 1)
				{
					Mensagem = "Selecione um exemplo para poder exclu�-lo.";
				}
				else
				{
					if (objExemploDal.ExemploExcluir(exemplo))
					{
						Mensagem = "Exemplo exclúido com sucesso.";
					}
					else
					{
						Mensagem = "Não foi possível excluir o exemplo.";
					}
				}
				return Mensagem;
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}