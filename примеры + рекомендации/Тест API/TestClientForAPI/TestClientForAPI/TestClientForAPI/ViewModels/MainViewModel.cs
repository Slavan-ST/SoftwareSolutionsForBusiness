using ReactiveUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                APIExperts();
            });
        }

        //это моя API (переписал взятую от экспертов)
        async void APIMe()
        {
            try
            {
                Text = "";


                HttpClient httpClient = new HttpClient();
                var persons = await httpClient.GetFromJsonAsync<List<Person>>("http://localhost:8080/PersonLocations");

                //Вывод полученных данных
                foreach (var person in persons!)
                {
                    Text += person.personCode + Environment.NewLine;
                    Text += person.personRole + Environment.NewLine;
                    Text += person.lastSecurityPointNumber + Environment.NewLine;
                    Text += person.lastSecurityPointDirection + Environment.NewLine;
                    Text += person.lastSecurityPointTime + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                Text = e.ToString();
            }
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
                var persons = JsonSerializer.Deserialize<Person[]>(text);

                //Вывод полученных данных
                foreach (var person in persons!)
                {
                    //это моё, на это смотреть не надо
                    Debug.WriteLine(

                        $" \r\n            " +
                        $"new Person()\r\n            {{\r\n                " +
                        $"PersonCode = {person.personCode},\r\n                " +
                        $"PersonRole =\"{person.personRole}\",\r\n                " +
                        $"LastSecurityPointNumber = {person.lastSecurityPointNumber},\r\n                " +
                        $"LastSecurityPointDirection= \"{person.lastSecurityPointDirection}\",\r\n                " +
                        $"LastSecurityPointTime = \"{person.lastSecurityPointTime}\"\r\n            }},"


                        );


                    Text += person.personCode + Environment.NewLine;
                    Text += person.personRole + Environment.NewLine;
                    Text += person.lastSecurityPointNumber + Environment.NewLine;
                    Text += person.lastSecurityPointDirection + Environment.NewLine;
                    Text += person.lastSecurityPointTime + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                Text = e.ToString();
            }
        }

        public ICommand Click { get; set; }
        string _text = "";
        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref _text, value);
        }
    }
}
