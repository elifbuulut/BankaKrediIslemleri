using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri
{
    internal class DatabaseLoggerServices : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı ");
        }
    }
}
