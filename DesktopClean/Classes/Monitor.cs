using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClean.Classes
{
    public class Monitor
    {
        public Monitor()
        {
            FileSystemWatcher fsw = new FileSystemWatcher(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            fsw.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastWrite;

            fsw.Filter = "*.*";

            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.Changed += new FileSystemEventHandler(fsw_Created);
            fsw.EnableRaisingEvents = true;
           
           
        }

        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Area de trabalho modificada: " + e.FullPath);
        }

        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Area de trabalho modificada: " + e.FullPath);
        }
       
   
       
    }
}
