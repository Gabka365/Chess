﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Chess;

internal static class Initializer
{
    internal static Button GetButton(int ButtonSize, int x, int y, int offestX = 0, int offsetY = 0)
    {
        var figure = GetFigure(x, y, true);
        return new Button
        {
            Width = ButtonSize,
            Height = ButtonSize,
            Location = new Point(x * ButtonSize + offestX, y * ButtonSize + offsetY),
            BackColor = (x + y) % 2 == 0 ? Color.White : Color.Black,
            Tag = figure is not null ? figure : new Point(x, y),
            Image = figure?.GetImage()
        };
    }

    private static Figure? GetFigure(int x, int y, bool isWhiteDown)
    {
        switch (y)
        {
            case 0 or 7:
                switch (x)
                {
                    case 0:
                    case 7:
                        return new Rook(y is 7, new Point(x, y));
                    case 1:
                    case 6:
                        break;
                    case 2:
                    case 5:
                        break;
                    case 3:
                        break;
                    case 4:
                        return new King(y is 7, new Point(x, y));
                }

                break;
            case 1 or 6:
                return new Pawn(y is 6, new Point(x, y), isWhiteDown);
        }

        return null;
    }
}