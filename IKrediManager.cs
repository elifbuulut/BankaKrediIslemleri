using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri// SOYUTLAMA, POLİMORFIZM, INTERFACES ANLATIM 
{
    interface IKrediManager
    {

        // 1)      if (KrediManager==x)
        //{
        //}     örn eğer kredi ihtiyaç kredisiyse söyle hesapla, taşıtsa böyle... demek bu alanı çorba eder
        //Zira rtalama bir bankada yüzlerce çeşit kredi var. 
        //bu tip durumlarda her biri kredi için ayrı class oluşturulur.

        void Hesapla();
        void BirseyYap();
        //2)imzanın aynı oldugu ama içriğinin farklı oldugu durumlarda base de oluşturdugumuz classı  interface olarak oluştururuz.
      
    }
}
