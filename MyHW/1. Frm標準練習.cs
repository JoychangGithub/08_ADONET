
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;

            //int[] array = new int[3];
            //array[0] = 

            int Highest = 0;

            if (a > Highest)
            {
                Highest = a;
            }
            if (b > Highest)
            {
                Highest = b;
            }
            if (c > Highest)
            {
                Highest = c;
            }
            lblResult.Text = a+","+b+ ","+ c+ "中的最大值為: "+ Highest.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };

            int OddCuont = 0;
            int EvenCuont = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];

                if (number % 2 == 0)
                {
                    EvenCuont += 1;
                }
                else
                {
                    OddCuont += 1;
                }
            }
            lblResult.Text = "int[] nums = { 33, 4, 5, 11, 222, 34 }中\n奇數共" + OddCuont + "個\n偶數共" + EvenCuont + "個";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk" };

            int Longest = 0;
            string LongestName = "";
            foreach (string item in names)
            {
                if (item.Length > Longest)
                {
                    Longest = item.Length;
                    LongestName = item;
                }
            }
            lblResult.Text = "string[] names = { aaa, ksdkfjsdk }中\n最長的名字為" + LongestName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number;
            string character;
            string result;
            bool isNum = int.TryParse(textBox4.Text, out number);  //判斷輸入值是否為整數

            if (isNum)
            {
                if (number % 2 == 0)
                {
                    character = "偶數";
                    result = "輸入的數 " + number + "為" + character;
                }
                else
                {
                    character = "奇數";
                    result = "輸入的數 " + number + "為" + character;
                }

                lblResult.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            lblResult.Text = "int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 }中\n最高分: " + MaxScore(scores) + "\n最低分: " + MinScore(scores);
        }

        //建立方法找最高分
        private string MaxScore(int[] array)
        {
            int Highest = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Highest)
                {
                    Highest = array[i];
                }
            }
            return Highest.ToString();
        }

        //建立方法找最高分
        private string MinScore(int[] array)
        {
            string Lowest = "";
            foreach (int item in array)
            {
                if (Lowest == "")
                {
                    Lowest = item.ToString();
                }
                else if (item < int.Parse(Lowest))
                {
                    Lowest = item.ToString();
                }
            }
            return Lowest;
        }
        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] names = new string[8] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

            int count = 0;

            foreach (string item in names)
            {
                string str = item;
                string newstr = str.ToUpper();  //轉為大寫並傳回新字串


                int indC = newstr.IndexOf("C");


                if (indC >= 0)
                {
                    count += 1;
                }
            }
            lblResult.Text = "string[] names = new string[8] { mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker }中\n有C及有c的名字共有" + count.ToString() + "個";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int from;
            int step;
            int max;
            int Sum = 0;

            //判斷輸入值是否為整數
            bool isNum1 = int.TryParse(textBox1.Text, out from);
            bool isNum2 = int.TryParse(textBox3.Text, out step);
            bool isNum3 = int.TryParse(textBox2.Text, out max);

            step = step - 1;
            max = max + 1;

            if (isNum1 && isNum2 && isNum3 && textBox3.Text != "0")
            {
                if (textBox3.Text == "0") 
                {
                    MessageBox.Show("請輸入0以上(不包括0)的數值。");
                }
                //MessageBox.Show("最大值: " + max);  //測試用
                for (int i = from; i < max; i++)
                {
                    //MessageBox.Show("initial: " + i);  //測試用
                    Sum = Sum + i;
                    i = i + step;
                    //MessageBox.Show("Sum: " + Sum.ToString() + " ,i: " + i.ToString());   //測試用
                }
                lblResult.Text = from + " 到 " + textBox2.Text + " 相隔 " + step.ToString() + "\n加總為 " + Sum.ToString();
            }
            else if (textBox3.Text == "0")
            {
                MessageBox.Show("請輸入0以上的數值(不包括0)。");
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int from;
            int step;
            int max;
            int Sum = 0;

            //判斷輸入值是否為整數
            bool isNum1 = int.TryParse(textBox1.Text, out from);
            bool isNum2 = int.TryParse(textBox3.Text, out step);
            bool isNum3 = int.TryParse(textBox2.Text, out max);

            step = step - 1;
            max = max + 1;

            if (isNum1 && isNum2 && isNum3 && textBox3.Text != "0")
            {
                if (textBox3.Text == "0")
                {
                    MessageBox.Show("請輸入0以上(不包括0)的數值。");
                }
                int i = from;
                while (i < max)
                {
                    //MessageBox.Show("initial: " + i);  //測試用
                    Sum = Sum + i;
                    i = i + step + 1;
                    //MessageBox.Show("Sum: " + Sum.ToString() + " ,i: " + i.ToString());   //測試用
                }
                lblResult.Text = from + " 到 " + textBox2.Text + " 相隔 " + step.ToString() + "\n加總為 " + Sum.ToString();
            }
            else if (textBox3.Text == "0")
            {
                MessageBox.Show("請輸入0以上的數值(不包括0)。");
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int from;
            int step;
            int max;
            int Sum = 0;

            //判斷輸入值是否為整數
            bool isNum1 = int.TryParse(textBox1.Text, out from);
            bool isNum2 = int.TryParse(textBox3.Text, out step);
            bool isNum3 = int.TryParse(textBox2.Text, out max);

            step = step - 1;
            max = max + 1;

            if (isNum1 && isNum2 && isNum3 && textBox3.Text != "0")
            {
               int i = from;
                do
                {
                    //MessageBox.Show("initial: " + i);  //測試用
                    Sum = Sum + i;
                    i = i + step + 1;
                    //MessageBox.Show("Sum: " + Sum.ToString() + " ,i: " + i.ToString());   //測試用
                } while (i < max);
                lblResult.Text = from + " 到 " + textBox2.Text + " 相隔 " + step.ToString() + "\n加總為 " + Sum.ToString();
            }
            else if(textBox3.Text == "0")
            {
                MessageBox.Show("請輸入0以上的數值(不包括0)。");
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9 };
            lblResult.Text = "九九乘法表\n";

            for (int i = 1; i < 10; i++)
            {
                foreach (int item in arr)
                {
                    int multiple = item * i;
                    string result = item + "x" + i + "=" + multiple + "|";
                    string result2 = String.Format("{0,10}", result);
                    //string s2 = String.Format("{0,13}", s);
                    //上面的數字“13”就是佔位符，正數是靠右對齊，反之，負數是靠左對齊：

                    lblResult.Text += result2;
                }
                lblResult.Text += Environment.NewLine;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<string> ResultList = new List<string>();
            int integer = 100 * 2;
            int remainder;
            //int remainder = 100 % 2;
            //int integer = 100 / 2;
            //ResultList.Add(remainder.ToString());
            //MessageBox.Show("integer: " + integer.ToString() + "remainder: " + remainder.ToString());

            int i = 2;
            while (i > 1)
            {
                integer = integer / 2;
                remainder = integer % 2;
                ResultList.Insert(0, remainder.ToString());
                //MessageBox.Show("integer: " + integer.ToString() + "remainder: " + remainder.ToString()); //測試用

                if (integer == 1)  //若使用if (integer == 0)最前面會多一個0
                {
                    i = -1;
                }
            }
            lblResult.Text = "100的二進位為:\n";
            for (int j = 0; j < ResultList.Count; j++)
            {
                string Result = ResultList[j];
                //MessageBox.Show(Result); //測試用
                lblResult.Text += Result;
            }
            //MessageBox.Show((1%2).ToString());  //測試用
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int[] lotteryArray = new int[6];
            Random rnd = new Random();  //產生亂數
            for (int i = 0; i < 6; i++)
            {
                lotteryArray[i] = rnd.Next(1, 49);

                for (int j = 0; j < i; j++)
                {
                    while (lotteryArray[j] == lotteryArray[i])    //檢查是否發生重複數值，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查
                        lotteryArray[i] = rnd.Next(1, 49);   //重新產生，存回陣列
                    }
                }
            }
            lblResult.Text = "樂透號碼\n";
            foreach (int item in lotteryArray) 
            {
                lblResult.Text += item.ToString() + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MAXscores = MaxScore2(2, 3, 46, 33, 22, 100, 150, 33, 55);
            lblResult.Text = "MaxScore2(2, 3, 46, 33, 22, 100, 150, 33, 55)中\n最高分: " + MAXscores;
        }
        //建立使用建立參數為params的方法找最高分
        private string MaxScore2(params int[] arr)
        {
            int Highest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Highest)
                {
                    Highest = arr[i];
                }
            }
            return Highest.ToString();
        }
    }
}
