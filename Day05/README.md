## Day5

* ライブラリ（DLL）を作って呼び出す
* ライブラリ側で名前空間を定義する namespace Functions
* 一つのライブラリを構成する複数のソース内で名前空間が重なってても大丈夫っぽい。
* DLLを作るには /target:library /out:Functions.dll
* DLLを使う時には using <名前空間>;
* DLLを使うアセンブリをビルドする時には /R:Functions.DLL を付ける
* ちょっと今日マジ時間ない。
