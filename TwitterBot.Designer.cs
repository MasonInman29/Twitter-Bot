namespace TwitterBotForm
{
    partial class TwitterBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterBot));
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SendTweetBTN = new System.Windows.Forms.Button();
            this.RandomQuoteBTN = new System.Windows.Forms.Button();
            this.TweetTB = new System.Windows.Forms.TextBox();
            this.emptyTweetPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SelectQuoteBTN = new System.Windows.Forms.Button();
            this.WBBTwitterLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emptyTweetPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBTN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(369, 283);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(88, 56);
            this.ExitBTN.TabIndex = 4;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // SendTweetBTN
            // 
            this.SendTweetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendTweetBTN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTweetBTN.Image = ((System.Drawing.Image)(resources.GetObject("SendTweetBTN.Image")));
            this.SendTweetBTN.Location = new System.Drawing.Point(106, 283);
            this.SendTweetBTN.Name = "SendTweetBTN";
            this.SendTweetBTN.Size = new System.Drawing.Size(163, 56);
            this.SendTweetBTN.TabIndex = 3;
            this.SendTweetBTN.Text = "Send Tweet!";
            this.SendTweetBTN.UseVisualStyleBackColor = true;
            this.SendTweetBTN.Click += new System.EventHandler(this.SendTweetBTN_Click);
            // 
            // RandomQuoteBTN
            // 
            this.RandomQuoteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.RandomQuoteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomQuoteBTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.RandomQuoteBTN.FlatAppearance.BorderSize = 0;
            this.RandomQuoteBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RandomQuoteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RandomQuoteBTN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomQuoteBTN.Location = new System.Drawing.Point(12, 283);
            this.RandomQuoteBTN.Name = "RandomQuoteBTN";
            this.RandomQuoteBTN.Size = new System.Drawing.Size(88, 56);
            this.RandomQuoteBTN.TabIndex = 2;
            this.RandomQuoteBTN.Text = "Random Quote";
            this.RandomQuoteBTN.UseVisualStyleBackColor = false;
            this.RandomQuoteBTN.Click += new System.EventHandler(this.RandomQuoteBTN_Click);
            // 
            // TweetTB
            // 
            this.TweetTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TweetTB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TweetTB.Location = new System.Drawing.Point(75, 101);
            this.TweetTB.Multiline = true;
            this.TweetTB.Name = "TweetTB";
            this.TweetTB.Size = new System.Drawing.Size(256, 141);
            this.TweetTB.TabIndex = 1;
            this.TweetTB.Text = "Input tweet here\r\n\r\nor\r\n\r\nClick \'Random Quote\' to get some inspiration";
            this.TweetTB.TextChanged += new System.EventHandler(this.TweetTB_TextChanged);
            // 
            // emptyTweetPB
            // 
            this.emptyTweetPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emptyTweetPB.Image = ((System.Drawing.Image)(resources.GetObject("emptyTweetPB.Image")));
            this.emptyTweetPB.Location = new System.Drawing.Point(12, 34);
            this.emptyTweetPB.Name = "emptyTweetPB";
            this.emptyTweetPB.Size = new System.Drawing.Size(351, 243);
            this.emptyTweetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyTweetPB.TabIndex = 6;
            this.emptyTweetPB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // SelectQuoteBTN
            // 
            this.SelectQuoteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.SelectQuoteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectQuoteBTN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectQuoteBTN.Location = new System.Drawing.Point(275, 282);
            this.SelectQuoteBTN.Name = "SelectQuoteBTN";
            this.SelectQuoteBTN.Size = new System.Drawing.Size(88, 56);
            this.SelectQuoteBTN.TabIndex = 9;
            this.SelectQuoteBTN.Text = "Select Quote";
            this.SelectQuoteBTN.UseVisualStyleBackColor = false;
            this.SelectQuoteBTN.Click += new System.EventHandler(this.SelectQuoteBTN_Click);
            // 
            // WBBTwitterLink
            // 
            this.WBBTwitterLink.AutoSize = true;
            this.WBBTwitterLink.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WBBTwitterLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.WBBTwitterLink.Location = new System.Drawing.Point(467, 306);
            this.WBBTwitterLink.Name = "WBBTwitterLink";
            this.WBBTwitterLink.Size = new System.Drawing.Size(180, 15);
            this.WBBTwitterLink.TabIndex = 10;
            this.WBBTwitterLink.TabStop = true;
            this.WBBTwitterLink.Text = "https://twitter.com/WordsByBots";
            this.WBBTwitterLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.WBBTwitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WBBTwitterLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Click link to check your tweet!";
            // 
            // TwitterBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(649, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WBBTwitterLink);
            this.Controls.Add(this.SelectQuoteBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TweetTB);
            this.Controls.Add(this.RandomQuoteBTN);
            this.Controls.Add(this.SendTweetBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.emptyTweetPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitterBot";
            this.Text = "Words By Bots";
            ((System.ComponentModel.ISupportInitialize)(this.emptyTweetPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button SendTweetBTN;
        private System.Windows.Forms.Button RandomQuoteBTN;
        private System.Windows.Forms.TextBox TweetTB;
        private System.Windows.Forms.PictureBox emptyTweetPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SelectQuoteBTN;
        private System.Windows.Forms.LinkLabel WBBTwitterLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

