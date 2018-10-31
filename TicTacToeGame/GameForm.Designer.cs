namespace TicTacToeGame
{
    partial class GameMainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.picBx8 = new System.Windows.Forms.PictureBox();
            this.picBx7 = new System.Windows.Forms.PictureBox();
            this.picBx6 = new System.Windows.Forms.PictureBox();
            this.picBx5 = new System.Windows.Forms.PictureBox();
            this.picBx4 = new System.Windows.Forms.PictureBox();
            this.picBx3 = new System.Windows.Forms.PictureBox();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.picBx0 = new System.Windows.Forms.PictureBox();
            this.rdBtnAgainstPC = new System.Windows.Forms.RadioButton();
            this.rdBtnAgainstFriend = new System.Windows.Forms.RadioButton();
            this.rdBtnNetwork = new System.Windows.Forms.RadioButton();
            this.pnlGameOptions = new System.Windows.Forms.Panel();
            this.pnlNetWorkSettings = new System.Windows.Forms.Panel();
            this.btnInvite = new System.Windows.Forms.Button();
            this.txBxVistorIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lnkLblInvitation = new System.Windows.Forms.LinkLabel();
            this.lblSocketStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerRemainingTime = new System.Windows.Forms.Timer(this.components);
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblVisitorName = new System.Windows.Forms.Label();
            this.pnlScoreBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlVisitorRemainingTime = new System.Windows.Forms.Panel();
            this.pnlHostRemainingTime = new System.Windows.Forms.Panel();
            this.lblVisitorScore = new System.Windows.Forms.Label();
            this.lblHostScore = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.timerHighLight = new System.Windows.Forms.Timer(this.components);
            this.pnlGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx0)).BeginInit();
            this.pnlGameOptions.SuspendLayout();
            this.pnlNetWorkSettings.SuspendLayout();
            this.pnlScoreBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGameBoard.Controls.Add(this.picBx8);
            this.pnlGameBoard.Controls.Add(this.picBx7);
            this.pnlGameBoard.Controls.Add(this.picBx6);
            this.pnlGameBoard.Controls.Add(this.picBx5);
            this.pnlGameBoard.Controls.Add(this.picBx4);
            this.pnlGameBoard.Controls.Add(this.picBx3);
            this.pnlGameBoard.Controls.Add(this.picBx2);
            this.pnlGameBoard.Controls.Add(this.picBx1);
            this.pnlGameBoard.Controls.Add(this.picBx0);
            this.pnlGameBoard.Location = new System.Drawing.Point(12, 139);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(269, 266);
            this.pnlGameBoard.TabIndex = 0;
            // 
            // picBx8
            // 
            this.picBx8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx8.Location = new System.Drawing.Point(185, 183);
            this.picBx8.Name = "picBx8";
            this.picBx8.Size = new System.Drawing.Size(80, 80);
            this.picBx8.TabIndex = 8;
            this.picBx8.TabStop = false;
            this.picBx8.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx7
            // 
            this.picBx7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx7.Location = new System.Drawing.Point(93, 183);
            this.picBx7.Name = "picBx7";
            this.picBx7.Size = new System.Drawing.Size(80, 80);
            this.picBx7.TabIndex = 7;
            this.picBx7.TabStop = false;
            this.picBx7.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx6
            // 
            this.picBx6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx6.Location = new System.Drawing.Point(0, 183);
            this.picBx6.Name = "picBx6";
            this.picBx6.Size = new System.Drawing.Size(80, 80);
            this.picBx6.TabIndex = 6;
            this.picBx6.TabStop = false;
            this.picBx6.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx5
            // 
            this.picBx5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx5.Location = new System.Drawing.Point(185, 92);
            this.picBx5.Name = "picBx5";
            this.picBx5.Size = new System.Drawing.Size(80, 80);
            this.picBx5.TabIndex = 5;
            this.picBx5.TabStop = false;
            this.picBx5.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx4
            // 
            this.picBx4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx4.Location = new System.Drawing.Point(93, 92);
            this.picBx4.Name = "picBx4";
            this.picBx4.Size = new System.Drawing.Size(80, 80);
            this.picBx4.TabIndex = 4;
            this.picBx4.TabStop = false;
            this.picBx4.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx3
            // 
            this.picBx3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx3.Location = new System.Drawing.Point(0, 92);
            this.picBx3.Name = "picBx3";
            this.picBx3.Size = new System.Drawing.Size(80, 80);
            this.picBx3.TabIndex = 3;
            this.picBx3.TabStop = false;
            this.picBx3.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx2
            // 
            this.picBx2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx2.Location = new System.Drawing.Point(185, 0);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(80, 80);
            this.picBx2.TabIndex = 2;
            this.picBx2.TabStop = false;
            this.picBx2.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx1
            // 
            this.picBx1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx1.Location = new System.Drawing.Point(93, 0);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(80, 80);
            this.picBx1.TabIndex = 1;
            this.picBx1.TabStop = false;
            this.picBx1.Click += new System.EventHandler(this.ClickForMove);
            // 
            // picBx0
            // 
            this.picBx0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx0.Location = new System.Drawing.Point(0, 0);
            this.picBx0.Name = "picBx0";
            this.picBx0.Size = new System.Drawing.Size(80, 80);
            this.picBx0.TabIndex = 0;
            this.picBx0.TabStop = false;
            this.picBx0.Click += new System.EventHandler(this.ClickForMove);
            // 
            // rdBtnAgainstPC
            // 
            this.rdBtnAgainstPC.AutoSize = true;
            this.rdBtnAgainstPC.Checked = true;
            this.rdBtnAgainstPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnAgainstPC.Location = new System.Drawing.Point(3, 3);
            this.rdBtnAgainstPC.Name = "rdBtnAgainstPC";
            this.rdBtnAgainstPC.Size = new System.Drawing.Size(205, 24);
            this.rdBtnAgainstPC.TabIndex = 2;
            this.rdBtnAgainstPC.TabStop = true;
            this.rdBtnAgainstPC.Text = "Bilgisayara Karşı Oyna";
            this.rdBtnAgainstPC.UseVisualStyleBackColor = true;
            this.rdBtnAgainstPC.Click += new System.EventHandler(this.GameStatusChanged);
            // 
            // rdBtnAgainstFriend
            // 
            this.rdBtnAgainstFriend.AutoSize = true;
            this.rdBtnAgainstFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnAgainstFriend.Location = new System.Drawing.Point(3, 31);
            this.rdBtnAgainstFriend.Name = "rdBtnAgainstFriend";
            this.rdBtnAgainstFriend.Size = new System.Drawing.Size(125, 24);
            this.rdBtnAgainstFriend.TabIndex = 3;
            this.rdBtnAgainstFriend.Text = "İki Kişi Oyna";
            this.rdBtnAgainstFriend.UseVisualStyleBackColor = true;
            this.rdBtnAgainstFriend.Click += new System.EventHandler(this.GameStatusChanged);
            // 
            // rdBtnNetwork
            // 
            this.rdBtnNetwork.AutoSize = true;
            this.rdBtnNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnNetwork.Location = new System.Drawing.Point(3, 61);
            this.rdBtnNetwork.Name = "rdBtnNetwork";
            this.rdBtnNetwork.Size = new System.Drawing.Size(115, 24);
            this.rdBtnNetwork.TabIndex = 4;
            this.rdBtnNetwork.Text = "Ağda Oyna";
            this.rdBtnNetwork.UseVisualStyleBackColor = true;
            this.rdBtnNetwork.Click += new System.EventHandler(this.GameStatusChanged);
            // 
            // pnlGameOptions
            // 
            this.pnlGameOptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlGameOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGameOptions.Controls.Add(this.pnlNetWorkSettings);
            this.pnlGameOptions.Controls.Add(this.lblSocketStatus);
            this.pnlGameOptions.Controls.Add(this.rdBtnAgainstPC);
            this.pnlGameOptions.Controls.Add(this.rdBtnNetwork);
            this.pnlGameOptions.Controls.Add(this.rdBtnAgainstFriend);
            this.pnlGameOptions.Location = new System.Drawing.Point(287, 141);
            this.pnlGameOptions.Name = "pnlGameOptions";
            this.pnlGameOptions.Size = new System.Drawing.Size(328, 263);
            this.pnlGameOptions.TabIndex = 5;
            // 
            // pnlNetWorkSettings
            // 
            this.pnlNetWorkSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNetWorkSettings.Controls.Add(this.btnInvite);
            this.pnlNetWorkSettings.Controls.Add(this.txBxVistorIP);
            this.pnlNetWorkSettings.Controls.Add(this.lblIP);
            this.pnlNetWorkSettings.Controls.Add(this.lnkLblInvitation);
            this.pnlNetWorkSettings.Location = new System.Drawing.Point(14, 89);
            this.pnlNetWorkSettings.Name = "pnlNetWorkSettings";
            this.pnlNetWorkSettings.Size = new System.Drawing.Size(293, 165);
            this.pnlNetWorkSettings.TabIndex = 8;
            // 
            // btnInvite
            // 
            this.btnInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvite.Location = new System.Drawing.Point(186, 30);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(100, 28);
            this.btnInvite.TabIndex = 9;
            this.btnInvite.Text = "Davet Et";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // txBxVistorIP
            // 
            this.txBxVistorIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxVistorIP.Location = new System.Drawing.Point(13, 32);
            this.txBxVistorIP.Name = "txBxVistorIP";
            this.txBxVistorIP.Size = new System.Drawing.Size(157, 26);
            this.txBxVistorIP.TabIndex = 8;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIP.Location = new System.Drawing.Point(12, 6);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 20);
            this.lblIP.TabIndex = 7;
            // 
            // lnkLblInvitation
            // 
            this.lnkLblInvitation.AutoSize = true;
            this.lnkLblInvitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblInvitation.Location = new System.Drawing.Point(12, 73);
            this.lnkLblInvitation.Name = "lnkLblInvitation";
            this.lnkLblInvitation.Size = new System.Drawing.Size(0, 17);
            this.lnkLblInvitation.TabIndex = 6;
            this.lnkLblInvitation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblInvitation_LinkClicked);
            // 
            // lblSocketStatus
            // 
            this.lblSocketStatus.AutoSize = true;
            this.lblSocketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSocketStatus.Location = new System.Drawing.Point(125, 65);
            this.lblSocketStatus.Name = "lblSocketStatus";
            this.lblSocketStatus.Size = new System.Drawing.Size(0, 17);
            this.lblSocketStatus.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Salmon;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(12, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(267, 50);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerRemainingTime
            // 
            this.timerRemainingTime.Tick += new System.EventHandler(this.timerRemainingTime_Tick);
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.Location = new System.Drawing.Point(14, 106);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(265, 31);
            this.lblRemainingTime.TabIndex = 7;
            this.lblRemainingTime.Text = "Game Over";
            this.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHostName
            // 
            this.lblHostName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHostName.Location = new System.Drawing.Point(3, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(142, 21);
            this.lblHostName.TabIndex = 8;
            this.lblHostName.Text = "label1";
            this.lblHostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisitorName
            // 
            this.lblVisitorName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVisitorName.Location = new System.Drawing.Point(183, 0);
            this.lblVisitorName.Name = "lblVisitorName";
            this.lblVisitorName.Size = new System.Drawing.Size(140, 21);
            this.lblVisitorName.TabIndex = 9;
            this.lblVisitorName.Text = "label1";
            this.lblVisitorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScoreBoard
            // 
            this.pnlScoreBoard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScoreBoard.Controls.Add(this.panel1);
            this.pnlScoreBoard.Controls.Add(this.lblVisitorScore);
            this.pnlScoreBoard.Controls.Add(this.lblHostScore);
            this.pnlScoreBoard.Controls.Add(this.lblVisitorName);
            this.pnlScoreBoard.Controls.Add(this.lblHostName);
            this.pnlScoreBoard.Location = new System.Drawing.Point(287, 9);
            this.pnlScoreBoard.Name = "pnlScoreBoard";
            this.pnlScoreBoard.Size = new System.Drawing.Size(328, 86);
            this.pnlScoreBoard.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnlVisitorRemainingTime);
            this.panel1.Controls.Add(this.pnlHostRemainingTime);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 24);
            this.panel1.TabIndex = 12;
            // 
            // pnlVisitorRemainingTime
            // 
            this.pnlVisitorRemainingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlVisitorRemainingTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVisitorRemainingTime.Location = new System.Drawing.Point(160, 0);
            this.pnlVisitorRemainingTime.Name = "pnlVisitorRemainingTime";
            this.pnlVisitorRemainingTime.Size = new System.Drawing.Size(160, 20);
            this.pnlVisitorRemainingTime.TabIndex = 13;
            // 
            // pnlHostRemainingTime
            // 
            this.pnlHostRemainingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlHostRemainingTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHostRemainingTime.Location = new System.Drawing.Point(0, 0);
            this.pnlHostRemainingTime.Name = "pnlHostRemainingTime";
            this.pnlHostRemainingTime.Size = new System.Drawing.Size(160, 20);
            this.pnlHostRemainingTime.TabIndex = 12;
            // 
            // lblVisitorScore
            // 
            this.lblVisitorScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisitorScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVisitorScore.Location = new System.Drawing.Point(183, 31);
            this.lblVisitorScore.Name = "lblVisitorScore";
            this.lblVisitorScore.Size = new System.Drawing.Size(140, 21);
            this.lblVisitorScore.TabIndex = 11;
            this.lblVisitorScore.Text = "label1";
            this.lblVisitorScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHostScore
            // 
            this.lblHostScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHostScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHostScore.Location = new System.Drawing.Point(3, 31);
            this.lblHostScore.Name = "lblHostScore";
            this.lblHostScore.Size = new System.Drawing.Size(142, 21);
            this.lblHostScore.TabIndex = 10;
            this.lblHostScore.Text = "label1";
            this.lblHostScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameResult
            // 
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameResult.Location = new System.Drawing.Point(14, 9);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(265, 36);
            this.lblGameResult.TabIndex = 11;
            this.lblGameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHighLight
            // 
            this.timerHighLight.Interval = 500;
            this.timerHighLight.Tick += new System.EventHandler(this.timerHighLight_Tick);
            // 
            // GameMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 409);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.pnlScoreBoard);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGameOptions);
            this.Controls.Add(this.pnlGameBoard);
            this.Name = "GameMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.GameMainForm_Load);
            this.pnlGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx0)).EndInit();
            this.pnlGameOptions.ResumeLayout(false);
            this.pnlGameOptions.PerformLayout();
            this.pnlNetWorkSettings.ResumeLayout(false);
            this.pnlNetWorkSettings.PerformLayout();
            this.pnlScoreBoard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.PictureBox picBx8;
        private System.Windows.Forms.PictureBox picBx7;
        private System.Windows.Forms.PictureBox picBx6;
        private System.Windows.Forms.PictureBox picBx5;
        private System.Windows.Forms.PictureBox picBx4;
        private System.Windows.Forms.PictureBox picBx3;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.PictureBox picBx0;
        private System.Windows.Forms.RadioButton rdBtnAgainstPC;
        private System.Windows.Forms.RadioButton rdBtnAgainstFriend;
        private System.Windows.Forms.RadioButton rdBtnNetwork;
        private System.Windows.Forms.Panel pnlGameOptions;
        private System.Windows.Forms.Label lblSocketStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerRemainingTime;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblVisitorName;
        private System.Windows.Forms.Panel pnlScoreBoard;
        private System.Windows.Forms.Label lblVisitorScore;
        private System.Windows.Forms.Label lblHostScore;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.Panel pnlVisitorRemainingTime;
        private System.Windows.Forms.Panel pnlHostRemainingTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerHighLight;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.LinkLabel lnkLblInvitation;
        private System.Windows.Forms.Panel pnlNetWorkSettings;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.TextBox txBxVistorIP;
    }
}

