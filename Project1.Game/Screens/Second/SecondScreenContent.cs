using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using Project1.Game.IO;

namespace Project1.Game.Screens.Second;

public partial class SecondScreenContent : CompositeDrawable
{
    private HabitControls habitControls = null!;

    private HabitTable habitTable = null!;

    [Resolved]
    private HabitStorage HabitStorage { get; set; } = null!;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.Both;

        this.InternalChildren =
        [
            this.habitTable = new HabitTable(), 
            this.habitControls = new HabitControls(),
        ];
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        this.habitControls.OnHabitAdded += this.HabitStorage.AddHabit;
    }

    protected override void Dispose(bool isDisposing)
    {
        if (this.habitControls != null)
        {
            this.habitControls.OnHabitAdded -= this.HabitStorage.AddHabit;
        }

        base.Dispose(isDisposing);
    }
}