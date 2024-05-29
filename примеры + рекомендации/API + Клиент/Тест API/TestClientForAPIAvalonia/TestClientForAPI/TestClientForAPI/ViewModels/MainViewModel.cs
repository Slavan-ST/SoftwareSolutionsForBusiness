using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
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

            ThreadPool.QueueUserWorkItem(APIExperts);
        }



        List<EventO>? _persons = new List<EventO>();

        
        async void APIExperts(object? stat)
        {
            Text = "start" + Environment.NewLine; ;
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://localhost:4914/PersonLocations");

                //Получение содержимого ответа
                string text = await response.Content.ReadAsStringAsync();
                //Получение содержимого ответа

                var persons = JsonSerializer.Deserialize<List<Person>>(text);
                
                if (persons == null)
                {
                    return;
                }

                foreach (var p in persons)
                {
                    Text += p.personCode + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }
            Text += "start 6" + Environment.NewLine;
        }

        public ICommand Click { get; set; }

        [Reactive]
        public string Text { get; set; } = string.Empty;
    }
}
