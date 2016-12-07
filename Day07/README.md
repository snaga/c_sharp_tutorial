## Day7

* foreach と一緒に使えるのはコレクションクラス。
* 必要なのは IEnumerable クラス（コレクション）とEnumeratorクラス。
* コレクションクラスを作るには IEnumerable インターフェースを実装する
    * https://msdn.microsoft.com/ja-jp/library/9eekhta0(v=vs.110).aspx
* public IEnumerator GetEnumerator() メソッドを実装する
* GetEnumerator() では IEnumerator インターフェースを実装したオブジェクトを返す
    * https://msdn.microsoft.com/ja-jp/library/system.collections.ienumerator(v=vs.110).aspx
    * メソッドとして MoveNext() と Reset() を実装する。
    * プロパティとして Current を参照専用として実装する。
* IEnumerable/IEnumeratorから派生せずに実装すると、（状況によっては）オブジェクトではなくプリミティブを返せるので、foreachでの方チェックが厳密になる。
    * 結果として実行時のエラーではなく、ビルド時に型チェックされる。
* ただし、「ランタイム互換言語との互換性」がなくなる。
    * この話、よく分からん。
* 両立させるには「明示的なインターフェイスの実装」というのがあるらしいが、Day15で出てくるみたいなので、ここでは割愛。

