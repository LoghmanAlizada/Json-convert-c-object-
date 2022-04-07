using exp5.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace exp5
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpCLient = new HttpClient();
            var response = httpCLient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            var responseJysonStr = response.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(responseJysonStr);

            List<User> exp = JsonConvert.DeserializeObject<List<User>>(responseJysonStr);

            foreach (var item in exp)
            {
                Console.WriteLine(item.email);
            }
        }
    }
}
