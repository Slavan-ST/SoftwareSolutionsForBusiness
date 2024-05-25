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

            APIExperts();
        }



        List<EventO>? _persons = new List<EventO>();

        
        //это API от экспертов (браузер потестить не получится, так как там проблема с CORS)
        async void APIExperts()
        {
            Text = "start" + Environment.NewLine; ;
            try
            {

                Text += "start 2" + Environment.NewLine;

                HttpClient httpClient = new HttpClient();

                Text += "start 3" + Environment.NewLine;
                var response = await httpClient.GetAsync("http://localhost:4914/PersonLocations");


                Text += "start 4" + Environment.NewLine;

                //Получение содержимого ответа
                string text = await response.Content.ReadAsStringAsync();
                //Получение содержимого ответа

                var persons = JsonSerializer.Deserialize<List<Person>>(text);

                foreach (var p in persons)
                {
                    Text += p.personCode;
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
        public string Text { get; set; }
    }
}
