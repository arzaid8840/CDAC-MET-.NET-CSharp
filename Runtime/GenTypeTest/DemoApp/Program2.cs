class Program
{
    static void PrintStack(IStackReader<object> store)
    {
        while(!store.Empty())
            Console.WriteLine(store.Pop());
    }

    static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        PrintStack(a);
        Console.WriteLine("-------------------");
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(5, 21));
        b.Push(new Interval(7, 42));
        b.Push(new Interval(6, 13));
        b.Push(new Interval(4, 54));
        PrintStack(b);
    }
}
