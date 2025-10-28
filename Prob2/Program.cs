using Spectre.Console;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;

class Program
{
    static async Task<int> Main(string[] args)
    {
        // Ask URL & output dir if not provided via args
        string url = args.Length > 0 ? args[0] : AnsiConsole.Ask<string>("[green]Enter YouTube URL[/]:");
        string outDir = args.Length > 1 ? args[1] : @"C:\transfer\YouTube";
        Directory.CreateDirectory(outDir);

        // Prepare tools directory (yt-dlp + ffmpeg)
        string toolsDir = Path.Combine(AppContext.BaseDirectory, "tools");
        Directory.CreateDirectory(toolsDir);
        await EnsureToolsAsync(toolsDir);

        // Create YoutubeDL client and point at the tools
        var ytdl = new YoutubeDL
        {
            YoutubeDLPath = Path.Combine(toolsDir, "yt-dlp.exe"),
            FFmpegPath = Path.Combine(toolsDir, "ffmpeg.exe"),
        };

        // Ctrl+C cancellation
        using var cts = new CancellationTokenSource();
        Console.CancelKeyPress += (s, e) => { e.Cancel = true; cts.Cancel(); };

        try
        {
            await AnsiConsole.Progress()
                .AutoClear(false)
                .HideCompleted(false)
                .Columns(new ProgressColumn[]
                {
                    new TaskDescriptionColumn(),
                    new ProgressBarColumn(),
                    new PercentageColumn(),
                    new RemainingTimeColumn(),
                    new SpinnerColumn(),
                })
                .StartAsync(async ctx =>
                {
                    var task = ctx.AddTask("[yellow]Downloading[/]", maxValue: 1.0);

                    var progress = new Progress<DownloadProgress>(p =>
                    {
                        task.Value = Math.Clamp(p.Progress, 0, 1);            // <-- no scale
                        var speed = string.IsNullOrWhiteSpace(p.DownloadSpeed) ? "" : $" | {p.DownloadSpeed}";
                        var eta = string.IsNullOrWhiteSpace(p.ETA) ? "" : $" | ETA {p.ETA}";
                        task.Description = $"[yellow]Downloading*[/]{speed}{eta}";
                    });


                    // Output template; change as desired
                    var opts = new OptionSet
                    {
                        Output = Path.Combine(outDir, "%(title)s.%(ext)s"),
                        RestrictFilenames = true,


                    };
                    
                    

                    var run = await ytdl.RunVideoDownload(
                        url,
                        overrideOptions: opts,
                        progress: progress,
                        ct: cts.Token
                    );

                    if (!run.Success)
                    {
                        //var err = string.Join(Environment.NewLine, run.ErrorOutput ?? Array.Empty<string>());
                        //var std = string.Join(Environment.NewLine, run.Output ?? Array.Empty<string>());
                        throw new Exception($"Download failed.");
                    }

                    task.Value = 100;
                    task.Description = "[green]Completed[/]";
                });

            AnsiConsole.MarkupLine("[green]✅ Done![/]");
            return 0;
        }
        catch (OperationCanceledException)
        {
            AnsiConsole.MarkupLine("[red]⛔ Canceled by user.[/]");
            return 2;
        }
        catch (Exception ex)
        {
            AnsiConsole.WriteException(ex);
            return 1;
        }
    }

    private static async Task EnsureToolsAsync(string toolsDir)
    {
        // Place downloaded binaries in toolsDir
        string prev = Environment.CurrentDirectory;
        try
        {
            Environment.CurrentDirectory = toolsDir;
            await YoutubeDLSharp.Utils.DownloadYtDlp();   // no-op if exists
            await YoutubeDLSharp.Utils.DownloadFFmpeg();   // no-op if exists
        }
        finally
        {
            Environment.CurrentDirectory = prev;
        }

        if (!File.Exists(Path.Combine(toolsDir, "yt-dlp.exe")) ||
            !File.Exists(Path.Combine(toolsDir, "ffmpeg.exe")))
        {
            throw new FileNotFoundException("Failed to prepare yt-dlp or ffmpeg in tools directory.");
        }
    }
}
