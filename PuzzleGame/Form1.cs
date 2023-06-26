using System.Reflection.Emit;
using System.Timers;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {

        List<PictureBox> PictureBoxList;
        int[,] current_state;
        Point[,] Posi;
        int x, y, n;

        int[,] Easyfinish = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
        int[,] HardFinish = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };


        int[,] finish_state;

        int Level = 1;

        //tập các câu trả lời của AI
        List<Tuple<int[,], int, int>> ans;
        int[,] roll;
        int roll_x, roll_y;
        bool AI_Sovled = false;
        PictureBox pic1, pic2;

        public Form1()
        {
            PictureBoxList = new List<PictureBox>();

            InitializeComponent();


        }
        public string chose_image()
        {
            string[] files = Directory.GetFiles("600x600imgs", "*.jpg");

            if (files.Length > 0)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, files.Length);

                string randomFile = files[randomIndex];
                return randomFile;
            }
            return "";

        }
        void swap(int[,] state, int x1, int y1, int x2, int y2)
        {
            int temp = state[x1, y1];
            state[x1, y1] = state[x2, y2];
            state[x2, y2] = temp;
        }
        private void CreateLevel(object sender, EventArgs e)
        {
            current_state = n == 3 ? (int[,])Easyfinish.Clone() : (int[,])HardFinish.Clone();
            x = y = 0;
            int pre_x = -1, pre_y = -1;
            Random rand = new Random();
            for (int i = 0; i < Level * 2; i++)
            {

                int r = rand.Next(0, 100);
                if (r <= 30)
                {
                    if (x + 1 < n && x + 1 != pre_x)
                    {
                        swap(current_state, x, y, x + 1, y);
                        pre_x = x; pre_y = y;
                        x++;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                else if (r <= 50)
                {
                    if (x - 1 >= 0 && x - 1 != pre_x)
                    {
                        swap(current_state, x, y, x - 1, y);
                        pre_x = x; pre_y = y;
                        x--;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                else if (r <= 80)
                {
                    if (y + 1 < n && y + 1 != pre_y)
                    {
                        swap(current_state, x, y, x, y + 1);
                        pre_x = x; pre_y = y;
                        y++;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                else
                {
                    if (y - 1 >= 0 && y - 1 != pre_y)
                    {
                        swap(current_state, x, y, x, y - 1);
                        pre_x = x; pre_y = y;
                        y--;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
            }

        }
        public void add_image(string imgPath, int n)
        {
            if (imgPath == "")
            {
                return;
            }
            // Clear control, List
            panel1.Controls.Clear();
            PictureBoxList.Clear();



            // Load the image from file
            Image img = Image.FromFile(imgPath);

            // Set sample picture


            samplePic.Image = Image.FromFile(imgPath);
            samplePic.SizeMode = PictureBoxSizeMode.Zoom;

            // Calculate the dimensions of each sub-image
            int subWidth = img.Width / n;
            int subHeight = img.Height / n;

            // Loop through each sub-image and add it to the panel
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    // Create a new PictureBox control to hold the sub-image
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(col * subWidth, row * subHeight);
                    pb.Size = new Size(subWidth, subHeight);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pb.Padding = new Padding(1); // Thay đổi giá trị của Padding tùy ý
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    // Lưu lại vị trí ban đầu của các bức ảnh
                    Posi[row, col] = new Point(pb.Location.X, pb.Location.Y);

                    // Crop the sub-image from the original image and assign it to the PictureBox
                    Bitmap bmp = new Bitmap(subWidth, subHeight);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(img, new Rectangle(0, 0, subWidth, subHeight), new Rectangle(col * subWidth, row * subHeight, subWidth, subHeight), GraphicsUnit.Pixel);
                    pb.Image = bmp;

                    // Add the PictureBox to the panel
                    panel1.Controls.Add(pb);
                    // Add the PictureBox to the List
                    PictureBoxList.Add(pb);

                }
            }
            PictureBoxList.ElementAt(0).Image = null;
            PictureBoxList.ElementAt(0).BackColor = panel1.BackColor;
            PictureBoxList.ElementAt(0).BorderStyle = BorderStyle.None;
            // Dispose of the original image
            img.Dispose();


        }

        private void easymodebtn_Click(object sender, EventArgs e)
        {
            string img = chose_image();
            Posi = new Point[3, 3];

            n = 3;
            add_image(img, 3);
            CreateLevel(sender, e);
            set_position();
            finish_state = Easyfinish;
            ShowTextBox();
            panel3.Visible = true;
        }

        private void hardmodebtn_Click(object sender, EventArgs e)
        {
            string img = chose_image();
            Posi = new Point[4, 4];
            n = 4;
            add_image(img, 4);
            CreateLevel(sender, e);
            set_position();
            finish_state = HardFinish;
            ShowTextBox();
            panel3.Visible = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.W)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S)
            {
                button3_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D)
            {
                button2_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x - 1 < 0)
            {
                return;
            }
            if (AI_Sovled)
            {
                Solvebtn.Enabled = false;
            }
            PictureBoxList.ElementAt(current_state[x, y]).Location = Posi[x - 1, y];
            PictureBoxList.ElementAt(current_state[x - 1, y]).Location = Posi[x, y];
            int temp = current_state[x - 1, y];
            current_state[x - 1, y] = current_state[x, y];
            current_state[x, y] = temp;
            x--;
            ShowTextBox();
            CheckFinish(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y + 1 >= n)
            {
                return;
            }
            if (AI_Sovled)
            {
                Solvebtn.Enabled = false;
            }
            PictureBoxList.ElementAt(current_state[x, y]).Location = Posi[x, y + 1];
            PictureBoxList.ElementAt(current_state[x, y + 1]).Location = Posi[x, y];
            int temp = current_state[x, y + 1];
            current_state[x, y + 1] = current_state[x, y];
            current_state[x, y] = temp;
            y++;
            ShowTextBox();
            CheckFinish(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y - 1 < 0)
            {
                return;
            }
            if (AI_Sovled)
            {
                Solvebtn.Enabled = false;
            }
            PictureBoxList.ElementAt(current_state[x, y]).Location = Posi[x, y - 1];
            PictureBoxList.ElementAt(current_state[x, y - 1]).Location = Posi[x, y];
            int temp = current_state[x, y - 1];
            current_state[x, y - 1] = current_state[x, y];
            current_state[x, y] = temp;
            y--;
            ShowTextBox();
            CheckFinish(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (x + 1 >= n)
            {
                return;
            }
            if (AI_Sovled)
            {
                Solvebtn.Enabled = false;
            }
            PictureBoxList.ElementAt(current_state[x, y]).Location = Posi[x + 1, y];
            PictureBoxList.ElementAt(current_state[x + 1, y]).Location = Posi[x, y];
            int temp = current_state[x + 1, y];
            current_state[x + 1, y] = current_state[x, y];
            current_state[x, y] = temp;
            x++;
            ShowTextBox();
            CheckFinish(sender, e);
        }
        private void ShowTextBox()
        {
            textBox1.Clear();
            if (n == 4)
            {
                textBox1.Font = new Font("Segoe", 15, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font("Segoe", 20, FontStyle.Bold);
            }
            string matrix = "";
            for (int i = 0; i < n; i++)
            {
                matrix += "|";
                for (int j = 0; j < n; j++)
                {
                    if (current_state[i, j] < 10)
                    {
                        matrix += "  ";
                    }
                    matrix += current_state[i, j] + "|";
                }
                matrix += "\r\n";
            }
            textBox1.Text = matrix;
            textBox1.Refresh();
        }
        private void set_position()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    PictureBoxList.ElementAt(current_state[i, j]).Location = Posi[i, j];
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Answerbtn_Click(object sender, EventArgs e)
        {
            //show cac buoc giai
            anstb.Clear();
            anstb.Visible = true;
            int step = 0;
            for (int answ = ans.Count - 1; answ >= 0; answ--)
            {
                string matrix = "";
                matrix += step;
                matrix += ".\r\n";

                for (int i = 0; i < n; i++)
                {
                    matrix += "|";
                    for (int j = 0; j < n; j++)
                    {
                        if (ans.ElementAt(answ).Item1[i, j] < 10)
                        {
                            matrix += "  ";
                        }
                        matrix += ans.ElementAt(answ).Item1[i, j];
                        matrix += "|";
                    }
                    matrix += "\r\n";
                }
                matrix += "--------------\r\n";
                step++;
                anstb.Text += matrix;
            }
        }

        private void AIsovlebtn_Click(object sender, EventArgs e)
        {
            Answerbtn.Visible = true;
            Solvebtn.Visible = true;
            rollbackbtn.Visible = true;
            anstb.Visible = true;
            anstb.Clear();
            Algorithm a = new Algorithm(current_state, finish_state, n, x, y);
            ans = a.A_Sao();
            roll = (int[,])current_state.Clone();
            roll_x = x;
            roll_y = y;
            AI_Sovled = true;
        }

        private void Solvebtn_Click(object sender, EventArgs e)
        {
            Solvebtn.Visible = false;

            //giai minh hoa
            for (int i = ans.Count - 2; i >= 0; i--)
            {

                if (ans.ElementAt(i).Item2 == x + 1)
                {

                    pic1 = PictureBoxList[current_state[x, y]];
                    pic2 = PictureBoxList[current_state[x + 1, y]];
                    movepic(pic1, pic2);


                    int temp = current_state[x + 1, y];
                    current_state[x + 1, y] = current_state[x, y];
                    current_state[x, y] = temp;
                    x++;

                    ShowTextBox();

                }
                else if (ans.ElementAt(i).Item2 == x - 1)
                {
                    pic1 = PictureBoxList[current_state[x, y]];
                    pic2 = PictureBoxList[current_state[x - 1, y]];
                    movepic(pic1, pic2);

                    int temp = current_state[x - 1, y];
                    current_state[x - 1, y] = current_state[x, y];
                    current_state[x, y] = temp;
                    x--;
                    ShowTextBox();
                }
                else if (ans.ElementAt(i).Item3 == y + 1)
                {
                    pic1 = PictureBoxList[current_state[x, y]];
                    pic2 = PictureBoxList[current_state[x, y + 1]];
                    movepic(pic1, pic2);

                    int temp = current_state[x, y + 1];
                    current_state[x, y + 1] = current_state[x, y];
                    current_state[x, y] = temp;
                    y++;
                    ShowTextBox();
                }
                else if (ans.ElementAt(i).Item3 == y - 1)
                {
                    pic1 = PictureBoxList[current_state[x, y]];
                    pic2 = PictureBoxList[current_state[x, y - 1]];
                    movepic(pic1, pic2);


                    int temp = current_state[x, y - 1];
                    current_state[x, y - 1] = current_state[x, y];
                    current_state[x, y] = temp;
                    y--;
                    ShowTextBox();
                }
                Thread.Sleep(500);
            }
        }
        private void rollbackbtn_Click(object sender, EventArgs e)
        {
            current_state = (int[,])roll.Clone();
            x = roll_x;
            y = roll_y;
            set_position();
            ShowTextBox();
            Solvebtn.Visible = true;
            Solvebtn.Enabled = true;
        }

        private void RestartLvlbtn_Click(object sender, EventArgs e)
        {
            AI_Sovled = false;
            Solvebtn.Enabled = true;
            StartGamebtn_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // Thực hiện một số hành động khi phím mũi tên lên được nhấn trên panel2
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                // Thực hiện một số hành động khi phím mũi tên xuống được nhấn trên panel2
                button3_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Left)
            {
                // Thực hiện một số hành động khi phím mũi tên trái được nhấn trên panel2
                button4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Right)
            {
                // Thực hiện một số hành động khi phím mũi tên phải được nhấn trên panel2
                button2_Click(sender, e);
            }
        }

        private void StartGamebtn_Click(object sender, EventArgs e)
        {
            StartGamebtn.Visible = false;
            Answerbtn.Visible = false;
            Solvebtn.Visible = false;
            rollbackbtn.Visible = false;
            anstb.Visible = false;

            RestartLvlbtn.Visible = true;

            Levellable.Text = "Level: " + Level;
            if (Level < 8)
            {
                easymodebtn_Click(sender, e);
            }
            else
            {
                hardmodebtn_Click(sender, e);
            }

        }

        private void movepic(PictureBox pic1, PictureBox pic2)
        {

            Point temp = pic1.Location;
            pic1.Location = pic2.Location;
            pic2.Location = temp;

            pic1.Invalidate();
            pic1.Refresh();
            pic2.Invalidate();
            pic2.Refresh();
        }
        private void CheckFinish(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (current_state[i, j] != finish_state[i, j])
                    {
                        return;
                    }
                }
            }
            LevelPassed(sender, e);
        }

        private void LevelPassed(object sender, EventArgs e)
        {

            if (!AI_Sovled)
            {

                DialogResult result = MessageBox.Show(("Chúc mừng bạn đã hoàn thành level " + Level), "Thông báo");
                Level++;
                StartGamebtn_Click(sender, e);
            }

        }
    }

}