using osu.Framework.Allocation;
using osu.Framework.Configuration;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Input;
using osu.Framework.IO.Stores;
using Project1.Game.IO;
using Project1.Resources;

namespace Project1.Game;

public partial class Project1GameBase : osu.Framework.Game
{
    private DependencyContainer dependencies;

    protected Project1GameBase()
    {
        base.Content.Add(this.Content = new DrawSizePreservingFillContainer());
    }

    protected override Container<Drawable> Content { get; }

    [BackgroundDependencyLoader]
    private void Load(FrameworkConfigManager config)
    {
        this.Resources.AddStore(new DllResourceStore(typeof(Project1Resources).Assembly));

        //Size windowSize = new Size(1920, 1080) * 1;
        //config.SetValue(FrameworkSetting.SizeFullscreen, windowSize);
        config.SetValue(FrameworkSetting.ConfineMouseMode, ConfineMouseMode.Never);
        config.SetValue(FrameworkSetting.MinimiseOnFocusLossInFullscreen, false);
        config.SetValue(FrameworkSetting.WindowMode, WindowMode.Borderless);

        this.dependencies.Cache(new HabitStorage(this.Host.Storage));
    }

    protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
    {
        return this.dependencies = new DependencyContainer(base.CreateChildDependencies(parent));
    }
}