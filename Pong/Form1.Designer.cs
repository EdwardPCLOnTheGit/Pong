namespace Pong
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
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            computer = new PictureBox();
            ball = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackgroundImageLayout = ImageLayout.None;
            player.Image = Properties.Resources.player;
            player.Location = new Point(2, 152);
            player.Name = "player";
            player.Size = new Size(40, 145);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // computer
            // 
            computer.BackgroundImageLayout = ImageLayout.None;
            computer.Image = Properties.Resources.computer;
            computer.Location = new Point(770, 165);
            computer.Name = "computer";
            computer.Size = new Size(40, 145);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 1;
            computer.TabStop = false;
            // 
            // ball
            // 
            ball.BackgroundImageLayout = ImageLayout.None;
            ball.Image = Properties.Resources.ball;
            ball.Location = new Point(385, 165);
            ball.Name = "ball";
            ball.Size = new Size(40, 145);
            ball.SizeMode = PictureBoxSizeMode.CenterImage;
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(810, 475);
            Controls.Add(ball);
            Controls.Add(computer);
            Controls.Add(player);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Player: 0 --- Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}
