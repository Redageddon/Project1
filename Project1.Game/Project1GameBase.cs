using System.Drawing;
using osu.Framework.Allocation;
using osu.Framework.Configuration;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Input;
using osu.Framework.IO.Stores;
using Project1.Resources;

namespace Project1.Game;

public partial class Project1GameBase : osu.Framework.Game
{
    protected override Container<Drawable> Content { get; }
    
    protected Project1GameBase()
    {
        base.Content.Add(this.Content = new DrawSizePreservingFillContainer());
    }

    [BackgroundDependencyLoader]
    private void Load(FrameworkConfigManager config)
    {
        this.Resources.AddStore(new DllResourceStore(typeof(Project1Resources).Assembly));
        
        Size windowSize = new Size(1920, 1080) * 2;
        config.SetValue(FrameworkSetting.SizeFullscreen, windowSize);
        config.SetValue(FrameworkSetting.ConfineMouseMode, ConfineMouseMode.Never);
        config.SetValue(FrameworkSetting.MinimiseOnFocusLossInFullscreen, false);
        config.SetValue(FrameworkSetting.WindowMode, WindowMode.Fullscreen);
    }
}