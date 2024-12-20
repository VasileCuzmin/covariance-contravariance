class Derived1 : Base
{
    public void DoMore() =>
        Console.WriteLine(
            $"Doing more from {this.GetType().Name}");
}