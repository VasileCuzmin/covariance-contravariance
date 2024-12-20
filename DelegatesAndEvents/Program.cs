using System.Runtime.InteropServices.ComTypes;
using DelegatesAndEvents;
using static System.Net.Mime.MediaTypeNames;

FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);
DelegateTest instance = new DelegateTest();

FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

Console.WriteLine(d1(10)); // Writes out "Static method: 10"
Console.WriteLine(d2(5));

EventTest t = new EventTest();

t.MyEvent += t.DoNothing;
t.MyEvent -= null;

public delegate string FirstDelegate(int x);