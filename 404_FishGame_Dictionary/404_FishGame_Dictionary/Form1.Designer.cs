namespace _404_FishGame_Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "你的名字";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(14, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(214, 22);
            this.textName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "遊戲歷程";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "對子";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(14, 354);
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(214, 128);
            this.textBooks.TabIndex = 6;
            this.textBooks.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "你的手牌";
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(234, 488);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(158, 23);
            this.btnAsk.TabIndex = 9;
            this.btnAsk.Text = "抽牌";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 488);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "遊戲開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 12;
            this.listHand.Location = new System.Drawing.Point(234, 24);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(158, 460);
            this.listHand.TabIndex = 11;
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(14, 80);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(214, 237);
            this.textProgress.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 515);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.TextBox textProgress;
    }
}

