using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace CourseWork
{
    class Rook:Figure
    {
        public Rook(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"rook w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"rook b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void ChekingMove(Cell newCell)
        {
            if (CurrentCell.CoordinateX == newCell.CoordinateX || CurrentCell.CoordinateY == newCell.CoordinateY)
            {
                throw new Exception("Фигура 'ЛАДЬЯ' ходит только по диагонали");
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
