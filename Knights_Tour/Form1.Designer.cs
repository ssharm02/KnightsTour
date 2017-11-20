using System.ComponentModel;
using System.Windows.Forms;

namespace Knights_Tour
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.rbMethodDumb = new System.Windows.Forms.RadioButton();
            this.rbMethodSmart = new System.Windows.Forms.RadioButton();
            this.lbMethod = new System.Windows.Forms.Label();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.lbAverage = new System.Windows.Forms.Label();
            this.nuAttempts = new System.Windows.Forms.NumericUpDown();
            this.lbStdDev = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbStdDev = new System.Windows.Forms.TextBox();
            this.btRunTour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuAttempts)).BeginInit();
            this.SuspendLayout();
            // 
            // rtOutput
            // 
            this.rtOutput.Font = new System.Drawing.Font("Courier New", 12.5F, System.Drawing.FontStyle.Bold);
            this.rtOutput.Location = new System.Drawing.Point(12, 12);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.ReadOnly = true;
            this.rtOutput.Size = new System.Drawing.Size(425, 350);
            this.rtOutput.TabIndex = 0;
            this.rtOutput.TabStop = false;
            this.rtOutput.Text = "";
            // 
            // rbMethodDumb
            // 
            this.rbMethodDumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMethodDumb.AutoSize = true;
            this.rbMethodDumb.Location = new System.Drawing.Point(467, 80);
            this.rbMethodDumb.Name = "rbMethodDumb";
            this.rbMethodDumb.Size = new System.Drawing.Size(93, 17);
            this.rbMethodDumb.TabIndex = 1;
            this.rbMethodDumb.TabStop = true;
            this.rbMethodDumb.Text = "Non-Intelligent";
            this.rbMethodDumb.UseVisualStyleBackColor = true;
            // 
            // rbMethodSmart
            // 
            this.rbMethodSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMethodSmart.AutoSize = true;
            this.rbMethodSmart.Location = new System.Drawing.Point(467, 103);
            this.rbMethodSmart.Name = "rbMethodSmart";
            this.rbMethodSmart.Size = new System.Drawing.Size(70, 17);
            this.rbMethodSmart.TabIndex = 2;
            this.rbMethodSmart.TabStop = true;
            this.rbMethodSmart.Text = "Intelligent";
            this.rbMethodSmart.UseVisualStyleBackColor = true;
            // 
            // lbMethod
            // 
            this.lbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(467, 60);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(43, 13);
            this.lbMethod.TabIndex = 3;
            this.lbMethod.Text = "Method";
            // 
            // lbAttempts
            // 
            this.lbAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAttempts.AutoSize = true;
            this.lbAttempts.Location = new System.Drawing.Point(467, 150);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(48, 13);
            this.lbAttempts.TabIndex = 4;
            this.lbAttempts.Text = "Attempts";
            // 
            // lbAverage
            // 
            this.lbAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(467, 210);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(92, 13);
            this.lbAverage.TabIndex = 5;
            this.lbAverage.Text = "Average # Moves";
            // 
            // nuAttempts
            // 
            this.nuAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuAttempts.Location = new System.Drawing.Point(467, 166);
            this.nuAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAttempts.Name = "nuAttempts";
            this.nuAttempts.Size = new System.Drawing.Size(56, 20);
            this.nuAttempts.TabIndex = 3;
            this.nuAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbStdDev
            // 
            this.lbStdDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStdDev.AutoSize = true;
            this.lbStdDev.Location = new System.Drawing.Point(467, 260);
            this.lbStdDev.Name = "lbStdDev";
            this.lbStdDev.Size = new System.Drawing.Size(98, 13);
            this.lbStdDev.TabIndex = 7;
            this.lbStdDev.Text = "Standard Deviation";
            // 
            // tbAverage
            // 
            this.tbAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAverage.Location = new System.Drawing.Point(467, 226);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(40, 20);
            this.tbAverage.TabIndex = 4;
            // 
            // tbStdDev
            // 
            this.tbStdDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStdDev.Location = new System.Drawing.Point(467, 276);
            this.tbStdDev.Name = "tbStdDev";
            this.tbStdDev.ReadOnly = true;
            this.tbStdDev.Size = new System.Drawing.Size(56, 20);
            this.tbStdDev.TabIndex = 5;
            // 
            // btRunTour
            // 
            this.btRunTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRunTour.Location = new System.Drawing.Point(470, 320);
            this.btRunTour.Name = "btRunTour";
            this.btRunTour.Size = new System.Drawing.Size(75, 25);
            this.btRunTour.TabIndex = 6;
            this.btRunTour.Text = "Run";
            this.btRunTour.UseVisualStyleBackColor = true;
            this.btRunTour.Click += new System.EventHandler(this.btRunTour_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(463, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Knight\'s Tour\r\nProgram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRunTour);
            this.Controls.Add(this.tbStdDev);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.lbStdDev);
            this.Controls.Add(this.nuAttempts);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.lbMethod);
            this.Controls.Add(this.rbMethodSmart);
            this.Controls.Add(this.rbMethodDumb);
            this.Controls.Add(this.rtOutput);
            this.Name = "Form1";
            this.Text = "Knight\'s Tour";
            ((System.ComponentModel.ISupportInitialize)(this.nuAttempts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtOutput;
        private RadioButton rbMethodDumb;
        private RadioButton rbMethodSmart;
        private Label lbMethod;
        private Label lbAttempts;
        private Label lbAverage;
        private NumericUpDown nuAttempts;
        private Label lbStdDev;
        private TextBox tbAverage;
        private TextBox tbStdDev;
        private Button btRunTour;
        private Label label1;
    }
}

