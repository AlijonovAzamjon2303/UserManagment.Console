using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.Console.Brokers;
using UserManagment.Console.Models;

namespace UserManagment.Console.Services
{
    internal class LogingService : ILogingService
    {
        private readonly IStorageBroker storageBroker;
        private Credential[] credentials;
        public LogingService()
        {
            this.storageBroker = new StorageBroker();
            this.credentials = this.storageBroker.GetAll();
        }

        public bool Check(Credential credential)
        {
            foreach (Credential cred in this.credentials) 
            {
                if(cred.Username == credential.Username && cred.Password == credential.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
