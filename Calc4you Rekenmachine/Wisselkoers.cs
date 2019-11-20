using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class Wisselkoers
    {
        public static double USD2 { get; private set; }

        public static decimal EuroDollarKoers(decimal _bedragInEuro)
        {
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("https://api.exchangeratesapi.io/latest");
                HttpResponseMessage response = client.GetAsync("?symbols=USD").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                string USD = result.Substring(16, 6);
                string USD1 = USD.Replace(".", ",");
                decimal USD2 = Convert.ToDecimal(USD1);

                return _bedragInEuro * USD2;

            }
        }
    }
}






