using System;

class ArrayTest
{
	public static void Main(string[] args)
    {
        Console.WriteLine("hello, world");

        // その1：一次元配列
        int[] a;
		a = new int[]{ 1,2,3 };

        // 何も考えずにWriteLineしようとするとデータ型が表示される。
        Console.WriteLine("{0}", a);
        // 要素を表示
        Console.WriteLine("a[1] = {0}", a[1]);
        // 長さを表示
        Console.WriteLine("Length = {0}", a.Length);

        // その2：多次元配列
        //int[,] b;
        //b = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        //int[,] b = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        int[,] b;
        // エラー
        //b = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        // OK
        b = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        Console.WriteLine("{0}", b);
		// 12になる
        Console.WriteLine("Length = {0}", b.Length);

        // iは1～12を取る（添字ではなく要素を取り出している）
        foreach (int i in b)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("");

        // b.Length は 12 だが、こういう一次元的なアクセスはできない。
        // 「System.IndexOutOfRangeException」が出る
        for (int i = 0; i < b.Length; i++)
        {
            //            Console.Write("{0} ", b[i,0]);
            //            Console.Write("{0} ", b[0,i]);
        }
        Console.WriteLine("");

        // その3：ジャグ配列
        // 長さの異なる配列を要素として持つ配列を作れる
        int[][] c = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

		// この場合、長さは2となる
        Console.WriteLine("c.Length = {0}", c.Length);

        // ということは、以下のようにnested loopをわりと楽に書ける
        // outer loop
        foreach (int[] i in c) // outer loop
        {
            foreach (int j in i) // inner loop
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("");
        }
    }
}
