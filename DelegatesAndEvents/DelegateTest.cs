namespace DelegatesAndEvents;

public class DelegateTest
{
    string name;


    public string InstanceMethod(int i)
    {
        return string.Format("{0}: {1}", name, i);
    }


    public static string StaticMethod(int i)
    {
        return $"Static method: {i}";
    }
}