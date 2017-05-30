using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace CourseWork
{
    class Cell : Panel
    {
        private Figure _figiure;
        public Cell(string сolorCell) : base()
        {
            if (сolorCell == "White")
            {
                this.BackColor = Color.White;
            }
            if (сolorCell == "Black")
            {
                this.BackColor = Color.Black;
            }
        }
        public Figure CurrentFigure
        {
            get { return this._figiure; }
            set
            {
                this._figiure = value;
                this.Controls.Add(value);
                
            }
        }
        public void DeleteFigure()
        {
          
            for (int index = 0; index <= Controls.Count-1; index++)
            {
                this.Controls[index].Dispose();
            }
        }

        public int CoordinateX;
        public int CoordinateY;
    }
}
