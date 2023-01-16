﻿using System.Diagnostics;
namespace AccountBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tr1 = new Transaction("2023/1/25", "食費", "牛丼", 500, "つゆだく");
            var tr2 = new Transaction((Date)DateTime.Now, "文房具", "ボールペン", 200, "");
            Debug.WriteLine(tr1);
            Debug.WriteLine(tr2);

            var tr3 = tr1 with { };     // with句を使い、tr1と全く同じ値を持つデータを作る
            Debug.WriteLine(tr3);

            var tr4 = tr2 with { Name = "万年筆", Amount = 12345, Remarks = "プレゼント用" };
            Debug.WriteLine(tr4);

            //tr1.Amount = 600;   // レコードのプロパティは作成時以外は変更できない 
        }
    }
}