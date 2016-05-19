using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClean.App.Classes
{
    public class Log
    {
        public static void Loggar(string mensagemLog)
        {
            Apoio.GravarEmArquivoTexto(DateTime.Now.ToString() + " - " + mensagemLog, Application.StartupPath, "log.txt", true);
        }

        public static void LoggarInicio()
        {
            Loggar("Aplicação Iniciada");
        }

        public static void LoggarSaida()
        {
            Loggar("Aplicação Encerrada");
        }

    }
}
