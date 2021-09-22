using System;
using System.Drawing;
using System.Windows.Forms;

namespace CellularAutomata
{
    public partial class Form1 : Form
    {
        //sets cell matrix dimensions
        const int ROWS = 100; const int COLS = 100;
        //instantiates cell states and next state matrix
        private Array cellst = new int[ROWS, COLS];
        private Array nextst = new int[ROWS, COLS];
        private readonly Random rand = new Random(); //sets up random num gen
        private int fill = 2; //higher value means less alive cells initialized
        int neigh; //var to keep track of a cells neighbors
        bool pause = true; //pauses program
        
        //template booleans
        bool random = true;
        bool glider = false;
        bool whiteblack = false;
        bool oreo = false;
        bool japan = false;
        bool stripes = false;
        bool misc = false;
        //wrapped boolean. do borders wrap around
        bool wrap = true;
        //control update speed
        int count = 0;
        int period = 10;


        public Form1()
        {
            InitializeComponent();
            //assigns random state to cells
            Reset(fill);
            Size = new Size(50 +COLS * 5,  100+(ROWS * 5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x; int y; int l = Size.Width / COLS;
            int o = 20;//offset
            Size = new Size(3*o + l * COLS, 5*o + l * ROWS);
            Graphics g = e.Graphics;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    if (cellst.GetValue(r, c).Equals(1))
                    {
                        x = l * c; y = l * r; g.FillRectangle(Brushes.White,o + x,(2*o) + y, l, l);
                    }
                }
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            //only update if unpaused
            count++;
            if (!pause && (count > period))
            {
                //update and set cell state to the next state
                nextst = Update(cellst, nextst);
                Array.Copy(nextst, cellst, (ROWS * COLS));
                Refresh();
                count = 0;
            }
        }

        private int NeighborsWrap(int r, int c, Array current)
        {
            int neigh = 0;
            if ((r == 0) && (c == 0))
            {
                if (current.GetValue(ROWS - 1, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if ((r == 0) && (c == COLS - 1))
            {
                if (current.GetValue(ROWS - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, 0).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, 0).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, 0).Equals(1)) neigh += 1;
            }
            else if ((r == ROWS - 1) && (c == 0))
            {
                if (current.GetValue(r - 1, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(0, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(0, c).Equals(1)) neigh += 1;
                if (current.GetValue(0, c + 1).Equals(1)) neigh += 1;
            }
            else if ((r == ROWS - 1) && (c == COLS - 1))
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, 0).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, 0).Equals(1)) neigh += 1;
                if (current.GetValue(0, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(0, c).Equals(1)) neigh += 1;
                if (current.GetValue(0, 0).Equals(1)) neigh += 1;
            }
            else if (c == 0)
            {
                if (current.GetValue(r - 1, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, COLS - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if (c == COLS - 1)
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, 0).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, 0).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, 0).Equals(1)) neigh += 1;
            }
            else if (r == 0)
            {
                if (current.GetValue(ROWS - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(ROWS - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if (r == ROWS - 1)
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(0, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(0, c).Equals(1)) neigh += 1;
                if (current.GetValue(0, c + 1).Equals(1)) neigh += 1;
            }
            else
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            return neigh;
        }
        private int NeighborsClosed(int r, int c, Array current)
        {
            int neigh = 0;
            if ((r == 0) && (c == 0))
            {
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if ((r == 0) && (c == COLS - 1))
            {
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
            }
            else if ((r == ROWS - 1) && (c == 0))
            {
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
            }
            else if ((r == ROWS - 1) && (c == COLS - 1))
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
            }
            else if (c == 0)
            {
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if (c == COLS - 1)
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
            }
            else if (r == 0)
            {
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            else if (r == ROWS - 1)
            {
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
            }
            else
            {
                if (current.GetValue(r - 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r - 1, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r, c + 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c - 1).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c).Equals(1)) neigh += 1;
                if (current.GetValue(r + 1, c + 1).Equals(1)) neigh += 1;
            }
            return neigh;
        }

        private int NeighborsHex(int r, int c, Array current)
        {
            int neigh = 0;

            return neigh;
        }
        private Array Update(Array current, Array next)
        {
            //iterate through cells
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    //evaluate cells neighbor count
                    if (!wrap) neigh = NeighborsClosed(r,c, current);
                    else neigh = NeighborsWrap(r, c, current);
                    //more than 3 neighbors die overpop. Less than 2 neigh die underpop
                    //if ((neigh > 3) || (neigh < 2)) next.SetValue(0,r,c);
                    //3 neighbors reproduct. 2 or 3 neigh live on
                    //else if ((current.GetValue(r, c).Equals(1) && neigh == 2) || (neigh == 3)) next.SetValue(1, r, c);
                    if (current.GetValue(r, c).Equals(1))
                    {
                        if (neigh < 2) next.SetValue(0, r, c);
                        else if ((neigh == 2) || (neigh == 3)) next.SetValue(1, r, c);
                        else if (neigh > 3) next.SetValue(0, r, c);
                    }
                    else
                    {
                        if(neigh == 3) next.SetValue(1, r, c);
                    }
                }
            }
            return next;
        }

        private void pause1_Click(object sender, EventArgs e)
        {
            pause = true ^ pause;
            if (pause) pause1.Text = "Play";
            else pause1.Text = "Pause";
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            Reset(fill);
        }
        private void Reset(int fill)
        {
            if (random)
            {
                for (int r = 0; r < cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c < cellst.GetUpperBound(1); c++)
                    {
                        cellst.SetValue(rand.Next(0, fill), r, c);
                    }
                }
            }
            else if (glider)
            {
                Array.Clear(cellst, 0, ROWS * COLS);
                int[,] glide = { { 2, 6 }, { 2, 7 }, { 3, 6 }, { 3, 7 }, { 12, 6 }, { 12, 7 }, { 12, 8 }, { 13, 5 },
                                  { 13, 9 }, { 14, 4 }, { 14, 10 }, { 15, 4 },{ 15, 10 }, { 16, 7 }, { 17, 5 }, { 17, 9},
                                  { 18, 6 }, { 18, 7 }, { 18, 8 }, { 19, 7 },{ 22, 4 }, { 22, 5 }, { 22, 6 }, { 23, 4 },
                                  { 23, 5}, { 23, 6 }, { 24,3},{24,7},{26,2},{26,3},{26,7},{26,8},{36,4},{36,5 },{37,4 },{37,5 } };
                for(int n=0;n< glide.GetUpperBound(0); n++)
                {
                    cellst.SetValue(1, glide[n, 1], glide[n, 0]);
                    if(!wrap) cellst.SetValue(1, 73 - glide[n, 1], glide[n, 0]); //second gun
                    if(!wrap) cellst.SetValue(1, glide[n, 1], COLS - glide[n, 0]); //third gun
                    if(!wrap) cellst.SetValue(1, 73 - glide[n, 1], COLS - glide[n, 0]);
                    //second glider
                }
            }
            else if (whiteblack)
            {
                for (int r = 0; r <= cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= cellst.GetUpperBound(1); c++)
                    {
                        if (c < COLS / 2) cellst.SetValue(1, r, c);
                        else cellst.SetValue(0, r, c);
                    }
                }
            }
            else if (oreo)
            {
                for (int r = 0; r <= cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= cellst.GetUpperBound(1); c++)
                    {
                        if ((r < ROWS / 3)||(r> (2*ROWS/3))) cellst.SetValue(1, r, c);
                        else cellst.SetValue(0, r, c);
                    }
                }
                if (wrap) cellst.SetValue(1, (ROWS / 3) + 1, COLS / 2);
            }
            else if (japan)
            {
                for (int r = 0; r <= cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= cellst.GetUpperBound(1); c++)
                    {
                        if ((r > ROWS / 3) && (r < (2 * ROWS / 3)) && (c > COLS / 3) && (c < (2 * COLS / 3))) cellst.SetValue(1, r, c);
                        else cellst.SetValue(0, r, c);
                    }
                }
            }
            else if (stripes)
            {
                for (int r = 0; r <= cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= cellst.GetUpperBound(1); c++)
                    {
                        if (r%3==0) cellst.SetValue(1, r, c);
                        else cellst.SetValue(0, r, c);
                    }
                }
                if (wrap) cellst.SetValue(1, 2, COLS / 2);
            }
            else if (misc)
            {
                for (int r = 0; r <= cellst.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= cellst.GetUpperBound(1); c++)
                    {
                        if ((((r - c) >ROWS/2) || ((r - c) < ROWS/2) || ((r - c) / 2 > 0) || ((r-c)/2 <0)) && (r+c)%2==0) cellst.SetValue(1, r, c);
                        else cellst.SetValue(0, r, c);
                    }
                }
            }

            Array.Clear(nextst, 0, ROWS * COLS);
            Refresh();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            panel1.Visible = panel1.Visible ^ true; //toggles menu
        }
        private void template1_Click(object sender, EventArgs e)
        {
            random = true; glider = false; whiteblack = false; oreo = false;
            japan = false; stripes = false; misc = false;
            Reset(fill);
        }
        private void template2_Click(object sender, EventArgs e)
        {
            random = false;  glider = true; whiteblack = false; oreo = false;
            japan = false; stripes = false; misc = false;
            Reset(fill);
        }
        private void template3_Click(object sender, EventArgs e)
        {
            random = false; glider = false; whiteblack = true; oreo = false;
            japan = false; stripes = false; misc = false;
            Reset(fill);
        }

        private void template4_Click(object sender, EventArgs e)
        {
            random = false; glider = false; whiteblack = false; oreo = true;
            japan = false; stripes = false; misc = false;
            Reset(fill);
        }

        private void template5_Click(object sender, EventArgs e)
        {
            random = false; glider = false; whiteblack = false; oreo = false;
            japan = true; stripes = false; misc = false;
            Reset(fill);
        }

        private void template6_Click(object sender, EventArgs e)
        {
            random = false; glider = false; whiteblack = false; oreo = false;
            japan = false; stripes = true; misc = false;
            Reset(fill);
        }

        private void template7_Click(object sender, EventArgs e)
        {
            random = false; glider = false; whiteblack = false; oreo = false;
            japan = false; stripes = false; misc = true;
            Reset(fill);
        }

        private void clockspeed1_ValueChanged(object sender, EventArgs e)
        {
            period = (int) clockspeed1.Value;
        }

        private void wraplabel_Click(object sender, EventArgs e)
        {
            wrap = wrap ^ true;
            if (wrap) wraplabel.Text = "Wrapped Edge";
            else wraplabel.Text = "Closed Edge";
        }

        private void fillBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                fill = Int32.Parse(fillBox1.Text);
                fillBox1.Text = "Fill..";
            }
            catch (Exception ex)
            {
                fillBox1.Text = "EnterInt";
            }
        }
    }
}
