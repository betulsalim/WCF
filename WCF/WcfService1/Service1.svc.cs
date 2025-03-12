using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
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
