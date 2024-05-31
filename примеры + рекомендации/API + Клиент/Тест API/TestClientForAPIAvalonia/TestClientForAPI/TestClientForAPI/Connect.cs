
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public static class Connect
    {
        static string _connection = "http://localhost:4914/";
        static bool _check = false;
        public static string Connection
        {
            get
            {
                return _connection;
            }
        }

    }
}
