using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopClean.App.Classes;

namespace DesktopClean.Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarGravaEmArquivoTexto()
        {
            Apoio.GravarEmArquivoTexto("teste3\r\nteste3\r\n", "C:\\sgr","test.txt",true);

        }
    }
}
