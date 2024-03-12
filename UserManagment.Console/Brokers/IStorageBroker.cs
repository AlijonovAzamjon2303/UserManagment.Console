using UserManagment.Console.Models;

namespace UserManagment.Console.Brokers
{
    internal interface IStorageBroker
    {
        Credential[] GetAll();
    }
}
