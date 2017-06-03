namespace Imobiliaria
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.opcClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.opcImovel = new System.Windows.Forms.ToolStripMenuItem();
            this.opcProfissional = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcRelFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.opcBlocoDeNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.opcInternet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblData = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblComputador = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTipo = new System.Windows.Forms.ToolStripLabel();
            this.lblFuncionario = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnProfissionais = new System.Windows.Forms.Button();
            this.btnImoveis = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastro,
            this.mnuRelatorios,
            this.mnuFerramentas,
            this.mnuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // opcSair
            // 
            this.opcSair.Image = ((System.Drawing.Image)(resources.GetObject("opcSair.Image")));
            this.opcSair.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.opcSair.Name = "opcSair";
            this.opcSair.Size = new System.Drawing.Size(93, 22);
            this.opcSair.Text = "Sair";
            this.opcSair.Click += new System.EventHandler(this.opcSair_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcClientes,
            this.opcImovel,
            this.opcProfissional,
            this.toolStripMenuItem1,
            this.opcFuncionarios});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // opcClientes
            // 
            this.opcClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opcClientes.Image = ((System.Drawing.Image)(resources.GetObject("opcClientes.Image")));
            this.opcClientes.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcClientes.Name = "opcClientes";
            this.opcClientes.Size = new System.Drawing.Size(152, 22);
            this.opcClientes.Text = "Clientes";
            this.opcClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // opcImovel
            // 
            this.opcImovel.Image = ((System.Drawing.Image)(resources.GetObject("opcImovel.Image")));
            this.opcImovel.Name = "opcImovel";
            this.opcImovel.Size = new System.Drawing.Size(152, 22);
            this.opcImovel.Text = "Imovel";
            this.opcImovel.Click += new System.EventHandler(this.btnImoveis_Click);
            // 
            // opcProfissional
            // 
            this.opcProfissional.Image = ((System.Drawing.Image)(resources.GetObject("opcProfissional.Image")));
            this.opcProfissional.Name = "opcProfissional";
            this.opcProfissional.Size = new System.Drawing.Size(152, 22);
            this.opcProfissional.Text = "Profissional";
            this.opcProfissional.Click += new System.EventHandler(this.btnProfissionais_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // opcFuncionarios
            // 
            this.opcFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("opcFuncionarios.Image")));
            this.opcFuncionarios.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcFuncionarios.Name = "opcFuncionarios";
            this.opcFuncionarios.Size = new System.Drawing.Size(152, 22);
            this.opcFuncionarios.Text = "Funcionários";
            this.opcFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.opcRelFuncionarios});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "Relatórios";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 6);
            // 
            // opcRelFuncionarios
            // 
            this.opcRelFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("opcRelFuncionarios.Image")));
            this.opcRelFuncionarios.Name = "opcRelFuncionarios";
            this.opcRelFuncionarios.Size = new System.Drawing.Size(142, 22);
            this.opcRelFuncionarios.Text = "Funcionários";
            // 
            // mnuFerramentas
            // 
            this.mnuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcCalculadora,
            this.opcCalendario,
            this.opcBlocoDeNotas,
            this.opcInternet});
            this.mnuFerramentas.Name = "mnuFerramentas";
            this.mnuFerramentas.Size = new System.Drawing.Size(84, 20);
            this.mnuFerramentas.Text = "Ferramentas";
            // 
            // opcCalculadora
            // 
            this.opcCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("opcCalculadora.Image")));
            this.opcCalculadora.Name = "opcCalculadora";
            this.opcCalculadora.Size = new System.Drawing.Size(154, 22);
            this.opcCalculadora.Text = "Calculadora";
            this.opcCalculadora.Click += new System.EventHandler(this.opcCalculadora_Click);
            // 
            // opcCalendario
            // 
            this.opcCalendario.Image = ((System.Drawing.Image)(resources.GetObject("opcCalendario.Image")));
            this.opcCalendario.Name = "opcCalendario";
            this.opcCalendario.Size = new System.Drawing.Size(154, 22);
            this.opcCalendario.Text = "Calendário";
            this.opcCalendario.Click += new System.EventHandler(this.opcCalendario_Click);
            // 
            // opcBlocoDeNotas
            // 
            this.opcBlocoDeNotas.Image = ((System.Drawing.Image)(resources.GetObject("opcBlocoDeNotas.Image")));
            this.opcBlocoDeNotas.Name = "opcBlocoDeNotas";
            this.opcBlocoDeNotas.Size = new System.Drawing.Size(154, 22);
            this.opcBlocoDeNotas.Text = "Bloco de Notas";
            this.opcBlocoDeNotas.Click += new System.EventHandler(this.opcBlocoDeNotas_Click);
            // 
            // opcInternet
            // 
            this.opcInternet.Image = ((System.Drawing.Image)(resources.GetObject("opcInternet.Image")));
            this.opcInternet.Name = "opcInternet";
            this.opcInternet.Size = new System.Drawing.Size(154, 22);
            this.opcInternet.Text = "Internet";
            this.opcInternet.Click += new System.EventHandler(this.opcInternet_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // opcSobre
            // 
            this.opcSobre.Image = ((System.Drawing.Image)(resources.GetObject("opcSobre.Image")));
            this.opcSobre.Name = "opcSobre";
            this.opcSobre.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.opcSobre.Size = new System.Drawing.Size(129, 22);
            this.opcSobre.Text = "Sobre";
            this.opcSobre.Click += new System.EventHandler(this.opcSobre_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblData,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.lblHora,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.lblComputador,
            this.toolStripSeparator6,
            this.lblTipo,
            this.lblFuncionario});
            this.toolStrip2.Location = new System.Drawing.Point(0, 397);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(684, 25);
            this.toolStrip2.TabIndex = 46;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(77, 22);
            this.lblData.Text = "dd/mm/aaaa";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 22);
            this.lblHora.Text = "hh:mm:ss";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel3.Text = "Computador:";
            // 
            // lblComputador
            // 
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(22, 22);
            this.lblComputador.Text = "PC";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTipo
            // 
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(73, 22);
            this.lblTipo.Text = "Funcionário:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(38, 22);
            this.lblFuncionario.Text = "nome";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnProfissionais);
            this.panel1.Controls.Add(this.btnImoveis);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 175);
            this.panel1.TabIndex = 48;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackgroundImage = global::Imobiliaria.Properties.Resources.clientes;
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionarios.Location = new System.Drawing.Point(510, 11);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(120, 154);
            this.btnFuncionarios.TabIndex = 3;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnProfissionais
            // 
            this.btnProfissionais.BackgroundImage = global::Imobiliaria.Properties.Resources.Profissionais;
            this.btnProfissionais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfissionais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfissionais.FlatAppearance.BorderSize = 0;
            this.btnProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfissionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfissionais.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProfissionais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfissionais.Location = new System.Drawing.Point(357, 11);
            this.btnProfissionais.Name = "btnProfissionais";
            this.btnProfissionais.Size = new System.Drawing.Size(120, 154);
            this.btnProfissionais.TabIndex = 2;
            this.btnProfissionais.Text = "Profissionais";
            this.btnProfissionais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfissionais.UseVisualStyleBackColor = false;
            this.btnProfissionais.Click += new System.EventHandler(this.btnProfissionais_Click);
            // 
            // btnImoveis
            // 
            this.btnImoveis.BackgroundImage = global::Imobiliaria.Properties.Resources.Imoveis;
            this.btnImoveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImoveis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImoveis.FlatAppearance.BorderSize = 0;
            this.btnImoveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImoveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImoveis.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImoveis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImoveis.Location = new System.Drawing.Point(186, 11);
            this.btnImoveis.Name = "btnImoveis";
            this.btnImoveis.Size = new System.Drawing.Size(120, 154);
            this.btnImoveis.TabIndex = 2;
            this.btnImoveis.Text = "Imóveis";
            this.btnImoveis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImoveis.UseVisualStyleBackColor = false;
            this.btnImoveis.Click += new System.EventHandler(this.btnImoveis_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::Imobiliaria.Properties.Resources.clientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(30, 11);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(120, 154);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 175);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Location = new System.Drawing.Point(347, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 175);
            this.panel3.TabIndex = 50;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 422);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imobiliária Juneco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem opcSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem opcClientes;
        private System.Windows.Forms.ToolStripMenuItem opcProfissional;
        private System.Windows.Forms.ToolStripMenuItem opcImovel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem opcCalculadora;
        private System.Windows.Forms.ToolStripMenuItem opcCalendario;
        private System.Windows.Forms.ToolStripMenuItem opcBlocoDeNotas;
        private System.Windows.Forms.ToolStripMenuItem opcInternet;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem opcSobre;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblHora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblComputador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel lblTipo;
        private System.Windows.Forms.ToolStripLabel lblFuncionario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opcRelFuncionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnImoveis;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnProfissionais;
    }
}

