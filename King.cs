using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class King:Figure
    {
        public King(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"king w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"king b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void Walk(Cell newCell)
        {
            base.Cheking(newCell);
            var differenceX = newCell.CoordinateX - CurrentCell.CoordinateX;
            var differenceY = newCell.CoordinateY - CurrentCell.CoordinateY;
            if (differenceX > 80 || differenceY > 80)
            {
                throw new Exception("Фигура 'КОРОЛЬ' ходит только на одну клетку");
            }
            if(CurrentCell.CoordinateX != newCell.CoordinateX && CurrentCell.CoordinateY != newCell.CoordinateY)
            {
                throw new Exception("Фигура 'КОРОЛЬ' не ходит по диагонали");
            }
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;
            
        }
    }
}
