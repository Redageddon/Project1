using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;

namespace Project1.Game.Screens.Second
{
    public partial class Row : GridContainer
    {
        public Row(string habit, string date, int textSize)
        {
            this.RelativeSizeAxes = Axes.X;
            this.AutoSizeAxes = Axes.Y;

            this.Content = new[]
            {
                new[]
                {
                    CreateTextWithBox(habit, textSize),
                    CreateTextWithBox(date, textSize),
                },
            };
        }

        private static Container CreateTextWithBox(string text, int textSize)
        {
            return new Container
            {
                RelativeSizeAxes = Axes.X,
                AutoSizeAxes = Axes.Y,
                Masking = true,
                CornerRadius = 4,
                BorderThickness = 3,
                BorderColour = Colour4.Black,
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,

                Children =
                [
                    new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Colour = new Colour4(50, 50, 50, 255),
                    },
                    new SpriteText
                    {
                        Text = text,
                        Font = FontUsage.Default.With(size: textSize),
                        Colour = Colour4.White,
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                    },
                ],
            };
        }
    }
}