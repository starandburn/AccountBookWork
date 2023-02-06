namespace AccountBook
{
    partial class EntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnMulti2 = new System.Windows.Forms.Button();
            this.btnMulti3 = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "分類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "品名";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtName.Location = new System.Drawing.Point(71, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 29);
            this.txtName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "備考";
            // 
            // txtRemarks
            // 
            this.txtRemarks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtRemarks.Location = new System.Drawing.Point(71, 195);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(192, 73);
            this.txtRemarks.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 13);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 40);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtpDate.Location = new System.Drawing.Point(71, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(192, 29);
            this.dtpDate.TabIndex = 14;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cboCategory.Items.AddRange(new object[] {
            "食費",
            "娯楽費",
            "交通費",
            "生活費",
            "医療費",
            "教育費",
            "雑費"});
            this.cboCategory.Location = new System.Drawing.Point(71, 60);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(192, 29);
            this.cboCategory.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Location = new System.Drawing.Point(71, 150);
            this.nudAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(192, 29);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMulti2
            // 
            this.btnMulti2.Location = new System.Drawing.Point(271, 151);
            this.btnMulti2.Name = "btnMulti2";
            this.btnMulti2.Size = new System.Drawing.Size(42, 27);
            this.btnMulti2.TabIndex = 6;
            this.btnMulti2.TabStop = false;
            this.btnMulti2.Tag = "2";
            this.btnMulti2.Text = "×2";
            this.btnMulti2.UseVisualStyleBackColor = true;
            this.btnMulti2.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // btnMulti3
            // 
            this.btnMulti3.Location = new System.Drawing.Point(321, 151);
            this.btnMulti3.Name = "btnMulti3";
            this.btnMulti3.Size = new System.Drawing.Size(42, 27);
            this.btnMulti3.TabIndex = 7;
            this.btnMulti3.TabStop = false;
            this.btnMulti3.Tag = "3";
            this.btnMulti3.Text = "×3";
            this.btnMulti3.UseVisualStyleBackColor = true;
            this.btnMulti3.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(371, 151);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(42, 27);
            this.btnTax.TabIndex = 8;
            this.btnTax.TabStop = false;
            this.btnTax.Tag = "1.1";
            this.btnTax.Text = "税";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(465, 298);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnMulti3);
            this.Controls.Add(this.btnMulti2);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "データ入力";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox txtRemarks;
        private Button btnOK;
        private Button btnCancel;
        private DateTimePicker dtpDate;
        private ComboBox cboCategory;
        private NumericUpDown nudAmount;
        private Button btnMulti2;
        private Button btnMulti3;
        private Button btnTax;
    }
}