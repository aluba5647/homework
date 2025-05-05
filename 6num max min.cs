using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6num_find_min_max
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtNumbers.Text.Trim();
                string[] parts = input.Split(' ');

                if (parts.Length != 6)
                {
                    MessageBox.Show("請輸入 6 個整數，以空格分隔。");
                    return;
                }

                int[] numbers = parts.Select(p => int.Parse(p)).ToArray();

                int minValue = arrMin(numbers);  // 呼叫自訂函數
                int maxValue = arrMax(numbers);  // 呼叫自訂函數

                lblMin.Text = "最小值: " + minValue;
                lblMax.Text = "最大值: " + maxValue;
            }
            catch (FormatException)
            {
                MessageBox.Show("請確保所有輸入都是有效的整數！");
            }
        }
        int arrMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        int arrMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
