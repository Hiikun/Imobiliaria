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
    public partial class frmClientes : Form
    {
        ClientesModelo cliente = new ClientesModelo();
        ClientesBll objClientesBll = new ClientesBll();
        
        public frmClientes()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            try
            {
                string filtro = "";
                dgvClientes.DataSource = objClientesBll.ListarClientes(filtro);
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
            finally
            {
                FormatarGrid();
            }
        }

        private void FormatarGrid()
        {
            try
            {
                dgvClientes.Columns[0].HeaderText = "ID";
                dgvClientes.Columns[0].Width = 50;
                dgvClientes.Columns[1].HeaderText = "Nome";
                dgvClientes.Columns[1].Width = 200;
                dgvClientes.Columns[2].HeaderText = "CPF";
                dgvClientes.Columns[2].Width = 150;
                dgvClientes.Columns[3].HeaderText = "RG";
                dgvClientes.Columns[3].Width = 120;
                dgvClientes.Columns[4].HeaderText = "Endereco";
                dgvClientes.Columns[4].Width = 150;
                dgvClientes.Columns[5].HeaderText = "CEP";
                dgvClientes.Columns[5].Width = 100;
                dgvClientes.Columns[6].HeaderText = "Telefone 1";
                dgvClientes.Columns[6].Width = 100;
                dgvClientes.Columns[7].HeaderText = "Telefone 2";
                dgvClientes.Columns[7].Width = 100;
                dgvClientes.Columns[8].HeaderText = "Email";
                dgvClientes.Columns[8].Width = 120;
                dgvClientes.Columns[9].HeaderText = "Nascimento";
                dgvClientes.Columns[9].Width = 80;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
            finally
            {
                LimparDados();
            }
        }

        private void LimparDados()
        {
            try
            {
                lblIdCliente.Text = "";
                txtNome.Clear();
                txtEmail.Clear();
                mskTelefone1.Clear();
                mskTelefone2.Clear();
                mskCPF.Clear();
                mskRG.Clear();
                txtEndereco.Clear();
                mskCEP.Clear();
                dtpNascimento.Text = DateTime.Now.Date.ToString();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void ReceberDados()
        {
            try
            {
                lblIdCliente.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCPF.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                mskRG.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString(); ;
                txtEndereco.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString(); ;
                mskCEP.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString(); ;
                mskTelefone1.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone2.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString(); ;
                txtEmail.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpNascimento.Text = dgvClientes[9, dgvClientes.CurrentRow.Index].Value.ToString(); ;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.CliNome = txtNome.Text;
                cliente.CliEmail = txtEmail.Text;
                cliente.CliTelefone1 = mskTelefone1.Text;
                cliente.CliTelefone2 = mskTelefone2.Text;
                cliente.CliCPF = mskCPF.Text;
                cliente.CliRG = mskRG.Text;
                cliente.CliEndereco = txtEndereco.Text;
                cliente.CliCEP = mskCEP.Text;
                cliente.CliDataNascimento = dtpNascimento.Text;

                lblMensagem.Text = objClientesBll.InserirCliente(cliente);
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIdCliente.Text == "")
                {
                    lblMensagem.Text = "Selecione um cliente para poder alterá-lo.";
                }
                else
                {
                    cliente.CliId = Convert.ToInt32(lblIdCliente.Text);
                    cliente.CliNome = txtNome.Text;
                    cliente.CliEmail = txtEmail.Text;
                    cliente.CliTelefone1 = mskTelefone1.Text;
                    cliente.CliTelefone2 = mskTelefone2.Text;
                    cliente.CliCPF = mskCPF.Text;
                    cliente.CliRG = mskRG.Text;
                    cliente.CliEndereco = txtEndereco.Text;
                    cliente.CliCEP = mskCEP.Text;
                    cliente.CliDataNascimento = dtpNascimento.Text;

                    lblMensagem.Text = objClientesBll.AlterarCliente(cliente);
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
            try
            {
                if (lblIdCliente.Text == "")
                {
                    lblMensagem.Text = "Selecione um cliente para poder excluí-lo";
                }
                else
                {
                    cliente.CliId = Convert.ToInt32(lblIdCliente.Text);
                    lblMensagem.Text = objClientesBll.ExcluirCliente(cliente);
                    AtualizarGrid();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
            AtualizarGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtPesquisar.Text;
                dgvClientes.DataSource = objClientesBll.ListarClientes(filtro);
                FormatarGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}
