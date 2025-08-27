using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class Smartphone : ICallable, IBrowseable
{
    public void Browse(string msg)
    {
        if(!ValidateWeb(msg))
        {
            throw new ArgumentException("Invalid URL!");
        }

        Console.WriteLine($"Browsing: {msg}!");
    }

    public void Call(string msg)
    {
        if(!ValidatePhoneNumber(msg))
        {
            throw new ArgumentException("Invalid number!");
        }

        Console.WriteLine($"Calling... {msg}");
    }

    private bool ValidatePhoneNumber(string phoneNumber)     //=> phoneNumber.All(ch => char.IsDigit(ch));
    {
        if(phoneNumber.All(ch => char.IsDigit(ch)))
        {
            return true;
        }

        return false;
    }

    private bool ValidateWeb(string site)
    {
        if(site.Any(ch => char.IsDigit(ch)))
        {
            return false;
        }

        return true;
    }
}

