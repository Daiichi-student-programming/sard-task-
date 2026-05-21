using System;

public class Program
{
    public static void Main()
    {
        bool isGameEnd = false;
        
        while (true)
        {
            Console.WriteLine("バトルを選べ....1.空条承太郎&東方仗助 VS DIO 2.空条徐倫 VS プッチ神父(仮)  終わりたいなら”終わり”と");
            string playerselect = Console.ReadLine();

            if (playerselect != "1" && playerselect != "2" && playerselect != "終わり")
            {
                Console.WriteLine("\n???「アバ茶飲ませるぞくそが」");
                continue;
            }
            else if (playerselect == "終わり")
            {
                Console.WriteLine("スタープラチナザワールドは時を止めるけどおれとの楽しい時間は止めねぇでくれぇ...!");
                break;
            }

            string player = "承太郎&仗助";
            int playerhp = 700;
            int maxhp = 700;
            int playermp = 80;
            int maxmp = 80;

            string enemy = "DIO";
            int enemyhp = 2400;
            string secondplayer = "空条徐倫";
            int jorinhp = 500; //精神力だからね!空条徐倫は精神力トップクラスだからね!
            int jorinmaxhp = 500;
            int jorinmp = 300; //精神力だk(以下略)
            int jorinmaxmp = 300; //全体数字あげました 細かい調整のためです
            string Timeenemy = "プッチ神父";
            int TimeenemyHP = 2000;
            Random rand = new　Random();
            switch (playerselect)
            {
                case "1":
                    Console.WriteLine("承太郎&仗助VSDIO");
                    Console.WriteLine("承太郎/やれやれだぜ...");
                    Console.WriteLine("DIO/承太郎どうした？そんなハンバーグを頭に載せたガキを連れて");
                    Console.WriteLine("仗助/あんた今,俺の髪がなんだってェェェェッ！");
                    Console.WriteLine("DIO/貧弱 貧弱ゥ!");

                    while (playerhp > 0 && enemyhp > 0)
                    {
                        Console.WriteLine($"\n【承太郎&仗助】hp:{playerhp}/{maxhp} mp:{playermp}/{maxmp} | 【DIO】hp:{enemyhp}");
                        Console.WriteLine("どうする？(1.オラオラ&ドラララ 2.クレイジーD 3.時止め 4.精神統一)");
                        
                        string chois = Console.ReadLine();
                        bool isSkipEnemyAttack = false;

                        if (chois == "1")
                        {
                            int damage = rand.Next(140, 350);
                            Console.WriteLine("オラオラオラオラァッ！\nドララララララッ！");
                            Console.WriteLine($"同時ラッシュ！DIOに{damage}のダメージッ‼");
                            enemyhp -= damage;
                        }
                        else if (chois == "2")
                        {
                            if (playermp >= 30)
                            {
                                int heal = rand.Next(400, 450);
                                playerhp += heal;
                                if (playerhp > maxhp) playerhp = maxhp;
                                playermp -= 30;
                                Console.WriteLine($"クレイジーDによる治療!仗助たちのhpが{heal}回復した！");
                            }
                            else
                            {
                                Console.WriteLine("MPが足りません！");
                                continue;
                            }
                        }
                        else if (chois == "3")
                        {
                            if (playermp >= 10)
                            {
                                playermp -= 10;
                                if (rand.Next(0, 100) < 50)
                                {
                                    Console.WriteLine("スタープラチナ・ザ・ワールド!時は止まった!2ターン追加!");
                                    for (int i = 0; i < 2; i++)
                                    {
                                        if (enemyhp <= 0) break;
                                        Console.WriteLine($"\n【止まった時の中】残りの行動:{2 - i}回 / 1.オラオラァッ!");
                                        string stopChois = Console.ReadLine();
                                        if (stopChois == "1")
                                        {
                                            int stopdamage = rand.Next(100, 160);
                                            Console.WriteLine($"オラオラオラオラァッ!!承太郎の単独ラッシュ!DIOに{stopdamage}のダメージ");
                                            enemyhp -= stopdamage;
                                        }
                                    }
                                    Console.WriteLine("「時は動き出す...」");
                                    isSkipEnemyAttack = true;
                                }
                                else
                                {
                                    Console.WriteLine("なにィッ!集中力が足りない...!時止めに失敗!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("MPが足りません！");
                                continue;
                            }
                        }
                        else if (chois == "4")
                        {
                            playermp = maxmp;
                            Console.WriteLine("承太郎たちは精神を統一した。MPが全回復した！");
                        }
                        else
                        {
                            Console.WriteLine("1〜4の番号を半角で入力してください。");
                            continue;
                        }

                        if (enemyhp <= 0)
                        {
                            Console.WriteLine("\nDIO「な...なにぃぃーーーッ！このDIOがァァァァッ！！」");
                            Console.WriteLine("DIOは粉砕された。YOU WIN!");
                            break;
                        }

                        if (!isSkipEnemyAttack)
                        {
                            int enemydamage = rand.Next(150, 200);
                            Console.WriteLine($"\nDIO [無駄無駄無駄無駄無駄ァッ!!] {enemydamage}のダメージ！");
                            playerhp -= enemydamage;
                        }

                        if (playerhp <= 0)
                        {
                            Console.WriteLine("\n承太郎たちは再起不能（リタイア）した... GAME OVER");
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("テストバージョンだよ!第一中学校の娯楽になればと思ってゲーム制作しているよ!\n正直遊んで楽しかった!や、もっと追加してほしい!みたいな意見がモチベなのでぜひぜひ遊んでください!感想も欲しいです!デモ版みたいなのもあるかも!");
                    Console.WriteLine("徐倫「やれやれってやつだわ」"); //余談ですがうす汚ねェきゅうくらりん族とかの血を絶やしてやるくらりんを流しながら作業をここらへんはしてました
                    Console.WriteLine("プッチ神父「承太郎も死んだ今...お前に勝てる道理はない!」");
                    Console.WriteLine("徐倫「プッチ神父...私はあんたが得たものを封印する!」");
                    int mebiusGuardTurns = 0;
                    while(jorinhp > 0 && TimeenemyHP > 0)
                    {
                      Console.WriteLine($"\n【徐倫】hp:{jorinhp} mp:{jorinmp} 【プッチ神父】 hp:{TimeenemyHP}");
                      Console.WriteLine("行動を選べ!1.オラオラッ!(通常攻撃) 2.メビウスの輪:MP30 3.1000球だ:MP60 4.感覚の集中:MP全回復");
                      string Action = Console.ReadLine();
                        if (Action == "1")
                        {
                            int attackdamege = rand.Next(100,170);
                            Console.WriteLine($"オラオラオラァ!徐倫のラッシュ!プッチ神父に{attackdamege}のダメージ!");
                            TimeenemyHP -= attackdamege;
                        }
                        if (Action == "2")
                        {
                            if (jorinmp >= 30)
                            {
                                int Mebiusdamege = rand.Next(50,130);
                                Console.WriteLine("徐倫「裏表のない『メビウスの輪』!あんたの攻撃を流してやるわ!」");
                                Console.WriteLine($"徐倫の受け流しにより被ダメージ減少!さらにカウンターでプッチ神父に{Mebiusdamege}のダメージ!"); // 他キャラ活かして特殊技作ろうと思ってたから、不可抗力で徐倫が攻撃技ばっかのゴリラに...(泣)
                                TimeenemyHP -= Mebiusdamege;
                                jorinmp -=30;
                                mebiusGuardTurns = 3;
                            }
                        }
                        break;
                    }
                    break;

            }
        }
    }
}
