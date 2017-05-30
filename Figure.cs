using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
   abstract class Figure: PictureBox
    {
        public Figure()
        {
            this.Size = new Size(80, 80);
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public string FigureColor;
        public Cell CurrentCell;
        public abstract void Walk(Cell newCell);
        public void Cheking(Cell newCell)
        {
            int x = newCell.CoordinateX;
            int y = newCell.CoordinateY;
            if (x < 0 && x > 560 && y < 0 && y > 560)
            {
                throw new Exception("Выбранный диапазон не принадлежит шахматной доске");
            }
            if (newCell.CurrentFigure != null)
            {
                if (this.FigureColor != newCell.CurrentFigure.FigureColor)
                {
                    newCell.DeleteFigure();
                }
                else
                {
                    throw new Exception("На клетке уже есть фигура");
                }
            }
        }
       

    }
}
