using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.Modelos;
using Imobiliaria.DAL;

namespace Imobiliaria.BLL
{
    public class ServicoImoveisBll
    {
        String mensagem = "";
        ServicoImoveisDal objServicoDal = new ServicoImoveisDal();

        public bool ValidarServico(ServicoImovelModelo servico)
        {
            bool valido = false;
            try
            {
                if (servico.SerData.Length == 0)
                {
                    mensagem = "Data inválida.";
                }
                else if (servico.SerValor == 0)
                {
                    mensagem = "O campo valor total não pode ficar em branco.";
                }
                else
                {
                    valido = true;
                }
                return valido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ServicoImovelLista ListarServicos(string filtro)
        {
            return objServicoDal.Listagem(filtro);
        }

        public string InserirServico(ServicoImovelModelo servico)
        {
            try
            {
                if (!ValidarServico(servico))
                {
                    return mensagem;
                }
                else
                {
                    mensagem = objServicoDal.InserirServicoImovel(servico);
                }
                return mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AlterarServico(ServicoImovelModelo servico)
        {
            if (!ValidarServico(servico))
            {
                return mensagem;
            }
            else
            {
                if (servico.SerId <= 0)
                {
                    mensagem = "Selecione um serviço";
                }
                else
                {
                    objServicoDal.Alterar(servico);
                    mensagem = "Serviço alterado com sucesso!";
                }
            }
            return mensagem;
        }

        public string ExcluirServico(ServicoImovelModelo servico)
        {
            try
            {
                if (servico.SerId < 1)
                {
                    mensagem = "Selecione um serviço.";
                }
                else
                {
                    if (objServicoDal.Excluir(servico))
                    {
                        mensagem = "Serviço excluído com sucesso!";
                    }
                    else
                    {
                        mensagem = "Não foi possível excluir o serviço.";
                    }
                }
                return mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}