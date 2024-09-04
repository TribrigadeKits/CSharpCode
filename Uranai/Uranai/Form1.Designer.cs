namespace Uranai
{
    partial class FormUranai
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
            label1 = new Label();
            dateTimeUranai = new DateTimePicker();
            btnUranaiStart = new Button();
            ptbResult = new PictureBox();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "今日の日付";
            // 
            // dateTimeUranai
            // 
            dateTimeUranai.Location = new Point(111, 9);
            dateTimeUranai.Name = "dateTimeUranai";
            dateTimeUranai.Size = new Size(159, 27);
            dateTimeUranai.TabIndex = 1;
            // 
            // btnUranaiStart
            // 
            btnUranaiStart.Location = new Point(14, 42);
            btnUranaiStart.Name = "btnUranaiStart";
            btnUranaiStart.Size = new Size(256, 30);
            btnUranaiStart.TabIndex = 2;
            btnUranaiStart.Text = "占う";
            btnUranaiStart.UseVisualStyleBackColor = true;
            btnUranaiStart.Click += btnUranaiStart_Click;
            // 
            // ptbResult
            // 
            ptbResult.Location = new Point(14, 87);
            ptbResult.Name = "ptbResult";
            ptbResult.Size = new Size(256, 100);
            ptbResult.TabIndex = 3;
            ptbResult.TabStop = false;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(14, 201);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(256, 70);
            txtResult.TabIndex = 4;
            // 
            // FormUranai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 283);
            Controls.Add(txtResult);
            Controls.Add(ptbResult);
            Controls.Add(btnUranaiStart);
            Controls.Add(dateTimeUranai);
            Controls.Add(label1);
            Name = "FormUranai";
            Text = "占い";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)ptbResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimeUranai;
        private Button btnUranaiStart;
        private PictureBox ptbResult;
        private TextBox txtResult;
    }
}
