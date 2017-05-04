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
        public Pawn() : base()
        {
            int x = 0;
            int y = 0;
            Figure figure = null;
            for (int i = 0; i <= 63; i++)
            {
                if ((x == 2 && (y >= 1 && y <= 8)) || (x == 7 && (y >= 1 && y <= 8)))
                {
                    if (Convert.ToBoolean(figure.Color = "White"))
                    {
                        FileStream fs = new FileStream(@"C:\Users\Positronica\Documents\GitHub\CourseProject1\CourseWork\пешка белая", FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        this.Image = img;
                    }
                    if (Convert.ToBoolean(figure.Color = "Black"))
                    {
                        FileStream fs = new FileStream(@"C:\Users\Positronica\Documents\GitHub\CourseProject1\CourseWork\пешка черная", FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        this.Image = img;
                    }
                }
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
