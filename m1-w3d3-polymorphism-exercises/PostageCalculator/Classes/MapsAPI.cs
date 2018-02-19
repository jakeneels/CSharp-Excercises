using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PostageCalculator.Classes
{
    class MapsAPI
    {
        string jsonStr;
        static string key = "AIzaSyCMLeI_m76gJ241sVc9oZztyc3bJ_Csa34";

        public void RequestDist(string origName, string destName)
        {
            string request = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={origName}&destinations={destName}&key={key}";
            HttpClient client = new HttpClient();
            var req = WebRequest.Create(request);
            var stream = req.GetResponse().GetResponseStream();
            using (StreamReader sr = new StreamReader(stream))
            {
                jsonStr = sr.ReadToEnd();
                            }
        }
        
        public void goToPlace(string place)
        {
            System.Diagnostics.Process.Start($"https://www.google.com/maps/place/{place}");
        }
        public int GetDistance()
        {
            var jObj = JObject.Parse(jsonStr);
            string distStr = jObj.SelectToken("rows[0].elements[0].distance.text").ToString();
            distStr = distStr.Remove(distStr.IndexOf(' '), distStr.Length - distStr.IndexOf(' ') );
            int distance;
            int.TryParse(distStr, out distance);
            return distance;
        }
    }
}
