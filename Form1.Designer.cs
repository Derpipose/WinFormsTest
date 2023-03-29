namespace WinFormsTest {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ProgressBar1Label = new Label();
            ProgressBar2Label = new Label();
            ProgressBar3Label = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(185, 51);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(479, 29);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(185, 95);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(479, 29);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(185, 138);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(479, 29);
            progressBar3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 4;
            label1.Text = "Horse 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 95);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Horse 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 138);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Horse 3";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(376, 213);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Race!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProgressBar1Label
            // 
            ProgressBar1Label.AutoSize = true;
            ProgressBar1Label.Location = new Point(694, 51);
            ProgressBar1Label.Name = "ProgressBar1Label";
            ProgressBar1Label.Size = new Size(29, 20);
            ProgressBar1Label.TabIndex = 8;
            ProgressBar1Label.Text = "0%";
            // 
            // ProgressBar2Label
            // 
            ProgressBar2Label.AutoSize = true;
            ProgressBar2Label.Location = new Point(694, 95);
            ProgressBar2Label.Name = "ProgressBar2Label";
            ProgressBar2Label.Size = new Size(29, 20);
            ProgressBar2Label.TabIndex = 9;
            ProgressBar2Label.Text = "0%";
            // 
            // ProgressBar3Label
            // 
            ProgressBar3Label.AutoSize = true;
            ProgressBar3Label.Location = new Point(694, 138);
            ProgressBar3Label.Name = "ProgressBar3Label";
            ProgressBar3Label.Size = new Size(29, 20);
            ProgressBar3Label.TabIndex = 10;
            ProgressBar3Label.Text = "0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProgressBar3Label);
            Controls.Add(ProgressBar2Label);
            Controls.Add(ProgressBar1Label);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label ProgressBar1Label;
        private Label ProgressBar2Label;
        private Label ProgressBar3Label;
    }
}