using osu.Framework.Allocation;
using osu.Framework.Screens;
using Project1.Game.Screens.Main;
using Project1.Game.Screens.Second;

namespace Project1.Game;

public partial class Project1Game : Project1GameBase
{
    private ScreenStack screenStack;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.Child = this.screenStack = new ScreenStack();
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();

        this.screenStack.Push(new SecondScreen());
    }
}