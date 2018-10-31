using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameMainForm : Form
    {
        public GameMainForm()
        {
            InitializeComponent();
        }

        List<PictureBox> GameBoard;
        List<int> GameMatrix;
        private void GameMainForm_Load(object sender, EventArgs e)
        {
            OpenNewPlayerForm();
            CreateGameBoard();
            ListenSocket();
            PCGameMode();
            timerHighLight.Enabled = true;
        }

        //Yeni bir oyuncu eklemek için form açılıyor
        private void OpenNewPlayerForm()
        {
            NewPlayerForm newPlayerForm = new NewPlayerForm();
            newPlayerForm.ShowDialog();
            Host = new Player() { Name = newPlayerForm.Name };
            lblHostName.Text = Host.Name;
            lblHostScore.Text = Host.score.ToString();
        }

        //3X3 lük oyun alanı oluşturuldu
        private void CreateGameBoard()
        {
            GameBoard = new List<PictureBox>() {
                picBx0,picBx1,picBx2,
                picBx3,picBx4,picBx5,
                picBx6,picBx7,picBx8
            };
            GameMatrix = new List<int>() {
                0,0,0,
                0,0,0,
                0,0,0
            };
        }

        //Ev sahibi hamle yapıyor ve kutuya "X" yazıyor
        private void HostPlayerMakeMove(int place)
        {
            PictureBox picBx = GameBoard[place];
            picBx.BackgroundImage = Properties.Resources.board_X;
            picBx.Enabled = false;
            GameMatrix[place] = 1;

            CheckGame();

        }
        //Misafir hamle yapıyor ve kutuya "O" yazıyor
        private void VisitorPlayerMakeMove(int place)
        {
            PictureBox picBx = GameBoard[place];
            GameBoard[place].BackgroundImage = Properties.Resources.board_O;
            picBx.Enabled = false;
            GameMatrix[place] = -1;

            CheckGame();
        }
        //Bilgisayar hamle yapıyor ve kutuya "O" yazıyor
        Random random = new Random();
        private void PCMakeMove()
        {

            bool moreMoves = false;
            foreach (int result in GameMatrix)
            {
                if (result == 0)
                    moreMoves = true;
            }
            if (moreMoves && gameStarted)
            {
                int place = random.Next(0, 9);
                if (GameMatrix[place] == 0)
                {
                    PictureBox picBx = GameBoard[place];
                    GameBoard[place].BackgroundImage = Properties.Resources.board_O;
                    picBx.Enabled = false;
                    GameMatrix[place] = -1;
                    CheckGame();

                }
                else
                {
                    PCMakeMove();
                }
            }
            else
            {
                EndGame();
            }

        }

        //Oyunun bitip bitmediği kontrol ediliyor
        int result_combination = -1;
        private void CheckGame()
        {
            result_combination = -1;
            for (int i = 0; i < 8; i++)
            {
                int result = ResultMatrix()[i];

                if (result == 3)
                {
                    Host.IsWinner = true;
                    Visitor.IsWinner = false;
                    Host.score++;
                    result_combination = i;
                    EndGame();
                }
                if (result == -3)
                {
                    Host.IsWinner = false;
                    Visitor.IsWinner = true;
                    Visitor.score++;
                    result_combination = i;
                    EndGame();
                }
            }
            WhosTurn();
        }

        // Oyun bitiriliyor, sonuç ekrana yazılıp ayarlar resetleniyor
        private void EndGame()
        {
            lblGameResult.Text = "No Winner - Deuce";

            if (Host.IsWinner)
            {
                lblGameResult.Text = "Winner :" + Host.Name;

                lblHostScore.Text = Host.score.ToString();
                gameStarted = false;
            }
            if (Visitor.IsWinner)
            {
                lblGameResult.Text = "Winner :" + Visitor.Name;

                lblVisitorScore.Text = Visitor.score.ToString();
                gameStarted = false;
            }
            gameStarted = false;
            pnlGameOptions.Enabled = true;

            timerRemainingTime.Enabled = false;
            foreach (PictureBox p in GameBoard)
            {
                p.Enabled = false;
            }
            btnStart.Enabled = true;
            //networkteki rakibe oyun bitti mesajı gidiyor
            if (gameStatus == 2)
                SendMessage(myIP + "-19");
        }

        //oyun kazanma olasılıkları için matris
        private int[] ResultMatrix()
        {
            int row1 = GameMatrix[0] + GameMatrix[1] + GameMatrix[2];
            int row2 = GameMatrix[3] + GameMatrix[4] + GameMatrix[5];
            int row3 = GameMatrix[6] + GameMatrix[7] + GameMatrix[8];
            int col1 = GameMatrix[0] + GameMatrix[3] + GameMatrix[6];
            int col2 = GameMatrix[1] + GameMatrix[4] + GameMatrix[7];
            int col3 = GameMatrix[2] + GameMatrix[5] + GameMatrix[8];
            int cross1 = GameMatrix[0] + GameMatrix[4] + GameMatrix[8];
            int cross2 = GameMatrix[2] + GameMatrix[4] + GameMatrix[6];
            int[] resultMatrix = new int[8] { row1, row2, row3, col1, col2, col3, cross1, cross2 };
            return resultMatrix;
        }


        //Tüm oyun alanı temizleniyor
        private void ResetGameBoard()
        {
            foreach (PictureBox p in GameBoard)
            {
                p.BackgroundImage = null;
                p.Enabled = true;
                p.Width = 80;
                p.Height = 80;
            }
            for (int i = 0; i < 9; i++)
                GameMatrix[i] = 0;
            remainingTime = 100;
            lblGameResult.Text = "";
            Host.IsWinner = false;
            Visitor.IsWinner = false;
            pnlVisitorRemainingTime.Width = 160;
            pnlHostRemainingTime.Width = 160;
        }
      

        //Socket dinleniyor
        #region SocketListening
        TcpListener server;
        TcpClient client;
        bool socketIsListening;
        string myIP;
        private void ListenSocket()
        {
            // Get the IP  
            string hostName = Dns.GetHostName();
            myIP = System.Net.Dns.GetHostEntry(hostName).AddressList[1].ToString();
            lblIP.Text = "Your IP : " + myIP;

            server = new TcpListener(IPAddress.Any, 2000);
            client = default(TcpClient);
            try
            {
                server.Start();
                lblSocketStatus.Text = "Ağ Dinleniyor";
                lblSocketStatus.ForeColor = Color.Green;
                socketIsListening = true;
                Thread listen = new Thread(listenThread);
                listen.Start();
                CheckForIllegalCrossThreadCalls = false;
            }
            catch (Exception ex)
            {
                lblSocketStatus.Text = "Ağ Dinlenemiyor";
                lblSocketStatus.ForeColor = Color.Red;
                socketIsListening = false;
            }

        }

        private void listenThread()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                byte[] recievedBuffer = new byte[100];
                NetworkStream stream = client.GetStream();
                stream.Read(recievedBuffer, 0, recievedBuffer.Length);
                string msg = Encoding.ASCII.GetString(recievedBuffer, 0, recievedBuffer.Length);
                HandleMsg(msg);
            }
        }
        #endregion


        int remainingTime = 100;
        bool gameStarted;
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();

        }
        //Oyun başlıyor
        private void StartGame()
        {
            timerRemainingTime.Enabled = true;
            lblRemainingTime.Text = ((Double)remainingTime / 10).ToString();         
            gameStarted = true;
            pnlGameOptions.Enabled = false;
            ResetGameBoard();
            result_combination = -1;
            lastMoveEndTime = DateTime.Now;
            WhosTurn();

            if (gameStatus == 0 && playedGameCount % 2 == 1)
            {
                PCMakeMove();
            }

            if (gameStatus == 1 && (playedGameCount) % 2 == 1)
            {
                MovesCountInGame = 0;
            }
            if (gameStatus == 2)
            {
                SendMessage(visitor_ip + "-12");
            }
            playedGameCount++;
        }

        //10 saniyeden geri sayıyor ve 0 da oyun bitiyor
        private void timerRemainingTime_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            lblRemainingTime.Text = ((Double)remainingTime / 10).ToString() + " sec.";
            if (remainingTime == 0)
            {
                timerRemainingTime.Enabled = false;
                btnStart.Enabled = true;
                gameStarted = false;
                lblRemainingTime.Text = "Game Over";
                remainingTime = 100;
                pnlGameOptions.Enabled = true;
                EndGame();
            }
        }


        Player Host;
        Player Visitor;
        int gameStatus = 0;
        //3 oyun modundan biri seçiliyor
        private void GameStatusChanged(object sender, EventArgs e)
        {
            if (rdBtnAgainstPC.Checked)
                PCGameMode();
            if (rdBtnAgainstFriend.Checked)
                MultiPlayerGameMode();
            if (rdBtnNetwork.Checked)
                NetWorkGameMode();
        }

        private void NetWorkGameMode()
        {
            if (socketIsListening)
            {
                gameStatus = 2;
                pnlNetWorkSettings.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                MessageBox.Show("You are not connected to the network!");

            }
        }

        private void MultiPlayerGameMode()
        {           
            btnStart.Enabled = true;
            gameStatus = 1;
            Host.score = 0;
            NewPlayerForm newPlayer = new NewPlayerForm();
            newPlayer.ShowDialog();
            Visitor.Name = newPlayer.Name;
            lblVisitorName.Text = Visitor.Name;
            Visitor.score = 0;
            lblVisitorScore.Text = Visitor.score.ToString();
            lblHostScore.Text = Host.score.ToString();
            pnlNetWorkSettings.Enabled = false;
        }

        private void PCGameMode()
        {
            gameStatus = 0;
            playedGameCount = 0;
            btnStart.Enabled = true;
            Visitor = new Player() { Name = System.Environment.MachineName.ToUpper() };
            lblVisitorScore.Text = Visitor.score.ToString();
            lblVisitorName.Text = Visitor.Name;
            Host.score = 0;
            lblHostScore.Text = Host.score.ToString();
            pnlNetWorkSettings.Enabled = false;
        }

        int playedGameCount;
        int MovesCountInGame;
        /*
         * Hamle yapmak için picturebox tıklanma olayı
         */
        private void ClickForMove(object sender, EventArgs e)
        {
            if (!gameStarted)
                return;

            PictureBox clickedPictureBox = sender as PictureBox;
            int pnlIndex = Convert.ToInt32(clickedPictureBox.Name.Replace("picBx", ""));

            switch (gameStatus)
            {
                case 0:
                    HostPlayerMakeMove(pnlIndex);
                    PCMakeMove();
                    break;
                case 1:
                    if ((playedGameCount + MovesCountInGame) % 2 == 0)
                        HostPlayerMakeMove(pnlIndex);
                    else
                        VisitorPlayerMakeMove(pnlIndex);
                    MovesCountInGame++;
                    break;
                case 2:
                    HostPlayerMakeMove(pnlIndex);
                    SendMessage(visitor_ip + "-" + pnlIndex.ToString());
                    break;

            }


        }

        //sonucu gösteren labeli ve kazanan pictureboxlara animation katar
        private void timerHighLight_Tick(object sender, EventArgs e)
        {
            if (lblGameResult.Visible == true)
            {
                lblGameResult.Visible = false;
                HighlightWinner(false);

            }
            else
            {
                lblGameResult.Visible = true;
                HighlightWinner(true);
            }
        }

        private void HighlightWinner(bool v)
        {
            switch (result_combination)
            {
                case -1:
                    break;
                case 0:
                    if (v)
                    { ChangeSize(GameBoard[0], true); ChangeSize(GameBoard[1], true); ChangeSize(GameBoard[2], true); }
                    else
                    { ChangeSize(GameBoard[0], false); ChangeSize(GameBoard[1], false); ChangeSize(GameBoard[2], false); }
                    break;
                case 1:
                    if (v)
                    { ChangeSize(GameBoard[3], true); ChangeSize(GameBoard[4], true); ChangeSize(GameBoard[5], true); }
                    else
                    { ChangeSize(GameBoard[3], false); ChangeSize(GameBoard[4], false); ChangeSize(GameBoard[5], false); }
                    break;
                case 2:
                    if (v)
                    { ChangeSize(GameBoard[6], true); ChangeSize(GameBoard[7], true); ChangeSize(GameBoard[8], true); }
                    else
                    { ChangeSize(GameBoard[6], false); ChangeSize(GameBoard[7], false); ChangeSize(GameBoard[8], false); }
                    break;
                case 3:
                    if (v)
                    { ChangeSize(GameBoard[0], true); ChangeSize(GameBoard[3], true); ChangeSize(GameBoard[6], true); }
                    else
                    { ChangeSize(GameBoard[0], false); ChangeSize(GameBoard[3], false); ChangeSize(GameBoard[6], false); }
                    break;
                case 4:
                    if (v)
                    { ChangeSize(GameBoard[1], true); ChangeSize(GameBoard[4], true); ChangeSize(GameBoard[7], true); }
                    else
                    { ChangeSize(GameBoard[1], false); ChangeSize(GameBoard[4], false); ChangeSize(GameBoard[7], false); }
                    break;
                case 5:
                    if (v)
                    { ChangeSize(GameBoard[2], true); ChangeSize(GameBoard[5], true); ChangeSize(GameBoard[8], true); }
                    else
                    { ChangeSize(GameBoard[2], false); ChangeSize(GameBoard[5], false); ChangeSize(GameBoard[8], false); }
                    break;
                case 6:
                    if (v)
                    { ChangeSize(GameBoard[0], true); ChangeSize(GameBoard[4], true); ChangeSize(GameBoard[8], true); }
                    else
                    { ChangeSize(GameBoard[0], false); ChangeSize(GameBoard[4], false); ChangeSize(GameBoard[8], false); }
                    break;
                case 7:
                    if (v)
                    { ChangeSize(GameBoard[2], true); ChangeSize(GameBoard[4], true); ChangeSize(GameBoard[6], true); }
                    else
                    { ChangeSize(GameBoard[2], false); ChangeSize(GameBoard[4], false); ChangeSize(GameBoard[6], false); }
                    break;
            }
        }

        private void ChangeSize(PictureBox pictureBox, bool v)
        {
            if (v)
            {
                pictureBox.Width = 75;
                pictureBox.Height = 75;
            }
            else
            {
                pictureBox.Width = 80;
                pictureBox.Height = 80;
            }
        }

        string visitor_ip;
        //networkteki rakibi davet et
        private void btnInvite_Click(object sender, EventArgs e)
        {
            visitor_ip = txBxVistorIP.Text;
            SendMessage(myIP + "-9");

        }
        //Socket üzerinden mesaj gönder
        private void SendMessage(string message)
        {
            try
            {
                int port = 2000;
                TcpClient client = new TcpClient(visitor_ip, port);
                int byteCount = Encoding.ASCII.GetByteCount(message);
                byte[] sendData = new byte[byteCount];
                sendData = Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                stream.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("Connection Error with: " + visitor_ip);
            }
        }

        //Mesajı işle
        private void HandleMsg(string msg)
        {
            string sender_ip = msg.Split('-')[0];
            int msgCode = Convert.ToInt32(msg.Split('-')[1]);
            switch (msgCode)
            {
                case int n when (n <= 8):
                    /*
                     * 0-8 rakamları arası gelen mesaj kodları ile hamle yapılıyor
                     */                
                    HostPlayerMakeMove(msgCode);
                    break;
                case 9:
                    //Davet geldi                   
                    IncomingInvitation();
                    break;
                case 10:
                    //Davet Kabul edildi
                    AcceptInvitation();
                    break;               
                case 12:
                    //Oyun başladı
                    StartGame();
                    break;
                case 13:
                    //Oyun başladı
                    EndGame();
                    break;
            }


        }
        //Ağdan gelen daveti kabul et
        private void AcceptInvitation()
        {
            btnStart.Enabled = true;
        }

        //Davet geldi bildirimi
        private void IncomingInvitation()
        {           
            lnkLblInvitation.Text = visitor_ip + "'den Davet geldi, kabul et";
        }

        private void lnkLblInvitation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendMessage(myIP + "-10");
        }

        DateTime lastMoveEndTime;
        //Oyun sırasının kimde olduğunu tespit eder, süre gösteren paneli değiştirir
        private void WhosTurn()
        {
            decimal difference = Convert.ToDecimal((DateTime.Now - lastMoveEndTime).TotalSeconds);
            difference = Math.Round(difference,2);
            int panelMove = Convert.ToInt32(Math.Round(16 * difference));         

            if ((playedGameCount + MovesCountInGame) % 2 == 1)
            {
                pnlVisitorRemainingTime.Width -= panelMove;
                pnlHostRemainingTime.Width += panelMove;
            }
            else
            {
                pnlVisitorRemainingTime.Width += panelMove;
                pnlHostRemainingTime.Width -= panelMove;
            }
            lastMoveEndTime = DateTime.Now;
        }
    }
}
