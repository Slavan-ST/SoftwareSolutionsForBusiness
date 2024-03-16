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
            Click = ReactiveCommand.Create(async () =>
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
                        Text += person.personCode + Environment.NewLine;
                        Text += person.personRole + Environment.NewLine;
                        Text += person.lastSecurityPointNumber + Environment.NewLine;
                        Text += person.lastSecurityPointDirection + Environment.NewLine;
                        Text += person.lastSecurityPointTime + Environment.NewLine + Environment.NewLine;
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            });
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
