//class Foo
//{
//    static Foo()
//    {
//        Console.WriteLine("Foo");
//    }
//}

//class Bar
//{
//    static int i = Init();

//   public static int Init()
//    {
//        Console.WriteLine("Bar");

//        var y = i;
//        return 0;
//    }
//}

//class Test
//{
//    static void Main()
//    {
//        Foo f = new Foo();
//        Bar b = new Bar();

//        Bar.Init();
//    }
//}


//IEnumerable<int> FilterAndSquare(IEnumerable<int> numbers)
//{
//    return numbers.Where(n => n % 2 == 0).Select(n => n * n);
//}

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var result = FilterAndSquare(numbers);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//var lines = LogFileReader
//    .GetLogEntries(@"C:\Users\VasileCuzmin\source\repos\CovarianceContravariance\Iterator\dummy.txt");

//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}



//string[] lines = System.IO.File.ReadAllLines(@"C:\Users\VasileCuzmin\source\repos\CovarianceContravariance\Iterator\dummy.txt");
//string fileData = System.IO.File.ReadAllText(@"C:\Users\VasileCuzmin\source\repos\CovarianceContravariance\Iterator\dummy.txt");

//Console.ReadLine();

//Employee employee = new Employee("Cool Guy", 65);

//IPromotion p = employee;

//Console.WriteLine(employee);

//p.Promote();

//Console.WriteLine(employee);



//IPromotion employee1 = new Employee("Cool Guy", 65);

//IPromotion employee2 = employee1;

//Console.WriteLine(employee2); // outputs 65

//employee1.Promote();

//Console.WriteLine(employee2); // outputs 66!!


var t = "Horizon Application Form (can Docusign)-31039".GetStringBeforeTheNthSeparator('-',2);

Console.Write(t);




//var a = new Derived();

//var b = (Base)a;

//GenericM(b);
//;


void GenericM(Base b)
{
    ;
}


interface IPromotion
{
    void Promote();
}

struct Employee : IPromotion
{
    public string Name; public int JobGrade;
    public void Promote() { JobGrade++; }
    public Employee(string name, int jobGrade) { this.Name = name; this.JobGrade = jobGrade; }
    public override string ToString() => $"{Name} ({JobGrade})";
}


public class Base
{
    public int Type { get; set; } = 5;
}


class Derived : Base
{
    public int Type1 { get; set; } = 6;
}
