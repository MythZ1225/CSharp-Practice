namespace _396_2Decks
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toDeck2Btn = new System.Windows.Forms.Button();
            this.toDeck1Btn = new System.Windows.Forms.Button();
            this.ResetBtn1 = new System.Windows.Forms.Button();
            this.ShuffleBtn1 = new System.Windows.Forms.Button();
            this.ResetBtn2 = new System.Windows.Forms.Button();
            this.ShuffleBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deck #1( Cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deck #2( Cards)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 340);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(205, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(142, 340);
            this.listBox2.TabIndex = 3;
            // 
            // toDeck2Btn
            // 
            this.toDeck2Btn.Location = new System.Drawing.Point(160, 145);
            this.toDeck2Btn.Name = "toDeck2Btn";
            this.toDeck2Btn.Size = new System.Drawing.Size(39, 23);
            this.toDeck2Btn.TabIndex = 4;
            this.toDeck2Btn.Text = ">>";
            this.toDeck2Btn.UseVisualStyleBackColor = true;
            this.toDeck2Btn.Click += new System.EventHandler(this.toDeck2Btn_Click);
            // 
            // toDeck1Btn
            // 
            this.toDeck1Btn.Location = new System.Drawing.Point(160, 174);
            this.toDeck1Btn.Name = "toDeck1Btn";
            this.toDeck1Btn.Size = new System.Drawing.Size(39, 23);
            this.toDeck1Btn.TabIndex = 5;
            this.toDeck1Btn.Text = "<<";
            this.toDeck1Btn.UseVisualStyleBackColor = true;
            this.toDeck1Btn.Click += new System.EventHandler(this.toDeck1Btn_Click);
            // 
            // ResetBtn1
            // 
            this.ResetBtn1.Location = new System.Drawing.Point(12, 370);
            this.ResetBtn1.Name = "ResetBtn1";
            this.ResetBtn1.Size = new System.Drawing.Size(142, 23);
            this.ResetBtn1.TabIndex = 6;
            this.ResetBtn1.Text = "Reset Deck #1";
            this.ResetBtn1.UseVisualStyleBackColor = true;
            this.ResetBtn1.Click += new System.EventHandler(this.ResetBtn1_Click);
            // 
            // ShuffleBtn1
            // 
            this.ShuffleBtn1.Location = new System.Drawing.Point(12, 399);
            this.ShuffleBtn1.Name = "ShuffleBtn1";
            this.ShuffleBtn1.Size = new System.Drawing.Size(142, 23);
            this.ShuffleBtn1.TabIndex = 7;
            this.ShuffleBtn1.Text = "Shuffle Deck #1";
            this.ShuffleBtn1.UseVisualStyleBackColor = true;
            this.ShuffleBtn1.Click += new System.EventHandler(this.ShuffleBtn1_Click);
            // 
            // ResetBtn2
            // 
            this.ResetBtn2.Location = new System.Drawing.Point(205, 370);
            this.ResetBtn2.Name = "ResetBtn2";
            this.ResetBtn2.Size = new System.Drawing.Size(142, 23);
            this.ResetBtn2.TabIndex = 8;
            this.ResetBtn2.Text = "Reset Deck #2";
            this.ResetBtn2.UseVisualStyleBackColor = true;
            this.ResetBtn2.Click += new System.EventHandler(this.ResetBtn2_Click);
            // 
            // ShuffleBtn2
            // 
            this.ShuffleBtn2.Location = new System.Drawing.Point(205, 399);
            this.ShuffleBtn2.Name = "ShuffleBtn2";
            this.ShuffleBtn2.Size = new System.Drawing.Size(142, 23);
            this.ShuffleBtn2.TabIndex = 9;
            this.ShuffleBtn2.Text = "Shuffle Deck #2";
            this.ShuffleBtn2.UseVisualStyleBackColor = true;
            this.ShuffleBtn2.Click += new System.EventHandler(this.ShuffleBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 456);
            this.Controls.Add(this.ShuffleBtn2);
            this.Controls.Add(this.ResetBtn2);
            this.Controls.Add(this.ShuffleBtn1);
            this.Controls.Add(this.ResetBtn1);
            this.Controls.Add(this.toDeck1Btn);
            this.Controls.Add(this.toDeck2Btn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button toDeck2Btn;
        private System.Windows.Forms.Button toDeck1Btn;
        private System.Windows.Forms.Button ResetBtn1;
        private System.Windows.Forms.Button ShuffleBtn1;
        private System.Windows.Forms.Button ResetBtn2;
        private System.Windows.Forms.Button ShuffleBtn2;
    }
}

