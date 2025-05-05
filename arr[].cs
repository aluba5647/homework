using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 一維陣列排序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            Random rand = new Random();

            // 產生亂數並填入陣列
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 201); // 上限是 201，因為 Next 的上限是「不包含」
            }

            // 排序陣列
            Array.Sort(numbers);

            // 顯示結果
            lblResult.Text = "排序後的陣列: " + string.Join(", ", numbers);
        }
    }
}
