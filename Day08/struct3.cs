using System;


interface IStruct
{
    void foo();
}

// 構造体はインターフェースを実装することはできる。
struct MyStruct : IStruct
{
    public int x;

    //public MyStruct()
    public MyStruct(int x)
    {
        Console.WriteLine("constructer");
        this.x = x;
    }

    public void foo()
    {
        Console.WriteLine("Foo!");
    }
}

public class Struct3
{
    public static void Main(string[] args)
    {
        MyStruct s = new MyStruct();
        s.foo();
        Console.WriteLine("s.x = {0}", s.x);

        // コンストラクタで構造体のメンバを初期化できる
        MyStruct s2 = new MyStruct(5);
        Console.WriteLine("s2.x = {0}", s2.x);
    }
}
