namespace Imobiliaria
{
    partial class frmImoveis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImoveis));
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.lblIdImoveis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvImoveis = new System.Windows.Forms.DataGridView();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbComodos = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numVagasGaragem = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numBanheiros = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numSuites = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numDormitorios = new System.Windows.Forms.NumericUpDown();
            this.gpbClassificacao = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTipoImovel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rdbCondominioNao = new System.Windows.Forms.RadioButton();
            this.rdbCondominioSim = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMetragem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAluguel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIPTU = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnServicos = new System.Windows.Forms.Button();
            this.gpbDono = new System.Windows.Forms.GroupBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).BeginInit();
            this.gpbComodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVagasGaragem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBanheiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSuites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormitorios)).BeginInit();
            this.gpbClassificacao.SuspendLayout();
            this.gpbDono.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Location = new System.Drawing.Point(104, 88);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(254, 20);
            this.txtEndereco.TabIndex = 98;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnAlterar,
            this.btnExcluir,
            this.btnLimpar,
            this.toolStripSeparator1,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 93;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Teal;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(60, 22);
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Teal;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 22);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblIdImoveis
            // 
            this.lblIdImoveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdImoveis.Location = new System.Drawing.Point(104, 32);
            this.lblIdImoveis.Name = "lblIdImoveis";
            this.lblIdImoveis.Size = new System.Drawing.Size(56, 23);
            this.lblIdImoveis.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Id Imóvel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Imóvel:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(455, 437);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 23);
            this.btnPesquisar.TabIndex = 999;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(264, 437);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(185, 20);
            this.txtPesquisar.TabIndex = 110;
            // 
            // dgvImoveis
            // 
            this.dgvImoveis.AllowUserToAddRows = false;
            this.dgvImoveis.AllowUserToDeleteRows = false;
            this.dgvImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImoveis.Location = new System.Drawing.Point(25, 250);
            this.dgvImoveis.Name = "dgvImoveis";
            this.dgvImoveis.ReadOnly = true;
            this.dgvImoveis.Size = new System.Drawing.Size(682, 177);
            this.dgvImoveis.TabIndex = 1000;
            this.dgvImoveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImoveis_CellClick);
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(104, 114);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(122, 20);
            this.txtBairro.TabIndex = 99;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(104, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 96;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensagem.Location = new System.Drawing.Point(195, 487);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(342, 23);
            this.lblMensagem.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Mensagem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Pesquisar:";
            // 
            // gpbComodos
            // 
            this.gpbComodos.Controls.Add(this.label11);
            this.gpbComodos.Controls.Add(this.numVagasGaragem);
            this.gpbComodos.Controls.Add(this.label10);
            this.gpbComodos.Controls.Add(this.numBanheiros);
            this.gpbComodos.Controls.Add(this.label9);
            this.gpbComodos.Controls.Add(this.numSuites);
            this.gpbComodos.Controls.Add(this.label8);
            this.gpbComodos.Controls.Add(this.numDormitorios);
            this.gpbComodos.Location = new System.Drawing.Point(383, 110);
            this.gpbComodos.Name = "gpbComodos";
            this.gpbComodos.Size = new System.Drawing.Size(149, 129);
            this.gpbComodos.TabIndex = 108;
            this.gpbComodos.TabStop = false;
            this.gpbComodos.Text = "Comodos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Vagas Garagem";
            // 
            // numVagasGaragem
            // 
            this.numVagasGaragem.Location = new System.Drawing.Point(104, 99);
            this.numVagasGaragem.Name = "numVagasGaragem";
            this.numVagasGaragem.Size = new System.Drawing.Size(39, 20);
            this.numVagasGaragem.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Banheiros";
            // 
            // numBanheiros
            // 
            this.numBanheiros.Location = new System.Drawing.Point(104, 73);
            this.numBanheiros.Name = "numBanheiros";
            this.numBanheiros.Size = new System.Drawing.Size(39, 20);
            this.numBanheiros.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Suítes";
            // 
            // numSuites
            // 
            this.numSuites.Location = new System.Drawing.Point(104, 47);
            this.numSuites.Name = "numSuites";
            this.numSuites.Size = new System.Drawing.Size(39, 20);
            this.numSuites.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dormitórios";
            // 
            // numDormitorios
            // 
            this.numDormitorios.Location = new System.Drawing.Point(104, 21);
            this.numDormitorios.Name = "numDormitorios";
            this.numDormitorios.Size = new System.Drawing.Size(39, 20);
            this.numDormitorios.TabIndex = 0;
            // 
            // gpbClassificacao
            // 
            this.gpbClassificacao.Controls.Add(this.label12);
            this.gpbClassificacao.Controls.Add(this.cboTipoImovel);
            this.gpbClassificacao.Controls.Add(this.label13);
            this.gpbClassificacao.Controls.Add(this.rdbCondominioNao);
            this.gpbClassificacao.Controls.Add(this.rdbCondominioSim);
            this.gpbClassificacao.Location = new System.Drawing.Point(549, 111);
            this.gpbClassificacao.Name = "gpbClassificacao";
            this.gpbClassificacao.Size = new System.Drawing.Size(158, 129);
            this.gpbClassificacao.TabIndex = 109;
            this.gpbClassificacao.TabStop = false;
            this.gpbClassificacao.Text = "Classificação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tipo de Imóvel:";
            // 
            // cboTipoImovel
            // 
            this.cboTipoImovel.FormattingEnabled = true;
            this.cboTipoImovel.Items.AddRange(new object[] {
            "Apartamento",
            "Casa",
            "Casa de Praia",
            "Casa de Campo",
            "Chácara",
            "Cobertura",
            "Comercial",
            "Depósito",
            "Flat",
            "Kitnet",
            "Loft",
            "Mansão",
            "Sala",
            "Sobrado"});
            this.cboTipoImovel.Location = new System.Drawing.Point(18, 44);
            this.cboTipoImovel.Name = "cboTipoImovel";
            this.cboTipoImovel.Size = new System.Drawing.Size(121, 21);
            this.cboTipoImovel.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "É Condomínio?";
            // 
            // rdbCondominioNao
            // 
            this.rdbCondominioNao.AutoSize = true;
            this.rdbCondominioNao.Checked = true;
            this.rdbCondominioNao.Location = new System.Drawing.Point(90, 96);
            this.rdbCondominioNao.Name = "rdbCondominioNao";
            this.rdbCondominioNao.Size = new System.Drawing.Size(45, 17);
            this.rdbCondominioNao.TabIndex = 1;
            this.rdbCondominioNao.TabStop = true;
            this.rdbCondominioNao.Text = "Não";
            this.rdbCondominioNao.UseVisualStyleBackColor = true;
            // 
            // rdbCondominioSim
            // 
            this.rdbCondominioSim.AutoSize = true;
            this.rdbCondominioSim.Location = new System.Drawing.Point(28, 96);
            this.rdbCondominioSim.Name = "rdbCondominioSim";
            this.rdbCondominioSim.Size = new System.Drawing.Size(42, 17);
            this.rdbCondominioSim.TabIndex = 0;
            this.rdbCondominioSim.TabStop = true;
            this.rdbCondominioSim.Text = "Sim";
            this.rdbCondominioSim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "Zona:";
            // 
            // txtZona
            // 
            this.txtZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZona.Location = new System.Drawing.Point(273, 114);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(85, 20);
            this.txtZona.TabIndex = 100;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(104, 141);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(87, 20);
            this.mskCEP.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "CEP:";
            // 
            // txtMetragem
            // 
            this.txtMetragem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMetragem.Location = new System.Drawing.Point(260, 140);
            this.txtMetragem.Name = "txtMetragem";
            this.txtMetragem.Size = new System.Drawing.Size(98, 20);
            this.txtMetragem.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(197, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 116;
            this.label15.Text = "Metragem:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 118;
            this.label16.Text = "Aluguel:";
            // 
            // txtAluguel
            // 
            this.txtAluguel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAluguel.Location = new System.Drawing.Point(104, 167);
            this.txtAluguel.Name = "txtAluguel";
            this.txtAluguel.Size = new System.Drawing.Size(87, 20);
            this.txtAluguel.TabIndex = 103;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(219, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 120;
            this.label17.Text = "IPTU:";
            // 
            // txtIPTU
            // 
            this.txtIPTU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPTU.Location = new System.Drawing.Point(260, 166);
            this.txtIPTU.Name = "txtIPTU";
            this.txtIPTU.Size = new System.Drawing.Size(98, 20);
            this.txtIPTU.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 121;
            this.label18.Text = "Requisitos:";
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitos.Location = new System.Drawing.Point(104, 193);
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(254, 20);
            this.txtRequisitos.TabIndex = 105;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 123;
            this.label19.Text = "Obs:";
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(104, 219);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(254, 20);
            this.txtObs.TabIndex = 106;
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicos.Location = new System.Drawing.Point(235, 31);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(123, 25);
            this.btnServicos.TabIndex = 998;
            this.btnServicos.Text = "Serviços do Imovel  >>";
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // gpbDono
            // 
            this.gpbDono.Controls.Add(this.cboClientes);
            this.gpbDono.Location = new System.Drawing.Point(383, 31);
            this.gpbDono.Name = "gpbDono";
            this.gpbDono.Size = new System.Drawing.Size(324, 72);
            this.gpbDono.TabIndex = 107;
            this.gpbDono.TabStop = false;
            this.gpbDono.Text = "Dono";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(18, 33);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(287, 21);
            this.cboClientes.TabIndex = 0;
            // 
            // frmImoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 517);
            this.Controls.Add(this.gpbDono);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtRequisitos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIPTU);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAluguel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMetragem);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gpbClassificacao);
            this.Controls.Add(this.gpbComodos);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblIdImoveis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvImoveis);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImoveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de  Imóveis";
            this.Load += new System.EventHandler(this.frmImoveis_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImoveis)).EndInit();
            this.gpbComodos.ResumeLayout(false);
            this.gpbComodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVagasGaragem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBanheiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSuites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormitorios)).EndInit();
            this.gpbClassificacao.ResumeLayout(false);
            this.gpbClassificacao.PerformLayout();
            this.gpbDono.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Label lblIdImoveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvImoveis;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbComodos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numVagasGaragem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numBanheiros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSuites;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDormitorios;
        private System.Windows.Forms.GroupBox gpbClassificacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTipoImovel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbCondominioNao;
        private System.Windows.Forms.RadioButton rdbCondominioSim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMetragem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAluguel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIPTU;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.GroupBox gpbDono;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}