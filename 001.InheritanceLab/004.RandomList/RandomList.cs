namespace CustomRandomList;

public class RandomList : List<string>
{
    public string RandomString(List<string> list)
    {
        Random rnd = new Random();

        string result = list[rnd.Next(0, list.Count + 1)];

        return result;
    }
}