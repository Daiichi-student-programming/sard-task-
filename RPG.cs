using System;

public class Program
{
    public static void Main()
    {
        string player = "承太郎&仗助";
        int playerhp = 350;
        int maxhp = 350;
        int playermp = 80;
        int maxmp = 80;

        string enemy = "DIO";
        int enemyhp = 800;

        Console.WriteLine("承太郎&仗助VSDIO");
        Console.WriteLine("承太郎/やれやれだぜ...");
        Console.WriteLine("DIO/承太郎どうした？そんなハンバーグを頭に載せたガキを連れて");
        Console.WriteLine("仗助/あんた今,俺の髪がなんだってェェェェッ！");
        Console.WriteLine("DIO/貧弱 貧弱ゥ!");

        Random rand = new Random();

        while (playerhp > 0 && enemyhp > 0)
        {
            Console.WriteLine($"\n【承太郎&仗助】hp:{playerhp}/{maxhp} mp:{playermp}/{maxmp} | 【DIO】hp:{enemyhp}");
            Console.WriteLine("どうする？(1.オラオラ&ドラララ 2.クレイジーD 3.時止め 4.精神統一)");
            
            string chois = Console.ReadLine();
            bool isSkipEnemyAttack = false;

            if (chois == "1")
            {
                int damage = rand.Next(70, 150);
                Console.WriteLine("オラオラオラオラァッ！\nドララララララッ！");
                Console.WriteLine($"同時ラッシュ！DIOに{damage}のダメージッ‼");
                enemyhp -= damage;
            }
            else if (chois == "2")
            {
                if (playermp >= 30)
                {
                    int heal = rand.Next(250,300);
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
                                int stopdamage = rand.Next(50, 80);
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
                int enemydamage = rand.Next(90, 120);
                Console.WriteLine($"\nDIO [無駄無駄無駄無駄無駄ァッ!!] {enemydamage}のダメージ！");
                playerhp -= enemydamage;
            }

            if (playerhp <= 0)
            {
                Console.WriteLine("\n承太郎たちは再起不能（リタイア）した... GAME OVER");
            }
        }
    }
}