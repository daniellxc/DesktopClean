using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClean.App.Classes
{
    public class Apoio
    {
        protected static Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public static void MensagemErro(string mensagem)
        {
           
            MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public static void MensagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensagemAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void SetarConfiguracao(string chave, string valor)
        {
            try
            {
                
                config.AppSettings.Settings.Remove(chave);
                config.Save(ConfigurationSaveMode.Modified);
                config.AppSettings.Settings.Add(chave, valor);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            {
                throw;
            }
          
        }

        public static string DiretorioDestino()
        {
            return ConfigurationManager.AppSettings["pathDestino"];
        }

        public static void GravarEmArquivoTexto(string texto, string path, string fileName,bool append)
        {
            if (Directory.Exists(path))
            {
                StreamWriter sw = new StreamWriter(path+"\\"+fileName,append);
                sw.WriteLine(texto);
                sw.Close();
            }
            else
            {
                throw new Exception("Diretório de destino do arquivo não existe.");
            }
            
        }
    }
}
