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
            new Container
            {
                RelativeSizeAxes = Axes.Both,
                Padding = new MarginPadding { Top = textSize },
                Child = new BasicScrollContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    ScrollbarVisible = true,
                    Child = this.dataContainer = new FillFlowContainer
                    {
                        Direction = FillDirection.Vertical,
                        RelativeSizeAxes = Axes.X,
                        AutoSizeAxes = Axes.Y,
                        Spacing = new Vector2(textSize),
                        Padding = new MarginPadding { Top = textSize / 2f, Bottom = textSize / 2f },
                    },
                },
            },
            new Header("Habit", "Date", textSize),
        ];
    }

    public void Add(string habit, string date)
    {
        this.dataContainer.Add(new Row(habit, date, this.textSize));
    }
}