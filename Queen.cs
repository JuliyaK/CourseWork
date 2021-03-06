﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class Queen:Figure
    {
        public Queen(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"queen w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"queen b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void ChekingMove (Cell newCell)
        {
           
        }
        public override void Walk(Cell newCell)
        {
            base.Cheking(newCell);
            this.ChekingMove(newCell);
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;

        }
    }
}
