
/// Criar as funções de interação da biblioteca principal (formulários)
	{
		- Adicionar Referência a biblioteca "Modelos"
		- Adicionar Referência a biblioteca "BLL"

		using Projeto.Modelos
		using Projeto.BLL

		ModeloExemplo exemplo = new ModeloExemplo();
        ExemploBll objExemploBll = new ExemploBll();

		private void AtualizarGrid()
        {
            try
            {
                string filtro = "";
                dgvExemplo.DataSource = objExemploBll.ListarExemplo(filtro);
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
                dgvExemplo.Columns[0].HeaderText = "ID";
                dgvExemplo[0].Width = 80;
                dgvExemplo[1].HeaderText = "Nome";
                dgvExemplo[1].Width = 200;
                dgvExemplo[2].HeaderText = "E-Mail";
                dgvExemplo[2].Width = 150;
                dgvExemplo[3].HeaderText = "Telefone";
                dgvExemplo[3].Width = 150;
                dgvExemplo[4].HeaderText = "CPF";
                dgvExemplo[4].Width = 150;
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
                txtPesquisar.Clear();
                mskCPF.Clear();
                mskTelefone.Clear();
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
                lblIdCliente.Text = dgvExemplo[0, dgvExemplo.CurrentRow.Index].Value.ToString();
                txtNome.Text = 		dgvExemplo[1, dgvExemplo.CurrentRow.Index].Value.ToString();
                txtEmail.Text =		dgvExemplo[2, dgvExemplo.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = 	dgvExemplo[3, dgvExemplo.CurrentRow.Index].Value.ToString();
                mskCPF.Text = 		dgvExemplo[4, dgvExemplo.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
	}