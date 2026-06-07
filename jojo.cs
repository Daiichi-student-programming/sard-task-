using System; //余談タイム!ここからのコードはいじくりやすいようにこういうコードのコメントを残してあるよ!このコードそのものはいじっちゃだめだよ!
public class jojoRPG //ほかのエディターなどにコピペしていじくってみてください!
{
    public static void Main() //てゆうかこんだけ頑張ってコメント用意したんだからコード見ろ...(´;ω;｀)
    {
        Random rand = new Random(); // 乱数の変数を作っています!

        while (true)       //繰り返しコードです
        {
            Console.WriteLine("バトルを選べ....1.空条承太郎&東方仗助 VS DIO 2.空条徐倫 VS プッチ神父 3.プッチ神父超ハイテンポモード");
            string playerselect = Console.ReadLine();

            if (playerselect != "1" && playerselect != "2" && playerselect != "3")
            {
                Console.WriteLine("\n???「アバ茶飲ませるぞくそが」");
                continue;
            }

            string player = "承太郎&仗助";
            int playerhp = 700;
            int maxhp = 700;
            int playermp = 80;
            int maxmp = 80;

            string enemy = "DIO";
            int enemyhp = 2400;

            string secondplayer = "空条徐倫";
            int jorinhp = 800;
            int jorinmaxhp = 800;
            int jorinmp = 300;
            int jorinmaxmp = 300;

            string Timeenemy = "プッチ神父";
            int TimeenemyHP = 2000;

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

                                if (playerhp > maxhp)
                                {
                                    playerhp = maxhp;
                                }

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
                                        if (enemyhp <= 0)
                                        {
                                            break;
                                        }

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

                            Environment.Exit(0);
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

                            Environment.Exit(0);
                        }
                    }

                    break;

                case "2":
                case "3":

                    Console.WriteLine("徐倫「やれやれってやつだわ」");
                    Console.WriteLine("プッチ神父「承太郎も死んだ今...お前に勝てる道理はない!」");
                    Console.WriteLine("徐倫「プッチ神父...私はあんたが得たものを封印する!」");

                    int mebiusGuardTurns = 0;
                    int ballcooldown = 0;
                    int kissudebutyubutyu = 0;
                    int Turns = 1;
                    int AnasuiTurns = 0;
                    int HeelPranctonTurns = 0;

                    bool isSenkyuda = false;
                    bool isFFhelp = false;
                    bool isHermes = false;
                    bool isAnasuihelp = false;
                    bool isputchiwei = false;
                    bool isputchides = false;
                    bool isputchidoubledes = false;
                    bool isCMoon = false;
                    bool isCanyouMove = true;
                    bool isMadeinheaven = false;
                    if(playerselect == "3")
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("プッチ神父「なんかよくわからんが天国に到達してる!」"); //引力って便利やな...
                        Console.WriteLine("徐倫一行「ハァッ!?」"); //当然の反応
                        Console.WriteLine("★ 最初から最終形態で始まります...!"); //これ正直賢くない?
                        isFFhelp = true;
                        isHermes = true;
                        isAnasuihelp = true;
                        isputchides = true;
                        isputchidoubledes = true;
                        isMadeinheaven = true;
                        TimeenemyHP = 3000;
                    }

                    while (jorinhp > 0 && TimeenemyHP > 0)
                    {
                        if (Turns == 8 && isFFhelp == false && playerselect != "3")
                        {
                            foreach (char c in ".........?")
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(150);
                            }

                            System.Threading.Thread.Sleep(3000);

                            Console.WriteLine();
                            Console.WriteLine("??「徐倫ーーッ!助けにきたよ!」");

                            System.Threading.Thread.Sleep(2000);

                            foreach (char c in "あんたは...F・Fッ!")
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(100);
                            }

                            Console.WriteLine("\nF・F「あたしは徐倫を守る..!それが『生きる』ってことだから!」");
                            Console.WriteLine("★ F・Fでの回復行動が増えた!");

                            isFFhelp = true;
                        }

                        if (Turns == 12 && isHermes == false && playerselect != "3")
                        {
                            Console.WriteLine("エルメェス「ウッシャァ!」");
                            Console.WriteLine("徐倫「エルメェスも....!」");
                            Console.WriteLine("エルメェス「プランクトンにちょっと遅れは取ったが間に合ってよかったぜ!」");
                            Console.WriteLine("プッチ神父「この死にぞこないどもがぁ!」");

                            Console.WriteLine("\n★さらにエルメェスが加わった!エルメェスの「キッス」が行動に増えた!");

                            isHermes = true;
                        }

                        if (Turns >= 15 && isAnasuihelp == false && jorinhp <= 150 && playerselect != "3")
                        {
                            foreach (char c in ".....?")
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(150);
                            }

                            System.Threading.Thread.Sleep(2000);

                            Console.WriteLine("アナスイ「徐倫!おお!徐倫!愛してるぞぉぉぉ!」");

                            Console.Write("徐倫「");

                            foreach (char anasui in "......まあ来ると思ってたわ")
                            {
                                Console.Write(anasui);
                                System.Threading.Thread.Sleep(100);
                            }

                            Console.WriteLine("」");

                            System.Threading.Thread.Sleep(2000);

                            Console.WriteLine("★アナスイがさらに援護する！");

                            isAnasuihelp = true;
                        }

                        isCanyouMove = true;

                        if (isHermes == true)
                        {
                            Console.WriteLine($"\n【徐倫】hp:{jorinhp} mp:{jorinmp} 【プッチ神父】 hp:{TimeenemyHP} 【経過ターン】{Turns}");
                            Console.WriteLine("行動を選べ!1.オラオラッ!(通常攻撃) 2.メビウスの輪:MP30 3.1000球だ:MP60 4.感覚の集中:MP全回復 5.回復:MP20 6.キッス:MP50");
                        }
                        else if (isFFhelp == true)
                        {
                            Console.WriteLine($"\n【徐倫】hp:{jorinhp} mp:{jorinmp} 【プッチ神父】 hp:{TimeenemyHP} 【経過ターン】{Turns}");
                            Console.WriteLine("行動を選べ!1.オラオラッ!(通常攻撃) 2.メビウスの輪:MP30 3.1000球だ:MP60 4.感覚の集中:MP全回復 5.回復:MP20");
                        }
                        else
                        {
                            Console.WriteLine($"\n【徐倫】hp:{jorinhp} mp:{jorinmp} 【プッチ神父】 hp:{TimeenemyHP} 【経過ターン】{Turns}");
                            Console.WriteLine("行動を選べ!1.オラオラッ!(通常攻撃) 2.メビウスの輪:MP30 3.1000球だ:MP60 4.感覚の集中:MP全回復");
                        }

                        string? Action = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(Action))
                        {
                            Console.WriteLine("ｷｼｮ...ちゃんと入力形式書いといてるだろ...");
                            continue;
                        }

                        if (isCMoon == true)
                        {
                            int Gravity = rand.Next(0, 100);

                            if (mebiusGuardTurns > 0)
                            {
                                Console.WriteLine("徐倫「表裏のない永遠の循環する一つの輪...それが”メビウスの輪”よ!」");
                            }
                            else if (Gravity >= 50)
                            {
                                Console.WriteLine("徐倫「!?」");
                                Console.WriteLine("プッチ神父「重力は引力!」\n★徐倫は行動阻害で動けない...!");

                                isCanyouMove = false;
                            }
                            else
                            {
                                Console.WriteLine("プッチ神父「ふん....運が良かったようだな」");
                            }
                        }

                        if (isCanyouMove == true)
                        {
                            if (Action == "1")
                            {
                                int attackdamege = rand.Next(100, 170);

                                Console.WriteLine($"オラオラオラァ!徐倫のラッシュ!プッチ神父に{attackdamege}のダメージ!");

                                TimeenemyHP -= attackdamege;
                            }
                            else if (Action == "2")
                            {
                                if (jorinmp >= 30)
                                {
                                    int Mebiusdamege = rand.Next(50, 130);

                                    Console.WriteLine("徐倫「裏表のない『メビウスの輪』!あんたの攻撃を流してやるわ!」");
                                    Console.WriteLine($"徐倫の受け流しにより被ダメージ減少!さらにカウンターでプッチ神父に{Mebiusdamege}のダメージ!");

                                    TimeenemyHP -= Mebiusdamege;

                                    jorinmp -= 30;

                                    mebiusGuardTurns = 3;
                                }
                                else
                                {
                                    Console.WriteLine("徐倫「くそっ!糸が練れない...!」");
                                }
                            }
                            else if (Action == "3")
                            {
                                if (ballcooldown > 0 || jorinmp < 60)
                                {
                                    Console.WriteLine("徐倫「こんな状態じゃろくに発動できないわ...!」");
                                    continue;
                                }
                                else
                                {
                                    int senkyudamege = rand.Next(150, 200);

                                    Console.WriteLine($"徐倫「さてキャッチボールは800か?900か?\nいや面倒だな...1000球だ!オラオラオラオラオラァ!プッチ神父に{senkyudamege}の大ダメージ!」");

                                    TimeenemyHP -= senkyudamege;

                                    isSenkyuda = true;

                                    ballcooldown = 2;

                                    jorinmp -= 60;
                                }
                            }
                            else if (Action == "4")
                            {
                                Console.WriteLine("徐倫「感覚を研ぎ澄ますのよ...!あいつをぶちのめしてやるために....」徐倫のMPが全回復!");

                                jorinmp = 300;
                            }
                            else if (Action == "5" && isFFhelp == true)
                            {
                                if (jorinmp < 20)
                                {
                                    Console.WriteLine("F・F「ハッ!?水分が足りない...!」");

                                    continue;
                                }

                                Console.WriteLine("F・F「今回復するからね....」");
                                Console.WriteLine("\nF・Fのプランクトンで徐倫は徐々に回復する!");

                                HeelPranctonTurns = 3;

                                jorinmp -= 20;
                            }
                            else if (Action == "6" && isHermes == true)
                            {
                                if (jorinmp < 50)
                                {
                                    Console.WriteLine("エルメェス「集中力がタリねぇッ!」 徐倫「集中力が足りていない....!」");

                                    continue;
                                }

                                Console.WriteLine("...ペタァ!");

                                System.Threading.Thread.Sleep(1000);

                                Console.WriteLine("プッチ神父「なんだこれはぁ!」");

                                Console.WriteLine("\nエルメェス「シールを貼ってやったぜ!」");
                                Console.WriteLine("プッチ神父「....?これはおれの腕が増えている!好都合だ....」");

                                kissudebutyubutyu = 1;
                                isputchiwei = true;

                                jorinmp -= 50;
                            }

                            if (Action == "enporio" || Action == "エンポリオ")
                            {
                                Console.WriteLine("エンポリオが踊りだした!(特にこうかはない)");
                                Console.WriteLine("\n₍₍ ◝(　ﾟ∀ ﾟ )◟ ⁾⁾");
                            }
                        }

                        if (isSenkyuda == true)
                        {
                            Console.WriteLine("プッチ神父「なんだこの衝撃はぁ...!素数を...素数を数えて落ち着かなくては!」 プッチ神父は麻痺して行動できない!");

                            isSenkyuda = false;

                            if (mebiusGuardTurns > 0)
                            {
                                mebiusGuardTurns--;
                            }
                        }
                        else if (mebiusGuardTurns > 0)
                        {
                            int Timeenemyattackguard = rand.Next(30, 60);

                            Console.WriteLine($"受け流しに成功!徐倫に{Timeenemyattackguard}のダメージ!");

                            jorinhp -= Timeenemyattackguard;

                            mebiusGuardTurns--;
                        }
                        else
                        {
                            int AttackCount =1;
                            if(isMadeinheaven == true)
                            {
                                AttackCount =2;
                                Console.WriteLine("プッチ神父「時は加速する!」");
                            }
                            int ragebonus = (isputchiwei == true) ? 50 : 0;

                            for (int i = 0; i < AttackCount; i++)
                            {
                            int Timeenemyattack = rand.Next(40,80) + ragebonus;

                            Console.WriteLine($"覚悟が足りなかったようだな...!徐倫に{Timeenemyattack}のダメージ...!");

                            jorinhp -= Timeenemyattack;
                            }
                        }

                        if (HeelPranctonTurns > 0)
                        {
                            int Water = rand.Next(100, 120);

                            Console.WriteLine($"F・Fの水が少しづつ体になじんでいく... 徐倫のHPが{Water}回復していく..!");

                            jorinhp += Water;

                            if (jorinhp > jorinmaxhp)
                            {
                                jorinhp = jorinmaxhp;
                            }

                            HeelPranctonTurns--;
                        }

                        if (kissudebutyubutyu == 1)
                        {
                            int seal = rand.Next(300, 350);

                            Console.WriteLine("エルメェス「はがしてやるよそのシール!」");
                            Console.WriteLine($"\nバシィィン!プッチ神父「うがぁぁぁ!」プッチ神父に{seal}の大大ダメージ!");

                            TimeenemyHP -= seal;

                            isputchiwei = false;

                            kissudebutyubutyu--;
                        }

                        if (isAnasuihelp == true)
                        {
                            AnasuiTurns++;

                            if (AnasuiTurns == 3)
                            {
                                int Anasuiattack = rand.Next(150, 200);

                                Console.WriteLine("ナルシソ・アナスイ「ダイバーダウン!内部から破壊しろ!」");
                                Console.WriteLine($"プッチ神父「グハァッ!なんだこの感覚はぁ!」プッチ神父に{Anasuiattack}のダメージ!");
                                Console.WriteLine("アナスイ「潜行させておいたんだよ...ダイバーダウンをな...!」");

                                TimeenemyHP -= Anasuiattack;

                                AnasuiTurns = 0;
                            }
                        }

                        if (TimeenemyHP <= 0 && isputchides == false)
                        {
                            Console.WriteLine("やったわ...!プッチ神父を倒したわ...!");

                            System.Threading.Thread.Sleep(1000);

                            Console.WriteLine("プッチ神父「二手遅れたようだな....」");

                            System.Threading.Thread.Sleep(1000);

                            Console.WriteLine("徐倫「ッ!?」");

                            Console.WriteLine("ホワイトスネイク「てめぇらは幻覚に踊らされてたんだよバァカ!!」");

                            Console.WriteLine("★ プッチ神父は第二形態へ...");

                            TimeenemyHP = 2000;

                            isputchides = true;

                            isCMoon = true;
                        }

                        if (TimeenemyHP <= 0 && isputchides == true &&isputchidoubledes == false)
                        {
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("徐倫「ﾊｧﾊｧ...やったわ...」");
                            Console.WriteLine("F・F & エルメェス「ついに勝った!」");
                            Console.WriteLine("プッチ神父「グブゥッ...ただ、ただ!天国に到達できたぞ!」");
                            Console.WriteLine("徐倫「まだ気は抜けないようね...」");
                            Console.WriteLine("★ プッチ神父は最終形態へ突入します...!"); //かっこよくない?正直
                        isputchidoubledes = true;
                        isMadeinheaven = true;
                        TimeenemyHP = 2000;
                        }
                        if (TimeenemyHP <= 0 && isputchidoubledes == true)
                        {
                             Console.WriteLine("プッチ神父「グハァッ!......ま...待て!私を殺すな!」");
                            Console.WriteLine("徐倫「いやよ。オラァッ!」");
                            Console.WriteLine("プッチ神父「天国への道のりがあぁ!」");
                            Console.WriteLine("プッチ神父を撃破した! YOUWIN!");
                            Environment.Exit(0);
                        }
                        if (jorinhp <= 0)
                        {
                            Console.WriteLine("プッチ神父「やったぞ...!ついにジョースター家と決着をつけれたぞ!」");
                            Console.WriteLine("徐倫は再起不能した....YOU LOSE!");

                            Environment.Exit(0);
                        }

                        if (ballcooldown > 0)
                        {
                            ballcooldown--;
                        }

                        Turns++;
                
                    }
                    break;
            }
        }
    }
}