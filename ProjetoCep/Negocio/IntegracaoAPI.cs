using Newtonsoft.Json;
using RestSharp;
using ProjetoCep.Domain;
namespace ProjetoCep.Negocio
{
    public class IntegracaoAPI
    {
        public async Task<Endereco> buscacep(string yourcep)
        {
            var client = new RestClient("https://viacep.com.br/ws/" + yourcep + "/json/");
            var request = new RestRequest();
            request.Method = Method.Get;
            var result = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<Endereco>(result.Content);
        }
    }
}
