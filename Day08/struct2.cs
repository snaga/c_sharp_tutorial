

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

        // �\���́A�N���X�����ꂼ��1�ɏ�����
        a.x = 1;
        b.x = 1;
        Console.WriteLine("a.x = {0}", a.x);
        Console.WriteLine("b.x = {0}", b.x);

        // ���\�b�h�ɓn���ď���������
        structtaker(a);
        classtaker(b);

        // �l�n���̍\���͕̂ς�炸�A�Q�Ɠn���̃N���X�̒l�͕ς��A
        Console.WriteLine("a.x = {0}", a.x);
        Console.WriteLine("b.x = {0}", b.x);
    }
}