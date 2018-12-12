namespace DartGame
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
            this.playerName_tb = new System.Windows.Forms.TextBox();
            this.playerAdd_btn = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.main_label = new System.Windows.Forms.Label();
            this.start_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerName_tb
            // 
            this.playerName_tb.Location = new System.Drawing.Point(17, 92);
            this.playerName_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerName_tb.Name = "playerName_tb";
            this.playerName_tb.Size = new System.Drawing.Size(235, 22);
            this.playerName_tb.TabIndex = 0;
            // 
            // playerAdd_btn
            // 
            this.playerAdd_btn.Location = new System.Drawing.Point(261, 92);
            this.playerAdd_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerAdd_btn.Name = "playerAdd_btn";
            this.playerAdd_btn.Size = new System.Drawing.Size(100, 28);
            this.playerAdd_btn.TabIndex = 1;
            this.playerAdd_btn.Text = "Add Player";
            this.playerAdd_btn.UseVisualStyleBackColor = true;
            this.playerAdd_btn.Click += new System.EventHandler(this.AddPlayer_ButtonClick);
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 16;
            this.playerListBox.Location = new System.Drawing.Point(17, 126);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(235, 116);
            this.playerListBox.TabIndex = 2;
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(263, 16);
            this.main_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(502, 42);
            this.main_label.TabIndex = 3;
            this.main_label.Text = "Welcome to the Dart Game!";
            // 
            // start_Btn
            // 
            this.start_Btn.Location = new System.Drawing.Point(17, 251);
            this.start_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_Btn.Name = "start_Btn";
            this.start_Btn.Size = new System.Drawing.Size(100, 28);
            this.start_Btn.TabIndex = 4;
            this.start_Btn.Text = "Start Game!";
            this.start_Btn.UseVisualStyleBackColor = true;
            this.start_Btn.Click += new System.EventHandler(this.StartGame_ButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(571, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 561);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_Paint);
            // 
            // scoreboard
            // 
            this.scoreboard.FormattingEnabled = true;
            this.scoreboard.ItemHeight = 16;
            this.scoreboard.Location = new System.Drawing.Point(425, 94);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(139, 164);
            this.scoreboard.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 668);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_Btn);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerAdd_btn);
            this.Controls.Add(this.playerName_tb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerName_tb;
        private System.Windows.Forms.Button playerAdd_btn;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Button start_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox scoreboard;
    }
}

