using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Form1 : Form
    {
        //����������
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
            Cursor.Hide(); //������ ������

            FormBorderStyle = FormBorderStyle.None; //������ ��� �������
            /*TopMost = true;*/ // ������ �����
            Bounds = Screen.PrimaryScreen.Bounds; //Fullscreen �� �������� ��������
            WindowState = FormWindowState.Maximized;

            //����� ��������� �� ������
            lblLoss.Left = (playGround.Width / 2) - (lblLoss.Width / 2);
            lblLoss.Top = (playGround.Height / 2) - (lblLoss.Height / 2);

            // ���������� ������ 1/10 �� ������ �������� fullhd 108pixels
            player.Top = playGround.Bottom - (playGround.Bottom / 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ��������� ������ = ��������� �������, ����� �� ����� �� ������� �������� ������ ������
            player.Left = Cursor.Position.X - player.Width;

            //������� ���
            ball.Left += horizontalSpeed;
            ball.Top += verticalSpeed;

            // �������� ���� � �������
            if (ball.Bottom >= player.Top && ball.Bottom <= player.Bottom && ball.Left >= player.Left && ball.Right <= player.Right)
            {
                //�� �������� �������� ������ 14 ����� ����� �����
                if (verticalSpeed <= 14 && horizontalSpeed <= 14)
                {
                    verticalSpeed += 1;
                    horizontalSpeed += 1;
                }
                verticalSpeed = -verticalSpeed;// �������� �����������
                score += 1;//����� �����, �������! ������ ����;-;
                lblScore.Text = $"Score: {score}";
                playGround.BackColor = setColor();
            }

            //�������� ���� � ��������� �������� ����
            if (ball.Left <= playGround.Left)
            {
                horizontalSpeed = -horizontalSpeed; //���� ��� �������� � ����� ������, ����� �������������� ����������� 
            }
            if (ball.Right >= playGround.Right)
            {
                horizontalSpeed = -horizontalSpeed; // ����� �� ����� ��� ���? ���������! ������ ��� �����������
            }
            if (ball.Top <= playGround.Top)
            {
                verticalSpeed = -verticalSpeed;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                timer1.Enabled = false; //������, �� ��������
                lblLoss.Visible = true; //���� ���������
            }

        }

        // �����, ������� �� ��������� ������ � ���� �� ����� ������ � ������� �����(�� ������ ������)
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
                //����� �� ����
                case Keys.Escape:
                    Application.Exit();
                    break;
                //������� ����
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