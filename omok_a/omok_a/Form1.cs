using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omok_a
{
    public partial class Form1 : Form
    {
        public const int PAN_SIZE = 19;
        private const int BTN_SIZE = 25;
        private const int BTN_MARGIN = 26;
        private const int TOP_MARGIN = 7;
        private const int LEFT_MARGIN = 8;

        private int change = -1;

        Bitmap w_bit = new Bitmap(Properties.Resources.w_dol);
        Bitmap b_bit = new Bitmap(Properties.Resources.b_dol);
        Bitmap defalut = new Bitmap(Properties.Resources.defalut);
        Bitmap Bubble = new Bitmap(Properties.Resources.asd1);

        Panel[,] dol_btns = new Panel[PAN_SIZE, PAN_SIZE];

        public Form1()
        {
            InitializeComponent();

            draw();

        }
        private void draw()
        {
            for (int i = 0; i < PAN_SIZE; i++)
            {
                for (int j = 0; j < PAN_SIZE; j++)
                {
                    dol_btns[i, j] = new Panel();
                    dol_btns[i, j].Size = new Size(BTN_SIZE, BTN_SIZE);
                    dol_btns[i, j].Location = new Point(LEFT_MARGIN + j * (BTN_MARGIN), TOP_MARGIN + i * (BTN_MARGIN));
                    dol_btns[i, j].Click += Form1_Click;
                    dol_btns[i, j].BackColor = Color.Transparent;
                    dol_btns[i, j].MouseHover += Mouse_Hover;
                    dol_btns[i, j].MouseLeave += Mouse_Leave;

                    BtnInfo bi = new BtnInfo(i, j);
                    bi.Val = -1;//선택 안된곳은 -1
                    dol_btns[i, j].Tag = bi; // ============코드 핵심===============
                    dol_btns[i, j].Parent = splitContainer1.Panel1;
                }
            }
        }

        private void clear()
        {
            for (int i = 0; i < PAN_SIZE; i++)
            {
                for (int j = 0; j < PAN_SIZE; j++)
                {
                    BtnInfo bi = new BtnInfo(i, j);
                    bi.Val = -1;//선택 안된곳은 -1
                    dol_btns[i, j].BackgroundImage = defalut;
                    dol_btns[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    dol_btns[i, j].Enabled = true;
                }
            }
        }
        private void Mouse_Hover(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;
            BtnInfo bi = (BtnInfo)btn.Tag;
            btn.BackColor = Color.Transparent;
            btn.BackgroundImage = Bubble;
            btn.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;
            BtnInfo bi = (BtnInfo)btn.Tag;

            btn.BackgroundImage = defalut;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Panel btn = sender as Panel;
            BtnInfo bi = (BtnInfo)btn.Tag; // 배열 번호로 접근가능
            btn.MouseHover -= Mouse_Hover;
            btn.MouseLeave -= Mouse_Leave;

            if (draw_Dol() > 0)
            {
                btn.BackgroundImage = b_bit;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Enabled = false;

                bi.Val = 0; // 흑돌은 0

                if (checked_Five(bi.Row, bi.Col, bi.Val) == true)
                {
                    winGame(bi.Val);
                }
            }
            else
            {
                btn.BackgroundImage = w_bit;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Enabled = false;

                bi.Val = 1; // 백돌은 1

                if (checked_Five(bi.Row, bi.Col, bi.Val) == true)
                {

                    winGame(bi.Val);
                }
            }
        }

        private int draw_Dol()
        {
            change = change * -1;

            return change;
        }

        private bool checked_Five(int row, int col, int val)
        {
            const int SUB = 4;
            int max = 10;//최소 10번 검사
            int get_val = val;
            int get_col = col;
            int get_row = row;
            int count = 0;

            bool count_five = false;
            bool win = false;


            get_col -= SUB;
            if (get_col < 0)
            {
                max += get_col;
                get_col += (SUB - col);
            }
            //가로 검사
            for (int i = 0; i < max; i++)
            {

                if (get_col + i >= PAN_SIZE)
                {
                    break;
                }
                BtnInfo info = (BtnInfo)dol_btns[get_row, get_col + i].Tag;
                if (info.Val == get_val)
                {
                    count++;
                    if (count == 5)
                    {
                        count_five = true;
                    }
                    else if (count > 5)
                    {
                        count_five = false;
                    }
                }
                else
                {
                    count = 0;
                }
            }


            get_col = col; // 위에서 만약 5 이하의 col 부분에서 호출 되면 get_col이 변질 됨 그렇기에 col로 한번더 초기화 하는것이 합리적
            //세로 검사      
            count = 0; // count가 위에서 내려올때가 있음
            get_row -= SUB;
            max = 10;
            if (get_row < 0)
            {
                max += get_row;// 왜 인지 5번 이상검사함(get_row -1 하면 5번만 검사할듯함)
                get_row += (SUB - row);// 0,0 배열 누르면 
            }
            for (int i = 0; i < max; i++)
            {

                if (get_row + i >= PAN_SIZE)
                {
                    break;
                }
                BtnInfo info = (BtnInfo)dol_btns[get_row + i, get_col].Tag;
                if (info.Val == get_val)
                {
                    count++;
                    if (count == 5)
                    {
                        count_five = true;
                    }
                    else if (count > 5)
                    {
                        count_five = false;
                    }
                }
                else
                {
                    count = 0;
                }
            }


            //왼쪽 대각 검사
            count = 0; // count가 위에서 내려올때가 있음
            get_row = row;
            get_col = col;
            max = 10;
            get_row -= SUB;
            get_col -= SUB;
            if (get_row < 0)
            {
                max += get_row; // 수정 필요
                if (row > col)
                {
                    get_row += (SUB - col);
                    get_col += (SUB - col);
                }
                else
                {
                    get_row += (SUB - row);
                    get_col += (SUB - row);
                }
            }
            else if (get_col < 0)
            {
                max += get_col; // 수정 필요
                if (row > col)
                {
                    get_row += (SUB - col);
                    get_col += (SUB - col);
                }
                else
                {
                    get_row += (SUB - row);
                    get_col += (SUB - row);
                }
            }

            for (int i = 0; i < max; i++)
            {
                if ((get_row + i >= PAN_SIZE) || (get_col + i) >= PAN_SIZE)
                {
                    break;
                }
                BtnInfo info = (BtnInfo)dol_btns[get_row + i, get_col + i].Tag;
                if (info.Val == get_val)
                {
                    count++;
                    if (count == 5)
                    {
                        count_five = true;
                    }
                    else if (count > 5)
                    {
                        count_five = false;
                    }
                }
                else
                {
                    count = 0;
                }
            }



            //오른쪽 대각 , 버그 검사해야함

            count = 0; // count가 위에서 내려올때가 있음
            get_row = row;
            get_col = col;
            max = 10;
            get_row += SUB;
            get_col -= SUB;
            if (get_row >= PAN_SIZE && get_col < 0)
            {
                if (get_row - (PAN_SIZE - 1) <= (SUB - col))
                {
                    get_row -= (SUB - col);
                    get_col += (SUB - col);
                }
                else
                {
                    get_row -= (get_row - (PAN_SIZE - 1));
                    get_col += (row - (PAN_SIZE - 1) + SUB);
                }
            }
            else if (get_row >= PAN_SIZE)
            {
                get_row -= (get_row - (PAN_SIZE - 1));
                get_col += (row - (PAN_SIZE - 1) + SUB);
            }
            else if (get_col < 0)
            {
                get_row -= (SUB - col);
                get_col += (SUB - col);

            }


            for (int i = 0; i < max; i++)
            {
                if ((get_row - i < 0) || (get_col + i) >= PAN_SIZE)//여기 get_row 값 문제 
                {
                    break;
                }
                BtnInfo info = (BtnInfo)dol_btns[get_row - i, get_col + i].Tag;
                //MessageBox.Show((get_row - i) + ", " + (get_col + i) + ", " + info.Val);
                if (info.Val == get_val)
                {
                    count++;
                    if (count == 5)
                    {
                        count_five = true;
                    }
                    else if (count > 5)
                    {
                        count_five = false;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            if (count_five)
            {
                win = true;
            }

            return win;
        }

        private void winGame(int check_dol)
        {
            if (check_dol == 0)
            {
                MessageBox.Show("흑돌 승");
                clear();
            }
            else if (check_dol == 1)
            {
                MessageBox.Show("백돌 승");
                clear();
            }
        }

        class BtnInfo
        {
            private int get_row;
            private int get_col;
            private int val;
            public int Row
            {
                get { return get_row; }
                set { get_row = value; }
            }
            public int Col
            {
                get { return get_col; }
                set { get_col = value; }
            }
            public int Val
            {
                get { return val; }
                set { val = value; }
            }

            public BtnInfo(int get_row, int get_col)
            {
                this.get_row = get_row;
                this.get_col = get_col;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
