using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class Phone : ICallable
{
    public void Call(string msg)
    {
        if (!ValidatePhoneNumber(msg))
        {
            throw new ArgumentException("Invalid number!");
        }

        Console.WriteLine($"Dialing... {msg}");
    }

    private bool ValidatePhoneNumber(string phoneNumber)     //=> phoneNumber.All(ch => char.IsDigit(ch));
    {
        if (phoneNumber.All(ch => char.IsDigit(ch)))
        {
            return true;
        }

        return false;
    }
}
