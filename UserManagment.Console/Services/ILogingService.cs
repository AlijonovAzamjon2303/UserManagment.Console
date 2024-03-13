using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.Console.Models;

namespace UserManagment.Console.Services
{
    internal interface ILogingService
    {
        bool Check(Credential credential);
    }
}
