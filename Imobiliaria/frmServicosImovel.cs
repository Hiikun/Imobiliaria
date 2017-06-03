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
    public partial class frmServicoImovel : Form
    {
        ServicoImovelModelo servico = new ServicoImovelModelo();
        ServicoImoveisBll objServicoImovelBll = new ServicoImoveisBll();
        private int idImovel;

        public frmServicoImovel()
        {
            InitializeComponent();
        }

        private int EncontrarProfissional(string id)
        {
            for (int i = 0; i < cboProfissionais.Items.Count; i++)
            {
                string item = cboProfissionais.GetItemText(cboProfissionais.Items[i]);
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
                string filtro = idImovel.ToString();
                dgvServicoImovel.DataSource = objServicoImovelBll.ListarServicos(filtro);
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
                dgvServicoImovel.Columns[0].HeaderText = "ID";
                dgvServicoImovel.Columns[0].Width = 50;
                dgvServicoImovel.Columns[1].HeaderText = "Profissional ID";
                dgvServicoImovel.Columns.Remove("SerImovelId");
                dgvServicoImovel.Columns[1].Width = 50;
                dgvServicoImovel.Columns[2].HeaderText = "Data Serviço";
                dgvServicoImovel.Columns[2].Width = 80;
                dgvServicoImovel.Columns[3].HeaderText = "Valor";
                dgvServicoImovel.Columns[3].Width = 100;
                dgvServicoImovel.Columns[4].HeaderText = "Obs";
                dgvServicoImovel.Columns[4].Width = 150;
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
                lblIdServicoImovel.Text = "";
                cboProfissionais.SelectedIndex = -1;
                txtValor.Text = "R$ 0,00";
                txtPesquisar.Clear();
                cboProfissionais.Focus();
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
                lblIdServicoImovel.Text = dgvServicoImovel[0, dgvServicoImovel.CurrentRow.Index].Value.ToString();
                dateTimePicker1.Text = dgvServicoImovel[2, dgvServicoImovel.CurrentRow.Index].Value.ToString();
                txtValor.Text = dgvServicoImovel[3, dgvServicoImovel.CurrentRow.Index].Value.ToString();

                txtObs.Text = dgvServicoImovel[4, dgvServicoImovel.CurrentRow.Index].Value.ToString();

                cboProfissionais.SelectedIndex = EncontrarProfissional(dgvServicoImovel[1, dgvServicoImovel.CurrentRow.Index].Value.ToString());
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void frmServicoImovel_Load(object sender, EventArgs e)
        {
            lblDadosImovel.Text = Globais.dadosImovel;
            idImovel = Convert.ToInt32(lblDadosImovel.Text.Substring(0, lblDadosImovel.Text.IndexOf(':')));
            Globais.dadosImovel = "";

            AtualizarGrid();

            ProfissionaisBll objProfissionaisBll = new ProfissionaisBll();
            ListaProfissionais listaProfissionais = objProfissionaisBll.ListaProfissionais("");

            foreach (ProfissionalModelo p in listaProfissionais)
            {
                cboProfissionais.Items.Add(p.ProfId + ": " + p.ProfNome + " - " + p.ProfProfissao);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                servico.SerImovelId = idImovel;
                servico.SerProfissionalId = Convert.ToInt32(cboProfissionais.Text.Substring(0, cboProfissionais.Text.IndexOf(':')));
                servico.SerValor = Convert.ToDouble(txtValor.Text);
                servico.SerData = dateTimePicker1.Text;
                servico.SerObs = txtObs.Text;

                lblMensagem.Text = objServicoImovelBll.InserirServico(servico);
                lblIdServicoImovel.Text = servico.SerId.ToString();
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
                if (lblIdServicoImovel.Text == "")
                {
                    lblMensagem.Text = "Selecione um servico para poder alterá-lo.";
                }
                else
                {
                    servico.SerId = Convert.ToInt32(lblIdServicoImovel.Text);
                    servico.SerImovelId = idImovel;
                    servico.SerProfissionalId = Convert.ToInt32(cboProfissionais.Text.Substring(0, cboProfissionais.Text.IndexOf(':')));
                    servico.SerValor = Convert.ToDouble(txtValor.Text);
                    servico.SerData = dateTimePicker1.Text;
                    servico.SerObs = txtObs.Text;

                    lblMensagem.Text = objServicoImovelBll.AlterarServico(servico);
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
                if (lblIdServicoImovel.Text == "")
                {
                    lblMensagem.Text = "Selecione um servico para poder excluí-lo";
                }
                else
                {
                    servico.SerId = Convert.ToInt32(lblIdServicoImovel.Text);
                    lblMensagem.Text = objServicoImovelBll.ExcluirServico(servico);
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
                dgvServicoImovel.DataSource = objServicoImovelBll.ListarServicos(filtro);
                FormatarGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void dgvServicoImovel_CellClick(object sender, DataGridViewCellEventArgs e)
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