using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
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






        string pathForImage = Environment.CurrentDirectory + @"\Assets\";
        List<Person>? _persons = new List<Person>();

        [Reactive]
        public List<Image> Items { get; set; } = new List<Image>();


        private void Image_Holding(object? sender, HoldingRoutedEventArgs e)
        {
            Debug.WriteLine("12");
        }

        //это API от экспертов (браузер потестить не получится, так как там проблема с CORS)
        async void APIExperts()
        {
            try
            {
                Text = "";


                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://localhost:8080/PersonLocations");

                //Получение содержимого ответа
                string text = await response.Content.ReadAsStringAsync();

                //Для нормальной десериализации необходимо удалить некоторые лишние символы (в чате покажу)
                int index = text.IndexOf(":");

                //само удаление этих символов
                text = text.Remove(0, index + 1);
                text = text.Remove(text.Length - 1);

                //Десериализация в нужный нам тип
                var persons = JsonSerializer.Deserialize<List<Person>>(text);

                if (persons == null)
                {
                    return;
                }

                persons = persons.OrderBy(x => x.lastSecurityPointNumber).ToList();

                _persons = persons;



                List<Image> temp = new List<Image>();
                foreach (var person in _persons)
                {
                    Image image = new Image();
                    image.Holding += Image_Holding;
                    if (person.personRole == "Клиент")
                    {
                        Debug.WriteLine(pathForImage + "Клиент.png");
                        image.Source = new Bitmap(pathForImage + "Клиент.png");
                    }
                    if (person.personRole == "Сотрудник")
                    {
                        Debug.WriteLine(pathForImage + "Сотрудник.png");
                        image.Source = new Bitmap(pathForImage + "Сотрудник.png");
                    }

                    Items.Add(image);

                }
            }
            catch { }
        }

        public ICommand Click { get; set; }

        [Reactive]
        public string Text { get; set; }
    }
}
