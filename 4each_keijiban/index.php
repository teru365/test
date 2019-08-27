<!DOCTYPE html>
<html lang="ja">

<head>
    <meta charset="UTF-8">
    <title>4eachblog 掲示板</title>
    <link rel="stylesheet"type="text/css" href="style.css">
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
<div class="mainleft">
    <h1>プログラミングに役立つ掲示板</h1>
    <h4>入力ホーム</h4>
<form method="post" action="insert.php">
    <div>
        <label>名前</label>
        <br>
        <input type="text" class="text"size="35"name="handlename">
    </div>
    <div>
        <label>タイトル</label>
        <br>
        <input type="text" class="text"size="35"name="title">
    </div>
    <div>
        <label>コメント</label>
        <br>
        <textarea clos="35"rows="7"name="comments"></textarea>
    </div>
    <diV>
        <input type="submit"class="submit" value="投稿する">
    </diV>
</form>
    </div>
    <div class="mainright">
        <h3>人気の記事</h3>
        <p>PHP オススメの本</p>
        <p>PHP Myadomineの使い方</p>
        <p>今人気のエディタ top5</p>
        <p>HTMLの基礎</p>
        
        <h3>オススメリンク</h3>
        <p>株式会社</p>
        <p>XAMPPのダウンロード</p>
        <p>Eclipseのダウンロード</p>
        <p>Bracketsのダウンロード</p>
        
        <h3>カテゴリ</h3>
        <p>HTML</p>
        <p>PHP</p>
        <p>Mysql</p>
        <p>javaScript</p>
    </div>

<?php
    mb_internal_encoding("utf8");
    $pdo = new PDO("mysql:dbname=lesson01;host=localhost;","root","");
    $stmt =$pdo->query("select * from 4each_keijiban");

while($row = $stmt->fetch()){
    
    echo "<div class='kiji'>";
    echo"<h4>".$row['title']."</h4>";
    echo "<div class='contents'>";
    echo $row['comments'];
echo"<div class='handlename'>posted by".$row['handlename']."</div>";
echo"</div>";
echo"</div>";
    }
    ?>

</main>
    <footer>
    copyright &copy; internous | 4each blog is the one which provides A to about programming.
    </footer>
    
</body>

</html>