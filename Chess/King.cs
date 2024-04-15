﻿using Chess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure, IMarkable
    {
        public King(bool isWhite, Point point) : base(isWhite, point)
        {
        }

        public bool IsFirstTurn { get; set; } = true;

        public override IEnumerable<Point> GetAvailablePositions(IEnumerable<Figure> figures)
        {
            throw new NotImplementedException();
        }

        public override Image GetImage()
        {
            if (isWhite)
            {
                if (isChoosen)
                {
                    return Properties.Resources.King_White_Green;
                } else
                {
                    return (Position.X + Position.Y) % 2 == 0 ? Properties.Resources.King_White_White : Properties.Resources.King_White_Black;
                }
                
            } else
            {
                if (isChoosen)
                {
                    return Properties.Resources.King_Black_Green;
                }
                else
                {
                    return (Position.X + Position.Y) % 2 == 0 ? Properties.Resources.King_Black_White : Properties.Resources.King_Black_Black;
                }
            }
        }
    }
}
