using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Services
{
    internal interface IAuthenticationService
    {
        bool Register(string email, string username, string password, bool confirmPassword);
    }
}
