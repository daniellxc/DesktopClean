using DesktopClean.App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DesktopClean.App
{
    public partial class Form1 : Form
    {

        #region Propriedades

        public string PathDestino
        {
            get
            {
                if (Directory.Exists(Apoio.DiretorioDestino()))
                    return Apoio.DiretorioDestino();
                else
                    throw new Exception("Nenhum diretório de destino configurado.");

            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();

           
           
        }




        private void Form1_Load(object sender, EventArgs e)
        {
             try

            {
                toolStripStatusLabel1.Text = "Destino: " + Apoio.DiretorioDestino();
                //caminho da pasta que o FileSystemWatcher irá monitorar (atribuo o valor do TextBox)

                fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                //tipos de filtro que o FileSystemWatcher irá considerar

               // fsw.Filter = txtFiltro.Text;

                //lista de atributos que irão disparar eventos

                fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.CreationTime;

                //permitir a monitoração (sem o valor estar como true, é impossível do FSW monitorar os arquivos)

                fsw.EnableRaisingEvents = true;

                //monitorar subdiretórios (atribuo o valor do checkbox. Como está checado, assume o valor true)

                fsw.IncludeSubdirectories = false;

                //uso a propriedade abaixo como false para evitar o erro de chamada ilegal de thread, que pode

                //acessar um controle em outra thread aconteça. Se isso acontecer, será disparado uma exceção.

                CheckForIllegalCrossThreadCalls = false;

                //uso do WaitForChangedResults (mostrado no artigo) para Windows Services e Console Application"s

                //instancio a classe WaitForChangedResults, passando o FSW com o método WaitForChanged e dois

                //parâmetros: o tipo de modificações que ele irá aguardar, que no caso são todas, e o tempo de

                //espera para que sejam disparados estes eventos, que será de 10 segundos.

                WaitForChangedResult wcr = fsw.WaitForChanged(WatcherChangeTypes.All, 10000);

                //faço uma verificação, se der Timeout (passar o tempo esperado de 10 segundos),

                //disparo um aviso. Se não der Timeout, exibo o Nome do Evento e o Tipo dele.

                if (wcr.TimedOut)

                {

                    Console.WriteLine("Já se passaram 10 minutos do evento");

                }

                else

                {

                    Console.WriteLine("Evento: " + wcr.Name, wcr.ChangeType.ToString());

                }

            }

            catch (Exception)

            {

                throw;

            }


        }

        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                txtNotificacoes.Text += DateTime.Now.ToString() + Environment.NewLine;

                txtNotificacoes.Text += String.Format("Alteração: {0} {1}", e.FullPath, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

                txtNotificacoes.Text += String.Format("----------------------- {0}", Environment.NewLine);

                MoverArquivo(e.FullPath, PathDestino);
            }
            catch (Exception ex)
            {
                Apoio.MensagemErro(ex.Message);
            }
           

        }

        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                txtNotificacoes.Text += DateTime.Now.ToString() + Environment.NewLine;

                txtNotificacoes.Text += String.Format("Criação: {0} {1}", e.FullPath, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

                txtNotificacoes.Text += String.Format("----------------------- {0}", Environment.NewLine);

                MoverArquivo(e.FullPath, PathDestino);
            }
            catch (Exception ex)
            {
                Apoio.MensagemErro(ex.Message);
            }
        

        }

        private void MoverArquivo(string pathOrigem, string pathDestino)
        {
            try
            {
                FileInfo fi = new FileInfo(pathOrigem);

                File.Move(pathOrigem, pathDestino + "\\" + fi.Name);
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível mover o arquivo. " + ex.Message);
            }
        }

        private void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            try
            {
                txtNotificacoes.Text += DateTime.Now.ToString() + Environment.NewLine;

                txtNotificacoes.Text += String.Format("Criação: {0} {1}", e.FullPath, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

                txtNotificacoes.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

                txtNotificacoes.Text += String.Format("----------------------- {0}", Environment.NewLine);

                MoverArquivo(e.FullPath,PathDestino);
            }
            catch (Exception ex)
            {
                Apoio.MensagemErro(ex.Message);
            }
        
        }

     

        private void notificacao_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
              
                notificacao.Visible = true;
                notificacao.BalloonTipText = "Monitorando...";
                notificacao.BalloonTipTitle = "DesktopClean";
                notificacao.ShowBalloonTip(100);

            }
               
        }

      

        private void diretórioDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConfigurarDiretorioDestino().ShowDialog(this);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Destino: " + Apoio.DiretorioDestino();
        }
    }
}
