using System.Diagnostics;
namespace AccountBook
{
    public partial class EntryForm : Form
    {
        private bool CheckEntry()
        {
            if (!DateTime.TryParse(txtDate.Text, out _))
            {
                MessageBox.Show("日付が正しくありません。");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("品名は必須項目です。");
                return false;
            }

            if (!decimal.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("金額が正しくありません。");
                return false;
            }

            return true;
        }
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
            if (!CheckEntry()) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}