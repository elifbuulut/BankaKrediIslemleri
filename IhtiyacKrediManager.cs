using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri// SOYUTLAMA, POLİMORFIZM, INTERFACES ANLATIM 
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {

        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı"); 
        }
    }
}
