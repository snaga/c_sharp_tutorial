## Day10

* サンプルはDocumentクラスの中にアクセッサを持った WordCollection というクラスと CharacterCollection クラスを持つ。
    * doc.Words[i] や doc.Characters[i] といった形で参照、更新できるようにする。
* readonlyを指定すると、コンストラクタまたは宣言の文脈でのみ値を設定できるようになる。
    * https://msdn.microsoft.com/ja-jp/library/acdd6hb7.aspx
* が、この例だと WordCollection と CharacterCollection のアクセッサを介して値を書き換えているように見えるのだが、アクセッサ経由だと可能なの？　なんで？
* outパラメータを指定すると、メソッドから複数の値を返すことができる
    * https://msdn.microsoft.com/ja-jp/library/t3c3bfhx.aspx
* Array.Copyは配列を部分的にコピーする
    * https://msdn.microsoft.com/ja-jp/library/system.array.copy(v=vs.110).aspx
* ちょっといろいろややこしい。
