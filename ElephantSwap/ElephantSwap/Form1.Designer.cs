namespace ElephantSwap
{
    partial class Swap
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
            this.LloydBtn = new System.Windows.Forms.Button();
            this.LucindaBtn = new System.Windows.Forms.Button();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LloydBtn
            // 
            this.LloydBtn.Location = new System.Drawing.Point(13, 13);
            this.LloydBtn.Name = "LloydBtn";
            this.LloydBtn.Size = new System.Drawing.Size(91, 23);
            this.LloydBtn.TabIndex = 0;
            this.LloydBtn.Text = "Lloyd";
            this.LloydBtn.UseVisualStyleBackColor = true;
            this.LloydBtn.Click += new System.EventHandler(this.LloydBtn_Click);
            // 
            // LucindaBtn
            // 
            this.LucindaBtn.Location = new System.Drawing.Point(13, 42);
            this.LucindaBtn.Name = "LucindaBtn";
            this.LucindaBtn.Size = new System.Drawing.Size(91, 23);
            this.LucindaBtn.TabIndex = 1;
            this.LucindaBtn.Text = "Lucinda";
            this.LucindaBtn.UseVisualStyleBackColor = true;
            this.LucindaBtn.Click += new System.EventHandler(this.LucindaBtn_Click);
            // 
            // SwapBtn
            // 
            this.SwapBtn.Location = new System.Drawing.Point(13, 71);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(91, 23);
            this.SwapBtn.TabIndex = 2;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "If No Temp...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Swap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SwapBtn);
            this.Controls.Add(this.LucindaBtn);
            this.Controls.Add(this.LloydBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Swap";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LloydBtn;
        private System.Windows.Forms.Button LucindaBtn;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Button button1;
    }
}

