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
    public partial class frmProfissionais : Form
    {
        ModeloProfissional profissional = new ModeloProfissional();
        ProfissionaisBll objProfissionaisBll = new ProfissionaisBll();

        public frmProfissionais()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            try
            {
                string filtro = "";
                dgvProfissionais.DataSource = objProfissionaisBll.ListaProfissionais(filtro);
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
                dgvProfissionais.Columns[0].HeaderText = "ID";
                dgvProfissionais.Columns[0].Width = 50;
                dgvProfissionais.Columns[1].HeaderText = "Nome";
                dgvProfissionais.Columns[1].Width = 100;
                dgvProfissionais.Columns[2].HeaderText = "Profissão";
                dgvProfissionais.Columns[2].Width = 100;
                dgvProfissionais.Columns[3].HeaderText = "Telefone 1";
                dgvProfissionais.Columns[3].Width = 100;
                dgvProfissionais.Columns[4].HeaderText = "Telefone 2";
                dgvProfissionais.Columns[4].Width = 100;
                dgvProfissionais.Columns[5].HeaderText = "Valor Hora";
                dgvProfissionais.Columns[5].Width = 100;
                dgvProfissionais.Columns[6].HeaderText = "Obs";
                dgvProfissionais.Columns[6].Width = 100;
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
                lblIdProfissionais.Text = "";
                txtNome.Clear();
                txtProfissao.Clear();
                txtPesquisar.Clear();
                txtValorHora.Clear();
                mskTelefone1.Clear();
                mskTelefone2.Clear();
                txtObs.Clear();
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
                lblIdProfissionais.Text = dgvProfissionais[0, dgvProfissionais.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvProfissionais[1, dgvProfissionais.CurrentRow.Index].Value.ToString();
                txtProfissao.Text = dgvProfissionais[2, dgvProfissionais.CurrentRow.Index].Value.ToString();
                mskTelefone1.Text = dgvProfissionais[3, dgvProfissionais.CurrentRow.Index].Value.ToString();
                mskTelefone2.Text = dgvProfissionais[4, dgvProfissionais.CurrentRow.Index].Value.ToString();
                txtValorHora.Text = dgvProfissionais[5, dgvProfissionais.CurrentRow.Index].Value.ToString();
                txtObs.Text = dgvProfissionais[6, dgvProfissionais.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                profissional.ProfNome = txtNome.Text;
                profissional.ProfObs = txtObs.Text;
                profissional.ProfProfissao = txtProfissao.Text;
                profissional.ProfTel1 = mskTelefone1.Text;
                profissional.ProfTel2 = mskTelefone2.Text;
                profissional.ProfValorHora = Convert.ToDouble(txtValorHora.Text);

                lblMensagem.Text = objProfissionaisBll.Inserir(profissional);
                lblIdProfissionais.Text = profissional.ProfId.ToString();
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
                if (lblIdProfissionais.Text == "")
                {
                    lblMensagem.Text = "Selecione um profissional para poder alterá-lo.";
                }
                else
                {
                    profissional.ProfId = Convert.ToInt32(lblIdProfissionais.Text);
                    profissional.ProfNome = txtNome.Text;
                    profissional.ProfObs = txtObs.Text;
                    profissional.ProfProfissao = txtProfissao.Text;
                    profissional.ProfTel1 = mskTelefone1.Text;
                    profissional.ProfTel2 = mskTelefone2.Text;
                    profissional.ProfValorHora = Convert.ToDouble(txtValorHora.Text);

                    lblMensagem.Text = objProfissionaisBll.Alterar(profissional);
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
                if (lblIdProfissionais.Text == "")
                {
                    lblMensagem.Text = "Selecione um profissional para poder excluí-lo";
                }
                else
                {
                    profissional.ProfId = Convert.ToInt32(lblIdProfissionais.Text);
                    objProfissionaisBll.Excluir(profissional);
                    lblMensagem.Text = objProfissionaisBll.Mensagem;
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
                dgvProfissionais.DataSource = objProfissionaisBll.ListaProfissionais(filtro);
                FormatarGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void dgvProfissionais_CellClick(object sender, DataGridViewCellEventArgs e)
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
