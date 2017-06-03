using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.Modelos;
using Imobiliaria.DAL;

namespace Imobiliaria.BLL
{
    public class ProfissionaisBll
    {
        private string mensagem;

        private bool resposta;

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

        public bool Resposta
        {
            get
            {
                return resposta;
            }

            set
            {
                resposta = value;
            }
        }

        public bool verifica = false;

        ProfissionaisDal objProfissionaisDal = new ProfissionaisDal();

        private bool validaProfissional(ProfissionalModelo profissional)
        {
            bool valida = false;
            if (profissional.ProfNome.Length == 0)
            {
                mensagem = "O nome do profissional é obrigatório! Entre com um nome!";
            }
            else if (profissional.ProfProfissao.Length == 0)
            {
                mensagem = "O campo 'Profissão' é obrigatório!";
            }
            else if (profissional.ProfTel1.Length < 8 || profissional.ProfTel1.Length > 15)
            {
                mensagem = "O número de telefone precisa ter entre 8 ou 15 caracteres!";
            }
            else if (profissional.ProfValorHora <= 0)
            {
                mensagem = "Digite o valor da hora do profissional";
            }
            else
            {
                valida = true;
            }
            return valida;
        }

        public string Inserir(ProfissionalModelo profissional)
        {
            try
            {
                bool valida = validaProfissional(profissional);
                if (valida == false)
                {
                    return mensagem;
                }
                else
                {
                    objProfissionaisDal.Inserir(profissional);
                    mensagem = "Profissional inserido com sucesso!";
                    return mensagem;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Alterar(ProfissionalModelo profissional)
        {
            try
            {
                bool valida = validaProfissional(profissional);
                if (valida == false)
                {
                    return mensagem;
                }
                else
                {

                    objProfissionaisDal.Alterar(profissional);
                    mensagem = "Profissional alterado com sucesso!";
                    return mensagem;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ProfissionalModelo profissional)
        {
            try
            {
                bool resposta = false;
                if (profissional.ProfId < 1)
                {
                    mensagem = "Selecione um profissional antes de excluí-lo!";
                }
                else
                {
                    resposta = objProfissionaisDal.Excluir(profissional);
                    mensagem = "Profissional excluído com sucesso!";
                }
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListaProfissionais ListaProfissionais(string filtro)
        {
            return objProfissionaisDal.Listagem(filtro);
        }
    }
}