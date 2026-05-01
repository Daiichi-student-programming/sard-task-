using System;
 public class Program
 {
 public static void Main()
    {
        string player = "承太郎&仗助";
        int playerhp = 350;
        string enemy = "DIO";
       int enemyhp = 800;
       int playermp = 80;
       int extraTurns =0;
Console.WriteLine("承太郎&仗助VSDIO");
Console.WriteLine("承太郎/やれやれだぜ...");
Console.WriteLine("DIO/承太郎どうした？そんなハンバーグを頭に載せたガキを連れて");
Console.WriteLine("仗助/あんた今,俺の髪がなんだってェェェェッ！");
Console.WriteLine("DIO/貧弱 貧弱ゥ!");
while (playerhp>0 && enemyhp>0)
{Console.WriteLine($"\n【承太郎&仗助】hp:{playerhp}mp:{playermp}|【DIO】hp{enemyhp}");
Console.WriteLine("どうする？(1.オラオラ&ドラララ)");
Console.WriteLine("2.クレイジーDで回復(mp消費30)");
Console.WriteLine("3.スタープラチナ・ザ・ワールド(mp消費10)");
Console.WriteLine("4.精神統一(mp全回復)");
string chois =  Console.ReadLine();
}
 }
 }