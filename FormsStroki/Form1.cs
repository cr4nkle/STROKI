using System;
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
            textBox1.Text = Properties.Settings.Default.line.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = textBox1.Text;;
            bool check = Logic.Check(line);           
            Properties.Settings.Default.line = line;
            Properties.Settings.Default.Save();

            if (check)
            {
                int sum;
                try
                {
                    sum = Logic.GetSum(line);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(text: $"Сумма в строке\n{sum}");
            }
            else
            {
                MessageBox.Show("Вы ввели пустую строку.");
            }
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
