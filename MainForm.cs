using System.Diagnostics;

namespace AccountBook
{
    public partial class MainForm : Form
    {
        // 複数の家計簿レコードを保持するリスト
        private List<Transaction> transactions = new();

        private string GetCsvLine(Transaction tr)
        {
            return $"{tr.Date},{tr.Category},{tr.Name},{(string)tr.Amount},{tr.Remarks}";
        }

        private bool SaveTransactions(string filename)
        {
            try
            {
                using var sw = new StreamWriter(filename, false,
                                        System.Text.Encoding.GetEncoding("Shift-JIS"));
                foreach (var tr in transactions)
                {
                    sw.WriteLine(GetCsvLine(tr));
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private Transaction FromCsvLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line)) return null;
            var items = line.Split(",");		// カンマで分割して１件ずつ配列に入れる

            var date = new Date();
            var category = string.Empty;
            var name = string.Empty;
            var amount = new Money();
            var remarks = string.Empty;

            for (var i = 0; i < items.Length; i++) 	// 番号が必要なのでforeachを使わない
            {
                var item = items[i]?.ToString().Trim();	// １項目分の文字列を作る
                switch (i)
                {
                    case 0:     // 0番目のデータは日付
                        date = new Date(item);      // item（文字列）をもとに日付を作って入れる
                        break;
                    case 1:     // 1番目のデータは分類
                        category = item;            // 分類は文字列なのでitemをそのまま入れる
                        break;
                    case 2:
                        name = item;
                        break;
                    case 3:
                        amount = new Money(item);
                        break;
                    case 4:
                        remarks = item;
                        break;
                }
            }
            return new Transaction(date, category, name, amount, remarks);
        }

        // 画面上の家計簿一覧を作成する
        private void MakeTransactionList(int index = -1)
        {
            lstTransactions.BeginUpdate();  // リストボックス更新開始
            lstTransactions.Items.Clear();  // リストボックス中身クリア

            //lstTransactions.Items.Add(string.Join("\t", "|", "|", "|", "|", "|"));

            // 家計簿データを全件処理
            foreach (var tr in transactions)
            {
                // 表示する文字列の作成
                var text = $"{tr.Date}\t{tr.Category}\t{tr.Name}\t{tr.Amount}\t{tr.Remarks}";

                // 一覧に追加
                lstTransactions.Items.Add(text);
            }

            index = Math.Max(-1, Math.Min(index, lstTransactions.Items.Count - 1));
            lstTransactions.SelectedIndex = index;// 指定された項目を選択
            lstTransactions.EndUpdate();    // リストボックス更新終了
        }


        // コンストラクタ―(自動生成)
        public MainForm()
        {
            InitializeComponent();
        }

        // [終了]ボタンのイベントハンドラー
        private void btnExit_Click(object sender, EventArgs e)
        {
            // 自身のウィンドウを閉じる
            this.Close();
        }

        // [追加]ボタンのイベントハンドラー
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 入力フォームのインスタンスを作成
            var form = new EntryForm();

            // ダイアログとして表示して、結果がOKだった場合
            if (form.ShowDialog() == DialogResult.OK)
            {
                // 入力されているレコードを取得する
                var tr = form.GetTransaction();

                // リストの末尾に追加する
                transactions.Add(tr);

                MakeTransactionList(transactions.Count - 1);
            }
        }


        // メイン画面ロードのイベントハンドラー
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Shift-JISを使う準備
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // ダミーのデータを20件直接追加する
            transactions.Add(new Transaction("2023/03/01", "医療費", "風邪薬", 450, ""));
            transactions.Add(new Transaction("2023/03/01", "食費", "牛丼", 650, "クーポン使用"));
            transactions.Add(new Transaction("2023/03/01", "娯楽費", "ゲーム", 4000, ""));
            transactions.Add(new Transaction("2023/03/01", "交通費", "電車", 600, "往復"));
            transactions.Add(new Transaction("2023/03/01", "食費", "夕食の材料", 2000, ""));
            transactions.Add(new Transaction("2023/03/02", "交通費", "バス代", 150, "帰りは徒歩"));
            transactions.Add(new Transaction("2023/03/02", "生活費", "光熱費", 8000, "水道、ガス、電気"));
            transactions.Add(new Transaction("2023/03/02", "生活費", "電話代", 3500, ""));
            transactions.Add(new Transaction("2023/03/03", "医療費", "歯医者", 1200, "次回4/1"));
            transactions.Add(new Transaction("2023/03/03", "医療費", "痛み止め薬", 600, "歯痛"));
            transactions.Add(new Transaction("2023/03/03", "娯楽費", "映画館", 2100, "3Dメガネ付き"));
            transactions.Add(new Transaction("2023/03/03", "食費", "ポップコーン", 200, ""));
            transactions.Add(new Transaction("2023/03/03", "娯楽費", "カラオケ", 1500, "割り勘１人分"));
            transactions.Add(new Transaction("2023/03/04", "交通費", "タクシー代", 2000, ""));
            transactions.Add(new Transaction("2023/03/04", "教育費", "参考書", 3000, ""));
            transactions.Add(new Transaction("2023/03/04", "食費", "朝マック", 350, ""));
            transactions.Add(new Transaction("2023/03/04", "食費", "昼食", 700, ""));
            transactions.Add(new Transaction("2023/03/05", "食費", "夕食", 1000, ""));
            transactions.Add(new Transaction("2023/03/05", "雑費", "カード年会費", 1200, "年１回"));
            transactions.Add(new Transaction("2023/03/05", "娯楽", "マンガ", 400, ""));

            lstTransactions.UseCustomTabOffsets = true;
            lstTransactions.CustomTabOffsets.Clear();
            //lstTransactions.CustomTabOffsets.Add(42);
            //lstTransactions.CustomTabOffsets.Add(80);
            //lstTransactions.CustomTabOffsets.Add(160);
            //lstTransactions.CustomTabOffsets.Add(200);
            lstTransactions.CustomTabOffsets.AddRange(new[] { 42, 80, 160, 200 });

            // 一覧を作成して最終行を選択する
            MakeTransactionList(transactions.Count - 1);
        }

        // [更新]ボタンをクリックしたときのイベントハンドラー
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 現在選択されている項目を取得
            var index = lstTransactions.SelectedIndex;// 上から何番目か
            if (index == -1) return;    // 未選択なら何もしない

            var tr = transactions[index];   // 対応する家計簿データの取得

            // 入力フォームの表示
            var form = new EntryForm(tr);// データを指定して表示
            if (form.ShowDialog() != DialogResult.OK) return; // [OK]以外は何もしない

            // 家計簿データの更新
            var tr2 = form.GetTransaction();// 入力データの取得
            transactions[index] = tr2;      // 該当データの差し替え
            MakeTransactionList(index);     // 一覧の再作成

        }

        // [削除]ボタンをクリックしたときのイベントハンドラー
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 削除対象のインデックス番号を取得
            var index = lstTransactions.SelectedIndex;
            if (index == -1) return;    // 未選択なら何もしない

            // データ群から１件除外
            transactions.RemoveAt(index);

            // 一覧を再作成
            MakeTransactionList(index);
        }

        // フォームが閉じられようとしている時のイベントハンドラー
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("アプリケーションを終了しますか？", "確認",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes) return;
            // 終了をキャンセルする
            e.Cancel = true;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            var fname = @"C:\Temp\AccountBook.csv";
            if (SaveTransactions(fname))
            {
                MessageBox.Show("家計簿ファイルを保存しました。", "保存",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("家計簿ファイルが保存できませんでした。", "保存",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("一覧をクリアしてよろしいですか？", "新規",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.No) return;

            transactions.Clear();
            MakeTransactionList();
        }
    }
}
