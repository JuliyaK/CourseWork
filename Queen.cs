using System;
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
            this.Color = сolorFigure;
            if (Convert.ToBoolean(сolorFigure = "White"))
            {
                FileStream fs = new FileStream(@"queen w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (Convert.ToBoolean(сolorFigure = "Black"))
            {
                FileStream fs = new FileStream(@"queen b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public override void Walk(Cell newCell)
        {
            base.Cheking(newCell);
            if (CurrentCell.CoordinateX != newCell.CoordinateX || CurrentCell.CoordinateY != newCell.CoordinateY || 
                (CurrentCell.CoordinateX != newCell.CoordinateX && CurrentCell.CoordinateY != newCell.CoordinateY))
            {
                throw new Exception("Фигура 'ФЕРЗЬ' имеет другой алгоритм движения");
            }
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;

        }
    }
}
