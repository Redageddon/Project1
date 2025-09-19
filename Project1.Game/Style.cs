using osu.Framework.Graphics;

namespace Project1.Game;

public static class Style
{
    public static Colour4 Background { get; } = new(55, 55, 55, 255);

    public static Colour4 Text { get; } = Colour4.White;

    public static Colour4 TextNegative { get; } = Colour4.Black;

    public static Colour4 DrawableUnderlay1 { get; } = new(27, 27, 27, 255);

    public static Colour4 DrawableUnderlay2 { get; } = new(65, 64, 64, 255);

    public static Colour4 Boarder { get; } = Colour4.Black;

    public static Colour4 Hover { get; } = new(110, 110, 110, 255);

    public static Colour4 Selected { get; } = Colour4.Black;

    public static Colour4 Danger { get; } = Colour4.Red;
}