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
    class Cell : PictureBox
    {
        public Cell(string сolorCell) : base()
        {
            this.FigureColor = сolorCell;
            
               this.Size = new Size(60,60);
              
           
            if (сolorCell == "White")
            {
                FileStream fs = new FileStream(@"cell w.jpg", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (сolorCell == "Black")
            {
                FileStream fs = new FileStream(@"cell b.jpg", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public string FigureColor;
        public Figure CurrentFigure;
        public int CoordinateX;
        public int CoordinateY;
    }
}
