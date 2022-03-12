using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri// SOYUTLAMA, POLİMORFIZM, INTERFACES ANLATIM 
{  //bir sınıf bir interfsce i kullanıyorsa classlarımızın herbiri interfacein içeri ğini,bu methodları  yani tüm şaablonu içermek zorunda 
    //her class kendi kurallarını yazabilir.
    internal class TasitKrediManager : IKrediManager
    {
        public void BirseyYap()
        {

        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");

        }
    }
}
