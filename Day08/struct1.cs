
using System;
struct SimpleStruct
{
    private int xval;
    public int X
    {
        get
        {
            return xval;
        }
        set
        {
            if (value < 100)
                xval = value;
        }
    }
    public void DisplayX()
    {
        Console.WriteLine("The stored value is: {0}", xval);
    }
}

class TestClass
{
    public static void Main()
    {
        SimpleStruct ss = new SimpleStruct();
        ss.X = 5;
        ss.DisplayX();

        // �\���̂͒l�^�Ȃ̂ŁA�i�Q�Ƃł͂Ȃ��j�l���̂��̂�ێ�����̈悪�m�ۂ���A
        // �V�����l���������܂��B
        SimpleStruct ss2 = ss;

        // ���̂��߁Ass��ss2��ʁX�ɏ�����������B
        ss2.X = 7;

        // ss��ss2�͈قȂ�l�ƂȂ�B
        ss.DisplayX();
        ss2.DisplayX();
    }
}
