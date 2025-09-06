//Reflection and attributes - lab, Task 006
//07.09.2025, 01:14

namespace AuthorProblem;

[Author("Victor")]
class StartUp
{
    [Author("George")]
    static void Main(string[] args)
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}
