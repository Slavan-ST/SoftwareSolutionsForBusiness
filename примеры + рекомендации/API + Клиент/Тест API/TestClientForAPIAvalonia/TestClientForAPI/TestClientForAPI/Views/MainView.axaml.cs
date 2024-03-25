using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using TestClientForAPI.Models;
using TestClientForAPI.ViewModels;

namespace TestClientForAPI.Views
{
    public partial class MainView : UserControl
    {
        List<Person>? _persons = new List<Person>();
        string pathForImage = Environment.CurrentDirectory + @"\Assets\";
        public MainView()
        {
            InitializeComponent();

            Test();
            Fon.Source = new Bitmap(pathForImage + "���������.png");


        }

        async void Test()
        {
            try
            {


                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://localhost:8080/PersonLocations");

                //��������� ����������� ������
                string text = await response.Content.ReadAsStringAsync();

                //��� ���������� �������������� ���������� ������� ��������� ������ ������� (� ���� ������)
                int index = text.IndexOf(":");

                //���� �������� ���� ��������
                text = text.Remove(0, index + 1);
                text = text.Remove(text.Length - 1);

                //�������������� � ������ ��� ���
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

                    image.PointerPressed += Image_PointerPressed;


                    image.Width = 50;
                    image.Height = 50;

                    if (person.personRole == "������")
                    {
                        Debug.WriteLine(pathForImage + "������.png");
                        image.Source = new Bitmap(pathForImage + "������.png");
                    }
                    if (person.personRole == "���������")
                    {
                        Debug.WriteLine(pathForImage + "���������.png");
                        image.Source = new Bitmap(pathForImage + "���������.png");
                    }

                    Items.Children.Add(image);

                }
            }
            catch { }
        }

        bool isClick = false;
        double x = 0;
        double y = 0;
        Image temp = new Image();

        private void Image_PointerPressed(object? sender, PointerPressedEventArgs e)
        {
            var point = e.GetCurrentPoint(sender as Control);


            if (point.Properties.IsLeftButtonPressed && (sender as Control)!.Tag == null)
            {
                Debug.WriteLine("test 0");
                temp = (sender as Image)!;
                isClick = true;
            }
            if (point.Properties.IsRightButtonPressed)
            {
                Debug.WriteLine("test 1");
                x = point.Position.X;
                y = point.Position.Y;
                Canvas.SetLeft(temp, x);
                Canvas.SetTop(temp, y);
                isClick = false;
            }


        }

        private void Grid_PointerMoved(object? sender, Avalonia.Input.PointerEventArgs e)
        {
            var point = e.GetCurrentPoint(sender as Control);
            if (temp != null && isClick)
            {
                x = point.Position.X;
                y = point.Position.Y;
                Canvas.SetLeft(temp, x);
                Canvas.SetTop(temp, y);
            }
        }
    }
}