using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class Pawn:Figure
    {
        public Pawn(string сolorFigure) : base()
        {
            this.FigureColor = сolorFigure;
            if (сolorFigure == "White")
            {
                FileStream fs = new FileStream(@"pawn w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorFigure == "Black")
            {
                FileStream fs = new FileStream(@"pawn b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void ChekingMove(Cell newCell)
        {
            if (CurrentCell.CoordinateY == newCell.CoordinateY)
            {
                throw new Exception("Фигура 'ПЕШКА' имеет другой алгоритм движения");
            }
        }
        public override void Walk(Cell newCell)
        {
            if (FigureColor == "Black")
            {
                var difference = CurrentCell.CoordinateY - newCell.CoordinateY;
                bool firstStep = CurrentCell.CoordinateY == 480;
                if (CurrentCell.CoordinateX != newCell.CoordinateX)
                {
                    throw new Exception("Фигура 'ПЕШКА' ходит на одну или две клетки вперед");
                }
                if(firstStep  && difference > 160)
                {
                    throw new Exception("Фигура 'ПЕШКА'  не может ходить на 2 клетки");
                }
                if(!firstStep && difference > 800)
                {
                    throw new Exception("Фигура 'ПЕШКА' больше не может ходить на 2 клетки");
                }
                
            }
            if (FigureColor == "White")
            {
                var difference = newCell.CoordinateY - CurrentCell.CoordinateY;
                bool firstStep = CurrentCell.CoordinateY == 80;
                if (CurrentCell.CoordinateX != newCell.CoordinateX)
                {
                    throw new Exception("Фигура 'ПЕШКА' ходит на одну или две клетки вперед");
                }
                if (firstStep && difference > 160)
                {
                    throw new Exception("Фигура 'ПЕШКА'  не может ходить на 2 клетки");
                }
                if (!firstStep && difference > 80)
                {
                    throw new Exception("Фигура 'ПЕШКА' больше не может ходить на 2 клетки");
                }
            }

            base.Cheking(newCell);
            this.ChekingMove(newCell);
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;
        }
    }
}
