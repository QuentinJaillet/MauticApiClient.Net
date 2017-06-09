using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauticApiClient.Net.Auth
{
    public class BasicAuthentication : IAuthentication
    {
        private readonly string _username;
        private readonly string _password;

        public BasicAuthentication(string username, string password)
        {
        }
    }
}
