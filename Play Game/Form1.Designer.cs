namespace Play_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.countdownText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.startText = new System.Windows.Forms.Label();
            this.pressStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countdownText
            // 
            this.countdownText.BackColor = System.Drawing.Color.Transparent;
            this.countdownText.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownText.ForeColor = System.Drawing.Color.White;
            this.countdownText.Location = new System.Drawing.Point(266, 273);
            this.countdownText.Name = "countdownText";
            this.countdownText.Size = new System.Drawing.Size(259, 36);
            this.countdownText.TabIndex = 0;
            this.countdownText.Text = "The Game Will Start in: 3";
            this.countdownText.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Yellow;
            this.startButton.Location = new System.Drawing.Point(309, 172);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 94);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Play Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            this.startButton.MouseHover += new System.EventHandler(this.startButton_MouseHover);
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.Color.Transparent;
            this.startText.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.ForeColor = System.Drawing.Color.White;
            this.startText.Location = new System.Drawing.Point(350, 269);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(100, 40);
            this.startText.TabIndex = 2;
            this.startText.Text = "Begin!";
            this.startText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startText.Visible = false;
            // 
            // pressStart
            // 
            this.pressStart.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressStart.ForeColor = System.Drawing.Color.White;
            this.pressStart.Location = new System.Drawing.Point(241, 112);
            this.pressStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pressStart.Name = "pressStart";
            this.pressStart.Size = new System.Drawing.Size(322, 32);
            this.pressStart.TabIndex = 3;
            this.pressStart.Text = "Press the Play Button to Begin!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pressStart);
            this.Controls.Add(this.countdownText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.startButton);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Play Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label countdownText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label pressStart;
    }
}

