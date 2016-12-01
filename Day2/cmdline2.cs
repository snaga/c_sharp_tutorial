using System;

public class CommandLine
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Num of command-line parameters = {0}", args.Length);

        // foreach を使う場合、インデックスを取りたい場合には
        // 自分でカウンタ作るしかなさそう。
        // https://msdn.microsoft.com/ja-jp/library/ttw7t8t6.aspx

        foreach (string s in args)
        {
            Console.WriteLine(s);
        }
    }
}
