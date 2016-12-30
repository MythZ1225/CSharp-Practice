namespace DinnerParty
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DrinkTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FoodTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DecoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DecoExTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DisCounTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown1.Location = new System.Drawing.Point(15, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Fancy Decorations";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Healthy Option";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CostTextBox.Location = new System.Drawing.Point(61, 311);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(74, 22);
            this.CostTextBox.TabIndex = 10;
            // 
            // DrinkTextBox
            // 
            this.DrinkTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DrinkTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DrinkTextBox.Location = new System.Drawing.Point(61, 143);
            this.DrinkTextBox.Name = "DrinkTextBox";
            this.DrinkTextBox.Size = new System.Drawing.Size(74, 22);
            this.DrinkTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Drinks";
            // 
            // FoodTextBox
            // 
            this.FoodTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FoodTextBox.Location = new System.Drawing.Point(61, 171);
            this.FoodTextBox.Name = "FoodTextBox";
            this.FoodTextBox.Size = new System.Drawing.Size(74, 22);
            this.FoodTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Food";
            // 
            // DecoTextBox
            // 
            this.DecoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DecoTextBox.Location = new System.Drawing.Point(61, 199);
            this.DecoTextBox.Name = "DecoTextBox";
            this.DecoTextBox.Size = new System.Drawing.Size(74, 22);
            this.DecoTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Deco";
            // 
            // DecoExTextBox
            // 
            this.DecoExTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DecoExTextBox.Location = new System.Drawing.Point(61, 227);
            this.DecoExTextBox.Name = "DecoExTextBox";
            this.DecoExTextBox.Size = new System.Drawing.Size(74, 22);
            this.DecoExTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 230);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "DecoEx";
            // 
            // DisCounTextBox
            // 
            this.DisCounTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DisCounTextBox.Location = new System.Drawing.Point(61, 283);
            this.DisCounTextBox.Name = "DisCounTextBox";
            this.DisCounTextBox.Size = new System.Drawing.Size(74, 22);
            this.DisCounTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "DisCount";
            // 
            // TotalTextBox1
            // 
            this.TotalTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalTextBox1.Location = new System.Drawing.Point(61, 255);
            this.TotalTextBox1.Name = "TotalTextBox1";
            this.TotalTextBox1.Size = new System.Drawing.Size(74, 22);
            this.TotalTextBox1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 364);
            this.Controls.Add(this.TotalTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DisCounTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DecoExTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FoodTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DrinkTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CostTextBox;
        private System.Windows.Forms.MaskedTextBox DrinkTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox FoodTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox DecoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DecoExTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox DisCounTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TotalTextBox1;
        private System.Windows.Forms.Label label8;
    }
}

