namespace MathQuiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();

            // timeLabel
            this.timeLabel.Location = new System.Drawing.Point(300, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time Left";

            // plusLeftLabel
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 60);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(50, 23);
            this.plusLeftLabel.TabIndex = 1;
            this.plusLeftLabel.Text = "?";

            // plusRightLabel
            this.plusRightLabel.Location = new System.Drawing.Point(150, 60);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(50, 23);
            this.plusRightLabel.TabIndex = 2;
            this.plusRightLabel.Text = "?";

            // label4 (for addition sign)
            this.label4.Location = new System.Drawing.Point(100, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "+";

            // label5 (for equal sign)
            this.label5.Location = new System.Drawing.Point(200, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";

            // sum
            this.sum.Location = new System.Drawing.Point(250, 60);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 22);
            this.sum.TabIndex = 5;

            // minusLeftLabel
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 100);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(50, 23);
            this.minusLeftLabel.TabIndex = 6;
            this.minusLeftLabel.Text = "?";

            // minusRightLabel
            this.minusRightLabel.Location = new System.Drawing.Point(150, 100);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(50, 23);
            this.minusRightLabel.TabIndex = 7;
            this.minusRightLabel.Text = "?";

            // difference
            this.difference.Location = new System.Drawing.Point(250, 100);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 22);
            this.difference.TabIndex = 8;

            // timesLeftLabel
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 140);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(50, 23);
            this.timesLeftLabel.TabIndex = 9;
            this.timesLeftLabel.Text = "?";

            // timesRightLabel
            this.timesRightLabel.Location = new System.Drawing.Point(150, 140);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(50, 23);
            this.timesRightLabel.TabIndex = 10;
            this.timesRightLabel.Text = "?";

            // product
            this.product.Location = new System.Drawing.Point(250, 140);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 22);
            this.product.TabIndex = 11;

            // dividedLeftLabel
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 180);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(50, 23);
            this.dividedLeftLabel.TabIndex = 12;
            this.dividedLeftLabel.Text = "?";

            // dividedRightLabel
            this.dividedRightLabel.Location = new System.Drawing.Point(150, 180);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(50, 23);
            this.dividedRightLabel.TabIndex = 13;
            this.dividedRightLabel.Text = "?";

            // quotient
            this.quotient.Location = new System.Drawing.Point(250, 180);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 22);
            this.quotient.TabIndex = 14;

            // startButton
            this.startButton.Location = new System.Drawing.Point(300, 300);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start the quiz";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Math Quiz";

            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
