using API.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            Test();
        }
        async void Test()
        {
            HttpClient client = new HttpClient();
            var response = await client.PostAsJsonAsync("http://localhost:8080/Student", new Student()
            {
                Name = "new",
                Surname = "new",
                Patronymic = "new"
            }) ;

            Debug.WriteLine(response);
        }
    }
}
