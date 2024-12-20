class Derived : Base
{
    public void DoMore() =>
        Console.WriteLine(
            $"Doing more from {this.GetType().Name}");
}