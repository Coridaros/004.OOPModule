using Vehicle.IO.Interfaces;

namespace Vehicle.IO
{
    public class Writter : IWritter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
