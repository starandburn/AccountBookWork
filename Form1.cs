using System.Diagnostics;
namespace AccountBook
{
    public partial class EntryForm : Form
    {
        private bool CheckEntry()
        {
            //if (!DateTime.TryParse(txtDate.Text, out _))
            //{
            //    MessageBox.Show("日付が正しくありません。");
            //    return false;
            //}

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("品名は必須項目です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (!decimal.TryParse(txtAmount.Text, out _))
            //{
            //    MessageBox.Show("金額が正しくありません。");
            //    return false;
            //}

            return true;
        }
        private void ShowTransaction(Transaction tr)
        {
            txtName.Text = tr.Name;
            cboCategory.Text = tr.Category;
            txtRemarks.Text = tr.Remarks;
            nudAmount.Value = tr.Amount;
            dtpDate.Value = tr.Date;
        }
        public Transaction GetTransaction()
        {
            return new Transaction(
                (Date)dtpDate.Value,
                cboCategory.Text,
                txtName.Text,
                new Money(nudAmount.Value),
                txtRemarks.Text);
        }

        // デフォルトコンストラクタ―
        public EntryForm()
        {
            InitializeComponent();
            var tr = new Transaction((Date)DateTime.Today, "", "", 0, "");
            ShowTransaction(tr);
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

        private void MultiButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //if (btn == null) return;
            //if (btn?.Tag == null) return;
            var str = btn?.Tag?.ToString();
            if (!decimal.TryParse(str, out var dc)) return;
            nudAmount.Value *= dc;
        }
    }
}