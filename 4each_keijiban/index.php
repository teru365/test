<!DOCTYPE html>
<html lang="ja">
<head>
<meta charset="UTF-8">
<title>4eachblog 掲示板</title>
<link rel="stylesheet"type="text/css"href="style.css">
</head>
<body>
<div class="gazou">
<img src="4eachblog_logo.jpg"> 
</div>

<header>
<ul>
<li>トップ</li>
<li>プロフィール</li>
<li>4eachについて</li>
<li>登録フォーム</li>
<li>問い合わせ</li>
<li>その他</li>
</ul>
</header>
<main>
<h1>プログラミングに役立つ掲示板</h1>
<h4>入力ホーム</h4>
<form method="post" action="insert.php">
<div>
	<label>名前</label>
	<br>
	<input type="text"class="text"size="35"name="handlename">
</div>
<div>
	<label>タイトル</label>
	<br>
	<input type="text"class="text"size="35"name="title">
</div>
<div>
	<label>コメント</label>
	<br>
	<textarea cols="35"rows="7"name="commnets"></textarea>
</div>
	<div>
	<input type="submit" class="submit" value="送信する">
	</div>
</form>
<div class="mainleft">
<div class="box1">
    <div class="box_pic1" >
    <img src="pic1.jpg">
        <p>ドメイン取得方法</p>
    </div>
    <div class="box_pic1">
    <img src="pic2.jpg">
        <p>快適な職場環境</p>
    </div>
    <div class="box_pic1">
    <img src="pic3.jpg">
         <p>Linuxの基礎</p>
    </div>
    <div class="box_pic1">
    <img src="pic4.jpg">
         <p>マーケティング</p>
    </div>
</div>
    
<div class="box2">
    <div class="box_pic1">
    <img src="pic5.jpg">
        <p>アクティブラーニング</p>
    </div>
    <div class="box_pic1">
    <img src="pic6.jpg">
        <p>CSSの効率的な勉強方法</p>
    </div>
    <div class="box_pic1">
    <img src="pic7.jpg">
         <p>リーダブルコードとは</p>
    </div>
    <div class="box_pic1">
    <img src="pic8.jpg">
         <p>HTML5の可能性</p>
    </div>
</div>
</div>
    
<div class="mainright">
<h3>人気の記事</h3>
<p>PHP オススメ本</p>
<p>PHP　Myadomineの使い方</p>
<p>今人気のエディタ top5</p>
<p>HTMLの基礎</p>
    
<h3>オススメリンク</h3>
<p>インターノウス株式会社</p>
<p>XAMPPのダウンロード</p>
<p>Eclipseのダウンロード</p>
<p>Bracketsのダウンロード</p>
    
<h3>カテゴリ</h3>
<p>HTML</p>
<p>PHP</p>
<p>MySQL</p>
<p>javaScript</p>
</div>
    
</main>
    
<footer>
copyright &copy; internous | 4each blog is the one which provides A to about programming.
</footer>
    
</body>
</html>