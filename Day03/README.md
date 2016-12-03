## Day3

* 多次元配列の時に各次元の長さを取得する方法が分からない。
* int[,] a = new int[3,2] としたら a.Length は 6 となるので、3や2はコード側で覚えておく必要がある。
    * 一次元的なアクセスはできない。
* ジャグ配列を使うと、各次元の長さを取得できるので、nested loopを楽に書ける。
* push/pop や append/remove 的なのは無いのだろうか？
    * Stack<T> を使いましょう、ということかな。
	* https://msdn.microsoft.com/ja-jp/library/3278tedw(v=vs.110).aspx
