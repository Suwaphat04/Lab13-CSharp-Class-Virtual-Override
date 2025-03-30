using System;

class Program
{
    static void Main()
    {
        BaseClass bcRef = new DerivedClass();
        Console.WriteLine(bcRef.Data);
    }
}

class BaseClass
{
    virtual public string Data 
    { 
        get 
        { 
            return "Base Data"; 
        } 
    }
}

class DerivedClass : BaseClass
{
    override public string Data 
    { 
        get 
        { 
            return "Derived Data"; 
        } 
    }
}
