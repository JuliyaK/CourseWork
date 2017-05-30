using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace CourseWork
{
    class Chessboard : Panel
    {
        private Cell[,] _arrayCells;
        private Figure _selectedFigure;

        public void MakeCells()
        {
            _arrayCells = new Cell[8, 8];
            var cellColor = "";
            var cellHeight = 80;
            var cellWidth = 80;
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            cellColor = "White";
                        }
                        else
                        {
                            cellColor = "Black";
                        }
                    } else
                    {
                        if (j % 2 == 0)
                        {
                            cellColor = "Black";
                        }
                        else
                        {
                            cellColor = "White";
                        }
                    }
                    var x = j * cellWidth;
                    var y = i * cellHeight;
                    var cell = new Cell(cellColor)
                    {
                        Height = cellHeight,
                        Width = cellWidth,
                        Location = new Point(x, y),
                        CoordinateX = x,
                        CoordinateY = y
                    };
                    this.Controls.Add(cell);
                    _arrayCells[i, j] = cell;
                    cell.Click += OnCellClick;
                }
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            var cell = (Cell)sender;
            if (this._selectedFigure == null)
            {
                return;
            }

            try
            {
                this._selectedFigure.Walk(cell);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK);
            }
            finally
            {
                this._selectedFigure = null;
            }
        }

        private void OnFigureClick(object sender, EventArgs e)
        {
            var figure = (Figure)sender;
            var cellFigure = figure.CurrentCell;

            if (_selectedFigure != null)
            {
                cellFigure = figure.CurrentCell;
                try
            {
                this._selectedFigure.Walk(cellFigure);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK);
            }
            finally
            {
                this._selectedFigure = null;
            } 
            }
            else
            {
                this._selectedFigure = figure;
            }
            
           
        }

        public void LocateFigures()
        {
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    var cell = _arrayCells[i, j];
                    var figure = this._CreateFigure(cell);
                    if (figure != null)
                    {
                        cell.CurrentFigure = figure;
                        figure.CurrentCell = cell;
                        figure.Click += OnFigureClick;
                    }
                }
            }
        }

        private string _GetFigureColor(Cell cell)
        {
            var result = "White";

            if (cell.CoordinateY >= 480)
            {
                result = "Black";
            }

            return result;
        }

        private Figure _CreateFigure(Cell cell)
        {
            Figure figure = null;
            var figureColor = this._GetFigureColor(cell);
            var x = cell.CoordinateX;
            var y = cell.CoordinateY;

            // создаем пешки пешки
            if (y == 80 || y == 480)
            {
                figure = new Pawn(figureColor);
            }

            // создаем ладьи
            if ((x == 0 && y == 0) || (x == 560 && y == 0) || (x == 0 && y == 560) || (x == 560 && y == 560))
            {
                figure = new Rook(figureColor);
            }

            // создаем коней
            if ((x == 80 && y == 0) || (x == 480 && y == 0) || (x == 80 && y == 560) || (x == 480 && y == 560))
            {
                figure = new Kinght(figureColor);
            }

            // создаем слонов
            if ((x == 160 && y == 0) || (x == 400 && y == 0) || (x == 160 && y == 560) || (x == 400 && y == 560))
            {
                figure = new Bishop(figureColor);
            }

            // создаем королей
            if ((x == 240 && y == 0) || (x == 240 && y == 560))
            {
                figure = new King(figureColor);
            }

            // создаем ферзей
            if ((x == 320 && y == 0) || (x == 320 && y == 560))
            {
                figure = new Queen(figureColor);
            }

            return figure;
        }
    }
}