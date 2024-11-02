using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace phamquangminh_2122110339
{

    public partial class bai28 : Form
    {
        PictureBox pbBasket=new PictureBox();
        PictureBox pbEgg=new PictureBox();
        PictureBox pbChicken=new PictureBox(); 
        PictureBox pbBom=new PictureBox();
        Timer tmrBom = new Timer();
        Timer tmEgg=new Timer();
        Timer tmChicken=new Timer();
       
        Timer tmExplosion = new Timer();
        Timer tmStartBom = new Timer();
        

        int xBasket = 300;
        int yBasket = 285;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 3;

        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 2;

        int xBom = 300;
        int yBom = 10;
        int yDeltaBom = 2;

        bool canProceedToNextLevel = true;
        bool isEggBroken = false;//sự kiện trứng vỡ
        bool isBomBroken = false;//sự kiện bom nổ

        int score = 0;
        int second = 0;
        int level = 1;
        int highScore = 0;

        bool isGameRunning = false;
        bool isNewGame = true;

        private Label lblPlayerName = new Label();
        private TextBox txtPlayerName = new TextBox();
        private Button btnStartGame = new Button();
        private string playerName;
        SoundPlayer backgroundMusic;
        SoundPlayer catchSound;

        public bai28()
        {
            InitializeComponent();
            InitializeStartGameUI();
            LoadBackgroundMusic();
            //LoadCatchSound();
        }
       
       

        
        private void InitializeStartGameUI()
        {
            lblPlayerName.Text = "Tên người chơi";
            lblPlayerName.Font = new Font("Arial", 10, FontStyle.Bold);
            lblPlayerName.AutoSize = true;
            lblPlayerName.ForeColor = Color.DarkSlateBlue;
            lblPlayerName.Location = new Point(this.ClientSize.Width / 2 - lblPlayerName.Width / 2 - 55, this.ClientSize.Height / 2 - 80);
            this.Controls.Add(lblPlayerName);
            // TextBox cho tên người chơi
            txtPlayerName.Size = new Size(200, 30);
            txtPlayerName.Location = new Point(this.ClientSize.Width / 2 - 100, this.ClientSize.Height / 2 - 40);
            txtPlayerName.Font = new Font("Arial", 14);
            this.Controls.Add(txtPlayerName);

            // Button để bắt đầu trò chơi
            btnStartGame.Text = "Bắt đầu trò chơi";
            btnStartGame.Size = new Size(100, 40);
            btnStartGame.Location = new Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2 + 10);
            btnStartGame.Click += BtnStartGame_Click;
            this.Controls.Add(btnStartGame);

            pbBasket.Visible = false;
            pbEgg.Visible = false;
            pbChicken.Visible = false;
            pbBom.Visible = false;
            lblScore.Visible = false;
            lblLevel.Visible = false;

            isGameRunning = false;
        }
        private void GameLoop()
        {
            if (!isGameRunning) return; // Nếu trò chơi không chạy, dừng tất cả

            // Logic cho trò chơi (như trứng rơi)
            TmEgg_Tick(null, null); // Gọi hàm kiểm tra trứng
            TmChicken_Tick(null, null); // Gọi hàm kiểm tra gà
        }
        private void LoadBackgroundMusic()
        {
            // Specify the path to your background music file
            string musicFilePath = @"D:\bg_music.wav";

            backgroundMusic = new SoundPlayer(musicFilePath);
            backgroundMusic.PlayLooping(); // Loops the music continuously
        }
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            playerName = txtPlayerName.Text;
            if (isNewGame && string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn để bắt đầu trò chơi.");
                return;
            }

            // Ẩn giao diện bắt đầu
            if (isNewGame)
            {
                txtPlayerName.Visible = false;
                btnStartGame.Visible = false;
                lblPlayerName.Visible = false;
            }

            // Hiển thị các đối tượng trò chơi
            pbBasket.Visible = true;
            pbEgg.Visible = true;
            pbChicken.Visible = true;
            pbBom.Visible = true;
            lblScore.Visible = true;
            lblLevel.Visible = true;

            // Bắt đầu logic trò chơi
            isGameRunning = true;
            StartGame();
        }


        private void StartGame()
        {

            // Khởi tạo các thành phần trò chơi và bắt đầu bộ đếm thời gian
            
            TmEgg_Tick(null, EventArgs.Empty);
            TmBom_Tick(null, EventArgs.Empty);
            TmStopwatch_Tick(null, EventArgs.Empty);
            TmChicken_Tick(null, EventArgs.Empty);
            this.KeyPreview = true;
        }

        private void bai28_Load(object sender, EventArgs e)
        {
            if (isNewGame)
            {
                // Hiển thị form nhập tên người chơi
                InitializeStartGameUI();
            }
            else
            {
                // Bắt đầu trò chơi mà không cần nhập tên
               StartGame();
            }
            btnNextLevel.Text = "Qua màn";
            btnNextLevel.Size = new Size(100, 50);
            btnNextLevel.Location = new Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2);
            btnNextLevel.Visible = false; // Ẩn nút khi bắt đầu trò chơi
            btnNextLevel.Click += btnNextLevel_Click;
            this.Controls.Add(btnNextLevel);
            this.BackgroundImage = Image.FromFile("../../Images/bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            tmStartBom.Interval = 5000;  // 5000 milliseconds = 5 seconds
    
             tmStartBom.Start();
            
            //thời gian của trứng rơi
            tmEgg.Interval = 30;
            tmEgg.Tick += TmEgg_Tick;
            tmEgg.Start();
            //Thời gian bom rơi
            tmrBom.Interval = 25;
            tmrBom.Tick += TmBom_Tick;
           
            //thời gian gà di chuyển
            tmChicken.Interval =30;
            tmChicken.Tick += TmChicken_Tick;
            tmChicken.Start();
            //Thời Gian
            tmStopwatch.Interval = 1000;
            tmStopwatch.Tick += TmStopwatch_Tick;
            tmStopwatch.Start();
            //sự kiện của giỏ trứng
            pbBasket.SizeMode=PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(60, 60);
            pbBasket.Location = new Point(xBasket, yBasket);    
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);
            pbBasket.Image = Image.FromFile("../../Images/basket.png");
            //thuộc tính của trứng
            pbEgg.SizeMode= PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(40,40);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile("../../Images/egg.png");
            //thuộc tính gà
            pbChicken.SizeMode= PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(65,65);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add (pbChicken);
            pbChicken.Image = Image.FromFile("../../Images/chicken.png");
            //thuộc tính của bom
            pbBom.SizeMode= PictureBoxSizeMode.StretchImage;
            pbBom.Size= new Size(40,40);
            pbBom .BackColor = Color.Transparent;
            this.Controls.Add(pbBom);
 
            pbBasket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }
        private void TmBom_Tick(object sender, EventArgs e)
        {
            if (!isGameRunning) return;
            yBom += yDeltaBom;

            Rectangle unionRect = Rectangle.Intersect(pbBom.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                // Bom chạm giỏ
                tmrBom.Stop();
                tmEgg.Stop();
                tmChicken.Stop();

                // Hiển thị ảnh bom nổ
                pbBom.Image = Image.FromFile("../../Images/bomno.png");

                // Bắt đầu Timer để hiển thị ảnh nổ trong 1 giây
                tmExplosion.Interval = 1000;  // 1000 milliseconds = 1 second
                tmExplosion.Tick += TmExplosion_Tick;
                tmExplosion.Start();
            }

            pbBom.Location = new Point(xBom, yBom);
        }

        private void TmExplosion_Tick(object sender, EventArgs e)
        {
            // Dừng tất cả các Timer đang chạy (trứng, bom, gà, đồng hồ...)
            tmEgg.Stop();
            tmrBom.Stop();
            tmChicken.Stop();
            tmStopwatch.Stop();

            // Dừng giỏ (không nhận sự kiện từ bàn phím nữa)
            this.KeyPreview = false;

            // Hiển thị ảnh bom nổ
            pbBom.Image = Image.FromFile("../../Images/bomno.png");

            // Dừng việc hiển thị bom nổ sau 1 giây, và chuyển sang màn hình trắng
            tmExplosion.Stop();

            // Đổi màu nền thành trắng
            this.BackColor = Color.White;

            // Ẩn các đối tượng trên màn hình
            pbBasket.Visible = false;
            pbEgg.Visible = false;
            pbChicken.Visible = false;
            pbBom.Visible = false;
            // Save the player's score
            SavePlayerScore(txtPlayerName.Text, score);
            ShowEndGameOptions();   
        }

        private void TmStopwatch_Tick(object sender, EventArgs e)
        {
            if (!isGameRunning) return;
            second++;

            lblDisplay.Text = second.ToString();

            if (second % 5 == 0)
            {
                // Chỉ hiển thị bom sau khi đã bắt trứng
                if (second % 5 == 0 )
                {
                    // Logic to set the bomb's position should only happen after catching an egg
                    Random random = new Random();
                    int offsetX = random.Next(-50, 30); // Random offset to position bomb
                    xBom = xEgg + offsetX; // Position bomb near egg
                    yBom = pbChicken.Location.Y + pbChicken.Height; // Above chicken

                    // Make the bomb visible and set its initial position
                    pbBom.Location = new Point(xBom, yBom);
                    pbBom.Image = Image.FromFile("../../Images/bom.png");
                    pbBom.Visible = true; // Make bomb visible

                    tmrBom.Start(); // Start the bomb falling
                }

                if (isEggBroken)
                    tmStopwatch.Stop();
            }
        }
        private void TmChicken_Tick(object sender, EventArgs e)
        {
            if (isEggBroken)
            {
                return;  
            }
            xChicken += xDeltaChicken;
          
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken =- xDeltaChicken;
            }
            pbChicken.Location = new Point(xChicken, yChicken);
            
        }
        bool effect = false;
        private void TmEgg_Tick(object sender, EventArgs e)
        {
            if (!isGameRunning) return;
            if (score >= 5 && canProceedToNextLevel)
            {
                // Do not allow the egg to fall if we reached 5 points
                return;
            }
            yEgg += yDeltaEgg;

            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                pbEgg.Image = Image.FromFile("../../Images/broken_egg.png");
                isEggBroken = true;
                tmEgg.Stop();
                ShowEndGameOptions();
                return;
            }

            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                score++;
                lbDiem.Text = "Điểm: " + score;
                // Kiểm tra nếu điểm số đạt 15 thì qua màn
                if (score % 1 == 0)
                {
                    tmStopwatch.Stop();
                    tmChicken.Stop();
                    tmEgg.Stop();
                    tmrBom.Stop();
                    canProceedToNextLevel = false; // Ngăn không cho rơi trứng nữa
                    ShowNextLevel(); // Hiển thị nút qua màn
                    return; // Ngừng xử lý nếu đã đạt 5 điểm
                }

                // Tăng độ khó dần
                if (score % 3 == 0)
                {
                    yDeltaEgg += 1; // Tăng tốc độ rơi của trứng
                    xDeltaChicken += 1; // Tăng tốc độ di chuyển của gà
                }

                yEgg = pbChicken.Location.Y + pbChicken.Height;
                xEgg = pbChicken.Location.X + (pbChicken.Width / 2) - (pbEgg.Width / 2);
                isEggBroken = false;
                pbEgg.Image = Image.FromFile("../../Images/egg.png");
                tmEgg.Start();
            }
           
            pbEgg.Location = new Point(xEgg, yEgg);
        }
        //private void LoadCatchSound()
        //{
        //    string catchSoundPath = @"D:\ting.wav";
        //    catchSound = new SoundPlayer(catchSoundPath);

        //}
        //public void PlayCatchSound()
        //{
        //    catchSound.Play(); // Play catch sound without stopping the background music
        //}


        private Button btnPlayAgain = new Button();
        private Button btnExit = new Button();
        private Label lblLevel = new Label();
        private Label lblScore = new Label();
        private Button btnNextLevel = new Button();
        private void SetupLevelLabel()
        {
            lblLevel.Text = $"Cấp độ: {level}";
            lblLevel.Font = new Font("Arial", 10, FontStyle.Bold);
            lblLevel.ForeColor = Color.White;
            lblLevel.BackColor = Color.FromArgb(0, 102, 150);
            lblLevel.TextAlign = ContentAlignment.MiddleRight;
            lblLevel.BorderStyle = BorderStyle.FixedSingle;
            lblLevel.AutoSize = false;
            lblLevel.Size = new Size(80, 30);
            lblLevel.Location = new Point(ClientSize.Width - lblLevel.Width - 10, 10);
            lblLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLevel.Visible = true; // Đảm bảo label hiện trên giao diện
            this.Controls.Add(lblLevel); // Thêm label vào form
        }
        private void ShowNextLevel()
        {
            // Hiển thị nút qua màn
            btnNextLevel.Visible = true;

            // Đặt level hiện tại vào nhãn
            SetupLevelLabel();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            // Tăng level
            level++;
            SetupLevelLabel();

            // Tăng độ khó
            yDeltaEgg += 1; // Tăng tốc độ rơi của trứng
            xDeltaChicken += 1; // Tăng tốc độ di chuyển của gà

            // Ẩn nút qua màn
            btnNextLevel.Visible = false;

            // Reset vị trí của trứng
            yEgg = 10;
            pbEgg.Location = new Point(xEgg, yEgg);

            // Bắt đầu lại quá trình rơi trứng
            isEggBroken = false;
            tmrBom.Start();
            tmChicken.Start();
            tmStopwatch.Start();
            tmEgg.Start();
            
            
        }
        private void EndGame()
        {
            if (level == 10)
            {
                MessageBox.Show("Chúc mừng! Bạn đã hoàn thành cấp độ tối đa!", "Hoàn thành trò chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowEndGameOptions(); // Gọi hàm để hiển thị các nút 'Chơi lại' và 'Thoát'
            }
        }
        public class PlayerScore
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }

            public PlayerScore(string playerName, int score)
            {
                PlayerName = playerName;
                Score = score;
            }
        }
        private void SavePlayerScore(string playerName, int score)
        {
            string filePath = @"D:\scores.txt";
            List<PlayerScore> scores = LoadScores();

            // Kiểm tra nếu người chơi đã có điểm trước đó
            var existingScore = scores.FirstOrDefault(s => s.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase));

            // Nếu người chơi có điểm cũ và điểm mới không cao hơn điểm cũ thì không lưu
            if (existingScore != null)
            {
                if (score <= existingScore.Score)
                {
                    return; // Không lưu nếu điểm mới không cao hơn
                }
                else
                {
                    // Xóa điểm cũ
                    scores.Remove(existingScore);
                }
            }

            // Lưu điểm mới
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{playerName},{score}");
            }
        }
        //
        private List<PlayerScore> LoadScores()
        {
            string filePath = @"D:\scores.txt";
            List<PlayerScore> scores = new List<PlayerScore>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        scores.Add(new PlayerScore(parts[0], score));
                    }
                }
            }

            return scores;
        }
        //
        private void BtnShowLeaderboard_Click(object sender, EventArgs e)
        {
            ShowLeaderboard();
        }
        //
        private void ShowLeaderboard()
        {
            List<PlayerScore> scores = LoadScores();

            // Sắp xếp danh sách theo điểm số, giảm dần
            var sortedScores = scores.OrderByDescending(s => s.Score).ToList();

            // Tạo bảng xếp hạng
            string leaderboard = "Bảng xếp hạng:\n";
            for (int i = 0; i < sortedScores.Count; i++)
            {
                leaderboard += $"{i + 1}. {sortedScores[i].PlayerName}: {sortedScores[i].Score}\n";
            }

            // Hiển thị bảng xếp hạng trong một hộp thoại hoặc một label
            MessageBox.Show(leaderboard, "Bảng Xếp Hạng");
        }
        //
        private void ShowEndGameOptions()
        {
            lblScore.Visible = true;
            btnPlayAgain.Visible = true; // Hiển thị nút Chơi lại
            btnExit.Visible = true; // Hiển thị nút Thoát nếu cần

            // Ẩn các đối tượng trên màn hình
            pbBasket.Visible = false;
            pbEgg.Visible = false;
            pbChicken.Visible = false;
            pbBom.Visible = false;
            // Đọc điểm cao nhất
            List<PlayerScore> scores = LoadScores();
            int highScore = scores.Where(s => s.PlayerName == txtPlayerName.Text).Select(s => s.Score).DefaultIfEmpty(0).Max();

            // Kiểm tra và lưu điểm nếu điểm hiện tại cao hơn điểm cao nhất
            if (score > highScore)
            {
                SavePlayerScore(txtPlayerName.Text, score); // Lưu điểm mới nếu cao hơn
            }

            // Hiển thị thông tin điểm số
            lblScore.Text = $"Điểm của bạn: {score}\nĐiểm cao nhất: {highScore}";
            lblScore.Size = new Size(200, 50); // Tăng kích thước để hiển thị cả hai điểm
            lblScore.Location = new Point(this.ClientSize.Width / 2 - 100, this.ClientSize.Height / 2 - 50);
            lblScore.Font = new Font("Arial", 14, FontStyle.Bold);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblScore);

            // Tạo nút "Chơi lại"
            btnPlayAgain.Text = "Chơi lại";
            btnPlayAgain.Size = new Size(100, 50);
            btnPlayAgain.Location = new Point(this.ClientSize.Width / 2 - 110, this.ClientSize.Height / 2);
            btnPlayAgain.Click += BtnPlayAgain_Click;
            this.Controls.Add(btnPlayAgain);

            // Tạo nút "Thoát"
            btnExit.Text = "Thoát";
            btnExit.Size = new Size(100, 50);
            btnExit.Location = new Point(this.ClientSize.Width / 2 + 10, this.ClientSize.Height / 2);
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);
            //
            btnShowLeaderboard.Visible = true;
            btnShowLeaderboard.Text = "Xem Bảng Xếp Hạng";
            btnShowLeaderboard.Size = new Size(150, 50);
            btnShowLeaderboard.Location = new Point(this.ClientSize.Width / 2 - 75, this.ClientSize.Height / 2 + 60);
            btnShowLeaderboard.Click += BtnShowLeaderboard_Click;
            this.Controls.Add(btnShowLeaderboard);
        }
        private Button btnShowLeaderboard = new Button();

        // Xử lý khi nhấn nút "Chơi lại"
        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            // Đặt lại tất cả các biến trò chơi
            score = 0;
            level = 1;
            second = 0;
            canProceedToNextLevel = true;
            isEggBroken = false;
            isBomBroken = false;

            // Ẩn các nút và đối tượng không cần thiết
            btnPlayAgain.Visible = false;
            btnExit.Visible = false;
            btnNextLevel.Visible = false;

            // Khôi phục vị trí ban đầu của giỏ và các đối tượng
            xBasket = 300;
            yBasket = 285;
            xEgg = 300;
            yEgg = 10;
            xChicken = 300;
            yChicken = 10;
            

            // Thiết lập lại các đối tượng
            pbBasket.Location = new Point(xBasket, yBasket);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbChicken.Location = new Point(xChicken, yChicken);
            

            // Thiết lập lại hình ảnh cho các đối tượng
            pbEgg.Image = Image.FromFile("../../Images/egg.png");
            pbChicken.Image = Image.FromFile("../../Images/chicken.png");

            // Hiển thị lại các đối tượng trò chơi
            pbBasket.Visible = true;
            pbEgg.Visible = true;
            pbChicken.Visible = true;
            //
            btnShowLeaderboard.Visible = false;
            lblScore.Visible = false;
            lblLevel.Visible = true;

            // Bắt đầu lại trò chơi
            isGameRunning = true;
            tmChicken.Start();
            tmEgg.Start();
            tmStopwatch.Start();
            StartGame();
            
        }
        // Xử lý khi nhấn nút "Thoát"
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }
        private void bai28_KeyDown(object sender, KeyEventArgs e)
        {
           
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Right)
            {
                if (xBasket < this.ClientSize.Width - pbBasket.Width)
                    xBasket += xDeltaBasket;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (xBasket > 0)
                    xBasket -= xDeltaBasket;
            }

            pbBasket.Location = new Point(xBasket, yBasket);
        }

        
    }
}
