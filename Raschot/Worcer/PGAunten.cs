using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
namespace Raschot.Worcer
{
    class PGAunten
    {
        private string cityPickupId { get; set; }
        private string cityDeliveryId { get; set; }
   
        private string cityPickupNameTotal { get; set; }
        private string cityDeliveryNameTotal { get; set; }
   
        private string weightStr { get; set; }
        private string volumeStr { get; set; }
       


        private string Cookie { get; set; }

        public PGAunten(string cityPickupNameTotal,string cityDeliveryNameTotal,string weightStr,string volumeStr)
        {
          
            this.cityPickupNameTotal = cityPickupNameTotal;
            this.cityDeliveryNameTotal = cityDeliveryNameTotal;
            this.weightStr = weightStr;
            this.volumeStr = volumeStr;
          

        }
        private HttpResponse GetAuth()
        {
            HttpRequest request = new HttpRequest();
            request.UserAgentRandomize();
            request.KeepAlive = true;
            var response = request.Get("https://www.dpd.ru/ols/calc/calc.do2");
            return response;

        
        }

        public void ParsDataAuth() 
        {
            var GetAuths = GetAuth();
            cityPickupId = System.Text.RegularExpressions.Regex.Match(GetAuths.ToString(), "name=\"cityPickupId\" value=\"(.*?)\"").Groups[1].Value;
            cityDeliveryId = System.Text.RegularExpressions.Regex.Match(GetAuths.ToString(), "name=\"cityDeliveryId\" value=\"(.*?)\"").Groups[1].Value;
            Cookie = GetAuths.Cookies.GetCookieHeader("https://www.dpd.ru/ols/calc/calc.do2");

            

        }

        public string Auch()
        {
            HttpRequest request = new HttpRequest();
           
            request.AddHeader("Cookie", Cookie);
            request.AddHeader("Referer", "https://www.dpd.ru/ols/calc/calc.do2");
            request.UserAgentRandomize();
            request.KeepAlive = true;

            RequestParams Params = new RequestParams();
            Params["	form.cityPickupId	"] = cityPickupId;
            Params["	form.cityDeliveryId	"] = cityDeliveryId;
            Params["	form.cityPickupCountryCode	"] = "ru";
            Params["	form.cityDeliveryCountryCode	"] = "ru";
            //Params["	form.cityPickupNameFull	"] = cityPickupNameFull;
            //Params["	form.cityDeliveryNameFull	"] = cityDeliveryNameFull;
            Params["	form.cityPickupNameTotal	"] = cityPickupNameTotal;
            Params["	form.cityDeliveryNameTotal	"] = cityDeliveryNameTotal;
            Params["	serverCountryCode	"] = "ru";
            Params["	form.cityPickupName	"] = cityPickupNameTotal;
            Params["	form.cityPickupType	"] = "0";
            Params["	form.cityDeliveryName	"] = cityDeliveryNameTotal;
            Params["	form.cityDeliveryType	"] = "0";
            Params["	form.dependantProducts	"] = "CSM,MXO";
            Params["	form.iamOnlineStoreStatus	"] = "0";
            Params["	form.weightStr	"] = weightStr;
            Params["	form.volumeStr	"] = volumeStr;
            Params["	form.parcelLimits.maxLength	"] = "350";
            Params["	form.parcelLimits.maxWidth	"] = "160";
            Params["	form.parcelLimits.maxHeight	"] = "180";
            Params["	form.parcelLimits.maxWeight	"] = "1000";
            Params["	form.maxDeclaredCost	"] = "30000000";
            Params["	form.deliveryPeriodId	"] = "191696130";



                string response = request.Post("https://www.dpd.ru/ols/calc/calc.do2", Params).ToString();
            Cookie = request.Cookies.GetCookieHeader("https://www.dpd.ru/ols/calc/calc.do2");
            return response;
            
        }

        public int Chek(string respons)
        {
            int Otvet = 0;
            if (System.Text.RegularExpressions.Regex.Match(respons, "Notifier.init((.*))").Groups[1].Value.Length > 0)
                Otvet = 1;
            else
                Otvet = 0;
            return Otvet;

        }


        
    }
}
