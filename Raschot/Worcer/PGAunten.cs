using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace Raschot.Worcer
{
    class PGAunten2
    {
   
   
        private string cityPickupNameTotal { get; set; }
        private string cityDeliveryNameTotal { get; set; }
   
        private string weightStr { get; set; }
        private string volumeStr { get; set; }
       


        private string Cookie { get; set; }

        public PGAunten2(string cityPickupNameTotal,string cityDeliveryNameTotal,string weightStr,string volumeStr)
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
            Params["method: calc:"] ="";
            Params["direction:"] = "";


            Params["form.cityPickupId"] = "48999207";
            Params["form.cityDeliveryId"] = "49698502";
            Params["form.cityPickupCountryCode"] = "ru";
            Params["form.cityDeliveryCountryCode"] = "ru";
            Params["form.cityPickupNameFull"] = "г. Екатеринбург";
            Params["form.cityDeliveryNameFull"] = "г. Москва, 101000";
            Params["form.cityPickupNameTotal"] = cityPickupNameTotal;
            Params["form.cityDeliveryNameTotal"] = cityDeliveryNameTotal;
            Params["serverCountryCode"] = "ru";
            Params["form.cityPickupName"] = cityPickupNameTotal;
            Params["form.cityPickupType"] = "0";
            Params["form.cityDeliveryName"] = cityDeliveryNameTotal;
            Params["form.cityDeliveryType"] = "0";
            Params["form.dependantProducts"] = "CSM,MXO";
            Params["form.iamOnlineStoreStatus"] = "0";
            Params["form.weightStr"] = weightStr;
            Params["form.volumeStr"] = volumeStr;
            Params["form.parcelLimits.maxLength"] = "350";
            Params["form.parcelLimits.maxWidth"] = "160";
            Params["form.parcelLimits.maxHeight"] = "180";
            Params["form.parcelLimits.maxWeight"] = "1000";
            Params["form.deliveryPeriodId"] = "";
            Params["form.maxDeclaredCost"] = "30000000";
            Params["form.deliveryPeriodId"] = "";



            string response = request.Post("https://www.dpd.ru/ols/calc/calc.do2", Params).ToString();
            Cookie = request.Cookies.GetCookieHeader("https://www.dpd.ru/ols/calc/calc.do2");
           
                    
            return response;
        }


       


    }

}
//private static async Task PostRequestAsync()
//{
//    WebRequest request = WebRequest.Create("http://localhost:5374/Home/PostData");
//    request.Method = "POST"; // для отправки используется метод Post
//    // данные для отправки
//    string data = "sName=Hello world!";
//    // преобразуем данные в массив байтов
//    byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
//    // устанавливаем тип содержимого - параметр ContentType
//    request.ContentType = "application/x-www-form-urlencoded";
//    // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
//    request.ContentLength = byteArray.Length;
             
//    //записываем данные в поток запроса
//    using (Stream dataStream = request.GetRequestStream())
//    {
//        dataStream.Write(byteArray, 0, byteArray.Length);
//    }
 
//    WebResponse response = await request.GetResponseAsync();
//    using (Stream stream = response.GetResponseStream())
//    {
//        using (StreamReader reader = new StreamReader(stream))
//        {
//            Console.WriteLine(reader.ReadToEnd());
//        }
//    }
//    response.Close();
//    Console.WriteLine("Запрос выполнен...");
//}