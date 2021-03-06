﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class Kinght:Figure
    {
        public Kinght(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"kinght w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"kinght b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void ChekingMove(Cell newCell)
        {
            var differenceX = newCell.CoordinateX - CurrentCell.CoordinateX;
            var differenceY = newCell.CoordinateY - CurrentCell.CoordinateY;
            if (((differenceX != 80) || (differenceY != -160)) && ((differenceY != -80) || (differenceX != 160)) && ((differenceX != 160) || (differenceY != 80)) &&
               ((differenceX != 80) || (differenceY != 160)) && ((differenceX != -80) || (differenceY != 160)) && ((differenceX != -160) || (differenceY != 80)) &&
               ((differenceX != -160) || (differenceY != -80)) && ((differenceX != -80) || (differenceY != -160)))
            
            {
                throw new Exception("Фигура 'КОНЬ' ходит только буквой 'Г'");
            }
            
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
