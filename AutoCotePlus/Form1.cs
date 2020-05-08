using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCotePlus
{
    public partial class Form1 : Form
    {
        bool isMove;
        Point fPt;

        /* 3단 구조체 */
        public static string a1 = @"C:\codes\a1.txt";
        public static string b1 = System.IO.File.ReadAllText(a1);

        /* 파싱 */
        public static string a2 = @"C:\codes\a2.txt";
        public static string b2 = System.IO.File.ReadAllText(a2);


        /* string 종합 */
        public static string a3 = @"C:\codes\a3.txt";
        public static string b3 = System.IO.File.ReadAllText(a3);

        /* 상하좌우 탐색*/
        public static string a4 = @"C:\codes\a4.txt";
        public static string b4 = System.IO.File.ReadAllText(a4);

        /* 상하좌우 대각선가지 탐색*/
        public static string a5 = @"C:\codes\a5.txt";
        public static string b5 = System.IO.File.ReadAllText(a5);

        /* bfs */
        public static string a6 = @"C:\codes\a6.txt";
        public static string b6 = System.IO.File.ReadAllText(a6);

        /* 2중백터 종합 */
        public static string a7 = @"C:\codes\a7.txt";
        public static string b7 = System.IO.File.ReadAllText(a7);

        /* 셋 관련 */
        public static string a8 = @"C:\codes\a8.txt";
        public static string b8 = System.IO.File.ReadAllText(a8);

        /* 멥 관련 */
        public static string a9 = @"C:\codes\a9.txt";
        public static string b9 = System.IO.File.ReadAllText(a9);


        public Form1()
        {
            InitializeComponent();
            
        }

      

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
        }

        /* 3단 구조체 */
        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b1);

        }

        /* 파싱 */
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b2);
        }

        /* string 종합 */
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b3);
        }

        /* 상하좌우 탐색*/
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b4);
        }

        /* 상하좌우 대각선가지 탐색*/
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b5);
        }

        /* bfs */
        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b6);
        }

        /* 2중백터 종합 */
        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b7);
        }

        /* 셋 관련 */
        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b8);
        }



        /* 멥 관련 */
        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(b9);

        }
    }
}

