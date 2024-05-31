using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Client;
using Helper.Models.Main;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TestClientForAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TestClientForAPI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {


        public MainViewModel()
        {


            Click = ReactiveCommand.Create(() =>
            {
            });

            ThreadPool.QueueUserWorkItem(Test);
        }



        List<EventO>? _persons = new List<EventO>();

        
        void Test(object? state)
        {
            TestAsync().Wait();
        }
        async Task TestAsync()
        {
            var persons = await APIExperts();
            if (persons == null)
            {
                return;
            }
            foreach (var p in persons)
            {
                Text += p.personCode + Environment.NewLine;
            }
        }
        async Task<IEnumerable<Person>?> APIExperts()
        {
            Text = "start" + Environment.NewLine; ;
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetFromJsonAsync<IEnumerable<Person>>(Connect.Connection + "PersonLocations");
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ICommand Click { get; set; }

        [Reactive]
        public string Text { get; set; } = string.Empty;
    }
}
