namespace PuzzleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Easymodebtn = new Button();
            panel1 = new Panel();
            StartGamebtn = new Button();
            hardmodebtn = new Button();
            upbtn = new Button();
            rightbtn = new Button();
            downbtn = new Button();
            leftbtn = new Button();
            textBox1 = new TextBox();
            samplePic = new PictureBox();
            panel3 = new Panel();
            rollbackbtn = new Button();
            AIsovlebtn = new Button();
            Answerbtn = new Button();
            Solvebtn = new Button();
            anstb = new TextBox();
            RestartLvlbtn = new Button();
            Levellable = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)samplePic).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Easymodebtn
            // 
            Easymodebtn.BackColor = Color.Transparent;
            Easymodebtn.BackgroundImage = (Image)resources.GetObject("Easymodebtn.BackgroundImage");
            Easymodebtn.BackgroundImageLayout = ImageLayout.Stretch;
            Easymodebtn.FlatAppearance.BorderSize = 0;
            Easymodebtn.FlatStyle = FlatStyle.Popup;
            Easymodebtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Easymodebtn.ForeColor = SystemColors.ButtonHighlight;
            Easymodebtn.Location = new Point(998, 20);
            Easymodebtn.Name = "Easymodebtn";
            Easymodebtn.Size = new Size(140, 66);
            Easymodebtn.TabIndex = 0;
            Easymodebtn.TabStop = false;
            Easymodebtn.Text = "Easy";
            Easymodebtn.UseVisualStyleBackColor = false;
            Easymodebtn.Visible = false;
            Easymodebtn.Click += easymodebtn_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(StartGamebtn);
            panel1.Location = new Point(310, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // StartGamebtn
            // 
            StartGamebtn.BackColor = Color.Transparent;
            StartGamebtn.BackgroundImageLayout = ImageLayout.Stretch;
            StartGamebtn.FlatAppearance.BorderSize = 0;
            StartGamebtn.FlatStyle = FlatStyle.Popup;
            StartGamebtn.Font = new Font("Showcard Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            StartGamebtn.ForeColor = SystemColors.ButtonHighlight;
            StartGamebtn.Image = (Image)resources.GetObject("StartGamebtn.Image");
            StartGamebtn.Location = new Point(221, 211);
            StartGamebtn.Name = "StartGamebtn";
            StartGamebtn.RightToLeft = RightToLeft.Yes;
            StartGamebtn.Size = new Size(136, 139);
            StartGamebtn.TabIndex = 12;
            StartGamebtn.Text = "START";
            StartGamebtn.TextAlign = ContentAlignment.BottomCenter;
            StartGamebtn.UseVisualStyleBackColor = false;
            StartGamebtn.Click += StartGamebtn_Click;
            // 
            // hardmodebtn
            // 
            hardmodebtn.BackColor = Color.Transparent;
            hardmodebtn.BackgroundImage = (Image)resources.GetObject("hardmodebtn.BackgroundImage");
            hardmodebtn.BackgroundImageLayout = ImageLayout.Stretch;
            hardmodebtn.FlatAppearance.BorderSize = 0;
            hardmodebtn.FlatStyle = FlatStyle.Popup;
            hardmodebtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hardmodebtn.ForeColor = SystemColors.ButtonHighlight;
            hardmodebtn.Location = new Point(1159, 18);
            hardmodebtn.Name = "hardmodebtn";
            hardmodebtn.Size = new Size(138, 70);
            hardmodebtn.TabIndex = 0;
            hardmodebtn.TabStop = false;
            hardmodebtn.Text = "Hard";
            hardmodebtn.UseVisualStyleBackColor = false;
            hardmodebtn.Visible = false;
            hardmodebtn.Click += hardmodebtn_Click;
            // 
            // upbtn
            // 
            upbtn.BackColor = Color.Transparent;
            upbtn.BackgroundImage = (Image)resources.GetObject("upbtn.BackgroundImage");
            upbtn.BackgroundImageLayout = ImageLayout.Stretch;
            upbtn.FlatAppearance.BorderSize = 0;
            upbtn.FlatStyle = FlatStyle.Popup;
            upbtn.Location = new Point(1084, 393);
            upbtn.Name = "upbtn";
            upbtn.Size = new Size(108, 108);
            upbtn.TabIndex = 1;
            upbtn.UseVisualStyleBackColor = false;
            upbtn.Click += button1_Click;
            // 
            // rightbtn
            // 
            rightbtn.BackColor = Color.Transparent;
            rightbtn.BackgroundImage = (Image)resources.GetObject("rightbtn.BackgroundImage");
            rightbtn.BackgroundImageLayout = ImageLayout.Stretch;
            rightbtn.FlatAppearance.BorderSize = 0;
            rightbtn.FlatStyle = FlatStyle.Popup;
            rightbtn.Location = new Point(1198, 462);
            rightbtn.Name = "rightbtn";
            rightbtn.Size = new Size(108, 108);
            rightbtn.TabIndex = 2;
            rightbtn.UseVisualStyleBackColor = false;
            rightbtn.Click += button2_Click;
            // 
            // downbtn
            // 
            downbtn.BackColor = Color.Transparent;
            downbtn.BackgroundImage = (Image)resources.GetObject("downbtn.BackgroundImage");
            downbtn.BackgroundImageLayout = ImageLayout.Stretch;
            downbtn.FlatAppearance.BorderSize = 0;
            downbtn.FlatStyle = FlatStyle.Popup;
            downbtn.Location = new Point(1084, 536);
            downbtn.Name = "downbtn";
            downbtn.Size = new Size(108, 108);
            downbtn.TabIndex = 3;
            downbtn.UseVisualStyleBackColor = false;
            downbtn.Click += button3_Click;
            // 
            // leftbtn
            // 
            leftbtn.BackColor = Color.Transparent;
            leftbtn.BackgroundImage = (Image)resources.GetObject("leftbtn.BackgroundImage");
            leftbtn.BackgroundImageLayout = ImageLayout.Zoom;
            leftbtn.FlatAppearance.BorderSize = 0;
            leftbtn.FlatStyle = FlatStyle.Popup;
            leftbtn.Location = new Point(970, 462);
            leftbtn.Name = "leftbtn";
            leftbtn.Size = new Size(108, 108);
            leftbtn.TabIndex = 4;
            leftbtn.UseVisualStyleBackColor = false;
            leftbtn.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1155, 117);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(226, 220);
            textBox1.TabIndex = 5;
            // 
            // samplePic
            // 
            samplePic.BackColor = Color.Transparent;
            samplePic.BorderStyle = BorderStyle.Fixed3D;
            samplePic.Location = new Point(928, 117);
            samplePic.Name = "samplePic";
            samplePic.Size = new Size(221, 220);
            samplePic.TabIndex = 6;
            samplePic.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(rollbackbtn);
            panel3.Controls.Add(AIsovlebtn);
            panel3.Controls.Add(Answerbtn);
            panel3.Controls.Add(Solvebtn);
            panel3.Location = new Point(27, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 251);
            panel3.TabIndex = 9;
            panel3.Visible = false;
            // 
            // rollbackbtn
            // 
            rollbackbtn.BackColor = Color.Yellow;
            rollbackbtn.FlatStyle = FlatStyle.Flat;
            rollbackbtn.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            rollbackbtn.ForeColor = SystemColors.ActiveCaptionText;
            rollbackbtn.Location = new Point(3, 198);
            rollbackbtn.Name = "rollbackbtn";
            rollbackbtn.Size = new Size(248, 45);
            rollbackbtn.TabIndex = 12;
            rollbackbtn.TabStop = false;
            rollbackbtn.Text = "Quay trở lại bài toán";
            rollbackbtn.UseVisualStyleBackColor = false;
            rollbackbtn.Visible = false;
            rollbackbtn.Click += rollbackbtn_Click;
            // 
            // AIsovlebtn
            // 
            AIsovlebtn.BackColor = Color.FromArgb(192, 192, 0);
            AIsovlebtn.BackgroundImageLayout = ImageLayout.Stretch;
            AIsovlebtn.FlatStyle = FlatStyle.Flat;
            AIsovlebtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AIsovlebtn.ForeColor = SystemColors.ButtonHighlight;
            AIsovlebtn.Image = (Image)resources.GetObject("AIsovlebtn.Image");
            AIsovlebtn.Location = new Point(3, 2);
            AIsovlebtn.Name = "AIsovlebtn";
            AIsovlebtn.Size = new Size(248, 88);
            AIsovlebtn.TabIndex = 11;
            AIsovlebtn.Text = "HELP";
            AIsovlebtn.TextAlign = ContentAlignment.MiddleRight;
            AIsovlebtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AIsovlebtn.UseVisualStyleBackColor = false;
            AIsovlebtn.Click += AIsovlebtn_Click;
            // 
            // Answerbtn
            // 
            Answerbtn.BackColor = Color.FromArgb(255, 255, 192);
            Answerbtn.FlatStyle = FlatStyle.Flat;
            Answerbtn.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            Answerbtn.ForeColor = SystemColors.ActiveCaptionText;
            Answerbtn.Location = new Point(3, 96);
            Answerbtn.Name = "Answerbtn";
            Answerbtn.Size = new Size(248, 45);
            Answerbtn.TabIndex = 0;
            Answerbtn.TabStop = false;
            Answerbtn.Text = "Xem lời giải";
            Answerbtn.UseVisualStyleBackColor = false;
            Answerbtn.Visible = false;
            Answerbtn.Click += Answerbtn_Click;
            // 
            // Solvebtn
            // 
            Solvebtn.BackColor = Color.FromArgb(255, 255, 128);
            Solvebtn.FlatStyle = FlatStyle.Flat;
            Solvebtn.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            Solvebtn.ForeColor = SystemColors.ActiveCaptionText;
            Solvebtn.Location = new Point(3, 147);
            Solvebtn.Name = "Solvebtn";
            Solvebtn.Size = new Size(248, 45);
            Solvebtn.TabIndex = 0;
            Solvebtn.TabStop = false;
            Solvebtn.Text = "Giải minh họa";
            Solvebtn.UseVisualStyleBackColor = false;
            Solvebtn.Visible = false;
            Solvebtn.Click += Solvebtn_Click;
            // 
            // anstb
            // 
            anstb.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            anstb.Location = new Point(27, 349);
            anstb.Multiline = true;
            anstb.Name = "anstb";
            anstb.ReadOnly = true;
            anstb.ScrollBars = ScrollBars.Vertical;
            anstb.Size = new Size(262, 343);
            anstb.TabIndex = 11;
            anstb.TabStop = false;
            anstb.Visible = false;
            // 
            // RestartLvlbtn
            // 
            RestartLvlbtn.BackColor = Color.Transparent;
            RestartLvlbtn.BackgroundImage = (Image)resources.GetObject("RestartLvlbtn.BackgroundImage");
            RestartLvlbtn.BackgroundImageLayout = ImageLayout.Stretch;
            RestartLvlbtn.FlatAppearance.BorderSize = 0;
            RestartLvlbtn.FlatStyle = FlatStyle.Popup;
            RestartLvlbtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            RestartLvlbtn.ImageAlign = ContentAlignment.MiddleRight;
            RestartLvlbtn.Location = new Point(839, 26);
            RestartLvlbtn.Name = "RestartLvlbtn";
            RestartLvlbtn.RightToLeft = RightToLeft.Yes;
            RestartLvlbtn.Size = new Size(64, 60);
            RestartLvlbtn.TabIndex = 13;
            RestartLvlbtn.UseVisualStyleBackColor = false;
            RestartLvlbtn.Visible = false;
            RestartLvlbtn.Click += RestartLvlbtn_Click;
            // 
            // Levellable
            // 
            Levellable.AutoSize = true;
            Levellable.BackColor = Color.DarkViolet;
            Levellable.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Levellable.ForeColor = SystemColors.ButtonHighlight;
            Levellable.Image = (Image)resources.GetObject("Levellable.Image");
            Levellable.Location = new Point(310, 54);
            Levellable.Name = "Levellable";
            Levellable.Size = new Size(119, 35);
            Levellable.TabIndex = 14;
            Levellable.Text = "LEVEL :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(RestartLvlbtn);
            panel2.Controls.Add(upbtn);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(Levellable);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(rightbtn);
            panel2.Controls.Add(samplePic);
            panel2.Controls.Add(downbtn);
            panel2.Controls.Add(hardmodebtn);
            panel2.Controls.Add(leftbtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Easymodebtn);
            panel2.Controls.Add(anstb);
            panel2.Location = new Point(-6, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1443, 735);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.PreviewKeyDown += panel2_PreviewKeyDown;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1432, 732);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8 Puzzle";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)samplePic).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Easymodebtn;
        private Panel panel1;
        private Button hardmodebtn;
        private Button upbtn;
        private Button rightbtn;
        private Button downbtn;
        private Button leftbtn;
        private TextBox textBox1;
        private PictureBox samplePic;
        private Panel panel3;
        private Button Answerbtn;
        private Button Solvebtn;
        private TextBox anstb;
        private Button StartGamebtn;
        private Button rollbackbtn;
        private Button AIsovlebtn;
        private Button RestartLvlbtn;
        private Label Levellable;
        private Panel panel2;
    }
}