using DesktopClean.App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClean.App
{
    public partial class ConfigurarDiretorioDestino : Form
    {
        public ConfigurarDiretorioDestino()
        {
            InitializeComponent();
        }

        private void btnConsultarDiretorio_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDiretorioDestino.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSalvarConfiguracao_Click(object sender, EventArgs e)
        {
            try
            {
                Apoio.SetarConfiguracao("pathDestino", txtDiretorioDestino.Text);
                this.Close();
                
            }
            catch (Exception ex)
            {
                Apoio.MensagemErro("Não foi possível salvar a configuração. " + ex.Message);
            }
        }
    }
}
