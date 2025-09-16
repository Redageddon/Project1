using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class DataGrid : CompositeDrawable
{
    private readonly int textSize;
    private readonly FillFlowContainer dataContainer;

    public DataGrid(int textSize)
    {
        this.textSize = textSize;

        this.RelativeSizeAxes = Axes.Both;
        this.Size = new Vector2(0.8f);
        this.Anchor = Anchor.Centre;
        this.Origin = Anchor.Centre;

        this.InternalChildren =
        [
            new Box
            {
                RelativeSizeAxes = Axes.Both,
                Colour = new Colour4(100, 100, 100, 255),
            },
            new Header("Habit", "Date", textSize),
            new BasicScrollContainer
            {
                RelativeSizeAxes = Axes.Both,
                Padding = new MarginPadding { Top = textSize * 2f },
                ScrollbarVisible = true,
                Child = new Container
                {
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Child = this.dataContainer = new FillFlowContainer
                    {
                        Direction = FillDirection.Vertical,
                        AutoSizeAxes = Axes.Y,
                        RelativeSizeAxes = Axes.X,
                        Spacing = new Vector2(textSize),
                    },
                },
            },
        ];
    }

    public void Add(string habit, string date)
    {
        this.dataContainer.Add(new Row(habit, date, this.textSize));
    }
}