using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri // SOYUTLAMA, POLİMORFIZM, INTERFACES ANLATIM 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //not: C# Abstraction (Soyutlama) = Karmaşıklığı yönetmek için kullanılır.
            //Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir


            // KrediManager bir interface. Bu interface kuralları içerir ve onu implimente eden classlar o kuralları kendine göre doldurmak durumunda.
            // Interfaceleri genel olarak operasyonlarla kullanıyoruz. 
           // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); yerine 
           IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
          // ihtiyacKrediManager.Hesapla();
            //diyebiliriz. yani interfaceler o interfacei implimente eden classın referans numarasını tutabiliyor !

            IKrediManager tasitKrediManager =new TasitKrediManager();
          //  tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
          //  konutKrediManager.Hesapla();
           ILoggerServices databaseLoggerServices = new DatabaseLoggerServices();
            ILoggerServices fileLoggerServices=new FileLoggerServices();
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);  // kullanıcı seçimi olarak düşün!Artık burda ne seçilirse belleğe o gönderiliyor

            List<IKrediManager> krediler=new List<IKrediManager>
            {
                ihtiyacKrediManager,  tasitKrediManager
            };
            basvuruManager.KrediOnBilgilendirme(krediler);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerServices);
            Console.ReadLine();

            //INTERFACELRİ BİRBİRİNİN ALTERNATİFİ OLAN AMA KOD İÇERİKLERİ FARKLI OLAN DURUMLAR İÇİN KULLANIRIZ. KREDİ TÜRÜNÜN HEPSİNDE 
            //GERİ ODEME İÇİN HESAPLA () VARDIR HEPSİNDE DE AMA FAİZ ORANI FARKLIDIR. KREDİNİN TÜRÜNE GORE HESAPLAMA İŞLERİ DEĞİŞKENLİK GOSTERİR







        }
    }
}
