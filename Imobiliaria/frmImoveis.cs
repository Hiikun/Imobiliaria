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
    public partial class frmImoveis : Form
    {
        ImoveisModelo imoveis = new ImoveisModelo();
        ImoveisBll objImoveisBll = new ImoveisBll();

        public frmImoveis()
        {
            InitializeComponent();
        }

        private int EncontrarCliente(string id)
        {
            for (int i = 0; i < cboClientes.Items.Count; i++)
            {
                string item = cboClientes.GetItemText(cboClientes.Items[i]);
                int index = item.IndexOf(':');
                if (item.Substring(0, index) == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void AtualizarGrid()
        {
            try
            {
                string filtro = "";
                dgvImoveis.DataSource = objImoveisBll.ImoveisListar(filtro);
            }
            catch (Exception ex)
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
                dgvImoveis.Columns[0].HeaderText = "ID";
                dgvImoveis.Columns[0].Width = 50;
                dgvImoveis.Columns[1].HeaderText = "Cliente";
                dgvImoveis.Columns[1].Width = 50;
                dgvImoveis.Columns[2].HeaderText = "Imovel";
                dgvImoveis.Columns[2].Width = 150;
                dgvImoveis.Columns[3].HeaderText = "Endereco";
                dgvImoveis.Columns[3].Width = 150;
                dgvImoveis.Columns[4].HeaderText = "Bairro";
                dgvImoveis.Columns[4].Width = 100;
                dgvImoveis.Columns[5].HeaderText = "Zona";
                dgvImoveis.Columns[5].Width = 80;
                dgvImoveis.Columns[6].HeaderText = "Cep";
                dgvImoveis.Columns[6].Width = 80;
                dgvImoveis.Columns[7].HeaderText = "Tipo";
                dgvImoveis.Columns[7].Width = 80;
                dgvImoveis.Columns[8].HeaderText = "Condominio";
                dgvImoveis.Columns[8].Width = 50;
                dgvImoveis.Columns[9].HeaderText = "Metragem";
                dgvImoveis.Columns[9].Width = 100;
                dgvImoveis.Columns[10].HeaderText = "Dorm";
                dgvImoveis.Columns[10].Width = 50;
                dgvImoveis.Columns[11].HeaderText = "Banh";
                dgvImoveis.Columns[11].Width = 50;
                dgvImoveis.Columns[12].HeaderText = "Suit";
                dgvImoveis.Columns[12].Width = 50;
                dgvImoveis.Columns[13].HeaderText = "Vagas";
                dgvImoveis.Columns[13].Width = 50;
                dgvImoveis.Columns[14].HeaderText = "Aluguel";
                dgvImoveis.Columns[14].Width = 50;
                dgvImoveis.Columns[15].HeaderText = "IPTU";
                dgvImoveis.Columns[15].Width = 120;
                dgvImoveis.Columns[16].HeaderText = "Requisitos";
                dgvImoveis.Columns[16].Width = 150;
                dgvImoveis.Columns[17].HeaderText = "Obs";
                dgvImoveis.Columns[17].Width = 150;

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
                lblIdImoveis.Text = "";
                txtNome.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtZona.Clear();
                mskCEP.Clear();
                txtMetragem.Clear();
                txtAluguel.Clear();
                txtIPTU.Clear();
                txtRequisitos.Clear();
                txtObs.Clear();
                txtPesquisar.Clear();

                cboClientes.SelectedIndex = -1;

                numDormitorios.Value = 0;
                numSuites.Value = 0;
                numBanheiros.Value = 0;
                numVagasGaragem.Value = 0;

                cboTipoImovel.SelectedIndex = -1;
                rdbCondominioNao.Checked = true;
                rdbCondominioSim.Checked = false;

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
                lblIdImoveis.Text = dgvImoveis[0, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvImoveis[2, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvImoveis[3, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvImoveis[4, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtZona.Text = dgvImoveis[5, dgvImoveis.CurrentRow.Index].Value.ToString();
                mskCEP.Text = dgvImoveis[6, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtMetragem.Text = dgvImoveis[9, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtAluguel.Text = dgvImoveis[14, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtIPTU.Text = dgvImoveis[15, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtRequisitos.Text = dgvImoveis[16, dgvImoveis.CurrentRow.Index].Value.ToString();
                txtObs.Text = dgvImoveis[17, dgvImoveis.CurrentRow.Index].Value.ToString();               
                txtNome.Focus();

                cboClientes.SelectedIndex = EncontrarCliente(dgvImoveis[1, dgvImoveis.CurrentRow.Index].Value.ToString());

                numDormitorios.Value = Convert.ToInt32(dgvImoveis[10, dgvImoveis.CurrentRow.Index].Value.ToString());
                numSuites.Value = Convert.ToInt32(dgvImoveis[11, dgvImoveis.CurrentRow.Index].Value.ToString());
                numBanheiros.Value = Convert.ToInt32(dgvImoveis[12, dgvImoveis.CurrentRow.Index].Value.ToString());
                numVagasGaragem.Value = Convert.ToInt32(dgvImoveis[13, dgvImoveis.CurrentRow.Index].Value.ToString());

                cboTipoImovel.Text = dgvImoveis[7, dgvImoveis.CurrentRow.Index].Value.ToString();

                rdbCondominioSim.Checked = Convert.ToBoolean(dgvImoveis[8, dgvImoveis.CurrentRow.Index].Value.ToString());
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void frmImoveis_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            ClientesBll objClientesBll = new ClientesBll();
            ClientesLista listaCliente = objClientesBll.ListarClientes("");

            foreach (ClientesModelo c in listaCliente)
            {
                cboClientes.Items.Add(c.CliId + ": " + c.CliNome);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                imoveis.NomeImovel = txtNome.Text;
                imoveis.Endereco = txtEndereco.Text;
                imoveis.Bairro = txtBairro.Text;
                imoveis.ZonaCidade = txtZona.Text;
                imoveis.Cep = mskCEP.Text;
                imoveis.Metragem = Convert.ToDouble(txtMetragem.Text);
                imoveis.ValorAluguelSugerido = Convert.ToDouble(txtAluguel.Text);
                imoveis.ValorIptu = Convert.ToDouble(txtIPTU.Text);
                imoveis.RequisitosInquilino = txtRequisitos.Text;
                imoveis.Obs = txtObs.Text;

                imoveis.IdCliente = Convert.ToInt32(cboClientes.Text.Substring(0, cboClientes.Text.IndexOf(':')));

                imoveis.Dormitorios = (int)numBanheiros.Value;
                imoveis.Suites = (int)numSuites.Value;
                imoveis.Banheiros = (int)numBanheiros.Value;
                imoveis.VagasGaragem = (int)numVagasGaragem.Value;

                imoveis.TipoImovel = cboTipoImovel.Text;

                imoveis.Condominio = rdbCondominioSim.Checked;

                lblMensagem.Text = objImoveisBll.ImoveisInserir(imoveis);
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
                if (lblIdImoveis.Text == "")
                {
                    lblMensagem.Text = "Selecione um imoveis para poder alterá-lo.";
                }
                else
                {
                    imoveis.IdImovel = Convert.ToInt32(lblIdImoveis.Text);
                    imoveis.NomeImovel = txtNome.Text;
                    imoveis.Endereco = txtEndereco.Text;
                    imoveis.Bairro = txtBairro.Text;
                    imoveis.ZonaCidade = txtZona.Text;
                    imoveis.Cep = mskCEP.Text;
                    imoveis.Metragem = Convert.ToDouble(txtMetragem.Text);
                    imoveis.ValorAluguelSugerido = Convert.ToDouble(txtAluguel.Text);
                    imoveis.ValorIptu = Convert.ToDouble(txtIPTU.Text);
                    imoveis.RequisitosInquilino = txtRequisitos.Text;
                    imoveis.Obs = txtObs.Text;

                    imoveis.IdCliente = Convert.ToInt32(cboClientes.Text.Substring(0, cboClientes.Text.IndexOf(':')));

                    imoveis.Dormitorios = (int)numBanheiros.Value;
                    imoveis.Suites = (int)numSuites.Value;
                    imoveis.Banheiros = (int)numBanheiros.Value;
                    imoveis.VagasGaragem = (int)numVagasGaragem.Value;

                    imoveis.TipoImovel = cboTipoImovel.Text;

                    imoveis.Condominio = rdbCondominioSim.Checked;

                    lblMensagem.Text = objImoveisBll.ImoveisAlterar(imoveis);
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
                if (lblIdImoveis.Text == "")
                {
                    lblMensagem.Text = "Selecione um imoveis para poder excluí-lo";
                }
                else
                {
                    imoveis.IdImovel = Convert.ToInt32(lblIdImoveis.Text);
                    lblMensagem.Text = objImoveisBll.ImoveisExcluir(imoveis);
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
                dgvImoveis.DataSource = objImoveisBll.ImoveisListar(filtro);
                FormatarGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void dgvImoveis_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (lblIdImoveis.Text != "")
            {
                Globais.dadosImovel = lblIdImoveis.Text + ": " + txtNome.Text;
                frmServicoImovel objFrmServicos = new frmServicoImovel();
                objFrmServicos.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Selecione um imóvel para cadastrar um serviço!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}