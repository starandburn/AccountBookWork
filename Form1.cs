using System.Diagnostics;
namespace AccountBook
{
    public partial class EntryForm : Form
    {
        private void ShowTransaction(Transaction tr)
        {
            txtName.Text = tr.Name;
            txtCategory.Text = tr.Category;
            txtRemarks.Text = tr.Remarks;
            txtAmount.Text = (string)tr.Amount;
            txtDate.Text = tr.Date;
        }
        public Transaction GetTransaction()
        {
            return new Transaction(
                txtDate.Text,
                txtCategory.Text,
                txtName.Text,
                new Money(txtAmount.Text),
                txtRemarks.Text);
        }

        // デフォルトコンストラクタ―
        public EntryForm()
        {
            InitializeComponent();
        }

        // 更新用に家計簿データを指定するコンストラクタ―
        public EntryForm(Transaction tr) : this()
        {
            // 家計簿データの表示
            ShowTransaction(tr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // OKボタンのイベントハンドラー
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tr = GetTransaction();
            Debug.WriteLine(tr);
        }
    }
}