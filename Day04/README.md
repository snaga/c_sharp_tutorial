## Day4

* プロパティというのはクラスのメンバとのインターフェース。set/getというアクセサを持つ。
* どちらかだけを用意することで、読み込み専用、書き込み専用のプロパティとすることができる。
* メンバにはメンバーアクセス修飾子としてpublic/privete/protected/internal/protected internal属性を設定できる。
* internalというのは「同じアセンブリ内の任意のコードからアクセスできる」
    * https://msdn.microsoft.com/ja-jp/library/ms173121.aspx
* C#で言う「アセンブリ」は「ざっくり言うとexeかdllのこと」らしい。
	* http://qiita.com/rita0222/items/609583c31cb7f0132086#%E3%82%A2%E3%82%BB%E3%83%B3%E3%83%96%E3%83%AA%E3%81%A8%E3%81%AF
* ToString() をオーバーライドする時、明示的に宣言しないとコンパイルで警告が出てオーバーライドされない。
    * 詳細は Day6 で出てきそうなのでここでは割愛。
* override された ToString() は WriteLine() の文脈で暗黙的に呼び出される。
* コンストラクタは「基本クラス→派生クラス」の順で呼ばれる。
* 派生クラスのコンストラクタから呼び出す基本クラスのコンストラクタは base で指定する。
    * https://msdn.microsoft.com/ja-jp/library/hfw7t1ce.aspx
* base を省略すると、同じシグネチャの基本クラスのコンストラクタが呼ばれる。
    * 該当するものが無ければコンパイル時にエラーになる。（っぽい？）
