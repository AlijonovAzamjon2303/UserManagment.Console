using UserManagment.Console.Models;

namespace UserManagment.Console.Brokers
{
    internal class StorageBroker : IStorageBroker
    {
        private readonly Credential[] credentials = 
        {   
            new Credential {Username = "A'zamjon", Password = "2303"}, 
            new Credential {Username = "Yaqubaliy", Password = "1234"} 
        };
        public Credential[] GetAll() => credentials;
    }
}
