﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        int User = 1;
        private List<int> list1=new List<int>();
        private List<int> list2=new List<int>();


        public void UserSwap()
        {
            if (User==1)
            {
                lblUser.Text = "O";
                User = 2;
            }
            else
            {
                lblUser.Text = "X";
                User = 1;
            }
        }
        public string btnIcon()
        {
            string T = "";
            if (User == 1)
            {
                T = "X";
                return T;
            }
            else
            {
                T = "O";
                return T;
            }
            return T;
        }
        public void AddToList(int i)
        {
            if (User==1)
            {
                list1.Add(i);
            }
            else
            {
                list2.Add(i);
            }
            UserSwap();
            ValidateRes();
        }
        public void DisableAll(bool i)
        {
            btn1.Enabled = i;
            btn2.Enabled = i;
            btn3.Enabled = i;
            btn4.Enabled = i;
            btn5.Enabled = i;
            btn6.Enabled = i;
            btn7.Enabled = i;
            btn8.Enabled = i;
            btn9.Enabled = i;
        }
        public void ClearNew()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            User = 1;
            lblUser.Text = "X";
            DisableAll(true);
            list1.Clear();
            list2.Clear();
            btnNew.Focus();
        }
        public void msg(String name)
        {
            MessageBox.Show("User "+name+" is Winner");
            ClearNew();
            return;
        }
        public void ValidateRes()
        {
            
            if (
                (list1.Contains(1) && list1.Contains(2) && list1.Contains(3))|| 
                (list1.Contains(4) && list1.Contains(5) && list1.Contains(6))|| 
                (list1.Contains(7) && list1.Contains(8) && list1.Contains(9))||
                (list1.Contains(1) && list1.Contains(4) && list1.Contains(7))||
                (list1.Contains(2) && list1.Contains(5) && list1.Contains(8))||
                (list1.Contains(3) && list1.Contains(6) && list1.Contains(9))||
                (list1.Contains(1) && list1.Contains(5) && list1.Contains(9))||
                (list1.Contains(7) && list1.Contains(5) && list1.Contains(3))
               )
            {
                msg("1");
            }
            if (
                (list2.Contains(1) && list2.Contains(2) && list2.Contains(3)) ||
                (list2.Contains(4) && list2.Contains(5) && list2.Contains(6)) ||
                (list2.Contains(7) && list2.Contains(8) && list2.Contains(9)) ||
                (list2.Contains(1) && list2.Contains(4) && list2.Contains(7)) ||
                (list2.Contains(2) && list2.Contains(5) && list2.Contains(8)) ||
                (list2.Contains(3) && list2.Contains(6) && list2.Contains(9)) ||
                (list2.Contains(1) && list2.Contains(5) && list2.Contains(9)) ||
                (list2.Contains(7) && list2.Contains(5) && list2.Contains(3))
               )
            {
                msg("2");
            }
            
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = btnIcon();
            AddToList(1);
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = btnIcon();
            AddToList(2);
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = btnIcon();
            AddToList(3);
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = btnIcon();
            AddToList(4);
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = btnIcon();
            AddToList(5);
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = btnIcon();
            AddToList(6);
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = btnIcon();
            AddToList(7);
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = btnIcon();
            AddToList(8);
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = btnIcon();
            AddToList(9);
            btn9.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearNew();
        }
    }
}
