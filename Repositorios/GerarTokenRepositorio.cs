using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SdmBoletos.Repositorios
{
    public class GerarTokenRepositorio : IGerarToken
    {
        public string GerarToken()
        {
            var Autorization = "Basic ZXlKcFpDSTZJaUlzSW1OdlpHbG5iMUIxWW14cFkyRmtiM0lpT2pBc0ltTnZaR2xuYjFOdlpuUjNZWEpsSWpveE1qQXlOeXdpYzJWeGRXVnVZMmxoYkVsdWMzUmhiR0ZqWVc4aU9qRjk6ZXlKcFpDSTZJamd4TkdFeE9XTXROQ0lzSW1OdlpHbG5iMUIxWW14cFkyRmtiM0lpT2pBc0ltTnZaR2xuYjFOdlpuUjNZWEpsSWpveE1qQXlOeXdpYzJWeGRXVnVZMmxoYkVsdWMzUmhiR0ZqWVc4aU9qRXNJbk5sY1hWbGJtTnBZV3hEY21Wa1pXNWphV0ZzSWpveExDSmhiV0pwWlc1MFpTSTZJbkJ5YjJSMVkyRnZJaXdpYVdGMElqb3hOakExTnpFNU1EazBPRGM0ZlE=";
            var Grant_type = "client_credentials";
            var scope = "cobrancas.boletos-requisicao cobrancas.boletos-info";

            var url = $"https://oauth.bb.com.br/oauth/token";

            var client = new RestClient(url);
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", Autorization);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", Grant_type);
            request.AddParameter("scope", scope);

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                response = client.Execute(request);
                return response.Content;

            }

        }

        public string GerarTokenTeste()
        {
            var Autorization = "Basic ZXlKcFpDSTZJbUUyWWpOaVkySXRNMlE1T1MwMFpEZ3hMVGs1SWl3aVkyOWthV2R2VUhWaWJHbGpZV1J2Y2lJNk1Dd2lZMjlrYVdkdlUyOW1kSGRoY21VaU9qRXhOamc1TENKelpYRjFaVzVqYVdGc1NXNXpkR0ZzWVdOaGJ5STZNWDA6ZXlKcFpDSTZJbVZtWXpaaE5HRXRZVEJoSWl3aVkyOWthV2R2VUhWaWJHbGpZV1J2Y2lJNk1Dd2lZMjlrYVdkdlUyOW1kSGRoY21VaU9qRXhOamc1TENKelpYRjFaVzVqYVdGc1NXNXpkR0ZzWVdOaGJ5STZNU3dpYzJWeGRXVnVZMmxoYkVOeVpXUmxibU5wWVd3aU9qRXNJbUZ0WW1sbGJuUmxJam9pYUc5dGIyeHZaMkZqWVc4aUxDSnBZWFFpT2pFMk1EVTJNelF4T0Rnek5UUjk=";
            var Grant_type = "client_credentials";
            var scope = "cobrancas.boletos-requisicao cobrancas.boletos-info";

            var url = $"https://oauth.hm.bb.com.br/oauth/token";

            var client = new RestClient(url);
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", Autorization);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", Grant_type);
            request.AddParameter("scope", scope);

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                response = client.Execute(request);
                return response.Content;

            }
        }
    }
}
