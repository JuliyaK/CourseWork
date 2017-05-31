using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Height = 685;
            this.Width = 660;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Chessboard board = new Chessboard();
            board.Dock = DockStyle.Fill;
            this.Controls.Add(board);
            board.MakeCells();
            board.LocateFigures();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
