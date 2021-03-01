using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            esnafKrediManager.Hesapla();
                 

            // interface de eger inherit olubsa ozunde eyni referansi tutur 
            //interface onu implemente eden classin referansini tutabilir

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsloggerService = new SmsLoggerService();
            //burdada newleye bilerik , direkt basvuruyapin ichindede newleye bilerik) 

            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());

            basvuruManager.BasvuruYap(konutKrediManager,fileloggerService);

            basvuruManager.BasvuruYap(tasitKrediManager,smsloggerService);
            basvuruManager.BasvuruYap(esnafKrediManager,smsloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager,tasitKrediManager};



            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
