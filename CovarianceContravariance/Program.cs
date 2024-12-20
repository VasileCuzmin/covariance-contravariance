Base x = new Base();
Base y = new Derived();

//IProducer<Base> prodOfBase = null!;
//Base a = prodOfBase.Produce();
//// No: Derived b = prodOfBase.Produce();

//IProducer<Derived> prodOfDerived = null!;
//Derived b = prodOfDerived.Produce();
//Base c = prodOfDerived.Produce();


f(new DerivedProducer());


IProducer<Base> b1 = new DerivedProducer();

IProducer<Derived> d1 = new DerivedProducer();

IProducer<Derived1> d2 = new Derived1Producer();


IProducer<Base> c1 = new DerivedProducer();
c1.Consume(new Derived1());


f(b1);

static void f(IProducer<Base> producer)
{
    var t = producer.Produce();
    t.DoSomething();
}


interface IProducer<out T>
{
    T Produce();
}

class DerivedProducer : IProducer<Derived>
{
    public Derived Produce()
    {
        return new Derived();
    }
}

class Derived1Producer : IProducer<Derived1>
{
    public Derived1 Produce()
    {
        return new Derived1();
    }
}

class BaseProducer : IProducer<Base>
{
    public Base Produce()
    {
        return new Base();
    }
}

class BaseConsumer : IConsumer<Base>
{
    public void Consume(Base obj)
    {
        throw new NotImplementedException();
    }
}

class DerivedConsumer : IConsumer<Derived>
{
    public void Consume(Derived obj)
    {
        throw new NotImplementedException();
    }
}


interface IConsumer<in T>
{
    void Consume(T obj);
}