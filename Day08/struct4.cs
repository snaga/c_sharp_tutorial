using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
struct TestUnion
{
    [FieldOffset(0)]
    public int i;
    [FieldOffset(0)]
    public double d;
    [FieldOffset(0)]
    public char c;
    [FieldOffset(0)]
    public byte b1;
}

class Struct4
{
    public static void Main(string[] args)
    {
        TestUnion u = new TestUnion();
        u.i = 0;
        Console.WriteLine("i={0}, d={1}, c={2}, b1={3}", u.i, u.d, u.c, u.b1);

        u.i = 3;
        Console.WriteLine("i={0}, d={1}, c={2}, b1={3}", u.i, u.d, u.c, u.b1);

        u.d = 3.14;
        Console.WriteLine("i={0}, d={1}, c={2}, b1={3}", u.i, u.d, u.c, u.b1);

        u.c = 'a';
        Console.WriteLine("i={0}, d={1}, c={2}, b1={3}", u.i, u.d, u.c, u.b1);

        u.b1 = 0x20;
        Console.WriteLine("i={0}, d={1}, c={2}, b1={3}", u.i, u.d, u.c, u.b1);
    }
}
