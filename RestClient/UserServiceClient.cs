namespace RestClient
{
    using System;
    using System.Diagnostics;
    using System.Net.Http;
    using Common;
    using Common.Dto;
    using Newtonsoft.Json;

    public class UserServiceClient : IUserService
    {
        public UserDto GetUser(int userId)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2460/");
            var response = client.GetAsync("api/v1/user/" + userId).Result;
            if (!response.IsSuccessStatusCode)
            {
                Trace.WriteLine(response.ReasonPhrase);
                return null;
            }

            string responseJson = response.Content.ReadAsStringAsync().Result;
            UserDto result = JsonConvert.DeserializeObject<UserDto>(responseJson);
            return result;
        }
    }
}
