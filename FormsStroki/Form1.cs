﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsStroki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static int GetSum(string line)
        {
            char[] symbol = { '+', '-' };
            string[] changeLine = line.Split(symbol);
            int[] arr = new int[changeLine.Length];
            int sum = int.Parse(changeLine[0]);

            for (int i = 1; i < changeLine.Length; i++)
            {
                arr[i] = int.Parse(changeLine[i]);
                if (i % 2 == 0)
                {
                    sum = sum - arr[i];
                }
                else
                {
                    sum = sum + arr[i];
                }

            }

            return sum;
        }

        public static bool Check(string line)
        {
            bool check = true;
            if (line == "")
            {
                check = false;
            }
            return check;
        }
    }
}
