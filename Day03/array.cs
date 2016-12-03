using System;

class ArrayTest
{
	public static void Main(string[] args)
    {
        Console.WriteLine("hello, world");

        // ����1�F�ꎟ���z��
        int[] a;
		a = new int[]{ 1,2,3 };

        // �����l������WriteLine���悤�Ƃ���ƃf�[�^�^���\�������B
        Console.WriteLine("{0}", a);
        // �v�f��\��
        Console.WriteLine("a[1] = {0}", a[1]);
        // ������\��
        Console.WriteLine("Length = {0}", a.Length);

        // ����2�F�������z��
        //int[,] b;
        //b = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        //int[,] b = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        int[,] b;
        // �G���[
        //b = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        // OK
        b = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        Console.WriteLine("{0}", b);
		// 12�ɂȂ�
        Console.WriteLine("Length = {0}", b.Length);

        // i��1�`12�����i�Y���ł͂Ȃ��v�f�����o���Ă���j
        foreach (int i in b)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("");

        // b.Length �� 12 �����A���������ꎟ���I�ȃA�N�Z�X�͂ł��Ȃ��B
        // �uSystem.IndexOutOfRangeException�v���o��
        for (int i = 0; i < b.Length; i++)
        {
            //            Console.Write("{0} ", b[i,0]);
            //            Console.Write("{0} ", b[0,i]);
        }
        Console.WriteLine("");

        // ����3�F�W���O�z��
        // �����̈قȂ�z���v�f�Ƃ��Ď��z�������
        int[][] c = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

		// ���̏ꍇ�A������2�ƂȂ�
        Console.WriteLine("c.Length = {0}", c.Length);

        // �Ƃ������Ƃ́A�ȉ��̂悤��nested loop�����Ɗy�ɏ�����
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
