using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class FileLogger : ILogger
    {
        //Loglama:Yapılan çalışmaların bir yere kaydedilmesi.
        public void Log()
        {
            Console.WriteLine("Dosya loglandı.");
        }
    }
}
