using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Calc4you_Rekenmachine
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
                // "?symbols=USD" is de achter geplakt
                response.EnsureSuccessStatusCode();
                // API CALL en doe dingen
                string result = response.Content.ReadAsStringAsync().Result;
                // string naar result zetten
                string USD = result.Substring(16, 6);
                // van het begin 16 chars eraf en vanaf daar 6 chars nemen
                string USD1 = USD.Replace(".", ",");
                // verander de punt met een komma
                decimal USD2 = Convert.ToDecimal(USD1);
                // convert naar decimal

                return _bedragInEuro * USD2;
                // API CALL
            }
        }
    }
}
