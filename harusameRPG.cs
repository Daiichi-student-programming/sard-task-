using System;
using System.Diagnostics;

namespace JojoGitPusher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("【スタープラチナ！Gitリポジトリをオラオラプッシュするぜ！】\n");

            // あなたのGitHubリポジトリURL（環境に合わせて書き換えてください）
            string repoUrl = "github.com";

            // 実行するGitコマンドのリスト
            string[][] gitCommands = new string[][]
            {
                new string[] { "init", "Git初期化" },
                new string[] { "add .", "ステージング" },
                new string[] { "commit -m \"feat: ジョジョRPG実装！オラオラオラ！\"", "コミット" },
                new string[] { "branch -M main", "メインブランチ設定" },
                new string[] { $"remote add origin {repoUrl}", "リモート追加（登録済みならエラーを無視）" },
                new string[] { "push -u origin main", "GitHubへプッシュ" }
            };

            foreach (var cmd in gitCommands)
            {
                Console.WriteLine($"👉 実行中: git {cmd[0]} ({cmd[1]})");
                RunCommand("git", cmd[0]);
            }

            Console.WriteLine("\n【完了】「終わったぜ…… GitHubへのプッシュがな……」");
        }

        static void RunCommand(string fileName, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(output)) Console.WriteLine(output.Trim());
                if (!string.IsNullOrEmpty(error)) Console.ForegroundColor = ConsoleColor.Yellow;
                // リモートが既に存在する場合などの警告を表示
                if (!string.IsNullOrEmpty(error)) Console.WriteLine(error.Trim());
                Console.ResetColor();
            }
        }
    }
}