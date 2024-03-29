using API.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Json;

namespace Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            TestAddStudent();
            TestGetStudents();
        }
        async void TestAddStudent()
        {
            HttpClient client = new HttpClient();
            var response = await client.PostAsJsonAsync("http://localhost:8080/Student", new Student()
            {
                Name = "new",
                Surname = "new",
                Patronymic = "new"
            });

            Debug.WriteLine(response);
        }
        async void TestGetStudents()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<List<Student>>("http://localhost:8080/Student");

            //при возврате null - закрываем void
            if (response == null)
            {
                return;
            }

            foreach (var student in response)
            {
                Debug.WriteLine(student);
            }
        }
    }
}
