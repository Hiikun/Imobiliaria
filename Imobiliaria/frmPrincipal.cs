using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imobiliaria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            string strData, strDia, strMes, strAno;
            strDia = DateTime.Now.Day.ToString("00");
            strMes = DateTime.Now.Month.ToString("00");
            strAno = DateTime.Now.Year.ToString("0000");
            strData = strDia + "/" + strMes + "/" + strAno;
            lblData.Text = strData;
            lblComputador.Text = Environment.MachineName;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            lblFuncionario.Text = Globais.strFuncionario;
            lblTipo.Text = Globais.strTipo + ": ";
            if (Globais.strTipo == "Administrador")
            {                
                opcFuncionarios.Enabled = true;
            }
            else
            {
                opcFuncionarios.Enabled = false;
                btnFuncionarios.Enabled = false;          
            }
        }

        private void opcSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void opcBlocoDeNotas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void opcInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bra.ifsp.edu.br");
        }

        private void opcCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario objFrmCalendario = new frmCalendario();
            objFrmCalendario.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strRelogio, strHora, strMinuto, strSegundo;
            strHora = DateTime.Now.Hour.ToString("00");
            strMinuto = DateTime.Now.Minute.ToString("00");
            strSegundo = DateTime.Now.Second.ToString("00");
            strRelogio = strHora + ":" + strMinuto + ":" + strSegundo;
            lblHora.Text = strRelogio;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (Globais.strTipo == "Administrador")
            {
                frmFuncionarios objFrmFuncionarios = new frmFuncionarios();
                objFrmFuncionarios.ShowDialog();
            }            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes objFrmClientes = new frmClientes();
            objFrmClientes.ShowDialog();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            frmProfissionais objFrmProfissionais = new frmProfissionais();
            objFrmProfissionais.ShowDialog();
        }

        private void btnImoveis_Click(object sender, EventArgs e)
        {
            frmImoveis objFrmImoveis = new frmImoveis();
            objFrmImoveis.ShowDialog();
        }

        private void opcSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para mais informações acesse nosso site:\n https://www.junecoenterprise.com.br","Informações",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
