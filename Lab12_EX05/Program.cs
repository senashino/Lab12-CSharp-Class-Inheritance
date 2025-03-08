using System;

interface IBaseClass1
{
    void Method1();
}

interface IBaseClass2
{
    void Method2();
}

class BaseClass1 : IBaseClass1
{
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
    
    public void Method1()
    {
        System.Console.WriteLine("Method1 from BaseClass1");
    }
}

class BaseClass2 : IBaseClass2
{
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
    
    public void Method2()
    {
        System.Console.WriteLine("Method2 from BaseClass2");
    }
}

class DerivedClass : BaseClass1, IBaseClass2
{
    public DerivedClass() : base() // เรียกคอนสตรัคเตอร์ของ BaseClass1
    {
        System.Console.WriteLine("This is DerivedClass");
    }
    
    public void Method2()
    {
        System.Console.WriteLine("Method2 from DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();  // สร้างอ็อบเจกต์ของ DerivedClass
    }
}
