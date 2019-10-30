namespace Bartenders
{
    partial class Stock
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
            this.incrementByTwentyfourButton = new System.Windows.Forms.Button();
            this.incrementByTwelveButton = new System.Windows.Forms.Button();
            this.incrementBySixButton = new System.Windows.Forms.Button();
            this.incrementByOneButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // incrementByTwentyfourButton
            // 
            this.incrementByTwentyfourButton.Location = new System.Drawing.Point(426, 112);
            this.incrementByTwentyfourButton.Name = "incrementByTwentyfourButton";
            this.incrementByTwentyfourButton.Size = new System.Drawing.Size(74, 67);
            this.incrementByTwentyfourButton.TabIndex = 18;
            this.incrementByTwentyfourButton.Text = "+24";
            this.incrementByTwentyfourButton.UseVisualStyleBackColor = true;
            this.incrementByTwentyfourButton.Click += new System.EventHandler(this.IncrementByTwentyfourButton_Click);
            // 
            // incrementByTwelveButton
            // 
            this.incrementByTwelveButton.Location = new System.Drawing.Point(314, 112);
            this.incrementByTwelveButton.Name = "incrementByTwelveButton";
            this.incrementByTwelveButton.Size = new System.Drawing.Size(74, 67);
            this.incrementByTwelveButton.TabIndex = 17;
            this.incrementByTwelveButton.Text = "+12";
            this.incrementByTwelveButton.UseVisualStyleBackColor = true;
            this.incrementByTwelveButton.Click += new System.EventHandler(this.IncrementByTwelveButton_Click);
            // 
            // incrementBySixButton
            // 
            this.incrementBySixButton.Location = new System.Drawing.Point(212, 112);
            this.incrementBySixButton.Name = "incrementBySixButton";
            this.incrementBySixButton.Size = new System.Drawing.Size(74, 67);
            this.incrementBySixButton.TabIndex = 16;
            this.incrementBySixButton.Text = "+6";
            this.incrementBySixButton.UseVisualStyleBackColor = true;
            this.incrementBySixButton.Click += new System.EventHandler(this.IncrementBySixButton_Click);
            // 
            // incrementByOneButton
            // 
            this.incrementByOneButton.Location = new System.Drawing.Point(101, 112);
            this.incrementByOneButton.Name = "incrementByOneButton";
            this.incrementByOneButton.Size = new System.Drawing.Size(74, 67);
            this.incrementByOneButton.TabIndex = 15;
            this.incrementByOneButton.Text = "+1";
            this.incrementByOneButton.UseVisualStyleBackColor = true;
            this.incrementByOneButton.Click += new System.EventHandler(this.IncrementByOneButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(245, 189);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(143, 30);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Keuze bevestigen";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Maak hier uw keuze. U kunt kiezen uit een aantal opties hieronder. \r\n\r\n";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(101, 194);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.amountNumericUpDown.TabIndex = 12;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.AmountNumericUpDown_ValueChanged);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incrementByTwentyfourButton);
            this.Controls.Add(this.incrementByTwelveButton);
            this.Controls.Add(this.incrementBySixButton);
            this.Controls.Add(this.incrementByOneButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountNumericUpDown);
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incrementByTwentyfourButton;
        private System.Windows.Forms.Button incrementByTwelveButton;
        private System.Windows.Forms.Button incrementBySixButton;
        private System.Windows.Forms.Button incrementByOneButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}