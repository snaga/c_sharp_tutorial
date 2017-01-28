## Day3

* 多次元配列の時に各次元の長さを取得するには GetLength(X) メソッドを使う。
    * int[,] a = new int[3,2] の時、a.GetLength(0) == 3 で a.GetLength(1) == 2 となる。
    * a.Length は 6 となる。
* ジャグ配列を使うと、各次元の長さを取得できるので、nested loopを楽に書ける。
* push/pop や append/remove 的なのは無いのだろうか？
    * Stack<T> を使いましょう、ということかな。
	* https://msdn.microsoft.com/ja-jp/library/3278tedw(v=vs.110).aspx
