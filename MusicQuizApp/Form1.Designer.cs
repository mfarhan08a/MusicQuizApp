namespace MusicQuizApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_welcome = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.pnl_welcome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_play = new System.Windows.Forms.Panel();
            this.prevSongInfo = new System.Windows.Forms.GroupBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_questionNumber = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_skip = new System.Windows.Forms.Button();
            this.lbl_guess = new System.Windows.Forms.Label();
            this.btn_answer = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.btn_applySettings = new System.Windows.Forms.Button();
            this.gb_genreSelection = new System.Windows.Forms.GroupBox();
            this.clb_genreSelection = new System.Windows.Forms.CheckedListBox();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.dataSongsView = new System.Windows.Forms.DataGridView();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.gb_totalQuestion = new System.Windows.Forms.GroupBox();
            this.rb_totalquestion10 = new System.Windows.Forms.RadioButton();
            this.rb_totalquestion20 = new System.Windows.Forms.RadioButton();
            this.rb_totalquestion50 = new System.Windows.Forms.RadioButton();
            this.rb_totalquestion80 = new System.Windows.Forms.RadioButton();
            this.rb_totalquestion100 = new System.Windows.Forms.RadioButton();
            this.gb_countdownTimer = new System.Windows.Forms.GroupBox();
            this.rb_timer15 = new System.Windows.Forms.RadioButton();
            this.rb_timer25 = new System.Windows.Forms.RadioButton();
            this.rb_timer45 = new System.Windows.Forms.RadioButton();
            this.pnl_about = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_welcome.SuspendLayout();
            this.pnl_play.SuspendLayout();
            this.prevSongInfo.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            this.gb_genreSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSongsView)).BeginInit();
            this.gb_totalQuestion.SuspendLayout();
            this.gb_countdownTimer.SuspendLayout();
            this.pnl_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btn_welcome);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 681);
            this.panel1.TabIndex = 0;
            // 
            // btn_welcome
            // 
            this.btn_welcome.Location = new System.Drawing.Point(20, 161);
            this.btn_welcome.Margin = new System.Windows.Forms.Padding(2);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(146, 42);
            this.btn_welcome.TabIndex = 4;
            this.btn_welcome.Text = "Welcome";
            this.btn_welcome.UseVisualStyleBackColor = true;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(20, 320);
            this.btn_about.Margin = new System.Windows.Forms.Padding(2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(146, 42);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(20, 267);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(146, 42);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Window;
            this.btn_play.Location = new System.Drawing.Point(20, 214);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(146, 42);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pnl_welcome
            // 
            this.pnl_welcome.Controls.Add(this.label2);
            this.pnl_welcome.Controls.Add(this.label1);
            this.pnl_welcome.Location = new System.Drawing.Point(389, 113);
            this.pnl_welcome.Name = "pnl_welcome";
            this.pnl_welcome.Size = new System.Drawing.Size(863, 556);
            this.pnl_welcome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click play button to start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Music Quiz";
            // 
            // pnl_play
            // 
            this.pnl_play.Controls.Add(this.prevSongInfo);
            this.pnl_play.Controls.Add(this.lbl_questionNumber);
            this.pnl_play.Controls.Add(this.lbl_question);
            this.pnl_play.Controls.Add(this.lbl_guess);
            this.pnl_play.Controls.Add(this.lbl_timer);
            this.pnl_play.Controls.Add(this.btn_skip);
            this.pnl_play.Controls.Add(this.btn_answer);
            this.pnl_play.Controls.Add(this.guessBox);
            this.pnl_play.Controls.Add(this.label4);
            this.pnl_play.Controls.Add(this.label3);
            this.pnl_play.Location = new System.Drawing.Point(363, 84);
            this.pnl_play.Name = "pnl_play";
            this.pnl_play.Size = new System.Drawing.Size(873, 569);
            this.pnl_play.TabIndex = 3;
            // 
            // prevSongInfo
            // 
            this.prevSongInfo.Controls.Add(this.lbl_year);
            this.prevSongInfo.Controls.Add(this.lbl_artist);
            this.prevSongInfo.Controls.Add(this.lbl_title);
            this.prevSongInfo.Location = new System.Drawing.Point(632, 29);
            this.prevSongInfo.Name = "prevSongInfo";
            this.prevSongInfo.Size = new System.Drawing.Size(200, 103);
            this.prevSongInfo.TabIndex = 17;
            this.prevSongInfo.TabStop = false;
            this.prevSongInfo.Text = "Previous Song";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(12, 70);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(35, 13);
            this.lbl_year.TabIndex = 2;
            this.lbl_year.Text = "Year :";
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Location = new System.Drawing.Point(12, 48);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(30, 13);
            this.lbl_artist.TabIndex = 1;
            this.lbl_artist.Text = "Artist";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(36, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title : ";
            // 
            // lbl_questionNumber
            // 
            this.lbl_questionNumber.AutoSize = true;
            this.lbl_questionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionNumber.Location = new System.Drawing.Point(116, 29);
            this.lbl_questionNumber.Name = "lbl_questionNumber";
            this.lbl_questionNumber.Size = new System.Drawing.Size(49, 20);
            this.lbl_questionNumber.TabIndex = 16;
            this.lbl_questionNumber.Text = "10/10";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.Location = new System.Drawing.Point(29, 29);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(81, 20);
            this.lbl_question.TabIndex = 15;
            this.lbl_question.Text = "Question :";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(361, 77);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(153, 108);
            this.lbl_timer.TabIndex = 14;
            this.lbl_timer.Text = "45";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(730, 521);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(121, 29);
            this.btn_skip.TabIndex = 13;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // lbl_guess
            // 
            this.lbl_guess.AutoSize = true;
            this.lbl_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guess.Location = new System.Drawing.Point(128, 478);
            this.lbl_guess.Name = "lbl_guess";
            this.lbl_guess.Size = new System.Drawing.Size(86, 16);
            this.lbl_guess.TabIndex = 12;
            this.lbl_guess.Text = "Your Guess : ";
            this.lbl_guess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_answer
            // 
            this.btn_answer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_answer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_answer.Location = new System.Drawing.Point(622, 400);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(146, 45);
            this.btn_answer.TabIndex = 11;
            this.btn_answer.Text = "Enter";
            this.btn_answer.UseVisualStyleBackColor = false;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(120, 401);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(496, 44);
            this.guessBox.TabIndex = 10;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guess the title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timer";
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.gb_countdownTimer);
            this.pnl_settings.Controls.Add(this.gb_totalQuestion);
            this.pnl_settings.Controls.Add(this.btn_applySettings);
            this.pnl_settings.Controls.Add(this.gb_genreSelection);
            this.pnl_settings.Controls.Add(this.lbl_settings);
            this.pnl_settings.Controls.Add(this.dataSongsView);
            this.pnl_settings.Location = new System.Drawing.Point(183, 12);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(1039, 622);
            this.pnl_settings.TabIndex = 4;
            // 
            // btn_applySettings
            // 
            this.btn_applySettings.Location = new System.Drawing.Point(14, 558);
            this.btn_applySettings.Name = "btn_applySettings";
            this.btn_applySettings.Size = new System.Drawing.Size(99, 33);
            this.btn_applySettings.TabIndex = 3;
            this.btn_applySettings.Text = "Apply";
            this.btn_applySettings.UseVisualStyleBackColor = true;
            this.btn_applySettings.Click += new System.EventHandler(this.btn_applySettings_Click);
            // 
            // gb_genreSelection
            // 
            this.gb_genreSelection.Controls.Add(this.clb_genreSelection);
            this.gb_genreSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_genreSelection.Location = new System.Drawing.Point(14, 72);
            this.gb_genreSelection.Name = "gb_genreSelection";
            this.gb_genreSelection.Size = new System.Drawing.Size(423, 249);
            this.gb_genreSelection.TabIndex = 2;
            this.gb_genreSelection.TabStop = false;
            this.gb_genreSelection.Text = "Genre Selection";
            // 
            // clb_genreSelection
            // 
            this.clb_genreSelection.CheckOnClick = true;
            this.clb_genreSelection.FormattingEnabled = true;
            this.clb_genreSelection.Items.AddRange(new object[] {
            "Pop",
            "Country",
            "Rock",
            "Dance",
            "J-Pop",
            "K-Pop",
            "Indonesian-Pop",
            "Soundtrack",
            "Anime"});
            this.clb_genreSelection.Location = new System.Drawing.Point(6, 31);
            this.clb_genreSelection.Name = "clb_genreSelection";
            this.clb_genreSelection.Size = new System.Drawing.Size(411, 193);
            this.clb_genreSelection.TabIndex = 0;
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.Location = new System.Drawing.Point(19, 17);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(140, 37);
            this.lbl_settings.TabIndex = 1;
            this.lbl_settings.Text = "Settings";
            // 
            // dataSongsView
            // 
            this.dataSongsView.AllowUserToAddRows = false;
            this.dataSongsView.AllowUserToDeleteRows = false;
            this.dataSongsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSongsView.Location = new System.Drawing.Point(455, 4);
            this.dataSongsView.Name = "dataSongsView";
            this.dataSongsView.ReadOnly = true;
            this.dataSongsView.RowHeadersWidth = 51;
            this.dataSongsView.Size = new System.Drawing.Size(581, 562);
            this.dataSongsView.TabIndex = 0;
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // gb_totalQuestion
            // 
            this.gb_totalQuestion.Controls.Add(this.rb_totalquestion100);
            this.gb_totalQuestion.Controls.Add(this.rb_totalquestion80);
            this.gb_totalQuestion.Controls.Add(this.rb_totalquestion50);
            this.gb_totalQuestion.Controls.Add(this.rb_totalquestion20);
            this.gb_totalQuestion.Controls.Add(this.rb_totalquestion10);
            this.gb_totalQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_totalQuestion.Location = new System.Drawing.Point(14, 342);
            this.gb_totalQuestion.Name = "gb_totalQuestion";
            this.gb_totalQuestion.Size = new System.Drawing.Size(423, 77);
            this.gb_totalQuestion.TabIndex = 3;
            this.gb_totalQuestion.TabStop = false;
            this.gb_totalQuestion.Text = "Total Question";
            // 
            // rb_totalquestion10
            // 
            this.rb_totalquestion10.AutoSize = true;
            this.rb_totalquestion10.Location = new System.Drawing.Point(12, 35);
            this.rb_totalquestion10.Name = "rb_totalquestion10";
            this.rb_totalquestion10.Size = new System.Drawing.Size(45, 24);
            this.rb_totalquestion10.TabIndex = 0;
            this.rb_totalquestion10.TabStop = true;
            this.rb_totalquestion10.Text = "10";
            this.rb_totalquestion10.UseVisualStyleBackColor = true;
            // 
            // rb_totalquestion20
            // 
            this.rb_totalquestion20.AutoSize = true;
            this.rb_totalquestion20.Location = new System.Drawing.Point(87, 35);
            this.rb_totalquestion20.Name = "rb_totalquestion20";
            this.rb_totalquestion20.Size = new System.Drawing.Size(45, 24);
            this.rb_totalquestion20.TabIndex = 1;
            this.rb_totalquestion20.TabStop = true;
            this.rb_totalquestion20.Text = "20";
            this.rb_totalquestion20.UseVisualStyleBackColor = true;
            // 
            // rb_totalquestion50
            // 
            this.rb_totalquestion50.AutoSize = true;
            this.rb_totalquestion50.Location = new System.Drawing.Point(169, 35);
            this.rb_totalquestion50.Name = "rb_totalquestion50";
            this.rb_totalquestion50.Size = new System.Drawing.Size(45, 24);
            this.rb_totalquestion50.TabIndex = 2;
            this.rb_totalquestion50.TabStop = true;
            this.rb_totalquestion50.Text = "50";
            this.rb_totalquestion50.UseVisualStyleBackColor = true;
            // 
            // rb_totalquestion80
            // 
            this.rb_totalquestion80.AutoSize = true;
            this.rb_totalquestion80.Location = new System.Drawing.Point(257, 35);
            this.rb_totalquestion80.Name = "rb_totalquestion80";
            this.rb_totalquestion80.Size = new System.Drawing.Size(45, 24);
            this.rb_totalquestion80.TabIndex = 3;
            this.rb_totalquestion80.TabStop = true;
            this.rb_totalquestion80.Text = "80";
            this.rb_totalquestion80.UseVisualStyleBackColor = true;
            // 
            // rb_totalquestion100
            // 
            this.rb_totalquestion100.AutoSize = true;
            this.rb_totalquestion100.Location = new System.Drawing.Point(350, 35);
            this.rb_totalquestion100.Name = "rb_totalquestion100";
            this.rb_totalquestion100.Size = new System.Drawing.Size(54, 24);
            this.rb_totalquestion100.TabIndex = 4;
            this.rb_totalquestion100.TabStop = true;
            this.rb_totalquestion100.Text = "100";
            this.rb_totalquestion100.UseVisualStyleBackColor = true;
            // 
            // gb_countdownTimer
            // 
            this.gb_countdownTimer.Controls.Add(this.rb_timer15);
            this.gb_countdownTimer.Controls.Add(this.rb_timer25);
            this.gb_countdownTimer.Controls.Add(this.rb_timer45);
            this.gb_countdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_countdownTimer.Location = new System.Drawing.Point(14, 438);
            this.gb_countdownTimer.Name = "gb_countdownTimer";
            this.gb_countdownTimer.Size = new System.Drawing.Size(423, 77);
            this.gb_countdownTimer.TabIndex = 5;
            this.gb_countdownTimer.TabStop = false;
            this.gb_countdownTimer.Text = "Countdown Timer";
            // 
            // rb_timer15
            // 
            this.rb_timer15.AutoSize = true;
            this.rb_timer15.Location = new System.Drawing.Point(286, 35);
            this.rb_timer15.Name = "rb_timer15";
            this.rb_timer15.Size = new System.Drawing.Size(109, 24);
            this.rb_timer15.TabIndex = 2;
            this.rb_timer15.TabStop = true;
            this.rb_timer15.Text = "15 seconds";
            this.rb_timer15.UseVisualStyleBackColor = true;
            // 
            // rb_timer25
            // 
            this.rb_timer25.AutoSize = true;
            this.rb_timer25.Location = new System.Drawing.Point(146, 35);
            this.rb_timer25.Name = "rb_timer25";
            this.rb_timer25.Size = new System.Drawing.Size(109, 24);
            this.rb_timer25.TabIndex = 1;
            this.rb_timer25.TabStop = true;
            this.rb_timer25.Text = "25 seconds";
            this.rb_timer25.UseVisualStyleBackColor = true;
            // 
            // rb_timer45
            // 
            this.rb_timer45.AutoSize = true;
            this.rb_timer45.Location = new System.Drawing.Point(12, 35);
            this.rb_timer45.Name = "rb_timer45";
            this.rb_timer45.Size = new System.Drawing.Size(109, 24);
            this.rb_timer45.TabIndex = 0;
            this.rb_timer45.TabStop = true;
            this.rb_timer45.Text = "45 seconds";
            this.rb_timer45.UseVisualStyleBackColor = true;
            // 
            // pnl_about
            // 
            this.pnl_about.Controls.Add(this.label5);
            this.pnl_about.Location = new System.Drawing.Point(229, 12);
            this.pnl_about.Name = "pnl_about";
            this.pnl_about.Size = new System.Drawing.Size(960, 1011);
            this.pnl_about.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_about);
            this.Controls.Add(this.pnl_play);
            this.Controls.Add(this.pnl_settings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_welcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_welcome.ResumeLayout(false);
            this.pnl_welcome.PerformLayout();
            this.pnl_play.ResumeLayout(false);
            this.pnl_play.PerformLayout();
            this.prevSongInfo.ResumeLayout(false);
            this.prevSongInfo.PerformLayout();
            this.pnl_settings.ResumeLayout(false);
            this.pnl_settings.PerformLayout();
            this.gb_genreSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSongsView)).EndInit();
            this.gb_totalQuestion.ResumeLayout(false);
            this.gb_totalQuestion.PerformLayout();
            this.gb_countdownTimer.ResumeLayout(false);
            this.gb_countdownTimer.PerformLayout();
            this.pnl_about.ResumeLayout(false);
            this.pnl_about.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_welcome;
        private System.Windows.Forms.Panel pnl_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_play;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_guess;
        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.DataGridView dataSongsView;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.Label lbl_questionNumber;
        private System.Windows.Forms.GroupBox prevSongInfo;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_genreSelection;
        private System.Windows.Forms.CheckedListBox clb_genreSelection;
        private System.Windows.Forms.Button btn_applySettings;
        private System.Windows.Forms.GroupBox gb_totalQuestion;
        private System.Windows.Forms.RadioButton rb_totalquestion100;
        private System.Windows.Forms.RadioButton rb_totalquestion80;
        private System.Windows.Forms.RadioButton rb_totalquestion50;
        private System.Windows.Forms.RadioButton rb_totalquestion20;
        private System.Windows.Forms.RadioButton rb_totalquestion10;
        private System.Windows.Forms.GroupBox gb_countdownTimer;
        private System.Windows.Forms.RadioButton rb_timer15;
        private System.Windows.Forms.RadioButton rb_timer25;
        private System.Windows.Forms.RadioButton rb_timer45;
        private System.Windows.Forms.Panel pnl_about;
        private System.Windows.Forms.Label label5;
    }
}

