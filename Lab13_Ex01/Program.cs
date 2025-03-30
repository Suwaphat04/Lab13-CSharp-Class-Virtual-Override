using System;

class Program
{
    static void Main()
    {
        DerivedClass dcRef = new DerivedClass();
        BaseClass bcRef = new BaseClass();

        dcRef.Info();
        bcRef.Info();
    }
}

class BaseClass
{
    virtual public void Info()
    {
        Console.WriteLine("This is BaseClass");
    }
}

class DerivedClass : BaseClass
{
    override public void Info()
    {
        Console.WriteLine("This is DerivedClass");
    }
}

