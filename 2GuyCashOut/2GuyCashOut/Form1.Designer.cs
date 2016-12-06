namespace _2GuyCashOut
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
            this.JoeCash = new System.Windows.Forms.Label();
            this.BobCash = new System.Windows.Forms.Label();
            this.BankCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bobGiveToJoeBtn = new System.Windows.Forms.Button();
            this.joeGiveToBobBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoeCash
            // 
            this.JoeCash.AutoSize = true;
            this.JoeCash.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JoeCash.Location = new System.Drawing.Point(28, 9);
            this.JoeCash.Name = "JoeCash";
            this.JoeCash.Size = new System.Drawing.Size(88, 19);
            this.JoeCash.TabIndex = 0;
            this.JoeCash.Text = "Joe Has $?";
            // 
            // BobCash
            // 
            this.BobCash.AutoSize = true;
            this.BobCash.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BobCash.Location = new System.Drawing.Point(28, 47);
            this.BobCash.Name = "BobCash";
            this.BobCash.Size = new System.Drawing.Size(109, 19);
            this.BobCash.TabIndex = 1;
            this.BobCash.Text = "Bob has $100";
            // 
            // BankCash
            // 
            this.BankCash.AutoSize = true;
            this.BankCash.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BankCash.Location = new System.Drawing.Point(28, 85);
            this.BankCash.Name = "BankCash";
            this.BankCash.Size = new System.Drawing.Size(117, 19);
            this.BankCash.TabIndex = 2;
            this.BankCash.Text = "Bank has $100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bobGiveToJoeBtn
            // 
            this.bobGiveToJoeBtn.Location = new System.Drawing.Point(93, 164);
            this.bobGiveToJoeBtn.Name = "bobGiveToJoeBtn";
            this.bobGiveToJoeBtn.Size = new System.Drawing.Size(75, 46);
            this.bobGiveToJoeBtn.TabIndex = 6;
            this.bobGiveToJoeBtn.Text = "Bob Give $5 To Joe";
            this.bobGiveToJoeBtn.UseVisualStyleBackColor = true;
            this.bobGiveToJoeBtn.Click += new System.EventHandler(this.bobGiveToJoeBtn_Click);
            // 
            // joeGiveToBobBtn
            // 
            this.joeGiveToBobBtn.Location = new System.Drawing.Point(12, 164);
            this.joeGiveToBobBtn.Name = "joeGiveToBobBtn";
            this.joeGiveToBobBtn.Size = new System.Drawing.Size(75, 46);
            this.joeGiveToBobBtn.TabIndex = 5;
            this.joeGiveToBobBtn.Text = "Joe Give $10 To Bob";
            this.joeGiveToBobBtn.UseVisualStyleBackColor = true;
            this.joeGiveToBobBtn.Click += new System.EventHandler(this.joeGiveToBobBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 249);
            this.Controls.Add(this.bobGiveToJoeBtn);
            this.Controls.Add(this.joeGiveToBobBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BankCash);
            this.Controls.Add(this.BobCash);
            this.Controls.Add(this.JoeCash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoeCash;
        private System.Windows.Forms.Label BobCash;
        private System.Windows.Forms.Label BankCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bobGiveToJoeBtn;
        private System.Windows.Forms.Button joeGiveToBobBtn;
    }
}

