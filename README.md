# Unity_SoundGame-for-Mac
This repository has Unity_packages for SoundGame.

These packages use both Windiws and Mac.

using --ver.1.0.4--
1. ver.1.0.4のパッケージをProjectにドラッグ＆ドロップ

2. Assets>>Prefabs からStageを選んでHierarchyにドラッグ＆ドロップ

3. 2.でドロップしたStageのz座標を(24*小節目-12)にする。

　　ex)6小節目ならば　z=24 * 6-12

4. 2~3を小節の数だけ繰り返す

5. MainCamera >> Player Move Script >> Time　を曲の長さ(秒)にする

6. MainCamera >> Player Move Script >> End Position (x,y,z)=(0,3,24*(小節の数))にする

　　5,6 は画像参照

   ![2019-02-11 15 54 02](https://user-images.githubusercontent.com/44997646/52549963-3df46e00-2e19-11e9-8b29-06bad65199a6.png)

7. Assets >> Prefabs >> (Ball(nomal) or Ball(speical)) を並べる(x座標は(-3,-1,1,3)のいずれか)

   ~~簡単にいうと太◯の達人みたいに並べればいい~~

8. Hierarchy >> Ball >> (Nomal Ball Script or SP Ball Script) >> Canvas　

　　ここの◎をクリックしてCanvasを選ぶ

　　![2019-02-11 16 27 10](https://user-images.githubusercontent.com/44997646/52550124-194cc600-2e1a-11e9-8d3f-7fd6dcf7a517.png)

9. 完成！　(多分・・・)

曲はdefaultで　「[Take your Way](https://www.youtube.com/watch?v=zZ-NG0kZURg)」が入っています。

## 質問受け付けてます。下記のメールアドレスからできます。

***
mail **(luckyhiroaki0922@gmail.com)
　　
