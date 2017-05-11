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
            this.Color = сolorFigure;
            if (Convert.ToBoolean(сolorFigure = "White"))
            {
                FileStream fs = new FileStream(@"pawn w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (Convert.ToBoolean(сolorFigure = "Black"))
            {
                FileStream fs = new FileStream(@"pawn b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void Walk(Cell newCell)
        {
            base.Cheking(newCell);
            if (CurrentCell.CoordinateX != newCell.CoordinateY)
            {
                throw new Exception("Фигура 'ПЕШКА' имеет другой алгоритм движения");
            }
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;
        }
    }
}
