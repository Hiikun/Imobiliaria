using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imobiliaria.Modelos;
using Imobiliaria.BLL;

namespace Imobiliaria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Administrador");
            cboTipo.Items.Add("Usuario");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Variável que receberá como resposta sobre o sucesso ou não
                // autenticação.
                bool autentica = false;

                // O objeto funcionario resgatará os valores digitados em frmLogin
                FuncionariosModelo funcionario = new FuncionariosModelo();

                // Incrementação do contador que registra as tentativas
                // de autenticação do Login.
                Globais.intContador++;

                // Instância do objeto da camada de Regra de Negócios - Bll
                // que valida os dados do formulário.
                FuncionariosBll objFuncionariosBll = new FuncionariosBll();

                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    lblMensagem.Text = "Campos em Branco! Entre com os dados para o Login";
                    txtUsuario.Focus();
                }
                else
                {
                    lblMensagem.Text = "";
                    // Resgate dos dados da interface gráfica de frmLogin
                    funcionario.FunLogin = txtUsuario.Text;
                    funcionario.FunSenha = txtSenha.Text;
                    funcionario.FunTipo = cboTipo.Text;

                    // Transportando os dados para a classe Globais.
                    Globais.strFuncionario = funcionario.FunLogin;
                    Globais.strTipo = funcionario.FunTipo;

                    // O método Login da camada Bll retorna valor boleano para
                    // autenticar ou não o usuário.
                    autentica = objFuncionariosBll.Login(funcionario);
                    lblMensagem.Text = objFuncionariosBll.Mensagem;

                    // Caso haja sucesso na autenticação
                    if(autentica == true)
                    {
                        this.Hide();
                        // Cria uma instância do formulário frmPrincipal
                        // e exibe este formulário.
                        frmPrincipal objFrmPrincipal = new frmPrincipal();
                        objFrmPrincipal.ShowDialog();
                    }
                    else
                    {
                        // Caso não haja sucesso na autenticação.
                        // completar o código da mensagem de erro da camada Bll

                        this.Text = "Login - Tentativa " + Globais.intContador;
                        lblMensagem.Text = "Login Inválido! Tente novamente!";
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                    }

                    if(Globais.intContador > 3)
                    {
                        MessageBox.Show("Você ultrapassou o limite de tentativas de Login! Contate o suporte!", "Erro");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
