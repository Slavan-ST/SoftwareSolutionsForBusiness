using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat.ModeDetection;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;
using WebAPI.Models;

namespace TestAppHttpClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Greeting = "welcome";
            Debug.WriteLine("welcome");
            Start = ReactiveCommand.Create(async () =>
            {
                HttpClient client = new HttpClient();

                //тут работает
                var result = await client.GetStringAsync("http://192.168.0.2:5170/");

                //так тоже не работает
                //var resultJson = await client.GetFromJsonAsync<string>("http://localhost:5170/");

                Greeting = result;
            });
        }
        [Reactive]
        public string? Greeting { get; set; }
        public ICommand Start { get; set; }
    }
}
