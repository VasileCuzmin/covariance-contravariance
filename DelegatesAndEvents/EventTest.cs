namespace DelegatesAndEvents;

public class EventTest
{
    public event EventHandler MyEvent
    {
        add => Console.WriteLine("add operation");

        remove => Console.WriteLine("remove operation");
    }


    public void DoNothing(object sender, EventArgs e)
    {
    }


    //private EventHandler _myEvent;

    //public event EventHandler MyEvent
    //{
    //    add
    //    {
    //        lock (this)
    //        {
    //            _myEvent += value;
    //        }
    //    }
    //    remove
    //    {
    //        lock (this)
    //        {
    //            _myEvent -= value;
    //        }
    //    }
    //}
}