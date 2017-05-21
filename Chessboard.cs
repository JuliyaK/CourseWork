using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CourseWork
{
    class Chessboard:Panel
    {
        string сolorCell = null;
        public Cell [] arrayCells;
        public void MakeCells()
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i <= 63; i++)
            {
                if (i % 2 == 0)
            {
                сolorCell = "White";
            }
            else
            {
                сolorCell = "Black";
            }
            arrayCells = new Cell[64];
           
                arrayCells[i] = new Cell(сolorCell);
                if (i % 2 == 0)
                {
                    arrayCells[i].FigureColor = "White";
                }
                else
                {
                    arrayCells[i].FigureColor = "Blak";
                }
                if (i % 8 == 0)
                {
                    y = y + 1;
                    x = 1;
                }
                x++;
                arrayCells[i].CoordinateX = x;
                arrayCells[i].CoordinateY = y;
            }
        }
        public void LocationFigures()
        {
            int x = 0;
            int y = 0;
            string сolorFigure = null;
            Figure figure = null;
            for (int i = 0; i <= 63; i++)
            {
                arrayCells[i].CoordinateX = x;
                arrayCells[i].CoordinateY = y;
                if ((x == 1 && x == 2) && (y >= 1 && y <= 8))
                {
                    сolorFigure = "White";
                }
                if ((x == 7 && x == 8) && (y >= 1 && y <= 8))
                {
                    сolorFigure = "Black";
                }

                if ((x == 1 && y == 1) || (x == 1 && y == 8) || (x == 8 && y == 1) || (x == 8 && y == 8))
                {
                    figure = new Rook (сolorFigure);
                }

                if ((x == 1 && y == 2) || (x == 1 && y == 7) || (x == 8 && y == 2) || (x == 8 && y == 7))
                {
                    figure = new Kinght(сolorFigure);
                }

                if ((x == 1 && y == 3) || (x == 1 && y == 6) || (x == 8 && y == 3) || (x == 8 && y == 6))
                {
                    figure = new Bishop(сolorFigure);
                }

                if ((x == 1 && y == 4) || (x == 8 && y == 4))
                {
                    figure = new Queen(сolorFigure);
                }

                if ((x == 1 && y == 5) || (x == 8 && y == 5))
                {
                    figure = new King(сolorFigure);
                }

                if ((x == 2 && (y >= 1 && y <= 8)) || (x == 7 && (y >= 1 && y <= 8)))
                {
                    figure = new Pawn(сolorFigure);
                }
                figure.CurrentCell = arrayCells[i];
                arrayCells[i].CurrentFigure = figure;
                arrayCells[i].Controls.Add(figure);
            }
        }
        public void CreateChessPanel()
        {
            Panel chessPanel = new Panel();
            PictureBox pictureChess = new PictureBox();
            //TextBox textBox1 = new TextBox();
           // Label label1 = new Label();

            // Initialize the Panel control.
            chessPanel.Location = new Point(56, 72);
            chessPanel.Size = new Size(264, 152);
            // Set the Borderstyle for the Panel to three-dimensional.
            chessPanel.BorderStyle = BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            pictureChess.Location = new Point(16, 16);
            pictureChess.Size = new Size(64, 64);
           // label1.Location = new Point(16, 16);
           // label1.Text = "label1";
          //  label1.Size = new Size(104, 16);
          //  textBox1.Location = new Point(16, 32);
           // textBox1.Text = "";
          //  textBox1.Size = new Size(152, 20);

            // Add the Panel control to the form.
            this.Controls.Add(chessPanel);
            // Add the Label and TextBox controls to the Panel.
            chessPanel.Controls.Add(pictureChess);
          //  panel1.Controls.Add(textBox1);
        }
    }
}
