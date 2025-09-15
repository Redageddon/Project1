using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;

namespace Project1.Game.Screens.Second;

public partial class DataGrid
{
    private readonly int textSize;
    private readonly FillFlowContainer dataContainer;
    
    public BasicScrollContainer ScrollContainer { get; private set; }
    
    public DataGrid(int textSize)
    {
        this.textSize = textSize;
        
        this.dataContainer = new FillFlowContainer
        {
            Direction = FillDirection.Vertical,
            AutoSizeAxes = Axes.Y,
            RelativeSizeAxes = Axes.X,
            Spacing = new Vector2(textSize),
        };

        this.ScrollContainer = new BasicScrollContainer
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            RelativeSizeAxes = Axes.Both,
            Size = new Vector2(0.8f),
            Masking = true,
            ScrollbarVisible = true,
            Child = new Container
            {
                RelativeSizeAxes = Axes.X,
                AutoSizeAxes = Axes.Y,
                Children =
                [
                    new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Colour = Colour4.Black,
                    },
                    this.dataContainer,
                ],
            },
        };
    }
    
    public void Add(string habit, string date)
    {
        this.dataContainer.Add(new Row(habit, date, this.textSize));
    }
}