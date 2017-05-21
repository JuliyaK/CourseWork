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
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Chessboard board = new Chessboard();
            board.Dock = DockStyle.Fill;
            board.BackColor = Color.Green;
            /*  Chessboard panel1 = new Chessboard();
              Chessboard panel2 = new Chessboard();
              Chessboard panel3 = new Chessboard();
              Chessboard panel4 = new Chessboard();
              Chessboard panel5 = new Chessboard();
              Chessboard panel6 = new Chessboard();
              Chessboard panel7 = new Chessboard();
              Chessboard panel8 = new Chessboard();
              Chessboard panel9 = new Chessboard();
              Chessboard panel10 = new Chessboard();
              Chessboard panel11 = new Chessboard();
              Chessboard panel12 = new Chessboard();
              Chessboard panel13 = new Chessboard();
              Chessboard panel14 = new Chessboard();
              Chessboard panel15 = new Chessboard();
              Chessboard panel16 = new Chessboard();
              Chessboard panel17 = new Chessboard();
              Chessboard panel18 = new Chessboard();
              Chessboard panel19 = new Chessboard();
              Chessboard panel20 = new Chessboard();
              Chessboard panel21 = new Chessboard();
              Chessboard panel22 = new Chessboard();
              Chessboard panel23 = new Chessboard();
              Chessboard panel24 = new Chessboard();
              Chessboard panel25 = new Chessboard();
              Chessboard panel26 = new Chessboard();
              Chessboard panel27 = new Chessboard();
              Chessboard panel28 = new Chessboard();
              Chessboard panel29 = new Chessboard();
              Chessboard panel30 = new Chessboard();
              Chessboard panel31 = new Chessboard();
              Chessboard panel32 = new Chessboard();
              Chessboard panel33 = new Chessboard();
              Chessboard panel34 = new Chessboard();
              Chessboard panel35 = new Chessboard();
              Chessboard panel36 = new Chessboard();
              Chessboard panel37 = new Chessboard();
              Chessboard panel38 = new Chessboard();
              Chessboard panel39 = new Chessboard();
              Chessboard panel40 = new Chessboard();
              Chessboard panel41 = new Chessboard();
              Chessboard panel42 = new Chessboard();
              Chessboard panel43 = new Chessboard();
              Chessboard panel44 = new Chessboard();
              Chessboard panel45 = new Chessboard();
              Chessboard panel46 = new Chessboard();
              Chessboard panel47 = new Chessboard();
              Chessboard panel48 = new Chessboard();
              Chessboard panel49 = new Chessboard();
              Chessboard panel50 = new Chessboard();
              Chessboard panel51 = new Chessboard();
              Chessboard panel52 = new Chessboard();
              Chessboard panel53 = new Chessboard();
              Chessboard panel54 = new Chessboard();
              Chessboard panel55 = new Chessboard();
              Chessboard panel56 = new Chessboard();
              Chessboard panel57 = new Chessboard();
              Chessboard panel58 = new Chessboard();
              Chessboard panel59 = new Chessboard();
              Chessboard panel60 = new Chessboard();
              Chessboard panel61 = new Chessboard();
              Chessboard panel62 = new Chessboard();
              Chessboard panel63 = new Chessboard();
              Chessboard panel64 = new Chessboard();


              board.Dock = DockStyle.Fill;
              board.BackColor = Color.Green;

              panel1.BackColor = Color.White;
              panel1.Location = new Point(0, 0);
              panel1.Size = new Size(60, 60);

              panel2.BackColor = Color.Black;
              panel2.Location = new Point(60, 0);
              panel2.Size = new Size(60, 60);

              panel3.BackColor = Color.White;
              panel3.Location = new Point(120, 0);
              panel3.Size = new Size(60, 60);

              panel4.BackColor = Color.Black;
              panel4.Location = new Point(180, 0);
              panel4.Size = new Size(60, 60);

              panel5.BackColor = Color.White;
              panel5.Location = new Point(240, 0);
              panel5.Size = new Size(60, 60);

              panel6.BackColor = Color.Black;
              panel6.Location = new Point(300, 0);
              panel6.Size = new Size(60, 60);

              panel7.BackColor = Color.White;
              panel7.Location = new Point(360, 0);
              panel7.Size = new Size(60, 60);

              panel8.BackColor = Color.Black;
              panel8.Location = new Point(420, 0);
              panel8.Size = new Size(60,60);

              panel9.BackColor = Color.Black;
              panel9.Location = new Point(0, 60);
              panel9.Size = new Size(60,60);

              panel10.BackColor = Color.White;
              panel10.Location = new Point(60, 60);
              panel10.Size = new Size(60,60);

              panel11.BackColor = Color.Black;
              panel11.Location = new Point(120, 60);
              panel11.Size = new Size(60,60);

              panel12.BackColor = Color.White;
              panel12.Location = new Point(180, 60);
              panel12.Size = new Size(60, 60);

              panel13.BackColor = Color.Black;
              panel13.Location = new Point(240, 60);
              panel13.Size = new Size(60, 60);

              panel14.BackColor = Color.White;
              panel14.Location = new Point(300, 60);
              panel14.Size = new Size(60, 60);

              panel15.BackColor = Color.Black;
              panel15.Location = new Point(360, 60);
              panel15.Size = new Size(60,60);

              panel16.BackColor = Color.White;
              panel16.Location = new Point(420, 60);
              panel16.Size = new Size(60, 60);

              panel17.BackColor = Color.White;
              panel17.Location = new Point(0, 120);
              panel17.Size = new Size(60,60);

              panel18.BackColor = Color.Black;
              panel18.Location = new Point(60, 120);
              panel18.Size = new Size(60, 60); 

              panel19.BackColor = Color.White;
              panel19.Location = new Point(120, 120);
              panel19.Size = new Size(60, 60);

              panel20.BackColor = Color.Black;
              panel20.Location = new Point(180, 120);
              panel20.Size = new Size(60, 60);

              panel21.BackColor = Color.White;
              panel21.Location = new Point(240, 120);
              panel21.Size = new Size(60, 60);

              panel22.BackColor = Color.Black;
              panel22.Location = new Point(300, 120);
              panel22.Size = new Size(60, 60);

              panel23.BackColor = Color.White;
              panel23.Location = new Point(360, 120);
              panel23.Size = new Size(60, 60);

              panel24.BackColor = Color.Black;
              panel24.Location = new Point(420, 120);
              panel24.Size = new Size(60, 60);

              panel25.BackColor = Color.Black;
              panel25.Location = new Point(0, 180);
              panel25.Size = new Size(60, 60);

              panel26.BackColor = Color.White;
              panel26.Location = new Point(60, 180);
              panel26.Size = new Size(60, 60);

              panel27.BackColor = Color.Black;
              panel27.Location = new Point(120, 180);
              panel27.Size = new Size(60, 60);

              panel28.BackColor = Color.White;
              panel28.Location = new Point(180, 180);
              panel28.Size = new Size(60, 60);

              panel29.BackColor = Color.Black;
              panel29.Location = new Point(240, 180);
              panel29.Size = new Size(60, 60);

              panel30.BackColor = Color.White;
              panel30.Location = new Point(300, 180);
              panel30.Size = new Size(60, 60);

              panel31.BackColor = Color.Black;
              panel31.Location = new Point(360, 180);
              panel31.Size = new Size(60, 60);

              panel32.BackColor = Color.White;
              panel32.Location = new Point(420, 180);
              panel32.Size = new Size(60, 60);

              panel33.BackColor = Color.White;
              panel33.Location = new Point(0, 240);
              panel33.Size = new Size(60, 60);

              panel34.BackColor = Color.Black;
              panel34.Location = new Point(60, 240);
              panel34.Size = new Size(60, 60);

              panel35.BackColor = Color.White;
              panel35.Location = new Point(120, 240);
              panel35.Size = new Size(60, 60);

              panel36.BackColor = Color.Black;
              panel36.Location = new Point(180, 240);
              panel36.Size = new Size(60, 60);

              panel37.BackColor = Color.White;
              panel37.Location = new Point(240, 240);
              panel37.Size = new Size(60, 60);

              panel38.BackColor = Color.Black;
              panel38.Location = new Point(300, 240);
              panel38.Size = new Size(60, 60);

              panel39.BackColor = Color.White;
              panel39.Location = new Point(360, 240);
              panel39.Size = new Size(60, 60);

              panel40.BackColor = Color.Black;
              panel40.Location = new Point(420, 240);
              panel40.Size = new Size(60, 60);

              panel41.BackColor = Color.Black;
              panel41.Location = new Point(0, 300);
              panel41.Size = new Size(60, 60);

              panel42.BackColor = Color.White;
              panel42.Location = new Point(60, 300);
              panel42.Size = new Size(60, 60);;

              panel43.BackColor = Color.Black;
              panel43.Location = new Point(120, 300);
              panel43.Size = new Size(60, 60);

              panel44.BackColor = Color.White;
              panel44.Location = new Point(180, 300);
              panel44.Size = new Size(60, 60);

              panel45.BackColor = Color.Black;
              panel45.Location = new Point(240, 300);
              panel45.Size = new Size(60, 60);

              panel46.BackColor = Color.White;
              panel46.Location = new Point(300, 300);
              panel46.Size = new Size(60, 60);

              panel47.BackColor = Color.Black;
              panel47.Location = new Point(360, 300);
              panel47.Size = new Size(60, 60);

              panel48.BackColor = Color.White;
              panel48.Location = new Point(420, 300);
              panel48.Size = new Size(60, 60);

              panel49.BackColor = Color.White;
              panel49.Location = new Point(0, 360);
              panel49.Size = new Size(60, 60);

              panel50.BackColor = Color.Black;
              panel50.Location = new Point(60, 360);
              panel50.Size = new Size(60, 60);;

              panel51.BackColor = Color.White;
              panel51.Location = new Point(120, 360);
              panel51.Size = new Size(60, 60);

              panel52.BackColor = Color.Black;
              panel52.Location = new Point(180, 360);
              panel52.Size = new Size(60, 60);

              panel53.BackColor = Color.White;
              panel53.Location = new Point(240, 360);
              panel53.Size = new Size(60, 60);

              panel54.BackColor = Color.Black;
              panel54.Location = new Point(300, 360);
              panel54.Size = new Size(60, 60);

              panel55.BackColor = Color.White;
              panel55.Location = new Point(360, 360);
              panel55.Size = new Size(60, 60);

              panel56.BackColor = Color.Black;
              panel56.Location = new Point(420, 360);
              panel56.Size = new Size(60, 60);

              panel57.BackColor = Color.Black;
              panel57.Location = new Point(0, 420);
              panel57.Size = new Size(60, 60);

              panel58.BackColor = Color.White;
              panel58.Location = new Point(60, 420);
              panel58.Size = new Size(60, 60);

              panel59.BackColor = Color.Black;
              panel59.Location = new Point(120, 420);
              panel59.Size = new Size(60, 60);

              panel60.BackColor = Color.White;
              panel60.Location = new Point(180, 420);
              panel60.Size = new Size(60, 60);

              panel61.BackColor = Color.Black;
              panel61.Location = new Point(240, 420);
              panel61.Size = new Size(60, 60);

              panel62.BackColor = Color.White;
              panel62.Location = new Point(300, 420);
              panel62.Size = new Size(60, 60);

              panel63.BackColor = Color.Black;
              panel63.Location = new Point(360, 420);
              panel63.Size = new Size(60, 60);

              panel64.BackColor = Color.White;
              panel64.Location = new Point(420, 420);
              panel64.Size = new Size(60, 60);

              this.Controls.Add(panel1);
              this.Controls.Add(panel2);
              this.Controls.Add(panel3);
              this.Controls.Add(panel4);
              this.Controls.Add(panel5);
              this.Controls.Add(panel6);
              this.Controls.Add(panel7);
              this.Controls.Add(panel8);
              this.Controls.Add(panel9);
              this.Controls.Add(panel10);
              this.Controls.Add(panel11);
              this.Controls.Add(panel12);
              this.Controls.Add(panel13);
              this.Controls.Add(panel14);
              this.Controls.Add(panel15);
              this.Controls.Add(panel16);
              this.Controls.Add(panel17);
              this.Controls.Add(panel18);
              this.Controls.Add(panel19);
              this.Controls.Add(panel20);
              this.Controls.Add(panel21);
              this.Controls.Add(panel22);
              this.Controls.Add(panel23);
              this.Controls.Add(panel24);
              this.Controls.Add(panel25);
              this.Controls.Add(panel26);
              this.Controls.Add(panel27);
              this.Controls.Add(panel28);
              this.Controls.Add(panel29);
              this.Controls.Add(panel30);
              this.Controls.Add(panel31);
              this.Controls.Add(panel32);
              this.Controls.Add(panel33);
              this.Controls.Add(panel34);
              this.Controls.Add(panel35);
              this.Controls.Add(panel36);
              this.Controls.Add(panel37);
              this.Controls.Add(panel38);
              this.Controls.Add(panel39);
              this.Controls.Add(panel40);
              this.Controls.Add(panel41);
              this.Controls.Add(panel42);
              this.Controls.Add(panel43);
              this.Controls.Add(panel44);
              this.Controls.Add(panel45);
              this.Controls.Add(panel46);
              this.Controls.Add(panel47);
              this.Controls.Add(panel48);
              this.Controls.Add(panel49);
              this.Controls.Add(panel50);
              this.Controls.Add(panel51);
              this.Controls.Add(panel52);
              this.Controls.Add(panel53);
              this.Controls.Add(panel54);
              this.Controls.Add(panel55);
              this.Controls.Add(panel56);
              this.Controls.Add(panel57);
              this.Controls.Add(panel58);
              this.Controls.Add(panel59);
              this.Controls.Add(panel60);
              this.Controls.Add(panel61);
              this.Controls.Add(panel62);
              this.Controls.Add(panel63);
              this.Controls.Add(panel64);*/
            board.MakeCells();
            this.Controls.Add(board);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
