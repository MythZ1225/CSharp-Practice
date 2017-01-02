namespace FarmerAndTheCow
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BagsOfFeedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.feedMutiplierTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuber of Cows";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(158, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bags Of Feed";
            // 
            // BagsOfFeedTextBox
            // 
            this.BagsOfFeedTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BagsOfFeedTextBox.Location = new System.Drawing.Point(12, 122);
            this.BagsOfFeedTextBox.Name = "BagsOfFeedTextBox";
            this.BagsOfFeedTextBox.Size = new System.Drawing.Size(158, 22);
            this.BagsOfFeedTextBox.TabIndex = 4;
            // 
            // feedMutiplierTextBox
            // 
            this.feedMutiplierTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.feedMutiplierTextBox.Location = new System.Drawing.Point(12, 82);
            this.feedMutiplierTextBox.Name = "feedMutiplierTextBox";
            this.feedMutiplierTextBox.Size = new System.Drawing.Size(158, 22);
            this.feedMutiplierTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "feed Mutiplier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 240);
            this.Controls.Add(this.feedMutiplierTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BagsOfFeedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox BagsOfFeedTextBox;
        private System.Windows.Forms.MaskedTextBox feedMutiplierTextBox;
        private System.Windows.Forms.Label label2;
    }
}

