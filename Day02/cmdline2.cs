using System;

public class CommandLine
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Num of command-line parameters = {0}", args.Length);

        // foreach ���g���ꍇ�A�C���f�b�N�X����肽���ꍇ�ɂ�
        // �����ŃJ�E���^��邵���Ȃ������B
        // https://msdn.microsoft.com/ja-jp/library/ttw7t8t6.aspx

        foreach (string s in args)
        {
            Console.WriteLine(s);
        }
    }
}
