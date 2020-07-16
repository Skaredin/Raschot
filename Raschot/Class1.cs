using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raschot.ff
{
    class Class1
    {

        private string city1_id { get; set; }
        private string city2_id { get; set; }
        private string city1 { get; set; }
        private string city2 { get; set; }

        private string weight { get; set; }
        private string length { get; set; }
        private string width { get; set; }
        private string height { get; set; }
        private string session_id { get; set; }
        private string pochta { get; set; }
        private string mode { get; set; }
        private string submit { get; set; }
        private string Cookie { get; set; }

     

        public Class1(string city1, string city2, string weight, string length)
        {
            this.city1_id = "30";
            this.city2_id = "59";
            this.city1 = city1;
            this.city2 = city2;
            this.weight = weight;
            this.length = length;
            this.width = "1";
            this.height = "1";
            this.session_id = "87d75d12cbff3ede0d1e81b1f4cfcc5a";
            this.pochta = "on";
            this.mode = "on";
            this.submit = "";
        }
        private HttpResponse GetAuth()
        {
            HttpRequest request = new HttpRequest();
            request.UserAgentRandomize();
            request.KeepAlive = true;
            var response = request.Get("https://calculator-dostavki.ru");
            return response;


        }

        public void ParsDataAuth()
        {
            var GetAuths = GetAuth();

            Cookie = GetAuths.Cookies.GetCookieHeader("https://calculator-dostavki.ru");

        }

        public string Auch()
        {
            HttpRequest request = new HttpRequest();

            request.AddHeader("Cookie", Cookie);
            request.AddHeader("Referer", "https://calculator-dostavki.ru");
            request.UserAgentRandomize();
            request.KeepAlive = true;

            RequestParams Params = new RequestParams();
        

            Params["city1"] = city1;
            Params["city1_id"] = city1_id;
            Params["city2"] = city2;
            Params["city2_id"] = city2_id;
            Params["weight"] = weight;
            Params["length"] = length;
            Params["width"] = width;
            Params["height"] = height;
            Params["session_id"] = session_id;
            Params["pochta"] = pochta;
            Params["mode[3]"] = mode;
            Params["submit"] = submit;



            string response = request.Post("https://calculator-dostavki.ru/", Params).ToString();
                
            Cookie = request.Cookies.GetCookieHeader("https://calculator-dostavki.ru");


            return response;
        }





    }
}
