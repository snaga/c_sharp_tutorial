using System;


interface IStruct
{
    void foo();
}

// �\���̂̓C���^�[�t�F�[�X���������邱�Ƃ͂ł���B
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

        // �R���X�g���N�^�ō\���̂̃����o���������ł���
        MyStruct s2 = new MyStruct(5);
        Console.WriteLine("s2.x = {0}", s2.x);
    }
}
