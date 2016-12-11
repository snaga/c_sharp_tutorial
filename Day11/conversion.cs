// conversion.cs
using System;

struct RomanNumeral
{
    public RomanNumeral(int value)
    {
        this.value = value;
    }

    // implicit��int����RomanNumeral�ɕϊ����郁�\�b�h
    static public implicit operator RomanNumeral(int value)
    {
        // �v����� implicit �� new ���邾���B
        return new RomanNumeral(value);
    }
    // explicit��RomanNumeral����int�ɕϊ�����B
    static public explicit operator int(RomanNumeral roman)
    {
        // int�̒l��Ԃ�
        return roman.value;
    }

    // implicit��string�ɕϊ����ꂽ���́A��������Ă��Ȃ����Ă��Ƃɂ���
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

        // RoanNumeral��int��explicit�ɕϊ�����
        // static public explicit operator int(RomanNumeral roman)���Ă΂��
        Console.WriteLine((int)numeral);

        // implicit��int�Ɖ��Z���悤�Ƃ��Ă�string�Ƃ��Ĉ�����炵���B
        // "1Conversion not yet implemented" �Əo�͂����B
        Console.WriteLine((1 + numeral));
        // eexplicit�ɃL���X�g���Ă��牉�Z�����"11"�Əo�͂����B
        Console.WriteLine((1 + (int)numeral));

        // ����������WriteLine�ɓn���ƁAimplicit��string�ɃL���X�g�����B
        // static public implicit operator string(RomanNumeral roman)���Ă΂��B
        Console.WriteLine(numeral);

        // short�ɃL���X�g����ƁA�܂�int��explicit�ɕϊ�����A
        // ���̌�int����short�ɃL���X�g�����B�܂蓮���B
        short s = (short)numeral;

        Console.WriteLine(s);
    }
}