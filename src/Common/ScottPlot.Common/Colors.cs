﻿/*
 * Discussion and links to reference APIs:
 * https://github.com/ScottPlot/ScottPlot/pull/1647#issuecomment-1152963629
 * 
 */

namespace ScottPlot;

public struct Colors
{
    public static SPColor AliceBlue => new(240, 248, 255);
    public static SPColor AntiqueWhite => new(250, 235, 215);
    public static SPColor Aqua => new(0, 255, 255);
    public static SPColor Aquamarine => new(127, 255, 212);
    public static SPColor Azure => new(240, 255, 255);
    public static SPColor Beige => new(245, 245, 220);
    public static SPColor Bisque => new(255, 228, 196);
    public static SPColor Black => new(0, 0, 0);
    public static SPColor BlanchedAlmond => new(255, 235, 205);
    public static SPColor Blue => new(0, 0, 255);
    public static SPColor BlueViolet => new(138, 43, 226);
    public static SPColor Brown => new(165, 42, 42);
    public static SPColor BurlyWood => new(222, 184, 135);
    public static SPColor CadetBlue => new(95, 158, 160);
    public static SPColor Chartreuse => new(127, 255, 0);
    public static SPColor Chocolate => new(210, 105, 30);
    public static SPColor Coral => new(255, 127, 80);
    public static SPColor CornflowerBlue => new(100, 149, 237);
    public static SPColor Cornsilk => new(255, 248, 220);
    public static SPColor Crimson => new(220, 20, 60);
    public static SPColor Cyan => new(0, 255, 255);
    public static SPColor DarkBlue => new(0, 0, 139);
    public static SPColor DarkCyan => new(0, 139, 139);
    public static SPColor DarkGoldenRod => new(184, 134, 11);
    public static SPColor DarkGray => new(169, 169, 169);
    public static SPColor DarkGrey => new(169, 169, 169);
    public static SPColor DarkGreen => new(0, 100, 0);
    public static SPColor DarkKhaki => new(189, 183, 107);
    public static SPColor DarkMagenta => new(139, 0, 139);
    public static SPColor DarkOliveGreen => new(85, 107, 47);
    public static SPColor DarkOrange => new(255, 140, 0);
    public static SPColor DarkOrchid => new(153, 50, 204);
    public static SPColor DarkRed => new(139, 0, 0);
    public static SPColor DarkSalmon => new(233, 150, 122);
    public static SPColor DarkSeaGreen => new(143, 188, 143);
    public static SPColor DarkSlateBlue => new(72, 61, 139);
    public static SPColor DarkSlateGray => new(47, 79, 79);
    public static SPColor DarkSlateGrey => new(47, 79, 79);
    public static SPColor DarkTurquoise => new(0, 206, 209);
    public static SPColor DarkViolet => new(148, 0, 211);
    public static SPColor DeepPink => new(255, 20, 147);
    public static SPColor DeepSkyBlue => new(0, 191, 255);
    public static SPColor DimGray => new(105, 105, 105);
    public static SPColor DimGrey => new(105, 105, 105);
    public static SPColor DodgerBlue => new(30, 144, 255);
    public static SPColor FireBrick => new(178, 34, 34);
    public static SPColor FloralWhite => new(255, 250, 240);
    public static SPColor ForestGreen => new(34, 139, 34);
    public static SPColor Fuchsia => new(255, 0, 255);
    public static SPColor Gainsboro => new(220, 220, 220);
    public static SPColor GhostWhite => new(248, 248, 255);
    public static SPColor Gold => new(255, 215, 0);
    public static SPColor GoldenRod => new(218, 165, 32);
    public static SPColor Gray => new(128, 128, 128);
    public static SPColor Grey => new(128, 128, 128);
    public static SPColor Green => new(0, 128, 0);
    public static SPColor GreenYellow => new(173, 255, 47);
    public static SPColor HoneyDew => new(240, 255, 240);
    public static SPColor HotPink => new(255, 105, 180);
    public static SPColor IndianRed => new(205, 92, 92);
    public static SPColor Indigo => new(75, 0, 130);
    public static SPColor Ivory => new(255, 255, 240);
    public static SPColor Khaki => new(240, 230, 140);
    public static SPColor Lavender => new(230, 230, 250);
    public static SPColor LavenderBlush => new(255, 240, 245);
    public static SPColor LawnGreen => new(124, 252, 0);
    public static SPColor LemonChiffon => new(255, 250, 205);
    public static SPColor LightBlue => new(173, 216, 230);
    public static SPColor LightCoral => new(240, 128, 128);
    public static SPColor LightCyan => new(224, 255, 255);
    public static SPColor LightGoldenRodYellow => new(250, 250, 210);
    public static SPColor LightGray => new(211, 211, 211);
    public static SPColor LightGrey => new(211, 211, 211);
    public static SPColor LightGreen => new(144, 238, 144);
    public static SPColor LightPink => new(255, 182, 193);
    public static SPColor LightSalmon => new(255, 160, 122);
    public static SPColor LightSeaGreen => new(32, 178, 170);
    public static SPColor LightSkyBlue => new(135, 206, 250);
    public static SPColor LightSlateGray => new(119, 136, 153);
    public static SPColor LightSlateGrey => new(119, 136, 153);
    public static SPColor LightSteelBlue => new(176, 196, 222);
    public static SPColor LightYellow => new(255, 255, 224);
    public static SPColor Lime => new(0, 255, 0);
    public static SPColor LimeGreen => new(50, 205, 50);
    public static SPColor Linen => new(250, 240, 230);
    public static SPColor Magenta => new(255, 0, 255);
    public static SPColor Maroon => new(128, 0, 0);
    public static SPColor MediumAquaMarine => new(102, 205, 170);
    public static SPColor MediumBlue => new(0, 0, 205);
    public static SPColor MediumOrchid => new(186, 85, 211);
    public static SPColor MediumPurple => new(147, 112, 219);
    public static SPColor MediumSeaGreen => new(60, 179, 113);
    public static SPColor MediumSlateBlue => new(123, 104, 238);
    public static SPColor MediumSpringGreen => new(0, 250, 154);
    public static SPColor MediumTurquoise => new(72, 209, 204);
    public static SPColor MediumVioletRed => new(199, 21, 133);
    public static SPColor MidnightBlue => new(25, 25, 112);
    public static SPColor MintCream => new(245, 255, 250);
    public static SPColor MistyRose => new(255, 228, 225);
    public static SPColor Moccasin => new(255, 228, 181);
    public static SPColor NavajoWhite => new(255, 222, 173);
    public static SPColor Navy => new(0, 0, 128);
    public static SPColor OldLace => new(253, 245, 230);
    public static SPColor Olive => new(128, 128, 0);
    public static SPColor OliveDrab => new(107, 142, 35);
    public static SPColor Orange => new(255, 165, 0);
    public static SPColor OrangeRed => new(255, 69, 0);
    public static SPColor Orchid => new(218, 112, 214);
    public static SPColor PaleGoldenRod => new(238, 232, 170);
    public static SPColor PaleGreen => new(152, 251, 152);
    public static SPColor PaleTurquoise => new(175, 238, 238);
    public static SPColor PaleVioletRed => new(219, 112, 147);
    public static SPColor PapayaWhip => new(255, 239, 213);
    public static SPColor PeachPuff => new(255, 218, 185);
    public static SPColor Peru => new(205, 133, 63);
    public static SPColor Pink => new(255, 192, 203);
    public static SPColor Plum => new(221, 160, 221);
    public static SPColor PowderBlue => new(176, 224, 230);
    public static SPColor Purple => new(128, 0, 128);
    public static SPColor RebeccaPurple => new(102, 51, 153);
    public static SPColor Red => new(255, 0, 0);
    public static SPColor RosyBrown => new(188, 143, 143);
    public static SPColor RoyalBlue => new(65, 105, 225);
    public static SPColor SaddleBrown => new(139, 69, 19);
    public static SPColor Salmon => new(250, 128, 114);
    public static SPColor SandyBrown => new(244, 164, 96);
    public static SPColor SeaGreen => new(46, 139, 87);
    public static SPColor SeaShell => new(255, 245, 238);
    public static SPColor Sienna => new(160, 82, 45);
    public static SPColor Silver => new(192, 192, 192);
    public static SPColor SkyBlue => new(135, 206, 235);
    public static SPColor SlateBlue => new(106, 90, 205);
    public static SPColor SlateGray => new(112, 128, 144);
    public static SPColor SlateGrey => new(112, 128, 144);
    public static SPColor Snow => new(255, 250, 250);
    public static SPColor SpringGreen => new(0, 255, 127);
    public static SPColor SteelBlue => new(70, 130, 180);
    public static SPColor Tan => new(210, 180, 140);
    public static SPColor Teal => new(0, 128, 128);
    public static SPColor Thistle => new(216, 191, 216);
    public static SPColor Tomato => new(255, 99, 71);
    public static SPColor Turquoise => new(64, 224, 208);
    public static SPColor Violet => new(238, 130, 238);
    public static SPColor Wheat => new(245, 222, 179);
    public static SPColor White => new(255, 255, 255);
    public static SPColor WhiteSmoke => new(245, 245, 245);
    public static SPColor Yellow => new(255, 255, 0);
    public static SPColor YellowGreen => new(154, 205, 50);

    /// <summary>
    /// Default Windows Colors
    /// </summary>
    public class Windows : NamedColors.WindowsStandardColors { }

    /// <summary>
    /// Colors from the xkcd color name survey
    /// https://xkcd.com/color/rgb/
    /// </summary>
    public class Xkcd : NamedColors.XkcdColors { }
}
