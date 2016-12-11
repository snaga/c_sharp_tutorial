// conversion.cs
using System;

struct RomanNumeral
{
    public RomanNumeral(int value)
    {
        this.value = value;
    }

    // implicitにintからRomanNumeralに変換するメソッド
    static public implicit operator RomanNumeral(int value)
    {
        // 要するに implicit に new するだけ。
        return new RomanNumeral(value);
    }
    // explicitにRomanNumeralからintに変換する。
    static public explicit operator int(RomanNumeral roman)
    {
        // intの値を返す
        return roman.value;
    }

    // implicitにstringに変換された時は、実装されていないってことにする
    static public implicit operator string(RomanNumeral roman)
    {
        return ("Conversion not yet implemented");
    }
    private int value;
}

class Test
{
    static public void Main()
    {
        RomanNumeral numeral;

        numeral = 10;

        // RoanNumeralをintにexplicitに変換する
        // static public explicit operator int(RomanNumeral roman)が呼ばれる
        Console.WriteLine((int)numeral);

        // implicitにintと演算しようとしてもstringとして扱われるらしい。
        // "1Conversion not yet implemented" と出力される。
        Console.WriteLine((1 + numeral));
        // eexplicitにキャストしてから演算すると"11"と出力される。
        Console.WriteLine((1 + (int)numeral));

        // 何もせずにWriteLineに渡すと、implicitにstringにキャストされる。
        // static public implicit operator string(RomanNumeral roman)が呼ばれる。
        Console.WriteLine(numeral);

        // shortにキャストすると、まずintにexplicitに変換され、
        // その後intからshortにキャストされる。つまり動く。
        short s = (short)numeral;

        Console.WriteLine(s);
    }
}