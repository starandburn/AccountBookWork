using System.Diagnostics;
namespace AccountBook
{
    public partial class Form1 : Form
    {
        private void ShowTransaction(Transaction tr)
        {
            txtName.Text = tr.Name;
            txtCategory.Text = tr.Category;
            txtRemarks.Text = tr.Remarks;
            txtAmount.Text = (string)tr.Amount;
            txtDate.Text = tr.Date;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var d1 = new Date();                    // 引数なし
            var d2 = new Date(DateTime.Now);        // DateTime型（Nowは今現在の日時）
            var d3 = new Date("2023/1/23");     // 文字列
            Debug.WriteLine(d1.Value);                      // Valueプロパティを表示
            Debug.WriteLine(d2.Value.ToString());               // Valueの文字列表現を表示
            Debug.WriteLine(d3.Value.ToShortDateString());  // Valueの短い日付表現を表示
            Debug.WriteLine(d2.Value.ToLongDateString());       // Valueの長い日付表現を表示
            Debug.WriteLine(d3);                                // インスタンスをそのまま表示

            var d4 = (Date)DateTime.Now;    // DateTimeをDateにキャストして代入(d1はDate型になる)
            Date d5 = "2023/1/23";      // d5がDate型なので暗黙的にDateにキャストして代入 

            var tr1 = new Transaction("2023/1/25", "食費", "牛丼", 500, "つゆだく");
            var tr2 = new Transaction((Date)DateTime.Now, "文房具", "ボールペン", 200, "");
            Debug.WriteLine(tr1);
            Debug.WriteLine(tr2);

            var tr3 = tr1 with { };		// with句を使い、tr1と全く同じ値を持つデータを作る
            Debug.WriteLine(tr3);

            var tr4 = tr2 with { Name = "万年筆", Amount = 12345, Remarks = "プレゼント用" };
            Debug.WriteLine(tr4);

            ShowTransaction(tr4);


        }
    }
}