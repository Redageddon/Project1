using System;
using System.Collections.Specialized;
using System.Linq;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;
using Project1.Game.IO;

namespace Project1.Game.Screens.Second;

public partial class HabitTable : CompositeDrawable
{
    private const float RowHeight = 50;

    private FillFlowContainer<HabitTableRow> rowContainer = null!;

    [Resolved]
    private HabitStorage HabitStorage { get; set; } = null!;

    [BackgroundDependencyLoader]
    private void Load()
    {
        this.RelativeSizeAxes = Axes.Both;
        this.Size = new Vector2(0.8f);
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;

        this.InternalChildren =
        [
            new Box
            {
                RelativeSizeAxes = Axes.Both,
                Colour = Style.DrawableUnderlay2,
            },
            new Container
            {
                RelativeSizeAxes = Axes.Both,
                Padding = new MarginPadding { Top = RowHeight },
                Child = new BasicScrollContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    ScrollbarVisible = true,
                    Child = this.rowContainer = new FillFlowContainer<HabitTableRow>
                    {
                        RelativeSizeAxes = Axes.X,
                        AutoSizeAxes = Axes.Y,
                        Direction = FillDirection.Vertical,
                        Spacing = new Vector2(0, 2),
                    },
                },
            },
            new HabitTableHeader(),
        ];
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        this.HabitStorage.BindCollectionChanged(this.OnHabitsChanged);
    }

    private void OnHabitsChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                foreach (Habit habit in e.NewItems!)
                {
                    this.rowContainer.Add(new HabitTableRow(habit));
                }

                break;

            case NotifyCollectionChangedAction.Remove:
                foreach (Habit habit in e.OldItems!)
                {
                    HabitTableRow existingRow = this.rowContainer.Children.FirstOrDefault(r => r.Habit.Equals(habit));
                    existingRow?.Expire();
                }
                
                break;

            case NotifyCollectionChangedAction.Reset:   this.rowContainer.Clear(); break;
            case NotifyCollectionChangedAction.Replace:
            case NotifyCollectionChangedAction.Move:    break;
            default:                                    throw new ArgumentOutOfRangeException();
        }
    }

    protected override void Dispose(bool isDisposing)
    {
        this.HabitStorage.UnbindAll();
        base.Dispose(isDisposing);
    }
}