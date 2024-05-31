
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public static class Connect
    {
        static Connect()
        {
            var config = new ConfigurationBuilder()
                .AddXmlFile("App.config")
                .Build();

            string? connect = config["Connect"];

            if (connect == null)
            {
                return;
            }

            _connection = connect;
        }
        static string _connection = "http://localhost:8080/";
        static bool _check = false;
        public static string Connection
        {
            get
            {
                try
                {
                    CheckInternetConnection().Wait();
                    if (!_check)
                    {
                        Debug.WriteLine("Сервер не отвечает!");
                    }
                    else
                    {
                        //тут пихай всё своё *************
                        Debug.WriteLine("Всё ОК, сервер на связи");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                return _connection;
            }
        }
        static async Task CheckInternetConnection()
        {
            await CheckInternetConnectionAsync(_connection);
        }
        public async static Task<bool> CheckInternetConnectionAsync(string connect)
        {
            HttpClient client = new HttpClient();
            try
            {
                var response = await client.GetFromJsonAsync<System.Net.HttpStatusCode>(_connection + $"Home");
                return _check = true;
            }
            catch
            {
                return _check = false;
            }
        }

    }
}
