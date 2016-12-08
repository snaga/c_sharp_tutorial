

// struct2.cs
using System;

class TheClass
{
    public int x;
}

struct TheStruct
{
    public int x;
}

class TestClass
{
    public static void structtaker(TheStruct s)
    {
        s.x = 5;
    }
    public static void classtaker(TheClass c)
    {
        c.x = 5;
    }
    public static void Main()
    {
        TheStruct a = new TheStruct();
        TheClass b = new TheClass();

        // 構造体、クラスをそれぞれ1に初期化
        a.x = 1;
        b.x = 1;
        Console.WriteLine("a.x = {0}", a.x);
        Console.WriteLine("b.x = {0}", b.x);

        // メソッドに渡して書き換える
        structtaker(a);
        classtaker(b);

        // 値渡しの構造体は変わらず、参照渡しのクラスの値は変わる、
        Console.WriteLine("a.x = {0}", a.x);
        Console.WriteLine("b.x = {0}", b.x);
    }
}