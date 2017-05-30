﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class Bishop:Figure
    {
        public Bishop(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"bishop w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"bishop b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void Walk(Cell newCell)
        {
            base.Cheking(newCell);
            if (CurrentCell.CoordinateX == newCell.CoordinateX || CurrentCell.CoordinateY == newCell.CoordinateY )
            {
                CurrentCell.CurrentFigure = null;
                CurrentCell = newCell;
                newCell.CurrentFigure = this;
                
            }
            else
            {
                throw new Exception("Фигура 'СЛОН' имеет другой алгоритм движения");
            }
        }
    }
}
