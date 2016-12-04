using System;

public class BaseClass
{
    int num;

    public BaseClass()
    {
        Console.WriteLine("in BaseClass()");
    }

    public BaseClass(int i)
    {
        num = i;
        Console.WriteLine("in BaseClass(int i)");
    }

    public int GetNum()
    {
        return num;
    }
}

public class DerivedClass : BaseClass
{
    // This constructor will call BaseClass.BaseClass()

    // BaseClass()‚ªŒÄ‚Î‚ê‚é
    //public DerivedClass()

    // BaseClass(int i)‚ªŒÄ‚Î‚ê‚é
    //public DerivedClass() : base(0)

    public DerivedClass() : base()
    {
        Console.WriteLine("in DerivedClass()");
    }

    // This constructor will call BaseClass.BaseClass(int i)
    public DerivedClass(int i) : base(i)
    {
        Console.WriteLine("in DerivedClass(int i)");
    }

    static void Main()
    {
        DerivedClass md = new DerivedClass();
        DerivedClass md1 = new DerivedClass(1);
    }
}
/*
Output:
in BaseClass()
in BaseClass(int i)
*/
