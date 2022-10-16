namespace ping_pong
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
            this.components = new System.ComponentModel.Container();
            this.playGround = new System.Windows.Forms.Panel();
            this.lblLoss = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playGround.Controls.Add(this.lblLoss);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.lblScore);
            this.playGround.Controls.Add(this.player);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(724, 591);
            this.playGround.TabIndex = 0;
            // 
            // lblLoss
            // 
            this.lblLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoss.Location = new System.Drawing.Point(168, 88);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(380, 344);
            this.lblLoss.TabIndex = 3;
            this.lblLoss.Text = "GameOver\r\n\r\nR - Restart\r\nEsc - Exit\r\n";
            this.lblLoss.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(272, 201);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Sitka Text", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(191, 62);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.IndianRed;
            this.player.Location = new System.Drawing.Point(243, 541);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 20);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 591);
            this.Controls.Add(this.playGround);
            this.Name = "Form1";
            this.Text = "Ping pong!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel playGround;
        private PictureBox ball;
        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private Label lblScore;
        private Label lblLoss;
    }
}