class Base
{
    public void DoSomething() =>
        Console.WriteLine(
            $"Doing from {this.GetType().Name}");
}