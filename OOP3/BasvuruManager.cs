using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection - dependence injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Basvuranin bilgilerinin degerlendiririz
            //

            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
