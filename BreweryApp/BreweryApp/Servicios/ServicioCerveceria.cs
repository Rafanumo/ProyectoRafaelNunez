using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BreweryApp.Servicios
{
    public class ServicioCerveceria
    {
        private const string url = "http://api.brewerydb.com/v2/";

        public async Task<RootObject> Obtener()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var json = await httpClient.GetStringAsync("breweries/?key=43d0e3203a936fdc091ccfaccf489efe&format=json&p=44").ConfigureAwait(false);

                var resultado = JsonConvert.DeserializeObject<RootObject>(json);

                return resultado;
            }
        }

        public async Task<RootObject> ObtenerCerveceria(string id)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var json = await httpClient.GetStringAsync("brewery/" + id + "/?key=43d0e3203a936fdc091ccfaccf489efe&format=json").ConfigureAwait(false);

                var resultado = JsonConvert.DeserializeObject<RootObject>(json);

                return resultado;
            }
        }

        public async Task<Cervezas> ObtenerCervezas(string id)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var json = await httpClient.GetStringAsync("brewery/" + id + "/beers/?key=43d0e3203a936fdc091ccfaccf489efe&format=json").ConfigureAwait(false);

                var resultado = JsonConvert.DeserializeObject<Cervezas>(json);

                return resultado;
            }
        }
    }
}
