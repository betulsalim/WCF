using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KurlarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KurService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KurService.svc or KurService.svc.cs at the Solution Explorer and start debugging.
    public class KurService : IKurService
    {
        public List<double> KurlariGetir(string kurTipi)
        {
            Random randomKur = new Random();
            List<double> kurListesi = new List<double>();
            for (int i = 0; i < 15; i++)
            {
                kurListesi.Add(randomKur.NextDouble() + 2);
            }
            return kurListesi;
        }

        public List<string> ParaBirimileriGetir()
        {
            List<string> paraBirimleri = new List<string>();
            paraBirimleri.Add("USD");
            paraBirimleri.Add("EUR");
            paraBirimleri.Add("GBP");
            paraBirimleri.Add("JPY");
            paraBirimleri.Add("CHF");
            paraBirimleri.Add("SEK");
            paraBirimleri.Add("NOK");
            paraBirimleri.Add("DKK");

            return paraBirimleri;
        }
    }
}
