using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Form1 : Form
    {
        //Переменные
        Random random = new Random();
        private int horizontalSpeed = 4;
        private int verticalSpeed = 4;
        private int score = 0;
        private int fps = 70;


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000 / fps;
            timer1.Enabled = true;
            Cursor.Hide(); //Прячем курсор

            FormBorderStyle = FormBorderStyle.None; //Убрать все границы
            /*TopMost = true;*/ // Поверх всего
            Bounds = Screen.PrimaryScreen.Bounds; //Fullscreen на основном мониторе
            WindowState = FormWindowState.Maximized;

            //Экран проигрыша по центру
            lblLoss.Left = (playGround.Width / 2) - (lblLoss.Width / 2);
            lblLoss.Top = (playGround.Height / 2) - (lblLoss.Height / 2);

            // нахождение игрока 1/10 от высота монитора fullhd 108pixels
            player.Top = playGround.Bottom - (playGround.Bottom / 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Положение игрока = положению курсора, чтобы не вышло за границы отнимаем ширину игрока
            player.Left = Cursor.Position.X - player.Width;

            //Двигаем мяч
            ball.Left += horizontalSpeed;
            ball.Top += verticalSpeed;

            // Коллизия мяча с игроком
            if (ball.Bottom >= player.Top && ball.Bottom <= player.Bottom && ball.Left >= player.Left && ball.Right <= player.Right)
            {
                //Не допускаю скорость больше 14 иначе будет дрынь
                if (verticalSpeed <= 14 && horizontalSpeed <= 14)
                {
                    verticalSpeed += 1;
                    horizontalSpeed += 1;
                }
                verticalSpeed = -verticalSpeed;// Изменяет направление
                score += 1;//Игрок отбил, молодец! Получи очко;-;
                lblScore.Text = $"Score: {score}";
                playGround.BackColor = setColor();
            }

            //Коллизия мяча с границами игрового поля
            if (ball.Left <= playGround.Left)
            {
                horizontalSpeed = -horizontalSpeed; //Если мяч врезался в левую стенку, меняй горизонтальное направление 
            }
            if (ball.Right >= playGround.Right)
            {
                horizontalSpeed = -horizontalSpeed; // Минус на минус даёт что? Правильно! Меняет нам направление
            }
            if (ball.Top <= playGround.Top)
            {
                verticalSpeed = -verticalSpeed;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                timer1.Enabled = false; //Смэрть, ты проиграл
                lblLoss.Visible = true; //Окно поражения
            }

        }

        // Метод, который не допускает одного и того же цвета игрока и заднего плана(на всякий случай)
        private Color setColor()
        {
            Color newColor = Color.FromArgb(random.Next(140, 255), random.Next(140, 255), random.Next(140, 255));
            while (player.BackColor == newColor)
            {
                newColor = Color.FromArgb(random.Next(140, 255), random.Next(140, 255), random.Next(140, 255));
            }
            return newColor;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Выход из игры
                case Keys.Escape:
                    Application.Exit();
                    break;
                //Рестарт игры
                case Keys.R:
                    ball.Top = random.Next(playGround.Height / 2);
                    ball.Left = random.Next(50, playGround.Width - 50);
                    horizontalSpeed = 4;
                    verticalSpeed = 4;
                    score = 0;
                    lblScore.Text = $"Score: {score}";
                    timer1.Enabled = true;
                    lblLoss.Visible = false;
                    BackColor = Color.WhiteSmoke;
                    break;
            }
        }
    }
}