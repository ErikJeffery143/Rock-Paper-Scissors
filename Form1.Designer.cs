namespace Rock__Paper__Scissors
{
    partial class formRPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRPS));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            this.lblCPUPlay = new System.Windows.Forms.Label();
            this.picRockCPU = new System.Windows.Forms.PictureBox();
            this.picPaperCPU = new System.Windows.Forms.PictureBox();
            this.picScissorsCPU = new System.Windows.Forms.PictureBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRockCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissorsCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(54, 84);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Play : Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(205, 84);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Play : Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(364, 85);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(86, 23);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Text = "Play : Scissors";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // picPaper
            // 
            this.picPaper.BackColor = System.Drawing.Color.Transparent;
            this.picPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaper.BackgroundImage")));
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(189, 113);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(106, 126);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 3;
            this.picPaper.TabStop = false;
            // 
            // picRock
            // 
            this.picRock.BackColor = System.Drawing.Color.Transparent;
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(31, 113);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(119, 126);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 4;
            this.picRock.TabStop = false;
            // 
            // picScissor
            // 
            this.picScissor.BackColor = System.Drawing.Color.Transparent;
            this.picScissor.Image = ((System.Drawing.Image)(resources.GetObject("picScissor.Image")));
            this.picScissor.Location = new System.Drawing.Point(348, 114);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(102, 125);
            this.picScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissor.TabIndex = 5;
            this.picScissor.TabStop = false;
            // 
            // lblCPUPlay
            // 
            this.lblCPUPlay.AutoSize = true;
            this.lblCPUPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUPlay.Location = new System.Drawing.Point(163, 416);
            this.lblCPUPlay.Name = "lblCPUPlay";
            this.lblCPUPlay.Size = new System.Drawing.Size(158, 31);
            this.lblCPUPlay.TabIndex = 6;
            this.lblCPUPlay.Text = "Enemy Play";
            // 
            // picRockCPU
            // 
            this.picRockCPU.BackColor = System.Drawing.Color.Transparent;
            this.picRockCPU.Image = ((System.Drawing.Image)(resources.GetObject("picRockCPU.Image")));
            this.picRockCPU.Location = new System.Drawing.Point(31, 278);
            this.picRockCPU.Name = "picRockCPU";
            this.picRockCPU.Size = new System.Drawing.Size(119, 126);
            this.picRockCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRockCPU.TabIndex = 7;
            this.picRockCPU.TabStop = false;
            // 
            // picPaperCPU
            // 
            this.picPaperCPU.BackColor = System.Drawing.Color.Transparent;
            this.picPaperCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaperCPU.BackgroundImage")));
            this.picPaperCPU.Image = ((System.Drawing.Image)(resources.GetObject("picPaperCPU.Image")));
            this.picPaperCPU.Location = new System.Drawing.Point(189, 278);
            this.picPaperCPU.Name = "picPaperCPU";
            this.picPaperCPU.Size = new System.Drawing.Size(106, 126);
            this.picPaperCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaperCPU.TabIndex = 8;
            this.picPaperCPU.TabStop = false;
            // 
            // picScissorsCPU
            // 
            this.picScissorsCPU.BackColor = System.Drawing.Color.Transparent;
            this.picScissorsCPU.Image = ((System.Drawing.Image)(resources.GetObject("picScissorsCPU.Image")));
            this.picScissorsCPU.Location = new System.Drawing.Point(348, 278);
            this.picScissorsCPU.Name = "picScissorsCPU";
            this.picScissorsCPU.Size = new System.Drawing.Size(102, 125);
            this.picScissorsCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissorsCPU.TabIndex = 9;
            this.picScissorsCPU.TabStop = false;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.BackColor = System.Drawing.Color.Transparent;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(205, 9);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(63, 55);
            this.lblOutcome.TabIndex = 13;
            this.lblOutcome.Text = "...";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 77);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Would you like to leave?";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(31, 505);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(90, 25);
            this.lblWin.TabIndex = 15;
            this.lblWin.Text = "Wins: ";
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(31, 539);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(77, 25);
            this.lblTie.TabIndex = 16;
            this.lblTie.Text = "Ties:";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.Location = new System.Drawing.Point(31, 575);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(103, 25);
            this.lblLoss.TabIndex = 17;
            this.lblLoss.Text = "Losses:";
            // 
            // formRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 641);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.picScissorsCPU);
            this.Controls.Add(this.picPaperCPU);
            this.Controls.Add(this.picRockCPU);
            this.Controls.Add(this.lblCPUPlay);
            this.Controls.Add(this.picScissor);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "formRPS";
            this.Text = "Rock,Paper,Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRockCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissorsCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissor;
        private System.Windows.Forms.Label lblCPUPlay;
        private System.Windows.Forms.PictureBox picRockCPU;
        private System.Windows.Forms.PictureBox picPaperCPU;
        private System.Windows.Forms.PictureBox picScissorsCPU;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.Label lblLoss;
    }
}

