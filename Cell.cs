using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace CourseWork
{
    class Cell : PictureBox
    {
        public Cell(string сolorCell) : base()
        {
            this.Color = сolorCell;
            if (Convert.ToBoolean(сolorCell = "White"))
            {
                FileStream fs = new FileStream(@"cell w.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
            if (Convert.ToBoolean(сolorCell = "Black"))
            {
                FileStream fs = new FileStream(@"cell b.png", FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                this.Image = img;
            }
        }
        public string Color;
        public Figure CurrentFigure;
        public int CoordinateX;
        public int CoordinateY;
    }
}
