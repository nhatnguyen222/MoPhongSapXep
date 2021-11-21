using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mang;
        Button [] mangButton;
        Random rd= new Random();
        const int GAP = 50;
        const int HEIGHT = 100;
        const int SIZE = 50;
        private void tao_Click(object sender, EventArgs e)
        {
                int n = int.Parse(soPhanTu.Text);
                mang = new int[n];
                mangButton = new Button[n];
                panel1.Controls.Clear();
                for (int i = 0; i < n; i++)
                {
                    Button btn = new Button();
                    int giaTri = rd.Next(100);
                    btn.Text = giaTri.ToString();
                    btn.Height = btn.Width = SIZE;
                    btn.Location = new Point(panel1.Controls.Count * (btn.Width + GAP), panel1.Height / 2 - btn.Height);
                    mang[i] = giaTri;
                    mangButton[i] = btn;
                    panel1.Controls.Add(btn);
                }
            
           
        }
        private void BubbleSort(int [] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = mang.Length - 1; j > i; j--)
                {
                    if (mang[j] < mang[j - 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j - 1];
                        mang[j - 1] = temp;
                        System.Threading.Thread.Sleep(10);
                       MoveButton(j, j - 1);
                    }
                }
            }
        }

        private void MoveButton(int i, int j)
        {
            Status st= new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for (int x = 0; x < Distance; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVED;
            backgroundWorker1.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }

        private void sapXep_Click(object sender, EventArgs e)
        {
         backgroundWorker1.RunWorkerAsync();
        }
    
                 

        private void doWork(object sender, DoWorkEventArgs e)
        {
             BubbleSort(mang);

        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = mangButton[st.Pos1];
                mangButton[st.Pos1] = mangButton[st.Pos2];
                mangButton[st.Pos2] = tmp;
                return;
            }
            Button btn1 = mangButton[st.Pos1];
            Button btn2 = mangButton[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left = btn1.Left - 1;
                btn2.Left = btn2.Left + 1;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top = btn1.Top - 1;
                btn2.Top = btn2.Top + 1;
            }
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.BackColor = Color.ForestGreen;
                btn.ForeColor = Color.White;
            }
        }

        private void thuatToan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
