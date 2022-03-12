using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediIslemleri // SOYUTLAMA, POLİMORFIZM, INTERFACES ANLATIM 
{
    internal class BasvuruManager
    {
        // başvuru sonucunda hesaplama yaptıktan sonra ,hangi log seçildiyse sistemde onu loglasın. Method injection.Soyut halleri var somut hallerini enjekte ediyorum

        // kredi başvuru işleri 
        public void BasvuruYap(IKrediManager krediManager,ILoggerServices loggerServices) // hangi krediye başvuracaksam o krediyi geitrecek.( Method injection)
                                                           // Herkesin bilgisini tutan IKrediManager!!
        // HEPSİNİN REFERANSINI TUTAN IKrediManager. 
        //Başvuruyu kredi bağımsız hale getirdim.Artık buraya konut, ihtiyaç,tasit kredisi gönderebilirim. 
        // (IKrediManager krediManager)   eğer ben buraya ihtiyaç kredisi gönderirsem, bellekte ki ihtyiaç kredisinin referansı çalışır
        {
            
            krediManager.Hesapla();
            loggerServices.Log();
            
           
            



        }
        //--------------------------------------------------------------------------------------------------------------------
        //POLİMORFİZM BASİTLEŞTİRME (Çok çeşitlilik)
        //Krediye ihtiyacımız var, bankaya gittik.Ordaki memura kredi çekmek istedigimizi, soyluyoruz. Memur hangi amaçla çekmek istedigimizi
        //soruyor. Araba alacagımızı soyluyoruz. Ne kadar çekmek istedigimizi soruyor - 30 bin diyoruz
        //Hangi krediyi çekmek istedigimizi soruyor, memur asker , kamu çalışanı özel sektör çalışanı mısın işin gücün var mı vs diye soruyor
        //Size ihtiyaç kredisi de olur taşıtta, Taşıt kredisinde geri ödeyene kadar arabayı ipotek ediyoruz diyor.
        //Bizde şu soruyu soruyoruz;
        //. İhtiyaç kredisi çekersem ne kadar öderim taşıt kredisi çekersem ne kadar öderim?
        //bankada ki personel de önünde ki kredi listesinden bize uydugu için hem ihtiyaç hem de taşıt kredisini seçiyor. 
        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {// genelde ihtiyaç kredisi daha fazla faiz oranı var.O yüzden böyle bir seçeneği düşündük.
         // Şimdi memur tuşa bastı ve birden fazla kredinin hesabını yapmak iştedi. 
         //  public void BasvuruYap(IKrediManager krediManager) =>> burada bir kredinin hesabını yapmıştı .örn
         // basvuruManager.BasvuruYap(ihtiyacKrediManager)
         // KrediOnBilgilendirmede ise;
         //birden fazla kredi hesabı yapacak. O yüzden aynı veri türünde içerisinde birden fazla eleman tutan list <> yapısından yararlanıcaz 
         // ve bu listimizin türü <IKrediManager> olacak 
        

            //listede ki her bir krediyi dolaş ve  hesabını yap 
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();


            }

        }
    }
}
