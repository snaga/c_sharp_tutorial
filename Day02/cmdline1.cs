using System;

public class CommandLine
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Num of command-line parameters = {0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Arg[{0}] = {1}", i, args[i]);
            // WriteLineじゃなくてWriteを使うと改行されない。
            Console.Write("Arg[{0}] = {1}", i, args[i]);
        }
        Console.WriteLine("");

        // 関係ないけど、簡単な書式付き出力はこんな感じ
        // 桁数指定は後ろにくる。
        // http://ufcpp.net/study/dotnet/bcl_format.html
        Console.WriteLine("{0:d4}, 0x{1:x4}", 100, 100);
    }
}
