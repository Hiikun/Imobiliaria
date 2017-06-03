using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.DAL;
using Imobiliaria.Modelos;

namespace Imobiliaria.BLL
{
    public class ImoveisBll
    {
        public string Mensagem { get; set; }
        ImoveisDal objImoveisDal = new ImoveisDal();

        /* Criar Funcoes de Validacao de Dados Aqui */

        public bool ImoveisValidar(ImoveisModelo imovel)
        {
            bool valida = false;
            if (imovel.NomeImovel.Length == 0)
            {
                Mensagem = "Defina um nome para o imovel.";
            }
            else if (imovel.Cep.Length < 9)
            {
                Mensagem = "O CEP está incompleto.";
            }
            else if (imovel.Metragem <= 0)
            {
                Mensagem = "Metragem inválida, valor deve ser maior que zero.";
            }
            else if (imovel.Dormitorios < 0 || imovel.Banheiros < 0 || imovel.Suites < 0 || imovel.VagasGaragem < 0)
            {
                Mensagem = "Os comodos da casa não podem possuir valor menor que zero.";
            }
            else if (imovel.ValorAluguelSugerido <= 0)
            {
                Mensagem = "Valor de aluguel inválido, valor deve ser maior que zero.";
            }
            else if (imovel.ValorIptu < 0)
            {
                Mensagem = "Valor de aluguel inválido, valor não deve ser negativo.";
            }
            else
            {
                valida = true;
            }

            return valida;
        }

        public ImoveisLista ImoveisListar(string filtro)
        {
            return objImoveisDal.ImoveisListar(filtro);
        }

        public string ImoveisInserir(ImoveisModelo imovel)
        {
            try
            {
                if (!ImoveisValidar(imovel))
                {
                    return Mensagem;
                }
                else
                {
                    Mensagem = objImoveisDal.ImoveisInserir(imovel);
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ImoveisAlterar(ImoveisModelo imovel)
        {
            try
            {
                if (!ImoveisValidar(imovel))
                {
                    return Mensagem;
                }
                else
                {
                    if (imovel.IdImovel <= 0)
                    {
                        Mensagem = "Selecione um imovel para poder altera-lo.";
                    }
                    else
                    {
                        objImoveisDal.ImoveisAlterar(imovel);
                        Mensagem = "Imovel alterado com sucesso.";
                    }
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ImoveisExcluir(ImoveisModelo imovel)
        {
            try
            {
                if (imovel.IdImovel < 1)
                {
                    Mensagem = "Selecione um imovel para poder exclui-lo.";
                }
                else
                {
                    if (objImoveisDal.ImoveisExcluir(imovel))
                    {
                        Mensagem = "Imovel exclúido com sucesso.";
                    }
                    else
                    {
                        Mensagem = "Não foi possível excluir o imovel.";
                    }
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
