using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClean.App.Classes
{
    public class Apoio
    {
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
    }
}
