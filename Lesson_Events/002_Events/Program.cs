namespace _002_Events;
//2) Custom data — EventHandler<TEventArgs>

//Goal: pass extra info to handlers.

class DownloadProgressEventArgs : EventArgs
{
    public string FileName { get; }
    public int Percent { get; }
    public DownloadProgressEventArgs(string fileName, int percent)
    {
        FileName = fileName; Percent = percent;
    }
}

class Downloader
{
    public event EventHandler<DownloadProgressEventArgs>? ProgressChanged;

    public void Start(string fileName)
    {
        for (int p = 0; p <= 100; p += 25)
        {
            ProgressChanged?.Invoke(this, new DownloadProgressEventArgs(fileName, p));
            Thread.Sleep(200);
        }
    }
}

class Program
{
    static void Main()
    {
        var d = new Downloader();
        d.ProgressChanged += (sender, eventargs) =>
            Console.WriteLine($"{eventargs.FileName}: {eventargs.Percent}%");

        d.Start("video.mp4");
    }
}
