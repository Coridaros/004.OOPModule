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

        foreach (FieldInfo field in fieldInfo.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(inst)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAccessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);
        FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] gettersInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        MethodInfo[] settersInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);


        foreach(FieldInfo field in fieldInfos)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach(MethodInfo getter in gettersInfo.Where(g => g.Name.StartsWith("get")))
        {
            sb.AppendLine($"{getter.Name} have to be public!");
        }

        foreach(MethodInfo setter in settersInfo.Where(s => s.Name.StartsWith("set")))
        {
            sb.AppendLine($"{setter.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}
