using osu.Framework;
using osu.Framework.Platform;
using Project1.Game;

namespace Project1.Desktop;

public static class Program
{
    public static void Main()
    {
        using GameHost host = Host.GetSuitableDesktopHost("Project1");
        using osu.Framework.Game game = new Project1Game();
        host.Run(game);
    }
}