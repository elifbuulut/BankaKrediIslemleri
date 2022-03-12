using System;

namespace BankaKrediIslemleri
{
    internal class FileLoggerServices : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı ");
        }
    }
}
