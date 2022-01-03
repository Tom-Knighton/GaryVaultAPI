using System;
using GaryVaultAPI.Data;
using Org.OpenAPITools.Model;
using RestSharp;

namespace GaryVaultAPI
{
    public interface IAuthenticationService : IDisposable
    {
        public Task<JWTRefresh> GetAuthKeys();
    }

    public class AuthenticationService: IAuthenticationService
    {
        private readonly AppSettings _appSettings;
        public AuthenticationService(AppSettings appSettings) => _appSettings = appSettings;

        public void Dispose()
        {
            //TODO
        }

        public async Task<JWTRefresh> GetAuthKeys()
        {
            var client = new RestClient(Common.BASEURL);
            var request = new RestRequest("/token/new/", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("secret_id", _appSettings.SECRET_ID);
            request.AddParameter("secret_key", _appSettings.SECRET_KEY);
            IRestResponse<JWTRefresh> response = await client.ExecuteAsync<JWTRefresh>(request);
            Console.WriteLine(response.Content);
            return response.Data;
        }
    }
}

