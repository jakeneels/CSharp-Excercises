using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        static string key = "AIzaSyCMLeI_m76gJ241sVc9oZztyc3bJ_Csa34";
        public string Response { get; set; }

        public async void RequestDist(string origName, string destName)
        {
            string request = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={origName}&destinations={destName}&key={key}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response =  await client.GetAsync(request);
            HttpContent message = response.Content;
            Response = await message.ReadAsStringAsync();

        }
        public void goToPlace(string place)
        {
            System.Diagnostics.Process.Start($"https://www.google.com/maps/place/{place}");
        }
        public int GetDistance()
        {

            var jObj = JObject.Parse(Response);
            string distStr = jObj.SelectToken("rows[0].elements[0].distance.text").ToString();
            distStr = distStr.Remove(distStr.IndexOf(' '), distStr.Length - distStr.IndexOf(' ') );
            int distance;
            int.TryParse(distStr, out distance);
            return distance;
        }
    }
}
