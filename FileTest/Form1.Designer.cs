namespace FileTest
{
    partial class Form1
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.quantityUpDownLabel = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(197, 18);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save To File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantityUpDownLabel
            // 
            this.quantityUpDownLabel.AutoSize = true;
            this.quantityUpDownLabel.Location = new System.Drawing.Point(12, 20);
            this.quantityUpDownLabel.Name = "quantityUpDownLabel";
            this.quantityUpDownLabel.Size = new System.Drawing.Size(53, 15);
            this.quantityUpDownLabel.TabIndex = 2;
            this.quantityUpDownLabel.Text = "Quantity";
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantityUpDown.Location = new System.Drawing.Point(71, 18);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(120, 23);
            this.quantityUpDown.TabIndex = 3;
            this.quantityUpDown.ThousandsSeparator = true;
            this.quantityUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 86);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.quantityUpDownLabel);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Address Mega Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveBtn;
        private Label quantityUpDownLabel;
        private ProgressBar progressBar1;
        protected NumericUpDown quantityUpDown;
    }
}