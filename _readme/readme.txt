TvRemoteViewer_VB v0.03

チューナー数だけ平行起動してパパッとチャンネルを変更しようと思ったが4つでCPU100%・・



■環境


FrameWork4.0



■起動


設置後、起動するとタスクトレイからスタートします。
ダブルクリックで通常の大きさになります。
各パラメーターはreadme.jpg参照のこと
プログラミングするときはform1のWindowStateをNormalにしておくと通常の大きさで起動しますから便利でしょう。



■設置 readme.jpgや下に書いたテスト環境を参考にしてください


・RecTaskとBonDriverを適切に配置


・ffmpeg又はVLCをインストール（★半角スペースが入らない場所のほうが安心です）
（★ffmpegを使う場合は同梱のlibx264-ipod640.ffpresetをffmpegをインストールしたとこのpresetsフォルダにコピー）


・同梱のform_status〜.txtとHLS_option〜.txtをTvRemoteViewer_VB.exeと同じフォルダにコピー


・WWWROOT（WEBルートフォルダ）に同梱のHTMLフォルダ内のファイルをコピー
（★半角スペースが入らない場所のほうが安心です）


・index.htmlとViewTV*.htmlを自分の環境用に編集　★重要★　現状は関東に設定
Bondriver名とチャンネル名とServiceID、CSを指定する場合はチャンネルスペースを編集のうえ保存してください。
チャンネル名とサービスIDは
http://soranikakaruhashi.blog.fc2.com/blog-entry-71.html
を参考にすると良いでしょう

★htmlファイル名の大文字小文字を維持してください。

・index.html
index.htmlからStartTv（配信開始）が呼び出される際にWEBから送られるパラメーターとしては今のところ以下を想定しています。
Web_Start()内を編集すれば違う動作や異なるWEB設計にも対応できるでしょう。
パラメーター	valueの例
"num"		"1"					ストリームナンバー
"BonDriver"	"BonDriver_pt2_t0.dll"			BonDriverネーム
"ServiceID"	"54321"					サービスID
"ChSpace"	"0"（CSは1)				チャンネルスペース
"resolution"	"640x360"				解像度（縦横の組み合わせは決まっています）
"Bon_Sid_Ch"	"BonDriver_pt2_t0.dll,54321,0"		上記３つを同時に設定
"redirect"	"ViewTV2.html"				配信開始後ジャンプするページ

・ViewTV[n].htmlで使用できる変数
html内に以下の変数を記入しておくと呼び出されたときに適切な値に変換されます
変換前		変換後
%NUM%		ストリームナンバー



■HLSアプリにつきまして


・ffmpegをご使用の場合【推奨】
http://ffmpeg.zeranoe.com/builds/
うちではx64最新版を使用。４つまでは同時起動確認（古いバージョンでは3つ以上は不安定でした）
ffmpegインストール先のpresetsフォルダ内に同梱のlibx264-ipod640.ffpresetをコピーしてください。
参考：http://frmmpgit.blog.fc2.com/blog-entry-179.html
640x360以外の解像度は試していません。
極希に新たなフレームが読み込まれずm3u8が更新されなくなる現象有り


・VLCをご使用の場合
同梱のHLS_option.txtの内容をHLS_option_VLC.txtの内容に差し替えてフォーム上で解像度を選択し直してください。
当方のテストによりますと、複数のプロセスを起動しますとVLCの挙動が大変不安定になります。２つならまぁなんとか。
2.0.5、2.1.0ともクラッシュ多発、延々と再起動を繰り返し起動時に停止することも。2.0.5では応答しなくなる現象が1度有り



・HLSオプションで実行時に変換される定数
"%UDPPORT%"	ソフトで自動的に割り当てられたudpポート
"%WWWROOT%"	WWWのrootフォルダ
"%FILEROOT%"	m3u8やtsが作成されるフォルダ
"%HLSROOT%"	HLSアプリが存在するフォルダ
"%HLSROOT/../%"	HLSアプリが存在するフォルダの１つ上の親フォルダ（ffmpeg解凍時のフォルダ構造に対応）
"%rc-host%"	"127.0.0.1:%UDPPORT%"に変換されます。



■Windows上でのm3u8再生につきまして


・「windows hls 再生」でググればでてくる日本語ページから再生用flashをダウンロードしてhtmlを編集してあげればWindows上でm3u8が再生できます



■テスト環境
Windows7 x64
VisualStudio2010

RecTaskインスコ	=	D:\TvRemoteViewer\TVTest
BonDriver	=	D:\TvRemoteViewer\TVTest
%WWWROOT%	= 	D:\TvRemoteViewer\html
%FILEROOT%	=	D:\TvRemoteViewer\html
%HLSROOT%	=	D:\TvRemoteViewer\ffmpeg-20140628-git-4d1fa38-win64-static\bin
%HLSROOT/../%	=	D:\TvRemoteViewer\ffmpeg-20140628-git-4d1fa38-win64-static
(%HLSROOT%)	=	D:\TvRemoteViewer\vlc

iPad(第3世代）iOS7 safari



■修正したり追加したりして欲しいところ


・全般的に
クラスというものがわかってない・・おまいがっ


・想定外のエラー処理。テスト不足


・iPadでの自動再生


・HLSアプリが動いてるふりしながら停止しているときへの対処
まぁ、配信が止まると見てるほうも止まるから再読込や停止しますよね。
なので対処しなくてもいいかなと放置してます。


・Windows上での各種ニコニコ生放送ソフトとの連携（希望）
表示タイミングの調整
こっちがチャンネル変えたら向こうも変わるとか
実況ないとつまらないです
でも・・作ってみて思いました。使ったことないけどSplashtopが一番現実的かな〜・・orz



■履歴
0.01	酔っ払ってうｐ　今は反省している
0.02	いろんなとこを修正＆追加
0.03	コンソール表示・非表示のチェックボックスを設置
	配信中のストリーム番号をフォーム上に表示
	配信中のストリーム番号をタスクトレイマウスオーバー時に表示
	ffmpegのHLS_option.txt内容を修正（パスを「"」で囲っただけです）