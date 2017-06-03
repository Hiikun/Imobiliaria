using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Imobiliaria.Modelos;
using Imobiliaria.BLL;

namespace Imobiliaria
{
    public partial class frmFuncionarios : Form
    {
        // Objeto funcionario coletará os dados da interface gráfica.
        FuncionariosModelo funcionario = new FuncionariosModelo();
        FuncionariosBll objFuncionariosBll = new FuncionariosBll();

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Resgatando os dados da interface gráfica
                funcionario.FunNome = txtNome.Text;
                funcionario.FunLogin = txtLogin.Text;
                funcionario.FunSenha = txtSenha.Text;
                funcionario.FunTipo = cboTipo.Text;
                lblMensagem.Text = objFuncionariosBll.Inserir(funcionario);
                lblIdFuncionario.Text = funcionario.FunId.ToString();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void AtualizarGrid()
        {
            string filtro = "";
            try
            {
                dgvFuncionarios.DataSource = objFuncionariosBll.FuncionariosListar(filtro);
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
            finally
            {
                FormataGrid();
            }
        }

        private void FormataGrid()
        {
            try
            {
                // Cabeçalho da Coluna FunId
                dgvFuncionarios.Columns[0].HeaderText = "ID";
                dgvFuncionarios.Columns[0].Width = 80;
                // Cabeçalho da Coluna FunNome
                dgvFuncionarios.Columns[1].HeaderText = "Nome";
                dgvFuncionarios.Columns[1].Width = 200;
                // Cabeçalho da Coluna FunLogin
                dgvFuncionarios.Columns[2].HeaderText = "Login";
                dgvFuncionarios.Columns[2].Width = 150;
                // Cabeçalho da Coluna FunTipo
                dgvFuncionarios.Columns.Remove("FunSenha");
                dgvFuncionarios.Columns[3].HeaderText = "Tipo";
                dgvFuncionarios.Columns[3].Width = 120;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = (ex.Message);
            }
            finally
            {
                LimpaFuncionario();
            }
        }

        private void LimpaFuncionario()
        {
            lblIdFuncionario.Text = "";
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            cboTipo.SelectedIndex = -1;
            txtPesquisar.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            lblMensagem.Text = "";
            AtualizarGrid();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIdFuncionario.Text == "")
                {
                    lblMensagem.Text = "Selecione um funcionário para poder alterá-lo.";
                }
                else
                {
                    funcionario.FunId = Convert.ToInt32(lblIdFuncionario.Text);
                    funcionario.FunNome = txtNome.Text;
                    funcionario.FunLogin = txtLogin.Text;
                    funcionario.FunSenha = txtSenha.Text;
                    funcionario.FunTipo = cboTipo.Text;
                    lblMensagem.Text = objFuncionariosBll.Alterar(funcionario);
                    AtualizarGrid();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta = false;

            if (lblIdFuncionario.Text == "")
            {
                lblMensagem.Text = "Por favor, selecione um funcionário para excluí-lo.";
            }
            else
            {
                try
                {
                    funcionario.FunId = Convert.ToInt32(lblIdFuncionario.Text);
                    resposta = objFuncionariosBll.Excluir(funcionario);
                    if (resposta)
                    {
                        lblMensagem.Text = objFuncionariosBll.Mensagem;
                    }
                    else
                    {
                        lblMensagem.Text = objFuncionariosBll.Mensagem;
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }            
            }
            AtualizarGrid();
        }

        private void ReceberDados()
        {
            lblIdFuncionario.Text = dgvFuncionarios[0, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvFuncionarios[1, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            txtLogin.Text = dgvFuncionarios[2, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            cboTipo.Text = dgvFuncionarios[3, dgvFuncionarios.CurrentRow.Index].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // A variável "filtro" fará a pesquisa de funcionários no banco.
            string filtro = txtPesquisar.Text;
            try
            {
                dgvFuncionarios.DataSource = objFuncionariosBll.FuncionariosListar(filtro);
                FormataGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
        
        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceberDados();
        }
    }
}
