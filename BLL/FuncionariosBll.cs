using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Imobiliaria.Modelos;
using Imobiliaria.DAL;

namespace Imobiliaria.BLL
{
    public class FuncionariosBll
    {
        // Esta variável enviará ao usuário uma mensagem caso ocorra fracasso na tentativa de autenticação.
        public string Mensagem { get; set; }
        //Cria uma instância do objeto da classe FuncionariosDAL;
        FuncionariosDal objFuncionariosDal = new FuncionariosDal();

        public bool Login(FuncionariosModelo funcionario)
        {
            // Esta variável armazenará o resultado da autenticação.
            // Ser verdadeiro, houve sucesso, senão fracasso.
            bool resposta = false;
            bool verifica = false;
            try
            {
                // Regra de validação para login e senha
                if (funcionario.FunLogin.Length > 16 || funcionario.FunSenha.Length < 6 || funcionario.FunSenha.Length > 12)
                {
                    Mensagem = "O usuário pode ter no máximo 16 caracteres e" + "\n" + "a senha terá minimo de 6 e máximo de 8 caracteres!";
                    return false;
                }
                else
                {
                    // Converte caracteres para minusculas.
                    funcionario.FunLogin = funcionario.FunLogin.ToLower();

                    // Verificando a senha criptografada
                    verifica = VerificaSenhaMD5(funcionario);
                    if (verifica == true)
                    {
                        // Chamada do método Login da classe FuncionariosDal para autenticar
                        resposta = objFuncionariosDal.Login(funcionario);

                        if (!resposta)
                        {
                            Mensagem = "O funcionário não pode ser autenticado";
                        }
                    }
                    else
                    {
                        Mensagem = "Senha Incorreta!";
                    }
                }
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidarFuncionario(FuncionariosModelo funcionario)
        {
            bool valida = false;
            if (funcionario.FunNome.Length == 0)
            {
                Mensagem = "O nome do funcionário é obrigatório! Entre com o nome do funcionário.";
            }
            else if (funcionario.FunLogin.Length < 6 || funcionario.FunLogin.Length > 10)
            {
                Mensagem = "O usuário não pode ter menos que 6 ou mais de 10 caracteres.";
            }
            else if (funcionario.FunSenha.Length < 6 || funcionario.FunSenha.Length > 32)
            {
                Mensagem = "A senha não pode ter menos que 6 ou mais de 8 caracteres.";
            }
            else if (funcionario.FunTipo.Length == 0)
            {
                Mensagem = "Selecione um tipo para cadastrar o funcionário!";
            }
            else
            {
                valida = true;
            }
            return valida;
        }

        public string Inserir(FuncionariosModelo funcionario)
        {
            try
            {
                bool valida = ValidarFuncionario(funcionario);
                if (!valida)
                {
                    return Mensagem;
                }
                else
                {
                    funcionario.FunNome = funcionario.FunNome.ToLower();
                    funcionario.FunSenha = GeraSenhaMD5(funcionario.FunSenha);

                    Mensagem = objFuncionariosDal.Inserir(funcionario);
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Alterar(FuncionariosModelo funcionario)
        {
            try
            {
                bool valida = ValidarFuncionario(funcionario);
                if (!valida)
                {
                    return Mensagem;
                }
                else
                {
                    if (funcionario.FunId <= 0)
                    {
                        Mensagem = "Você deve selecionar um funcionário para poder alterá-lo.";
                    }
                    else
                    {
                        funcionario.FunNome = funcionario.FunNome.ToLower();

                        funcionario.FunSenha = GeraSenhaMD5(funcionario.FunSenha);

                        objFuncionariosDal.Alterar(funcionario);
                        Mensagem = "Funcionário alterado com sucesso!";
                    }
                }
                return Mensagem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(FuncionariosModelo funcionario)
        {
            try
            {
                bool resposta = false;
                if (funcionario.FunId < 1)
                {
                    Mensagem = "Selecione um funcionário antes de excluí-lo!";
                }
                else
                {
                    resposta = objFuncionariosDal.Excluir(funcionario);
                    Mensagem = "Funcionário excluido com sucesso.";
                }
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public FuncionariosLista FuncionariosListar(string filtro)
        {
            return objFuncionariosDal.Listagem(filtro);
        }

        private string GeraSenhaMD5(string texto)
        {
            try
            {
                // Cria Instância da clase MD5 Crypyo Service Provider.
                MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();

                // Gerar o hash do texto (senha)
                byte[] valorHash = MD5provider.ComputeHash(Encoding.Default.GetBytes(texto));
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < valorHash.Length; i++)
                {
                    // O formato x2 exibe caracteres no formato hexadecimal para variáveis do tipo byte
                    str.Append(valorHash[i].ToString("x2"));
                }

                return str.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool VerificaSenhaMD5(FuncionariosModelo funcionario)
        {
            try
            {
                //Gera criptografia para o texto de FunSenha que retornará criptografada
                string senha2 = GeraSenhaMD5(funcionario.FunSenha);
                funcionario.FunSenha = senha2;

                // Cria um objeto da classe string comparer que compara o hash gerado com o armazenado
                StringComparer strComparer = StringComparer.OrdinalIgnoreCase;

                string valorHashArmazenado = "";
                string filtro = "";
                FuncionariosLista listaFun = new FuncionariosLista();

                listaFun = FuncionariosListar(filtro);
                funcionario = listaFun.Find(f => f.FunSenha == funcionario.FunSenha);

                if (funcionario != null)
                {
                    valorHashArmazenado = funcionario.FunSenha;
                }
                else
                {
                    Mensagem = "Senha não localizada";
                }
                // Se o valor das strings forem iguais então retorna-se true
                // Se a comparação de uma string com outra for igual, retorna-se zero
                if (strComparer.Compare(senha2, valorHashArmazenado).Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

