﻿using API.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrainingRegistrationAPI.ViewModel;
using TrainingRegistrationClient.Base.Urls;

namespace TrainingRegistrationClient.Repository.Data
{
    public class LoginEmpRepository : GeneralRepository<LoginEmpVM, int>
    {
        private readonly Address address;
        private readonly HttpClient httpClient;
        private readonly string request;
        public LoginEmpRepository(Address address, string request = "Employees/") : base(address, request)
        {
            this.address = address;
            this.request = request;
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address.link)
            };
        }

        public async Task<JWTokenVM> Auth(LoginEmpVM login)
        {
            JWTokenVM token = null;

            StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(request + "Log In Employee", content);

            string apiResponse = await result.Content.ReadAsStringAsync();
            token = JsonConvert.DeserializeObject<JWTokenVM>(apiResponse);

            return token;
        }

    }
}
