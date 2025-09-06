using System.Reflection;
using System.Text;

namespace Stealer;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(investigatedClass);

        FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Instance | BindingFlags.Public
            | BindingFlags.NonPublic);

        object inst = Activator.CreateInstance(type);

        sb.AppendLine($"Class under investigation: {type}");

        foreach(FieldInfo field in fieldInfo.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(inst)}");
        }

        return sb.ToString().Trim();
    }
}
