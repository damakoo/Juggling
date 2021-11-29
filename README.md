# Juggling

ジャグリング学習支援VR

# DEMO

https://www.youtube.com/watch?v=kdx5XTNDz0c

# Features



# Requirement

Oculus Quest または Oculus Quest 2

Unity

# Installation & Usage

```bash
git clone https://github.com/damakoo/Juggling.git
```

Unity Hubでcloneしたプロジェクトを指定する

Project > Assets > Scenes > beanbagger.unity　を開く

Oculus Questを接続File > Build And Run で実行

中指または人差し指のトリガー(IndexTrigger,HandTrigger)を引くことにより，各トリガーにつき一つずつボールをつかむことができるようになっている．

机に向かって左側にあるパラメータパネルに向けて右コントローラのAボタン(Button.One)を押すことで各パラメータを調整することができる．

TimeScale:調整することで球の速度を遅くすることができる．

BallSize:ボールの大きさを調整できる．

Orbital:fixにすることで軌道を固定できる．放されたボールは放物線を描いて放した瞬間の反対の手の位置に落下するようになっている．

time:fixのとき，ボールを話してから反対の手にボールが到達するまでの時間を調整できる(単位は秒)．freeにおいても値を大きくすることでボールが高く飛びやすくなる．

ResetPos:右のResetボタンを押すことでボールをもとの位置に戻すことができる．左コントローラのXボタン(Button.Three)を押すことでもボールを初期位置に戻すことができる．


# Author
Daiki Kodama

東京大学大学院情報理工学系研究科知能機械情報学専攻修士1年

email:d_kodama at cyber.t.u-tokyo.ac.jp

