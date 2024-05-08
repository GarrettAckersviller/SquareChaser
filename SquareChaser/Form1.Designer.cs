namespace SquareChaser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.p2ScoreLable = new System.Windows.Forms.Label();
            this.p1ScoreLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Location = new System.Drawing.Point(254, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(179, 23);
            this.winLabel.TabIndex = 0;
            // 
            // p2ScoreLable
            // 
            this.p2ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2ScoreLable.Location = new System.Drawing.Point(581, 388);
            this.p2ScoreLable.Name = "p2ScoreLable";
            this.p2ScoreLable.Size = new System.Drawing.Size(179, 23);
            this.p2ScoreLable.TabIndex = 1;
            // 
            // p1ScoreLable
            // 
            this.p1ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLable.ForeColor = System.Drawing.Color.Black;
            this.p1ScoreLable.Location = new System.Drawing.Point(30, 388);
            this.p1ScoreLable.Name = "p1ScoreLable";
            this.p1ScoreLable.Size = new System.Drawing.Size(179, 23);
            this.p1ScoreLable.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(813, 419);
            this.Controls.Add(this.p1ScoreLable);
            this.Controls.Add(this.p2ScoreLable);
            this.Controls.Add(this.winLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label p2ScoreLable;
        private System.Windows.Forms.Label p1ScoreLable;
    }
}

