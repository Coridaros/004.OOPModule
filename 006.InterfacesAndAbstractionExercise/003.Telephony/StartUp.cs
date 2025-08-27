//Interfaces and abstraction - exercise, Task 003
//19.08.2025, 00:22

using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony;

public class StartUp
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split();
        string[] sites = Console.ReadLine().Split();

        ICallable call;

        foreach(var item in phoneNumbers)
        {
            if(item.Length == 10)
            {
                call = new Smartphone();
            }
            else
            {
                call = new Phone();
            }

            try
            {
                call.Call(item);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        IBrowseable browse = new Smartphone();

        foreach(var item in sites)
        {
            try
            {
                browse.Browse(item);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
