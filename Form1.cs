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
        public EntryForm()
        {
            InitializeComponent();
        }
        public EntryForm(Transaction tr) : this()
        {
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