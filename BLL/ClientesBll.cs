using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.Modelos;
using Imobiliaria.DAL;

namespace Imobiliaria.BLL
{
    public class ClientesBll
    {
        public string Mensagem = "";

        ClientesDal objClientesDal = new ClientesDal();

        public bool ValidarCpf(string CliCpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            CliCpf = CliCpf.Trim();
            CliCpf = CliCpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (CliCpf.Length != 11)
                return false;
            tempCpf = CliCpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return CliCpf.EndsWith(digito);
          }

        public bool ValidarCliente(ClientesModelo cliente)
        {
            bool valido = false;
            try
            {
                if (cliente.CliNome.Length == 0)
                {
                    Mensagem = "Preencha o nome do Cliente.";
                }
                else if (cliente.CliEndereco == "")
                {
                    Mensagem = "O endereço deve ser preenchido";
                }
                else if (cliente.CliCEP.Length < 8)
                {
                    Mensagem = "O CEP não pode ser menor que 8 caracteres.";
                }
                else if (cliente.CliTelefone1.Length < 8  || cliente.CliTelefone1.Length > 15)
                {
                    Mensagem = "O telefone 1 é inválido";
                }
                else if (cliente.CliTelefone2.Length < 8 || cliente.CliTelefone2.Length > 15)
                {
                    Mensagem = "O telefone 2 é invalido";
                }
                else if (cliente.CliEmail.Length == 0)
                {
                    Mensagem = "email invalido.";
                }
                else if (cliente.CliDataNascimento.Length < 8)
                {
                    Mensagem = "A data de nascimento invalida.";
                }
                else if (!ValidarCpf(cliente.CliCPF))
                {
                    Mensagem = "CPF inválido!";
                }
                else if (cliente.CliRG == "")
                {
                    Mensagem = "O RG deve ser preenchido";
                }
                else
                {
                    cliente.CliEmail.ToLower();
                    valido = true;
                }
                return valido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClientesLista ListarClientes(string filtro)
        {
            return objClientesDal.ListarClientes(filtro);
        }

        public string InserirCliente(ClientesModelo cliente)
        {
            try
            {
                if (!ValidarCliente(cliente))
                {
                    return Mensagem;
                }
                else
                {
                    Mensagem = objClientesDal.InserirCliente(cliente);
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AlterarCliente(ClientesModelo cliente)
        {
            if (!ValidarCliente(cliente))
            {
                return Mensagem;
            }
            else
            {
                if (cliente.CliId <= 0)
                {
                    Mensagem = "Selecione um cliente";
                }
                else
                {
                    objClientesDal.AlterarCliente(cliente);
                    Mensagem = "Cliente alterado com sucesso!";
                }
            }
            return Mensagem;
        }

        public string ExcluirCliente(ClientesModelo cliente)
        {
            try
            {
                if (cliente.CliId < 1)
                {
                    Mensagem = "Selecione um cliente";
                }
                else
                {
                    if (objClientesDal.ExcluirCliente(cliente))
                    {
                        Mensagem = "Cliente excluído com sucesso!";
                    }else
                    {
                        Mensagem = "Não foi possível excluir";
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
