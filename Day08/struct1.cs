
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

        // 構造体は値型なので、（参照ではなく）値そのものを保持する領域が確保され、
        // 新しい値が書き込まれる。
        SimpleStruct ss2 = ss;

        // そのため、ssとss2を別々に書き換えられる。
        ss2.X = 7;

        // ssとss2は異なる値となる。
        ss.DisplayX();
        ss2.DisplayX();
    }
}
